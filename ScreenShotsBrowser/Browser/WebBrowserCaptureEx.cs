using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace ScreenShotsBrowser.Browser
{
	public static class WebBrowserCaptureEx
	{
		public static Bitmap GetCapture(this WebBrowser source)
		{
			return capture(source, source.FindForm().Handle);
		}
		private static Bitmap capture(WebBrowser source, IntPtr hwnd)
		{
			HtmlDocument htmlDocument = source.Document;
			HtmlElement htmlElement = htmlDocument.Body;
			Rectangle rectangle = new Rectangle(new Point(0, 0), htmlElement.ScrollRectangle.Size);

			Bitmap image = new Bitmap(rectangle.Size.Width, rectangle.Size.Height, Graphics.FromHwnd(hwnd));

			using (Graphics graphics = Graphics.FromImage(image))
			{
				IOleObject oleObject = (IOleObject)htmlDocument.DomDocument;
				if (oleObject != null)
				{
					IntPtr imageDC = graphics.GetHdc();
					IntPtr pUnk = Marshal.GetIUnknownForObject(source.ActiveXInstance);
					try
					{
						Size currentSize = new Size();
						oleObject.GetExtent(DVASPECT.DVASPECT_CONTENT, out currentSize);
						Size drawingSize = convertPixelToHIMETRIC(rectangle.Size, imageDC);
						oleObject.SetExtent(DVASPECT.DVASPECT_CONTENT, ref drawingSize);

						OleDraw(pUnk, DVASPECT.DVASPECT_CONTENT, imageDC, ref rectangle);
						oleObject.SetExtent(DVASPECT.DVASPECT_CONTENT, ref currentSize);
					}
					finally
					{
						Marshal.Release(pUnk);
						graphics.ReleaseHdc(imageDC);
					}
				}
				graphics.Dispose();
			}
			return image;
		}
		#region キャプチャ用

		/// <summary>
		/// Pixel単位をHIMETRIC単位に変換するメソッド
		/// </summary>
		/// <param name="size">Pixel単位のサイズ構造体</param>
		/// <param name="hdc">デバイス・コンテキスト（デスクトップの解像度とコンパチであれば無問題？）</param>
		/// <returns>HIMETRIC単位のサイズ構造体</returns>
		private static Size convertPixelToHIMETRIC(Size size, IntPtr hdc)
		{
			const int HIMETRIC_PER_INCH = 2540;

			Size newSize = new Size();

			newSize.Width = (int)((double)size.Width * HIMETRIC_PER_INCH / GetDeviceCaps(hdc, DEVICECAPS.LOGPIXELSX) + 0.5);
			newSize.Height = (int)((double)size.Height * HIMETRIC_PER_INCH / GetDeviceCaps(hdc, DEVICECAPS.LOGPIXELSY) + 0.5);

			return newSize;
		}

		[DllImport("ole32")]
		private static extern int OleDraw(IntPtr pUnk, DVASPECT dwAspect, IntPtr hdcDraw, ref Rectangle lprcBounds);

		[DllImport("gdi32")]
		private static extern int GetDeviceCaps(IntPtr hdc, DEVICECAPS caps);

		#endregion
		// MEMO: エクステント・サイズを取得/設定するために使用。
		// UNDONE: SetExtent() / GetExtent() 以外は今回使用しないため、いい加減な定義となっているので要注意。
		[Guid("00000112-0000-0000-C000-000000000046"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown), ComVisible(false), ComImport]
		private interface IOleObject
		{
			void SetClientSite(IOleClientSite pClientSite);
			void GetClientSite(IOleClientSite ppClientSite);
			void SetHostNames(object szContainerApp, object szContainerObj);
			void Close(uint dwSaveOption);
			void SetMoniker(uint dwWhichMoniker, object pmk);
			void GetMoniker(uint dwAssign, uint dwWhichMoniker, object ppmk);
			void InitFromData(IDataObject pDataObject, bool fCreation, uint dwReserved);
			void GetClipboardData(uint dwReserved, IDataObject ppDataObject);
			void DoVerb(uint iVerb, uint lpmsg, object pActiveSite, uint lindex, uint hwndParent, uint lprcPosRect);
			void EnumVerbs(object ppEnumOleVerb);
			void Update();
			void IsUpToDate();
			void GetUserClassID(uint pClsid);
			void GetUserType(uint dwFormOfType, uint pszUserType);
			void SetExtent(DVASPECT dwDrawAspect, ref Size psizel);
			void GetExtent(DVASPECT dwDrawAspect, out Size psizel);
			void Advise(object pAdvSink, uint pdwConnection);
			void Unadvise(uint dwConnection);
			void EnumAdvise(object ppenumAdvise);
			void GetMiscStatus(uint dwAspect, uint pdwStatus);
			void SetColorScheme(object pLogpal);
		};
		// MEMO: このインタフェースは未使用。IOleObjectインタフェースの定義（再定義？）に必要。
		[Guid("00000118-0000-0000-C000-000000000046"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown), ComVisible(false), ComImport]
		private interface IOleClientSite
		{
			void SaveObject();
			void GetMoniker(uint dwAssign, uint dwWhichMoniker, object ppmk);
			void GetContainer(object ppContainer);
			void ShowObject();
			void OnShowWindow(bool fShow);
			void RequestNewObjectLayout();
		};
		private enum DVASPECT
		{
			DVASPECT_CONTENT = 1,
			DVASPECT_THUMBNAIL = 2,
			DVASPECT_ICON = 4,
			DVASPECT_DOCPRINT = 8
		}
		private enum DEVICECAPS
		{
			DRIVERVERSION = 0,
			TECHNOLOGY = 2,
			HORZSIZE = 4,
			VERTSIZE = 6,
			HORZRES = 8,
			VERTRES = 10,
			BITSPIXEL = 12,
			PLANES = 14,
			NUMBRUSHES = 16,
			NUMPENS = 18,
			NUMMARKERS = 20,
			NUMFONTS = 22,
			NUMCOLORS = 24,
			PDEVICESIZE = 26,
			CURVECAPS = 28,
			LINECAPS = 30,
			POLYGONALCAPS = 32,
			TEXTCAPS = 34,
			CLIPCAPS = 36,
			RASTERCAPS = 38,
			ASPECTX = 40,
			ASPECTY = 42,
			ASPECTXY = 44,
			LOGPIXELSX = 88,
			LOGPIXELSY = 90,
			SIZEPALETTE = 104,
			NUMRESERVED = 106,
			COLORRES = 108,
			PHYSICALWIDTH = 110,
			PHYSICALHEIGHT = 111,
			PHYSICALOFFSETX = 112,
			PHYSICALOFFSETY = 113,
			SCALINGFACTORX = 114,
			SCALINGFACTORY = 115,
			VREFRESH = 116,
			DESKTOPVERTRES = 117,
			DESKTOPHORZRES = 118,
			BLTALIGNMENT = 119,
			SHADEBLENDCAPS = 120,
			COLORMGMTCAPS = 121
		}
	}

}
