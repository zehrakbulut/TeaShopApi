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
    public class QuestionManager : IQuestionService
    {

        private readonly IQuestionDal _questionDal;

        public QuestionManager(IQuestionDal questionDal)
        {
            _questionDal = questionDal;
        }

        public void TDelete(Question entity)
        {
           _questionDal.Delete(entity);
        }

        public Question TGetByID(int id)
        {
            return _questionDal.GetByID(id);
        }

        public List<Question> TGetListAll()
        {
            return _questionDal.GetListAll();
        }

        public void TInsert(Question entity)
        {
            _questionDal.Insert(entity);
        }

        public void TUpdate(Question entity)
        {
            _questionDal.Update(entity);
        }
    }
}
