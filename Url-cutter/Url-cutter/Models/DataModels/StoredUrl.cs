using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Url_cutter.Models.DataModels
{
    public class StoredUrl
    {
        public int Id { get; set; }
        public string BaseUrl { get; set; }
        public string ShortUrl { get; set; }
        public DateTime CreationDate { get; set; }
        public int Transition { get; set; }
    }
}
