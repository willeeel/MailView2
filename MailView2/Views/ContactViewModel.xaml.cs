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
    /// Interaction logic for ContactViewModel.xaml
    /// </summary>
    public partial class ContactViewModel : UserControl
    {
        public ContactViewModel()
        {
            InitializeComponent();
        }
        public string ContactName
        {
            get { return contactName.Text; }
            set { contactName.Text = value; }
        }
        public string ContactRole
        {
            get { return contactRole.Text; }
            set { contactRole.Text = value; }
        }
    }
}
