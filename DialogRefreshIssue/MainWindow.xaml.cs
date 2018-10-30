using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

using MahApps.Metro.Controls;

namespace DialogRefreshIssue
{
    public partial class MainWindow : MetroWindow, INotifyPropertyChanged
    {
        private bool m_isShow;
        public bool IsShow
        {
            get { return m_isShow; }
            set { m_isShow = value; OnPropertyChanged(); }
        }

        private object m_dialogObject;
        public object DialogObject
        {
            get { return m_dialogObject; }
            set
            {
                if (m_dialogObject == value) return;
                m_dialogObject = value; OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged != null)
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void ButtonTestProgress_Click(object sender, RoutedEventArgs e)
        {
            DialogObject = new DialogProgress("Initializing...");
            IsShow = !IsShow;
        }
        private void ButtonTestInfo_Click(object sender, RoutedEventArgs e)
        {
            DialogObject = new DialogInformation("Exception initializing.", "Initialization");
            IsShow = !IsShow;
        }

        private void ButtonTestDataEntry_Click(object sender, RoutedEventArgs e)
        {
            DialogObject = new DialogDataEntry("Standby current", "Enter Standby current.");
            IsShow = !IsShow;
        }
    }
}
