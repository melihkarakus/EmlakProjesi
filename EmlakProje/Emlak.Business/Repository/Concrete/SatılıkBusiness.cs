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
    public class SatılıkBusiness : IDatabaseBusiness<Satılık>
    {
        EmlakDbEntities Db = new EmlakDbEntities();
        public void Delete(Satılık entity)
        {
            Db.Satılık.Attach(entity);
            Db.Entry(entity).State = System.Data.Entity.EntityState.Deleted;
            Db.SaveChanges();
        }

        public void Delete(int id)
        {
            var satılık = Get(id);
            Db.Satılık.Attach(satılık);
            Db.Entry(satılık).State = System.Data.Entity.EntityState.Deleted;
            Db.SaveChanges();
        }

        public Satılık Get(int id)
        {
            return Db.Satılık.Find(id);
        }

        public Satılık Get(Expression<Func<Satılık, bool>> expression)
        {
            return Db.Satılık.Where(expression).FirstOrDefault();
        }

        public List<Satılık> GetAll()
        {
            return Db.Satılık.ToList();
        }

        public List<Satılık> GetAll(Expression<Func<Satılık, bool>> expression)
        {
            return Db.Satılık.Where(expression).ToList();
        }

        public void Insert(Satılık entity)
        {
            Db.Satılık.Add(entity);
            Db.SaveChanges();
        }

        public void Update(Satılık entity)
        {
            Db.Satılık.Attach(entity);
            Db.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            Db.SaveChanges();
        }
    }
}
