using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Controls;

namespace DialogRefreshIssue
{
    public partial class DialogProgress : UserControl
    {
        private string m_progressTitle;
        public string ProgressTitle
        {
            get { return m_progressTitle; }
            set { m_progressTitle = value; OnPropertyChanged(); }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged != null)
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public DialogProgress(string title)
        {
            InitializeComponent();

            DataContext = this;

            ProgressTitle = title;
        }
    }
}