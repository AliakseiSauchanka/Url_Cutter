using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Url_cutter.Data;
using Url_cutter.Models.DataModels;

namespace Url_cutter.Services
{
    public class CutterService : ICutterService
    {
        private readonly UrlCutterContextDB context;

        public CutterService(UrlCutterContextDB context)
        {
            this.context = context;
        }

        public Task<int> Delete(StoredUrl url)
        {
            context.StoredUrls.Remove(url);
            var result = context.SaveChangesAsync();
            return result;
        }

        public IQueryable<StoredUrl> GetAll()
        {
            var allURLs = context.StoredUrls;
            return allURLs;
        }

        public Task<StoredUrl> GetById(int id)
        {
            var url = context.StoredUrls.FirstOrDefaultAsync(s => s.Id == id);
            return url;
        }

        public Task<int> Save(StoredUrl url)
        {
            context.StoredUrls.AddAsync(url);
            var result = context.SaveChangesAsync();
            return result;
        }

        public Task<int> Update(StoredUrl url)
        {
            context.StoredUrls.Update(url);
            var result = context.SaveChangesAsync();
            return result;
        }

        public Task<int> IncrementTransition(StoredUrl url)
        {
            url.Transition++;
            var result = context.SaveChangesAsync();
            return result;
        }
    }
}
