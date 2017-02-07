﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaoZouRiBao.Core.Model.ResultModel
{
    public class LatestOrHotComment
    {
        [JsonProperty(PropertyName = "data")]
        public Comment[] Comments { get; set; }

        [JsonProperty(PropertyName = "timestamp")]
        public string TimeStamp { get; set; }
    }
}
