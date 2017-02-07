﻿using BaoZouRiBao.Core.Enums;
using BaoZouRiBao.Core.Helper;
using BaoZouRiBao.Core.IncrementalCollection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaoZouRiBao.Core.ViewModel
{
    public class CommentPageViewModel : ViewModelBase
    {
        #region Properties
        public CommentCollection LatestComments { get; set; }

        public CommentCollection HotComments { get; set; }
       
        private bool isActive;
        public bool IsActive
        {
            get
            {
                return isActive;
            }
            set
            {
                isActive = value;
                OnPropertyChanged();
            }
        }
        #endregion

        #region Fields
        private string documentId;
        #endregion

        public void SetDocumentId(string documentId)
        {
            this.documentId = documentId;
        }

        public CommentPageViewModel()
        {
        } 

        private void OnDataLoadingEvent()
        {
            IsActive = true;
        }

        private void OnDataLoadedEvent()
        {
            IsActive = false;
        }

        public void GetLatestComments()
        {
            LatestComments = new CommentCollection(CommentTypeEnum.latest, documentId);
            LatestComments.OnDataLoadedEvent += OnDataLoadedEvent;
            LatestComments.OnDataLoadingEvent += OnDataLoadingEvent;
        }

        public void GetHotComments()
        {
            HotComments = new CommentCollection(CommentTypeEnum.hot, documentId);
            HotComments.OnDataLoadingEvent += OnDataLoadingEvent;
            HotComments.OnDataLoadedEvent += OnDataLoadedEvent;
        }

        public void RefreshLatestComments()
        {
            CommentCollection c = new CommentCollection(CommentTypeEnum.latest,documentId);
            LatestComments = c;
        }

        public void RefreshHotComments()
        {
            CommentCollection c = new CommentCollection(CommentTypeEnum.hot,documentId);
            HotComments = c;
        }
    }
}
