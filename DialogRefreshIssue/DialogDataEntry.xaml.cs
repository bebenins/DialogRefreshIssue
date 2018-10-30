using System.Windows;
using System.Windows.Controls;

namespace DialogRefreshIssue
{
    public partial class DialogDataEntry : UserControl
    {
        public enum ButtonType { OK, CancelOK, NoYes };

        public DialogDataEntry(string title, string description)
        {
            InitializeComponent();
            InitializeGUI(title, description, string.Empty, ButtonType.OK);
        }

        public DialogDataEntry(string title, string description, ButtonType buttonType)
        {
            InitializeComponent();
            InitializeGUI(title, description, string.Empty, buttonType);
        }

        public DialogDataEntry(string title, string description, string defaultData, ButtonType buttonType)
        {
            InitializeComponent();
            InitializeGUI(title, description, defaultData, buttonType);
        }

        private void InitializeGUI(string title, string description, string defaultData, ButtonType buttonType)
        {
            Title.Text = title;
            Description.Text = description;
            EnteredData.Text = defaultData;

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
