using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Data
{
    [DataContract]
    public class Book
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public List<Page> Pages { get; set; }
    }
}