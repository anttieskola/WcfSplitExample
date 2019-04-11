using Data;
using System.Collections.Generic;
using System.ServiceModel;

namespace SplitService
{
    [ServiceKnownType(typeof(Book))]
    [ServiceKnownType(typeof(Page))]
    [ServiceContract]
    public interface IBookServiceTwo
    {
        [OperationContract]
        List<Book> GetAll();
    }
}