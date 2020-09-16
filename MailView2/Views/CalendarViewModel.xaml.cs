using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MailView2.Views
{
    /// <summary>
    /// Interaction logic for CalendarViewModel.xaml
    /// </summary>
    public partial class CalendarViewModel : UserControl
    {
        public CalendarViewModel()
        {
            InitializeComponent();
        }
        public string CalendarName
        {
            get { return calendarName.Text; }
            set { calendarName.Text = value; }
        }
    }
}
