using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

using MahApps.Metro.Controls;

namespace DialogRefreshIssue
{
    public partial class MainWindow : MetroWindow, INotifyPropertyChanged
    {
        private bool m_isInitializing;
        public bool IsInitializing
        {
            get { return m_isInitializing; }
            set { m_isInitializing = value; OnPropertyChanged(); }
        }

        private object m_progressInitialization;
        public object ProgressInitialization
        {
            get { return m_progressInitialization; }
            set
            {
                if (m_progressInitialization == value) return;
                m_progressInitialization = value; OnPropertyChanged();
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

            ProgressInitialization = new ProgressDialog("Initializing...");
        }

        private void ButtonTest_Click(object sender, RoutedEventArgs e)
        {
            IsInitializing = !IsInitializing;
        }
    }
}
