using System.Windows.Forms;

namespace AlertToast {
    public partial class TransAlertRTB : RichTextBox {
        public TransAlertRTB() {
            InitializeComponent();
        }

        protected override CreateParams CreateParams {
            get {
                //This makes the control's background transparent
                CreateParams CP = base.CreateParams;
                CP.ExStyle |= 0x20;
                return CP;
            }
        }
    }
}
