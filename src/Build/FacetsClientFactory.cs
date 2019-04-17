using PipServices.Facets.Client.Version1;
using PipServices3.Commons.Refer;
using PipServices3.Components.Build;

namespace PipServices.Facets.Client.Build
{
    public class FacetsClientFactory : Factory
    {
        public static Descriptor Descriptor = new Descriptor("pip-services-facets", "factory", "default", "default", "1.0");
        public static Descriptor NullClientDescriptor = new Descriptor("pip-services-facets", "client", "null", "*", "1.0");
        public static Descriptor HttpClientDescriptor = new Descriptor("pip-services-facets", "client", "http", "*", "1.0");

        public FacetsClientFactory()
        {
            RegisterAsType(NullClientDescriptor, typeof(FacetsNullClientV1));
            RegisterAsType(HttpClientDescriptor, typeof(FacetsHttpClientV1));
        }
    }
}
