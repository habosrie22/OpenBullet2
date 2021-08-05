﻿using MahApps.Metro.Controls;
using OpenBullet2.Native.Helpers;
using OpenBullet2.Native.Pages;
using System;
using System.Windows.Controls;
using System.Windows.Input;

namespace OpenBullet2.Native
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        private readonly About aboutPage;
        private Page currentPage;

        public MainWindow()
        {
            InitializeComponent();

            aboutPage = new();
        }

        private void OpenJobsPage(object sender, MouseEventArgs e) => throw new NotImplementedException();
        private void OpenMonitorPage(object sender, MouseEventArgs e) => throw new NotImplementedException();
        private void OpenProxiesPage(object sender, MouseEventArgs e) => throw new NotImplementedException();
        private void OpenWordlistsPage(object sender, MouseEventArgs e) => throw new NotImplementedException();
        private void OpenConfigsPage(object sender, MouseEventArgs e) => throw new NotImplementedException();
        private void OpenHitsPage(object sender, MouseEventArgs e) => throw new NotImplementedException();
        private void OpenPluginsPage(object sender, MouseEventArgs e) => throw new NotImplementedException();
        private void OpenSettingsPage(object sender, MouseEventArgs e) => throw new NotImplementedException();
        private void OpenAboutPage(object sender, MouseEventArgs e) => ChangePage(aboutPage, menuOptionAbout);

        private void ChangePage(Page newPage, Label newLabel)
        {
            currentPage = newPage;
            mainFrame.Content = newPage;

            // Update the selected menu item
            foreach (var child in topMenu.Children)
            {
                var label = child as Label;
                label.Foreground = Brushes.Get("ForegroundMain");
            }

            newLabel.Foreground = Brushes.Get("ForegroundMenuSelected");
        }
    }
}
