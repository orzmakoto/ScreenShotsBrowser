using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ScreenShotsBrowser.Properties;

namespace ScreenShotsBrowser
{
	public enum SliderType
	{
		Horizontally,
		Vertically
	}
	public abstract class SliderBasePanel : Panel
	{
		public abstract SliderType SliderType { get; }
		public abstract void SetSliderLocation(Point first, Point last);
		public abstract void GetSliderLocation(out SimplePoint first, out  SimplePoint last);

		public Size TargetControlSize { get; set; }
		public void SetTargetControlSize(Size size)
		{
			TargetControlSize = size;
		}

		protected void InitLeft()
		{
			this.SliderLeft = new LocationHSliderPointer();
			{
				SliderLeft.Slider = this;
				SliderLeft.Image = Resources.sliderLeft;
				SliderLeft.Size = Resources.sliderLeft.Size;
				SliderLeft.SliderPosition = SliderPosition.Left;
				SliderLeft.Location = new Point(0, 1);
			}
			base.Controls.Add(this.SliderLeft);
		}
		protected void InitRight()
		{
			this.SliderRight = new LocationHSliderPointer();
			{
				SliderRight.Slider = this;
				SliderRight.Image = Resources.sliderRight;
				SliderRight.Size = Resources.sliderRight.Size;
				SliderRight.SliderPosition = SliderPosition.Right;
				SliderRight.Location = new Point(this.Size.Width - SliderRight.Size.Width, 1);
			}
			base.Controls.Add(this.SliderRight);
		}
		protected void InitTop()
		{
			this.SliderTop = new LocationVSliderPointer();
			{
				SliderTop.Slider = this;
				SliderTop.Image = Resources.sliderTop;
				SliderTop.Size = Resources.sliderTop.Size;
				SliderTop.SliderPosition = SliderPosition.Top;
				SliderTop.Location = new Point(1, 0);
			}
			base.Controls.Add(this.SliderTop);
		}
		protected void InitBottom()
		{
			this.SliderBottom = new LocationVSliderPointer();
			{
				SliderBottom.Slider = this;
				SliderBottom.Image = Resources.sliderButtom;
				SliderBottom.Size = Resources.sliderButtom.Size;
				SliderBottom.SliderPosition = SliderPosition.Bottom;
				SliderBottom.Location = new Point(1, this.Size.Height - SliderBottom.Size.Height);
			}
			base.Controls.Add(this.SliderBottom);
		}

		/// <summary>
		/// 横スライダー位置設定
		/// </summary>
		/// <param name="Left"></param>
		/// <param name="Right"></param>
		protected void SetHSliderLocation(Point left, Point right)
		{
			if (SliderLeft != null)
			{
				SliderLeft.Location = left;
			}
			if (SliderRight != null)
			{
				SliderRight.Location = right;
			}
		}
		/// <summary>
		/// 建スライダー位置設定
		/// </summary>
		/// <param name="top"></param>
		/// <param name="bottom"></param>
		protected void SetVSliderLocation(Point top, Point bottom)
		{
			if (SliderTop != null)
			{
				SliderTop.Location = top;
			}
			if (SliderBottom != null)
			{
				SliderBottom.Location = bottom;
			}
		}
		/// <summary>
		/// 横スライダー位置取得
		/// </summary>
		/// <param name="Left"></param>
		/// <param name="Right"></param>
		protected void GetHSliderLocation(out SimplePoint left, out SimplePoint right)
		{
			left = this.SliderLeft.Location.ToSimplePoint();
			right = this.SliderRight.Location.ToSimplePoint();
		}
		/// <summary>
		/// 建スライダー位置取得
		/// </summary>
		/// <param name="top"></param>
		/// <param name="bottom"></param>
		protected void GetVSliderLocation(out SimplePoint top, out SimplePoint bottom)
		{
			top = this.SliderTop.Location.ToSimplePoint();
			bottom = this.SliderBottom.Location.ToSimplePoint();
		}

		protected LocationHSliderPointer SliderLeft { get; set; }
		protected LocationHSliderPointer SliderRight { get; set; }

		protected LocationVSliderPointer SliderTop { get; set; }
		protected LocationVSliderPointer SliderBottom { get; set; }

		protected class SliderBasePointer : PictureBox
		{
			public SliderPosition SliderPosition { get; set; }
			public SliderBasePanel Slider { get; set; }
			public bool IsMouseDown { get; protected set; }
			protected GuideLineForm GuideLine;

			protected override void OnMouseEnter(EventArgs e)
			{
				if (Slider.SliderType == SliderType.Horizontally)
				{
					Cursor = System.Windows.Forms.Cursors.SizeWE;
				}
				else
				{
					Cursor = System.Windows.Forms.Cursors.SizeNS;
				}

				base.OnMouseEnter(e);
			}
			protected override void OnMouseLeave(EventArgs e)
			{
				Cursor = System.Windows.Forms.Cursors.Default;
				base.OnMouseLeave(e);
			}
			protected override void OnMouseUp(MouseEventArgs e)
			{
				if (e.Button == System.Windows.Forms.MouseButtons.Left)
				{
					GuideLine.Hide();
					IsMouseDown = false;
				}
				base.OnMouseUp(e);
			}
		}
		protected class LocationHSliderPointer : SliderBasePointer
		{
			protected override void OnMouseDown(MouseEventArgs e)
			{
				if (e.Button == System.Windows.Forms.MouseButtons.Left)
				{
					GuideLine = new GuideLineForm();
					GuideLine.ShowHorizontally(Slider.TargetControlSize.Height);
					IsMouseDown = true;
				}
				base.OnMouseDown(e);
			}

			protected override void OnMouseMove(MouseEventArgs e)
			{
				if (this.IsMouseDown == true)
				{
					if ((base.Location.X + e.X) > -1 &&
						(base.Location.X + e.X) <= base.Parent.Size.Width - this.Size.Width)
					{
						Point p = this.PointToScreen(new Point(0, 0));
						GuideLine.Location = new Point(
							SliderPosition == SliderPosition.Left ? p.X + e.X : p.X + this.Size.Width - 2,
							 p.Y + this.Size.Height
							);
						base.Location = new Point(base.Location.X + e.X, base.Location.Y);
					}
				}
				base.OnMouseMove(e);
			}
		}
		protected class LocationVSliderPointer : SliderBasePointer
		{
			protected override void OnMouseDown(MouseEventArgs e)
			{
				if (e.Button == System.Windows.Forms.MouseButtons.Left)
				{
					GuideLine = new GuideLineForm();
					GuideLine.ShowVertically(Slider.TargetControlSize.Width);
					IsMouseDown = true;
				}
				base.OnMouseDown(e);
			}
			protected override void OnMouseMove(MouseEventArgs e)
			{
				if (this.IsMouseDown == true)
				{
					if ((base.Location.Y + e.Y) > -1 &&
						(base.Location.Y + e.Y) <= base.Parent.Size.Height - this.Size.Height)
					{
						Point p = this.PointToScreen(new Point(0, 0));
						GuideLine.Location = new Point(
							p.X + this.Size.Width,
							SliderPosition == SliderPosition.Top ? p.Y + e.Y : p.Y + this.Size.Height - 2
							);

						base.Location = new Point(base.Location.X, base.Location.Y + e.Y);
					}
				}
				base.OnMouseMove(e);
			}
		}

		public int StartLeft
		{
			get
			{
				if (base.Visible == false)
				{
					return 0;
				}
				return SliderLeft.Location.X;
			}
		}
		public int StartRight
		{
			get
			{
				if (base.Visible == false)
				{
					return 0;
				}
				return SliderRight.Location.X + SliderRight.Size.Width;
			}
		}
		public int StartTop
		{
			get
			{
				if (base.Visible == false)
				{
					return 0;
				}
				return SliderTop.Location.Y;
			}
		}
		public int StartBottom
		{
			get
			{
				if (base.Visible == false)
				{
					return 0;
				}
				return SliderBottom.Location.Y + SliderBottom.Size.Height;
			}
		}
		public int RangeHeight
		{
			get
			{
				if (base.Visible == false)
				{
					return 0;
				}
				return SliderBottom.Location.Y - (SliderTop.Location.Y - SliderTop.Size.Height);
			}
		}
		public int RangeWidth
		{
			get
			{
				if (base.Visible == false)
				{
					return 0;
				}
				return SliderRight.Location.X - (SliderLeft.Location.X - SliderLeft.Size.Width);// -4;
			}
		}
	}

	public class LocationHorizontallySlider : SliderBasePanel
	{
		public override SliderType SliderType
		{
			get { return ScreenShotsBrowser.SliderType.Horizontally; }
		}
		protected override void OnPaint(PaintEventArgs e)
		{
			if (this.SliderLeft == null)
			{
				base.InitLeft();
				base.InitRight();
			}
			base.OnPaint(e);
		}

		public override void SetSliderLocation(Point first, Point last)
		{
			SetHSliderLocation(first, last);
		}
		public override void GetSliderLocation(out SimplePoint first, out SimplePoint last)
		{
			base.GetHSliderLocation(out first, out last);
		}
	}

	public class LocationVerticallySlider : SliderBasePanel
	{
		public override SliderType SliderType
		{
			get { return ScreenShotsBrowser.SliderType.Vertically; }
		}
		protected override void OnPaint(PaintEventArgs e)
		{
			if (this.SliderTop == null)
			{
				base.InitTop();
				base.InitBottom();
			}
			base.OnPaint(e);
		}

		public override void SetSliderLocation(Point first, Point last)
		{
			SetVSliderLocation(first, last);
		}
		public override void GetSliderLocation(out SimplePoint first, out SimplePoint last)
		{
			base.GetVSliderLocation(out first, out last);
		}
	}
}
