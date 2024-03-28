using MultiShop.Cargo.BusinessLayer.Abstract;
using MultiShop.Cargo.DataAccessLayer.Abstract;
using MultiShop.Cargo.EntityLayer.Concrete;

namespace MultiShop.Cargo.BusinessLayer.Concrete
{
    public class CargoOperationManager : ICargoOperationService
    {
        private readonly ICargoOperationDal _repository;

        public CargoOperationManager(ICargoOperationDal repository)
        {
            _repository = repository;
        }

        public void TDelete(int id)
        {
            _repository.Delete(id);
        }

        public List<CargoOperation> TGetAll()
        {
            return _repository.GetAll();
        }

        public CargoOperation TGetById(int id)
        {
            return _repository.GetById(id);
        }

        public void TInsert(CargoOperation entity)
        {
            _repository.Insert(entity);
        }

        public void TUpdate(CargoOperation entity)
        {
            _repository.Update(entity);
        }
    }
}
