﻿using BaoZouRiBao.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaoZouRiBao.Helper
{
    public class NavigationHelper
    {
        public static void MasterFrameNavigate(Type sourcePage,object parameter)
        {
            MasterDetailPage.Current.MasterFrame.Navigate(sourcePage,parameter);
        }

        public static void MasterFrameNavigate(Type sourcePage)
        {
            MasterDetailPage.Current.MasterFrame.Navigate(sourcePage);
        }

        public static void DetailFrameNavigate(Type sourcePage)
        {
            MasterDetailPage.Current.DetailFrame.Navigate(sourcePage);
        }

        public static void DetailFrameNavigate(Type sourcePage,object parameter)
        {
            while (MasterDetailPage.Current.DetailFrame.BackStackDepth > 1)
            {
                MasterDetailPage.Current.DetailFrame.BackStack.RemoveAt(0);
            }

            MasterDetailPage.Current.DetailFrame.Navigate(sourcePage,parameter);
        }

        /// <summary>
        /// 返回
        /// </summary>
        public static void GoBack()
        {
            if (MasterDetailPage.Current.DetailFrame.CanGoBack)
            {
                MasterDetailPage.Current.DetailFrame.GoBack();
            }
            else if (MasterDetailPage.Current.MasterFrame.CanGoBack)
            {
                MasterDetailPage.Current.MasterFrame.GoBack();
            }
            else
            {
                App.Current.Exit();
            }
        }
    }
}
