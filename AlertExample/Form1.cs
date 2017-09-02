using AlertToast;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AlertExample {
    public partial class Form1 : Form {
        AlertTheme red;
        AlertTheme blue;
        AlertTheme green;
        AlertTheme yellow;
        AlertTheme orange;

        public Form1() {
            InitializeComponent();
            initthemes();
        }

        private void initthemes() {
            this.red = new AlertTheme(Color.FromArgb(169, 68, 66), Color.FromArgb(255, 255, 255),
                Color.FromArgb(235, 204, 204),Color.FromArgb(169, 68, 66), new Font("Arial", 10),
                new Font("Arial", 12, FontStyle.Bold));
            this.yellow = new AlertTheme(Color.FromArgb(138, 109, 59), Color.FromArgb(255, 255, 255),
                Color.FromArgb(250, 242, 204), Color.FromArgb(138, 109, 59), new Font("Arial", 10),
                new Font("Arial", 12, FontStyle.Bold));
            this.orange = new AlertTheme(Color.FromArgb(255, 136, 0), Color.FromArgb(255, 255, 255),
                Color.FromArgb(255, 187, 51), Color.FromArgb(255, 136, 0), new Font("Arial", 10),
                new Font("Arial", 12, FontStyle.Bold));
            this.green = new AlertTheme(Color.FromArgb(60, 118, 61), Color.FromArgb(255, 255, 255),
                Color.FromArgb(208, 233, 198), Color.FromArgb(60, 118, 61), new Font("Arial", 10),
                new Font("Arial", 12, FontStyle.Bold));
            this.blue = new AlertTheme(Color.FromArgb(49, 112, 143), Color.FromArgb(255, 255, 255),
                Color.FromArgb(188, 223, 241), Color.FromArgb(49, 112, 143), new Font("Arial", 10),
                new Font("Arial", 12, FontStyle.Bold));
        }

        private void button1_Click(object sender, EventArgs e) {
            AlertTheme tmp = this.red;
            switch (this.comboBox1.SelectedItem.ToString().Trim()) {
                case "Green":
                    tmp = this.green;
                    break;
                case "Blue":
                    tmp = this.blue;
                    break;
                case "Yellow":
                    tmp = this.yellow;
                    break;
                case "Orange":
                    tmp = this.orange;
                    break;
                case "Red":
                    tmp = this.red;
                    break;
            }
            AlertManager.createAlert(textBox6.Text, richTextBox1.Rtf, tmp, true);
        }
    }
}
