using System.Runtime.Serialization;

namespace Data
{
    [DataContract]
    public class Page
    {
        [DataMember]
        public string Content { get; set; }
    }
}