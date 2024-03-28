using MultiShop.Cargo.BusinessLayer.Abstract;
using MultiShop.Cargo.DataAccessLayer.Abstract;
using MultiShop.Cargo.EntityLayer.Concrete;

namespace MultiShop.Cargo.BusinessLayer.Concrete
{
    public class CargoCompanyManager : ICargoCompanyService
    {
        private readonly ICargoCompanyDal _repository;

        public CargoCompanyManager(ICargoCompanyDal repository)
        {
            _repository = repository;
        }

        public void TDelete(int id)
        {
            _repository.Delete(id);
        }

        public List<CargoCompany> TGetAll()
        {
            return _repository.GetAll();
        }

        public CargoCompany TGetById(int id)
        {
            return _repository.GetById(id);
        }

        public void TInsert(CargoCompany entity)
        {
            _repository.Insert(entity);
        }

        public void TUpdate(CargoCompany entity)
        {
            _repository.Update(entity);
        }
    }
}
