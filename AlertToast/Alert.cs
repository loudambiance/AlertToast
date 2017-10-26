using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace AlertToast {
    public partial class Alert : Form {

        private AlertTheme gtheme;
        private int xoffset;
        private int yoffset;

        /// <summary>
        /// Create a toast/alert form
        /// </summary>
        /// <param name="header">String to be displayed in header/alert</param>
        /// <param name="body">String to be displayed in body of toast/alert</param>
        /// <param name="theme">AlertTheme object used to control colors and fonts of toast/alert message</param>
        /// <param name="rtf">Boolean flag to indicate if body parameter is plain text of rtf</param>
        /// <param name="xoffset">int offset value for X position</param>
        /// <param name="yoffset">int offset value for Y position</param>
        /// <param name="timer">int length of time in milliseconds to display form. 0 disables timer.</param>
        public Alert(String header, String body, AlertTheme theme, bool rtf = false, int xoffset = 0, int yoffset = 0, int timer = 0) {
            InitializeComponent();
            this.gtheme = theme;
            this.titletext.Text = header;
            this.xoffset = xoffset;
            this.yoffset = yoffset;
            if (rtf) {
                this.bodytext.Rtf = body;
            } else {
                this.bodytext.Text = body;
            }
            //this.bodytext.BackColor = this.gtheme.BodyBGColor;
            this.titletext.ForeColor = this.gtheme.HeaderTextColor;
            this.titletext.Font = this.gtheme.HeaderFont;
            this.close_label.ForeColor = this.gtheme.HeaderTextColor;
            this.close_label.Font = this.gtheme.HeaderFont;
            this.Height = this.tableLayoutPanel1.Height;
            this.Width = this.tableLayoutPanel1.Width;
            if(timer != 0) {
                this.timer1.Interval = timer;
                this.timer1.Enabled = true;
                this.timer1.Start();
            }
            this.Location = calculateLocation();
        }

        /*private void tableLayoutPanel1_CellPaint(object sender, TableLayoutCellPaintEventArgs e) {
            if ((e.Row) % 2 == 0) {
                if (this.gtheme.HeaderBG.GetType() == typeof(LinearGradientBrush)) {
                    LinearGradientBrush tmp = ((LinearGradientBrush)this.gtheme.HeaderBG);
                    float modifier = e.CellBounds.Height / tmp.Rectangle.Height;
                    tmp.ScaleTransform(1.0f, modifier, MatrixOrder.Prepend);
                    e.Graphics.FillRectangle(tmp, e.CellBounds);
                } else { 
                    e.Graphics.FillRectangle(this.gtheme.HeaderBG, e.CellBounds);
                }
            } else {
                if (this.gtheme.BodyBG.GetType() == typeof(LinearGradientBrush)) {
                    LinearGradientBrush tmp = ((LinearGradientBrush)this.gtheme.BodyBG);
                    float modifier = e.CellBounds.Height / tmp.Rectangle.Height;
                    Matrix A = tmp.Transform;
                    tmp.ScaleTransform(1.0f, modifier, MatrixOrder.Append);
                   Matrix B  = tmp.Transform;
                    
                    e.Graphics.FillRectangle(tmp, e.CellBounds);
                } else {
                    e.Graphics.FillRectangle(this.gtheme.BodyBG, e.CellBounds);
                }
            }
        }*/


        private void tableLayoutPanel1_CellPaint(object sender, TableLayoutCellPaintEventArgs e) {
            if ((e.Row) % 2 == 0) {
                e.Graphics.FillRectangle(new SolidBrush(this.gtheme.HeaderBG), e.CellBounds);
            } else {
               e.Graphics.FillRectangle(new SolidBrush(this.gtheme.BodyBG), e.CellBounds);
            }
        }

        private void bodytext_ContentsResized(object sender, ContentsResizedEventArgs e) {
            this.bodytext.Height = e.NewRectangle.Height+5;
            tableLayoutPanel1.Invalidate();
        }

        private void close_label_Click(object sender, EventArgs e) {
            this.Close();
        }

        public Point updatePosition(Point point) {
            Point ret;

            int bottom = Screen.PrimaryScreen.WorkingArea.Bottom;
            int right = Screen.PrimaryScreen.WorkingArea.Right;

            if ((point.Y - this.Height - 10) > 0) {
                ret = new Point(point.X, point.Y - this.Height - 10);
            } else {
                ret = new Point(point.X - this.Width - 10, bottom - this.Height - 10);
            }
            User32.MoveWindow(this.Handle, ret.X, ret.Y, this.Width, this.Height, true);
            //this.Location = ret; 
            return ret;
        }

        /// <summary>
        /// Calculate where to display alert based on provided offsets.
        /// </summary>
        /// <returns>Point object to be Top/Left location of form</returns>
        private Point calculateLocation() {

            Point ret;

            int bottom = Screen.PrimaryScreen.WorkingArea.Bottom;
            int right = Screen.PrimaryScreen.WorkingArea.Right;

            if (xoffset == right || (xoffset == 0 && yoffset == 0)) {
                ret = new Point(right - this.Width - 10, bottom - this.Height - 10);
            }else if ((yoffset - this.Height - 10) > 0) {
                ret = new Point(xoffset, yoffset - this.Height - 10);
            } else {
                ret = new Point(xoffset - this.Width - 10, bottom - this.Height - 10);
            }
            return ret;
        }

        
        //todo: Add options for other animations, and make animations optional
        protected override void OnLoad(System.EventArgs e) {
            this.Location = calculateLocation();
            this.TopMost = true;
            if(this.gtheme.animationIn == User32.AnimateWindowFlags.AW_SLIDE) {
                User32.AnimateWindow(this.Handle, this.gtheme.animationlenIn, this.gtheme.animationIn | this.gtheme.directionIn);
            }else {
                User32.AnimateWindow(this.Handle, this.gtheme.animationlenIn, this.gtheme.animationIn);
            }


            //used to fix issue with richtextbox not displaying after animation
            //todo: find better solution
            this.tableLayoutPanel1.Refresh();
            this.Text = this.Text + " X: " + this.Location.X + "; Y: " + this.Location.Y; 
            base.OnLoad(e);
            
        }

        protected override void OnClosing(CancelEventArgs e) {
            if (this.gtheme.animationOut == User32.AnimateWindowFlags.AW_SLIDE) {
                User32.AnimateWindow(this.Handle, this.gtheme.animationlenOut, this.gtheme.animationOut | this.gtheme.directionOut | User32.AnimateWindowFlags.AW_HIDE);
            } else {
                User32.AnimateWindow(this.Handle, this.gtheme.animationlenOut, this.gtheme.animationOut | User32.AnimateWindowFlags.AW_HIDE);
            }

            base.OnClosing(e);
        }

        private void Alert_FormClosed(object sender, FormClosedEventArgs e) {
            AlertManager.removeAlert(this);
        }

        private void timer1_Tick(object sender, EventArgs e) {
            this.Close();
        }

        private void bodytext_LinkClicked(object sender, LinkClickedEventArgs e) {
            System.Diagnostics.Process.Start(e.LinkText);
        }


    }
}
