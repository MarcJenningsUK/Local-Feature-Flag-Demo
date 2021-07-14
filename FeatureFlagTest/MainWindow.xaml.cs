﻿using FeatureControl;
using System.Windows;
using System.Windows.Controls;

namespace FeatureFlagTest
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

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var val = (sender as Button).Content.ToString();

            MessageBox.Show(FeatureManager.IsFeatureEnabled(val).ToString(), val + " availability");
        }

    }
}
