﻿using BaoZouRiBao.Core.Helper;
using BaoZouRiBao.Core.Http;
using BaoZouRiBao.Core.IncrementalCollection;
using BaoZouRiBao.Core.IncrementalLoadingCollection;
using BaoZouRiBao.Core.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaoZouRiBao.Core.ViewModel
{
    public class ChannelViewModel : ViewModelBase
    {
        public int TotalPages { get; set; } = -1;
         
        public IncrementalLoadingList<Channel> Channels { get; set; }
        
        public ChannelViewModel()
        {
            Channels = new IncrementalLoadingList<Channel>(GetChannel);
        }
 
        private async Task<IEnumerable<Channel>> GetChannel(uint count,int pageIndex)
        {
            List<Channel> channels = new List<Channel>(); 
            if (TotalPages > 0 && pageIndex > TotalPages)
            {
                Channels.NoMore();
                return channels;
            }
            var result = await ApiService.Instance.GetChannels(pageIndex++);
            
            if (result != null && result.Channels != null)
            {
                TotalPages = result.TotalPages;
                return result.Channels;
            }
            return channels;
        }
    }
}
