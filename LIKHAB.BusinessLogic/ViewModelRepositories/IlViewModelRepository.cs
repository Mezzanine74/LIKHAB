using LIKHAB._GenericRepository;
using LIKHAB.BusinessLogic.Interface;
using LIKHAB.Common;
using LIKHAB.DataLayer.DBContext;
using LIKHAB.DataLayer.Models;
using LIKHAB.ViewModels;
using System.Collections.Generic;

namespace LIKHAB.BusinessLogic.ViewModelRepositories
{
    public class IlViewModelRepository : IViewModelRepository<IlViewModel>
    {
        private LIKHAB.DataLayer.DBContext.LikhabDBContext _db = new LikhabDBContext();

        private GenericRepository<Ili, Log> _repository;

        public IlViewModelRepository()
        {
            _repository = new GenericRepository<Ili, Log>(_db);
        }

        public OperationResult Add(IlViewModel item)
        {
            var model = new Ili()
            {
                Il = item.Il,
                IlKatsayisi = item.IlKatsayisi,
            };

            var validation = model.Validate();

            if (validation.Success)
            {
                return _repository.Add(model);
            }

            return validation;
        }

        public List<IlViewModel> GetList(int Id = 0)
        {
            throw new System.NotImplementedException();
        }

        public OperationResult Remove(int Id)
        {
            throw new System.NotImplementedException();
        }

        public OperationResult Update(IlViewModel item)
        {
            throw new System.NotImplementedException();
        }
    }
}