using System.Drawing;

namespace AlertToast {
    /// <summary>
    /// Theme object to be used with the Alert class.
    /// </summary>
    public class AlertTheme {
        #region colors
        public Color HeaderBG;
        public Color HeaderTextColor;
        public Color BodyBG;
        public Color BodyTextColor;
        #endregion

        #region font settings
        public Font HeaderFont;
        public Font BodyFont;
        #endregion

        #region animation settings
        public int animationIn;
        public int directionIn;
        public int animationlenIn;
        public int animationOut;
        public int directionOut;
        public int animationlenOut;
        #endregion



        public AlertTheme(Color HeaderBG, Color HeaderTextColor, Color BodyBG,
            Color BodyTextColor, Font BodyFont, Font HeaderFont,int animationlenIn = 450,
            int animationIn = User32.AnimateWindowFlags.AW_SLIDE, int directionIn = User32.AnimateWindowFlags.AW_VER_NEGATIVE,
            int animationlenOut = 450, int animationOut = User32.AnimateWindowFlags.AW_BLEND, 
            int directionOut = User32.AnimateWindowFlags.AW_VER_NEGATIVE) {
            this.HeaderBG = HeaderBG;
            this.HeaderTextColor = HeaderTextColor;
            this.BodyBG = BodyBG;
            this.BodyTextColor = BodyTextColor;
            this.BodyFont = BodyFont;
            this.HeaderFont = HeaderFont;
            this.animationIn = animationIn;
            this.directionIn = directionIn;
            this.animationlenIn = animationlenIn;
            this.animationOut = animationOut;
            this.directionOut = directionOut;
            this.animationlenOut = animationlenOut;
        }
    }

}