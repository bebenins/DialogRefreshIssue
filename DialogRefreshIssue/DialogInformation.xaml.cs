using System.Windows;
using System.Windows.Controls;

namespace DialogRefreshIssue
{
    public partial class DialogInformation : UserControl
    {
        public enum ButtonType { OK, CancelOK, NoYes };

        public DialogInformation(string message, string title)
        {
            InitializeComponent();
            InitializeGUI(message, title, ButtonType.OK);
        }

        private void InitializeGUI(string message, string title, ButtonType buttonType)
        {
            Title.Text = title;
            Message.Text = message;

            Icon.Visibility = Visibility.Collapsed;
            Icon.Margin = new Thickness(0, 0, 0, 0);

            switch (buttonType)
            {
                case ButtonType.OK:
                    ButtonTrue.Content = "OK";
                    ButtonFalse.Content = null;
                    ButtonFalse.Visibility = Visibility.Hidden;
                    break;
                case ButtonType.CancelOK:
                    ButtonTrue.Content = "OK";
                    ButtonFalse.Content = "CANCEL";
                    break;
                case ButtonType.NoYes:
                    ButtonTrue.Content = "YES";
                    ButtonFalse.Content = "NO";
                    break;
            }
        }
    }
}