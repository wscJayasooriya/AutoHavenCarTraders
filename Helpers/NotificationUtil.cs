using iTextSharp.text.pdf.qrcode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Tulpep.NotificationWindow;

namespace CarTraders.Helpers
{
    public class NotificationUtil
    {
        public enum NotificationType
        {
            SUCCESS,
            EDIT,
            DELETE,
            WARN,
            UNAUTHORIZED,
            INFO,
            ERROR

        }

        public static void ShowNotification(NotificationType type, string message)
        {

            switch (type)
            {
                case NotificationType.SUCCESS:

                    // MessageBox.Show("SUCCESS BN");
                    ShowAlert(type, "Successfully Added.", message);
                    break;

                case NotificationType.EDIT:

                    //  MessageBox.Show("EDit BN");
                    ShowAlert(type, "Successfully Updated.", message);
                    break;

                case NotificationType.DELETE:

                    // MessageBox.Show("DELETE BN");
                    ShowAlert(type, "Successfully Deleted.", message);
                    break;

                case NotificationType.WARN:

                    //  MessageBox.Show("WARN BN");
                    ShowAlert(type, "Warning !", message);
                    break;

                case NotificationType.UNAUTHORIZED:
                    //  MessageBox.Show("UNAUTHORIZED BN");
                    ShowAlert(type, "You Don't Have Access.", message);
                    break;

                case NotificationType.INFO:
                    //  MessageBox.Show("INFO BN");
                    ShowAlert(type, "For Your Information.", message);
                    break;

                case NotificationType.ERROR:
                    //  MessageBox.Show("ERROR BN");
                    ShowAlert(type, "Error! Something Went Wrong", message);
                    break;

                default:
                    // MessageBox.Show(message);
                    ShowAlert(type, "For Your Information.", message);
                    break;
            }


        }

        private static void ShowAlert(NotificationType type, string title, string message)
        {
            var popupNotifier = new PopupNotifier
            {
                TitleText = title,
                ContentText = message,
                Size = new Size(500, 150),
                TitleFont = new Font(new FontFamily("Segoe UI"), 12),
                BodyColor = Color.LightGray,
                TitlePadding = new Padding(10),
                ContentPadding = new Padding(12),
                ImagePadding = new Padding(10),
                ContentHoverColor = Color.DarkBlue,
                IsRightToLeft = false,
                ShowCloseButton = false,
                ShowGrip = false,
                Delay = 3000,
                AnimationDuration = 500,
                Scroll = false
            };

            // Set properties based on the notification type
            switch (type)
            {
                case NotificationType.SUCCESS:
                    popupNotifier.Image = ByteArrayToBitmap(Properties.Resources.Ok);
                    popupNotifier.HeaderColor = Color.DarkOliveGreen;
                    break;
                case NotificationType.EDIT:
                    popupNotifier.Image = ByteArrayToBitmap(Properties.Resources.update);
                    popupNotifier.HeaderColor = Color.GreenYellow;
                    break;
                case NotificationType.DELETE:
                    popupNotifier.Image = ByteArrayToBitmap(Properties.Resources.Delete);
                    popupNotifier.HeaderColor = Color.Red;
                    break;
                case NotificationType.WARN:
                    popupNotifier.Image = ByteArrayToBitmap(Properties.Resources.Warning);
                    popupNotifier.HeaderColor = Color.Yellow;
                    break;
                case NotificationType.UNAUTHORIZED:
                    popupNotifier.Image = ByteArrayToBitmap(Properties.Resources.Restriction);
                    popupNotifier.HeaderColor = Color.Red;
                    break;
                case NotificationType.INFO:
                    popupNotifier.Image = ByteArrayToBitmap(Properties.Resources.info);
                    popupNotifier.HeaderColor = Color.DodgerBlue;
                    break;
                case NotificationType.ERROR:
                    popupNotifier.Image = ByteArrayToBitmap(Properties.Resources.Restriction);
                    popupNotifier.HeaderColor = Color.Red;
                    break;
            }

            popupNotifier.Popup();

        }

        private static Image ByteArrayToBitmap(byte[] byteArray)
        {
            using (var ms = new MemoryStream(byteArray))
            {
                return new Bitmap(ms);
            }
        }
    }
}
