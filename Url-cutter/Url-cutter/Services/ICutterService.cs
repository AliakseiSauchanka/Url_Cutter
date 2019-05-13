using System.Threading.Tasks;
using Url_cutter.Models.DataModels;
using System.Linq;

namespace Url_cutter.Services
{
    public interface ICutterService
    {
        Task<StoredUrl> GetById(int id);
        Task<int> Save(StoredUrl url);
        Task<int> Update(StoredUrl url);
        Task<int> Delete(StoredUrl url);
        Task<int> IncrementTransition(StoredUrl url);
        IQueryable<StoredUrl> GetAll();
    }
}
