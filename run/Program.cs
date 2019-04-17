using PipServices.Facets.Client.Version1;
using PipServices3.Commons.Config;
using System;

namespace run
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var correlationId = "123";
                var config = ConfigParams.FromTuples(
                    "connection.type", "http",
                    "connection.host", "localhost",
                    "connection.port", 8080
                );
                var client = new FacetsHttpClientV1();
                client.Configure(config);
                client.OpenAsync(correlationId);
                var facet = client.AddFacetAsync(null, "test", "group1");
                var page = client.GetFacetsByGroupAsync(null, "test", null);
                Console.WriteLine("Get facets by group!");

                Console.WriteLine("Press ENTER to exit...");
                Console.ReadLine();

                client.CloseAsync(string.Empty);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
