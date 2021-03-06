﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaoZouRiBao.Model.ResultModel
{
    /// <summary>
    /// 获取最新 | 最热评论返回值
    /// </summary>
    public class CommentResult
    {
        [JsonProperty(PropertyName = "data")]
        public Comment[] Comments { get; set; }

        [JsonProperty(PropertyName = "timestamp")]
        public string TimeStamp { get; set; }
    }
}
