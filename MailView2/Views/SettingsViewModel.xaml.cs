﻿using System;
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
    /// Interaction logic for SettingsViewModel.xaml
    /// </summary>
    public partial class SettingsViewModel : UserControl
    {
        public SettingsViewModel()
        {
            InitializeComponent();
        }
        public string SettingsName
        {
            get { return settingsName.Text; }
            set { settingsName.Text = value; }
        }
    }
}
