﻿using BaoZouRiBao.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace BaoZouRiBao.Views
{
    public sealed partial class RankPage : Page
    {
        public RankPage()
        {
            this.InitializeComponent();

            MasterDetailPage.Current.AdaptiveVisualStateChanged += Current_AdaptiveVisualStateChanged;
        }

        private void Current_AdaptiveVisualStateChanged(object sender, VisualStateChangedEventArgs e)
        {
            switch (e.NewState.Name)
            {
                case "Narrow":
                    splitViewButton.Visibility = Visibility.Visible;
                    pageTitleTextBlock.Margin = (Thickness)(Application.Current.Resources["NarrowPageTitleMargin"]);
                    break;
                case "Wide":
                    splitViewButton.Visibility = Visibility.Collapsed;
                    pageTitleTextBlock.Margin = (Thickness)(Application.Current.Resources["WidePageTitleMargin"]);
                    break;
            }
        }

        private bool isRankTimeChanged = false;

        private bool isReadLoaded = false;
        private bool isVoteLoaded = false;
        private bool isCommentLoaded = false;


        private async void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (pivot == null) return;
            isRankTimeChanged = true;
            switch (pivot.SelectedIndex)
            {
                case 0:
                    await ViewModel.RefreshReadCollectionAsync(comboBox.SelectedIndex);
                    break;
                case 1:
                    await ViewModel.RefreshVoteCollectionAsync(comboBox.SelectedIndex);
                    break;
                case 2:
                    await ViewModel.RefreshCommentCollectionAsync(comboBox.SelectedIndex);
                    break;
            }
        }

        private async void pivot_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (pivot.SelectedIndex)
            {
                case 0:
                    if (!isReadLoaded || isRankTimeChanged)
                    { 
                        await ViewModel.RefreshReadCollectionAsync(comboBox.SelectedIndex);
                        isReadLoaded = true;
                    }
                    break;
                case 1:
                    if(!isVoteLoaded || isRankTimeChanged)
                    { 
                        await ViewModel.RefreshVoteCollectionAsync((comboBox.SelectedIndex));
                        isVoteLoaded = true;
                    }
                    break;
                case 2:
                    if(!isCommentLoaded || isRankTimeChanged)
                    { 
                        await ViewModel.RefreshCommentCollectionAsync((comboBox.SelectedIndex));
                        isCommentLoaded = true;
                    }
                    break;
            }
        }
    }
}
