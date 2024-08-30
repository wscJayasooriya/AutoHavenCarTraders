using System;
using System.Collections.Generic;
using System.Linq;
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
                Size = new Size(400, 150),
                TitleFont = new Font(new FontFamily("Segoe UI"), 12),
                BodyColor = Color.LightGray,
                TitlePadding = new Padding(10),
                ContentPadding = new Padding(12),
                ImagePadding = new Padding(10),
                ContentHoverColor = Color.DarkBlue,
                IsRightToLeft = false,
                ShowCloseButton = false,
                ShowGrip = false,
                Delay = 5000,
                AnimationDuration = 500,
                Scroll = false
            };

            // Set properties based on the notification type
            switch (type)
            {
                case NotificationType.SUCCESS:
                    popupNotifier.Image = Properties.ResourceImage.Ok;
                    popupNotifier.HeaderColor = Color.DarkOliveGreen;
                    break;
                case NotificationType.EDIT:
                    popupNotifier.Image = Properties.ResourceImage.update;
                    popupNotifier.HeaderColor = Color.GreenYellow;
                    break;
                case NotificationType.DELETE:
                    popupNotifier.Image = Properties.ResourceImage.Delete;
                    popupNotifier.HeaderColor = Color.Red;
                    break;
                case NotificationType.WARN:
                    popupNotifier.Image = Properties.ResourceImage.Warning;
                    popupNotifier.HeaderColor = Color.Yellow;
                    break;
                case NotificationType.UNAUTHORIZED:
                    popupNotifier.Image = Properties.ResourceImage.Restriction;
                    popupNotifier.HeaderColor = Color.Red;
                    break;
                case NotificationType.INFO:
                    popupNotifier.Image = Properties.ResourceImage.info;
                    popupNotifier.HeaderColor = Color.DodgerBlue;
                    break;
            }

            // Show the notification
            popupNotifier.Popup();
        }
    }
}
