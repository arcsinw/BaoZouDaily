﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaoZouRiBao.Http
{
    public class ServiceUri
    {
        #region Need Authentication
        public const string OAuth2 = "http://api.ibaozou.com/oauth2/server/accesstoken";

        public const string AccessToken = "https://api.weibo.com/oauth2/access_token";

        public const string Login = "http://dailyapi.ibaozou.com/api/v31/user/login";

        /// <summary>
        /// 注销
        /// Post 
        /// </summary>
        public const string LogOut = "http://dailyapi.ibaozou.com/api/v31/user/logout";

        public const string TaskInfo = "http://dailyapi.ibaozou.com/api/v31/task/info";

        /// <summary>
        /// 消息数量
        /// </summary>
        public const string MessagesCount = "http://dailyapi.ibaozou.com/api/v31/messages/count";

        public const string TokenInfo = "http://dailyapi.ibaozou.com/api/v31/user/token_info";

        /// <summary>
        /// 用户头像
        /// </summary>
        public const string UserAvatar = "http://dailyapi.ibaozou.com/api/v1/user/avatar";

        /// <summary>
        /// 我的coin
        /// {0} AccessToken
        /// </summary>
        public const string MyCoins = "http://dailyapi.ibaozou.com/coin?token={0}";

        /// <summary>
        /// 我的收藏
        /// </summary>
        public const string MyFavorite = "http://dailyapi.ibaozou.com/api/v31/documents/favorites?timestamp={0}&";

        /// <summary>
        /// 我的评论
        /// </summary>
        public const string MyComment = "http://dailyapi.ibaozou.com/api/v31/comments/my?timestamp={0}&";

        /// <summary>
        /// 阅读历史
        /// </summary>
        public const string MyReadHistory = "http://dailyapi.ibaozou.com/api/v31/documents/read?timestamp={0}&";

        /// <summary>
        /// 我的投稿
        /// </summary>
        public const string MyContribute = "http://dailyapi.ibaozou.com/api/v31/documents/my_contribute?timestamp={0}&";

        /// <summary>
        /// 清除浏览历史记录
        /// </summary>
        public const string ClearReadHistory = "http://dailyapi.ibaozou.com/api/v31/documents/read/clear";

        /// <summary>
        /// 评论 的消息
        /// </summary>
        public const string CommentMessage = "http://dailyapi.ibaozou.com/api/v31/messages/comment_messages?timestamp={0}&";

        /// <summary>
        /// 赞 的消息
        /// </summary>
        public const string CommentVoteMessage = "http://dailyapi.ibaozou.com/api/v31/messages/comment_vote_messages?timestamp={0}&";

        /// <summary>
        /// 通知 的消息
        /// </summary>
        public const string AdminMessage = "http://dailyapi.ibaozou.com/api/v31/messages/admin_messages?timestamp={0}&";
         
        /// <summary>
        /// Like a comment
        /// {0} comment id 3325434
        /// </summary>
        public const string LikeComment = "http://dailyapi.ibaozou.com/api/v31/comments/{0}/like";

        /// <summary>
        /// 在文章下回复一个评论
        /// Post
        /// {"content":"x","parent_id":"3484432"}
        /// </summary>
        public const string replyComment = "http://dailyapi.ibaozou.com/api/v31/documents/{0}/comments";

        /// <summary>
        /// 用户投稿
        /// </summary>
        public const string UserContribute = "http://dailyapi.ibaozou.com/api/v31/documents/user_contribute";

        /// <summary>
        /// 上传头像
        /// </summary>
        public const string UploadAvatar = "http://dailyapi.ibaozou.com/api/v1/user/avatar";

        /// <summary>
        /// 举报评论
        /// {0} 举报的评论id
        /// </summary>
        public const string ReportComment = "http://dailyapi.ibaozou.com/api/v31/comments/{0}/report";
        #endregion

        /// <summary>
        /// 新闻列表
        /// </summary>
        public const string LatestDocument = "http://dailyapi.ibaozou.com/api/v31/documents/latest?timestamp={0}";

        /// <summary>
        /// 查看新闻
        /// </summary>
        public const string Document = "http://dailyapi.ibaozou.com/api/v31/documents/{0}";

        /// <summary>
        /// 新闻的额外信息 （点赞，评论数量，HackJs）
        /// </summary>
        public const string DocumentExtra = "http://dailyapi.ibaozou.com/api/v31/documents/{0}/extra";

        /// <summary>
        /// 相关新闻
        /// </summary>
        public const string DocumentRelated = "http://dailyapi.ibaozou.com/api/v31/documents/{0}/related";

        /// <summary>
        /// Hot or latest comments in documents  GET
        /// Write a comment to a document           POST   (postData  : {"content" : "吐槽"}
        /// </summary>
        public const string DocumentComments = "http://dailyapi.ibaozou.com/api/v31/documents/{0}/comments";

        /// <summary>
        /// {0} documentId
        /// {1} type hot latest
        /// {2} timestamp
        /// </summary>
        public const string LatestOrHotComment = "http://dailyapi.ibaozou.com/api/v31/documents/{0}/comments/{1}?timestamp={2}&";
        
        /// <summary>
        /// 投稿列表
        /// </summary>
        public const string LatestContribute = "http://dailyapi.ibaozou.com/api/v31/documents/contributes/latest?timestamp={0}";

        /// <summary>
        /// 视频列表
        /// </summary>
        public const string LatestVideo = "http://dailyapi.ibaozou.com/api/v31/documents/videos/latest?timestamp={0}";
         
        /// <summary>
        /// {0} read vote comment
        /// {1} day week month
        /// </summary>
        public const string Rank = "http://dailyapi.ibaozou.com/api/v31/rank/{0}/{1}";
         
        /// <summary>
        /// 频道
        /// </summary>
        public const string Channels = "http://dailyapi.ibaozou.com/api/v31/channels/index?page={0}&per_page={1}&";

        /// <summary>
        /// 频道里的内容
        /// </summary>
        public const string ContributeInChannel = "http://dailyapi.ibaozou.com/api/v31/channels/{0}?timestamp={1}&";

        /// <summary>
        /// 任务完成
        /// </summary>
        public const string TaskDone = "http://dailyapi.ibaozou.com/api/v31/task/done";

        /// <summary>
        /// 点赞文章
        /// </summary>
        public const string Favorite  = "http://dailyapi.ibaozou.com/api/v31/documents/{0}/favorite";

        /// <summary>
        /// 搜索
        /// </summary>
        public const string Search = "http://dailyapi.ibaozou.com/api/v31/documents/search";

        /// <summary>
        /// 给新闻点赞
        /// </summary>
        public const string Vote = "http://dailyapi.ibaozou.com/api/v31/documents/{0}/vote";
        
        /// <summary>
        /// 问答
        /// </summary>
        public const string FAQ = "http://dailyapi.ibaozou.com/faq?category_id=1";

        /// <summary>
        /// 离线下载新闻
        /// </summary>
        public const string DocumentOfflineDownload = "http://dailyapi.ibaozou.com/api/v31/documents/android_offline_download";
    }
}
