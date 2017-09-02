namespace AlertToast {
    partial class Alert {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.titletext = new System.Windows.Forms.Label();
            this.bodytext = new System.Windows.Forms.RichTextBox();
            this.close_label = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.titletext, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.bodytext, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.close_label, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.MaximumSize = new System.Drawing.Size(350, 0);
            this.tableLayoutPanel1.MinimumSize = new System.Drawing.Size(350, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(350, 70);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.tableLayoutPanel1_CellPaint);
            // 
            // titletext
            // 
            this.titletext.AutoSize = true;
            this.titletext.BackColor = System.Drawing.Color.Transparent;
            this.titletext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titletext.ForeColor = System.Drawing.Color.White;
            this.titletext.Location = new System.Drawing.Point(23, 0);
            this.titletext.Name = "titletext";
            this.titletext.Size = new System.Drawing.Size(69, 20);
            this.titletext.TabIndex = 0;
            this.titletext.Text = "titletext";
            // 
            // bodytext
            // 
            this.bodytext.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bodytext.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bodytext.Location = new System.Drawing.Point(23, 23);
            this.bodytext.Name = "bodytext";
            this.bodytext.ReadOnly = true;
            this.bodytext.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.bodytext.Size = new System.Drawing.Size(304, 44);
            this.bodytext.TabIndex = 2;
            this.bodytext.Text = "";
            this.bodytext.ContentsResized += new System.Windows.Forms.ContentsResizedEventHandler(this.bodytext_ContentsResized);
            // 
            // close_label
            // 
            this.close_label.AutoSize = true;
            this.close_label.BackColor = System.Drawing.Color.Transparent;
            this.close_label.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_label.ForeColor = System.Drawing.Color.White;
            this.close_label.Location = new System.Drawing.Point(333, 0);
            this.close_label.Name = "close_label";
            this.close_label.Size = new System.Drawing.Size(14, 20);
            this.close_label.TabIndex = 3;
            this.close_label.Text = "🗙   ";
            this.close_label.Click += new System.EventHandler(this.close_label_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Alert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 70);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(350, 800);
            this.MinimumSize = new System.Drawing.Size(350, 20);
            this.Name = "Alert";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Alert_FormClosed);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label titletext;
        private System.Windows.Forms.RichTextBox bodytext;
        private System.Windows.Forms.Label close_label;
        private System.Windows.Forms.Timer timer1;
    }
}