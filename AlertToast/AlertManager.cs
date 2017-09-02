using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace AlertToast {
    /// <summary>
    /// Pool of active alerts. Used to maintain and track locations
    /// so alerts do not overlap. Alerts can be used with out this
    /// class, but are not guaranteed to not overlap.
    /// </summary>
    public class AlertManager {
        private static List<Alert> ActiveAlerts = new List<Alert>();

        /// <summary>
        /// Creates and shows alert/toast, and adds alert/toast
        /// to pool of active alerts/toasts.
        /// </summary>
        /// <param name="header">String to be displayed in header/alert</param>
        /// <param name="body">String to be displayed in body of toast/alert</param>
        /// <param name="theme">AlertTheme object used to control colors and fonts of toast/alert message</param>
        /// <param name="rtf">Boolean flag to indicate if body parameter is plain text of rtf</param>
        /// <param name="timer">int length of time in milliseconds to display form. 0 disables timer.</param>
        /// <returns></returns>
        public static Alert createAlert(String header, String body, AlertTheme theme, bool rtf = false, int timer = 0) {
            Point tmp = getOffset();
            Alert newAlert = new Alert(header, body, theme, rtf, tmp.X, tmp.Y,timer);
            ActiveAlerts.Add(newAlert);
            newAlert.Show();
            return newAlert;
        }

        /// <summary>
        /// Removes the passed alert from the pool
        /// </summary>
        /// <param name="alert">Alert object to remove</param>
        public static void removeAlert(Alert alert) {
            ActiveAlerts.Remove(alert);
        }

        /// <summary>
        /// Locates the alert that is furthers to the left and to the top.
        /// </summary>
        /// <returns>Point object of Top and Left values of the top left alert.</returns>
        private static Point getOffset() {
            Point ret = new Point(Screen.PrimaryScreen.WorkingArea.Width, Screen.PrimaryScreen.WorkingArea.Height);
            Alert mosttopleft = null;
            
            foreach (Alert iter in ActiveAlerts) {
                if(mosttopleft == null){
                    mosttopleft = iter;
                    continue;
                }else if (iter.Left < mosttopleft.Left) {
                    mosttopleft = iter;
                }else if (iter.Top < mosttopleft.Top && iter.Left <= mosttopleft.Left) {
                    mosttopleft = iter;
                }
            }
            if(mosttopleft != null) {
                ret.X = mosttopleft.Left;
                ret.Y = mosttopleft.Top;
            }
            return ret;
        }
    }
}
