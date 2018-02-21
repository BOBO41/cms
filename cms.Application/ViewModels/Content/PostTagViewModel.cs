using cms.Application.ViewModels.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace cms.Application.ViewModels.Content
{
    public class PostTagViewModel
    {
        public int PostID { set; get; }

        public string TagID { set; get; }

        public PostViewModel Post { set; get; }

        public TagViewModel Tag { set; get; }
    }
}
