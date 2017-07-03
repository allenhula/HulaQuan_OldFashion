using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HulaQuan_OldFashion.Models
{
    public class HulaViewModels
    {
        public string UserName { get; set; }

        public string UserPicture { get; set; }

        public string Content { get; set; }

        public List<ImageViewModels> Images { get; set; }


    }

    public class ImageViewModels
    {
        public string Original { get; set; }
        public string Thumpnail { get; set; }
    }
}