using System.Drawing;

namespace AlertToast {
    /// <summary>
    /// Theme object to be used with the Alert class.
    /// </summary>
    public class AlertTheme {
        #region colors
        public Color HeaderBGColor;
        public Color HeaderTextColor;
        public Color BodyBGColor;
        public Color BodyTextColor;
        #endregion

        #region font settings
        public Font HeaderFont;
        public Font BodyFont;
        #endregion



        public AlertTheme(Color HeaderBGColor, Color HeaderTextColor, Color BodyBGColor,
            Color BodyTextColor, Font BodyFont, Font HeaderFont) {
            this.HeaderBGColor = HeaderBGColor;
            this.HeaderTextColor = HeaderTextColor;
            this.BodyBGColor = BodyBGColor;
            this.BodyTextColor = BodyTextColor;
            this.BodyFont = BodyFont;
            this.HeaderFont = HeaderFont;
        }
    }

}