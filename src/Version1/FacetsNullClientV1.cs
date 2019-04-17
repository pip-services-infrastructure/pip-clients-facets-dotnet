using System.Threading.Tasks;
using PipServices3.Commons.Data;

namespace PipServices.Facets.Client.Version1
{
    public class FacetsNullClientV1 : IFacetsClientV1
    {
        public async Task<DataPage<FacetV1>> GetFacetsByGroupAsync(string correlationId, string group, PagingParams paging)
        {
            return await Task.FromResult(new DataPage<FacetV1>());
        }

        public async Task<FacetV1> AddFacetAsync(string correlationId, string group, string name)
        {
            return await Task.FromResult(new FacetV1());
        }

        public async Task<FacetV1> RemoveFacetAsync(string correlationId, string group, string name)
        {
            return await Task.FromResult(new FacetV1());
        }

        public async Task DeleteFacetsByGroupAsync(string correlationId, string group)
        {
            await Task.Delay(0);
        }

        public async Task ClearAsync(string correlationId)
        {
            await Task.Delay(0);
        }
    }
}
