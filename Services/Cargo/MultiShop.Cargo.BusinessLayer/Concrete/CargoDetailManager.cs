using MultiShop.Cargo.BusinessLayer.Abstract;
using MultiShop.Cargo.DataAccessLayer.Abstract;
using MultiShop.Cargo.EntityLayer.Concrete;

namespace MultiShop.Cargo.BusinessLayer.Concrete
{
    public class CargoDetailManager : ICargoDetailService
    {
        private readonly ICargoDetailDal _repository;

        public CargoDetailManager(ICargoDetailDal repository)
        {
            _repository = repository;
        }

        public void TDelete(int id)
        {
            _repository.Delete(id);
        }

        public List<CargoDetail> TGetAll()
        {
            return _repository.GetAll();
        }

        public CargoDetail TGetById(int id)
        {
            return _repository.GetById(id);
        }

        public void TInsert(CargoDetail entity)
        {
            _repository.Insert(entity);
        }

        public void TUpdate(CargoDetail entity)
        {
            _repository.Update(entity);
        }
    }
}
