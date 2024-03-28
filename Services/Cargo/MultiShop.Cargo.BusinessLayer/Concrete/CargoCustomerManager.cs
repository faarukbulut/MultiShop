using MultiShop.Cargo.BusinessLayer.Abstract;
using MultiShop.Cargo.DataAccessLayer.Abstract;
using MultiShop.Cargo.EntityLayer.Concrete;

namespace MultiShop.Cargo.BusinessLayer.Concrete
{
    public class CargoCustomerManager : ICargoCustomerService
    {
        private readonly ICargoCustomerDal _repository;

        public CargoCustomerManager(ICargoCustomerDal repository)
        {
            _repository = repository;
        }

        public void TDelete(int id)
        {
            _repository.Delete(id);
        }

        public List<CargoCustomer> TGetAll()
        {
            return _repository.GetAll();
        }

        public CargoCustomer TGetById(int id)
        {
            return _repository.GetById(id);
        }

        public void TInsert(CargoCustomer entity)
        {
            _repository.Insert(entity);
        }

        public void TUpdate(CargoCustomer entity)
        {
            _repository.Update(entity);
        }
    }
}
