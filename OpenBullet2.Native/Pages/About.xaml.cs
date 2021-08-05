﻿using OpenBullet2.Native.Helpers;
using System.Windows;
using System.Windows.Controls;

namespace OpenBullet2.Native.Pages
{
    /// <summary>
    /// Interaction logic for About.xaml
    /// </summary>
    public partial class About : Page
    {
        public About()
        {
            InitializeComponent();
        }

        private void OpenDonation(object sender, RoutedEventArgs e) => Url.Open("https://en.cryptobadges.io/donate/39yMkox6pP8tnSC7rZ5EM4nUUHgPbg1fKM");

        private void OpenRepository(object sender, RoutedEventArgs e) => Url.Open("https://github.com/openbullet/OpenBullet2");

        private void OpenForum(object sender, RoutedEventArgs e) => Url.Open("https://discourse.openbullet.dev/");

        private void OpenIssues(object sender, RoutedEventArgs e) => Url.Open("https://github.com/openbullet/OpenBullet2/issues");
    }
}
