using LIKHAB.Common;
using System.Collections.Generic;

namespace LIKHAB.BusinessLogic.Interface
{
    public interface IViewModelRepository<T> where T : IId
    {
        List<T> GetList(int Id = 0);

        OperationResult Add(T item);

        OperationResult Update(T item);

        OperationResult Remove(int Id);
    }
}