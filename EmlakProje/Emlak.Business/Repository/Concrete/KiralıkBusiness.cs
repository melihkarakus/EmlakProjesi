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
    public class KiralıkBusiness : IDatabaseBusiness<Kiralık>
    {
        EmlakDbEntities Db = new EmlakDbEntities();
        public void Delete(Kiralık entity)
        {
            Db.Kiralık.Attach(entity);
            Db.Entry(entity).State = System.Data.Entity.EntityState.Deleted;
            Db.SaveChanges();
        }

        public void Delete(int id)
        {
            var kiralık = Get(id);
            Db.Kiralık.Attach(kiralık);
            Db.Entry(kiralık).State = System.Data.Entity.EntityState.Deleted;
            Db.SaveChanges();
        }

        public Kiralık Get(int id)
        {
            return Db.Kiralık.Find(id);
        }

        public Kiralık Get(Expression<Func<Kiralık, bool>> expression)
        {
            return Db.Kiralık.Where(expression).FirstOrDefault();
        }

        public List<Kiralık> GetAll()
        {
            return Db.Kiralık.ToList();
        }

        public List<Kiralık> GetAll(Expression<Func<Kiralık, bool>> expression)
        {
            return Db.Kiralık.Where(expression).ToList();
        }

        public void Insert(Kiralık entity)
        {
            Db.Kiralık.Add(entity);
            Db.SaveChanges();
        }

        public void Update(Kiralık entity)
        {
            Db.Kiralık.Attach(entity);
            Db.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            Db.SaveChanges();
        }
    }
}
