using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeaShopApi.BusinessLayer.Abstract;
using TeaShopApi.DataAccessLayer.Abstract;
using TeaShopApi.EntityLayer.Concrete;

namespace TeaShopApi.BusinessLayer.Concrete
{
    public class DrinkManager : IDrinkService
    {

        private readonly IDrinkDal _drinkDal;

        public DrinkManager(IDrinkDal drinkDal)
        {
            _drinkDal = drinkDal;
        }

        public void TDelete(Drink entity)
        {
            _drinkDal.Delete(entity);
        }

        public Drink TGetByID(int id)
        {
            return _drinkDal.GetByID(id);
        }

        public List<Drink> TGetListAll()
        {
            return _drinkDal.GetListAll();
        }

        public void TInsert(Drink entity)
        {
            _drinkDal.Insert(entity);
        }

        public void TUpdate(Drink entity)
        {
            _drinkDal.Update(entity);
        }
    }
}
