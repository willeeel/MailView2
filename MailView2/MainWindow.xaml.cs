using MailView2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MailView2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
           
        }
        private void btnContacts_Click (object sender, RoutedEventArgs e)
        {
            contactList.Children.Clear();
            DataContext = new ContactModel();
            var contacts = new List<string>()
            {
                "william",
                "person2",
                "person3",
            };

            foreach (var contact in contacts)
            {
                contactList.Children.Add(new Views.ContactViewModel() { ContactName = contact });
            }
        }
        private void btnMessages_Click(object sender, RoutedEventArgs e)
        {
            contactList.Children.Clear();
            DataContext = new MessageModel();
            var messages = new List<string>()
            {
                "message1",
                "message2",
                "message3",
            };
            foreach (var message in messages)
            {
                contactList.Children.Add(new Views.MessageViewModel() { MessageName = message });
            }

        }
        private void btnCalendar_Click(object sender, RoutedEventArgs e)
        {
            contactList.Children.Clear();
            DataContext = new CalendarModel();
            var calendars = new List<string>()
            {
                "1",
                "2",
                "3",
                "4",
                "5",
                "6",
                "7",
            };
            foreach (var calendar in calendars)
            {
                contactList.Children.Add(new Views.CalendarViewModel() { CalendarName = calendar });
            }

        }
        private void btnSettings_Click(object sender, RoutedEventArgs e)
        {
            contactList.Children.Clear();
            DataContext = new SettingsModel();
            var settings = new List<string>()
            {
                "setting1",
                "setting2",
                "setting3",
                "setting4",
                "setting5",
            };
            foreach (var setting in settings)
            {
                contactList.Children.Add(new Views.SettingsViewModel() { SettingsName = setting });
            }

        }
    }
}