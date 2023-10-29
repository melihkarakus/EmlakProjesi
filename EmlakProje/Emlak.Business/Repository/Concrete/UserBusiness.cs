using Emlak.Business.Repository.Abstract;
using Emlak.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Emlak.Business.Repository.Concrete
{
    public class UserBusiness : IDatabaseBusiness<Users>
    {
        EmlakDbEntities Db = new EmlakDbEntities();


        public void Delete(Users entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Users Get(int id)
        {
            throw new NotImplementedException();
        }

        public Users Get(Expression<Func<Users, bool>> expression)
        {
            return Db.Users.Where(expression).FirstOrDefault();
        }

        public List<Users> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<Users> GetAll(Expression<Func<Users, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public void Insert(Users entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Users entity)
        {
            throw new NotImplementedException();
        }
    }
}
