using PipServices3.Commons.Data;
using System.Threading.Tasks;

namespace PipServices.Facets.Client.Version1
{
    public interface IFacetsClientV1
    {
        Task<DataPage<FacetV1>> GetFacetsByGroupAsync(string correlationId, string group, PagingParams paging);
        Task<FacetV1> AddFacetAsync(string correlationId, string group, string name);
        Task<FacetV1> RemoveFacetAsync(string correlationId, string group, string name);
        Task DeleteFacetsByGroupAsync(string correlationId, string group);
        Task ClearAsync(string correlationId);
    }
}
