using System.Threading.Tasks;
using PipServices3.Commons.Config;
using PipServices3.Commons.Data;
using PipServices3.Rpc.Clients;

namespace PipServices.Facets.Client.Version1
{
    public class FacetsHttpClientV1 : CommandableHttpClient, IFacetsClientV1
    {
        public FacetsHttpClientV1() : base("v1/facets") { }

        public FacetsHttpClientV1(object config) : base("v1/facets")
        {
            if (config != null)
                this.Configure(ConfigParams.FromValue(config));
        }

        public async Task<DataPage<FacetV1>> GetFacetsByGroupAsync(string correlationId, string group, PagingParams paging)
        {
            using (var timing = Instrument(correlationId))
            {
                return await CallCommandAsync<DataPage<FacetV1>>(
                    "get_facets_by_group",
                    correlationId,
                    new
                    {
                        group = group,
                        paging = paging
                    }
                    );
            }
        }

        public async Task<FacetV1> AddFacetAsync(string correlationId, string group, string name)
        {
            using (var timing = Instrument(correlationId))
            {
                return await CallCommandAsync<FacetV1>(
                    "add_facet",
                    correlationId,
                    new
                    {
                        group = group,
                        name = name
                    }
                    );
            }
        }

        public async Task<FacetV1> RemoveFacetAsync(string correlationId, string group, string name)
        {
            using (var timing = Instrument(correlationId))
            {
                return await CallCommandAsync<FacetV1>(
                    "remove_facet",
                    correlationId,
                    new
                    {
                        group = group,
                        name = name
                    }
                    );
            }
        }

        public async Task DeleteFacetsByGroupAsync(string correlationId, string group)
        {
            using (var timing = Instrument(correlationId))
            {
                await CallCommandAsync<Task>(
                    "delete_facets_by_group",
                    correlationId,
                    new
                    {
                        group = group
                    }
                    );
            }
        }

        public async Task ClearAsync(string correlationId)
        {
            using (var timing = Instrument(correlationId))
            {
                await CallCommandAsync<Task>(
                    "clear",
                    correlationId,
                    new { }
                    );
            }
        }
    }
}
