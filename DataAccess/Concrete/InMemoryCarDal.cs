using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {

            _cars = new List<Car>
            {
                new Car{ID=1,BrandID=5,ColorID=1,DailyPrice=700,Description="1990 Model Araç",ModelYear=1990},
                new Car{ID=2,BrandID=4,ColorID=3,DailyPrice=300,Description="2000 Model Araç",ModelYear=2000},
                new Car{ID=3,BrandID=3,ColorID=4,DailyPrice=400,Description="2013 Model Araç",ModelYear=2013},
                new Car{ID=4,BrandID=2,ColorID=2,DailyPrice=600,Description="2016 Model Araç",ModelYear=2016},
                new Car{ID=5,BrandID=1,ColorID=5,DailyPrice=800,Description="2021 Model Araç",ModelYear=2021},
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {

            Car carToDelete = _cars.SingleOrDefault(p => p.ID == car.ID);

            _cars.Remove(carToDelete);
        }


        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAllByCategory(int categoryId)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int brandId)
        {
            return _cars.Where(c => c.BrandID == brandId).ToList();
        }
        public List<Car> GetByID()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.ID == car.ID);
            carToUpdate.ID = car.ID;
            carToUpdate.BrandID = car.ModelYear;
            carToUpdate.ColorID = car.ColorID;
            carToUpdate.BrandID = car.BrandID;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description; ;
        }
    }
}
