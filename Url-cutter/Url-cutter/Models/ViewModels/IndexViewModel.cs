using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Url_cutter.Models.DataModels;

namespace Url_cutter.Models.ViewModels
{
    public class IndexViewModel
    {
        public List<StoredUrl> StoredUrls { get; set; }
        public StoredUrl ToCutUrl { get; set; }
    }
}
