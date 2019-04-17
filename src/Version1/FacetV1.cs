using System.Runtime.Serialization;

namespace PipServices.Facets.Client.Version1
{
    [DataContract]
    public class FacetV1
    {
        public FacetV1() { }

        public FacetV1(string group, string name, int count)
        {
            Group = group;
            Name = name;
            Count = count;
        }

        [DataMember(Name = "group")]
        public string Group { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "count")]
        public int Count { get; set; }
    }
}
