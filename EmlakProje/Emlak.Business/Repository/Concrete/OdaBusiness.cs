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
    public class OdaBusiness : IDatabaseBusiness<Odalar>
    {
        EmlakDbEntities Db2 = new EmlakDbEntities();
        public void Delete(Odalar entity)
        {
            Db2.Odalar.Attach(entity);
            Db2.Entry(entity).State = System.Data.Entity.EntityState.Deleted;
            Db2.SaveChanges();
        }

        public void Delete(int id)
        {
            var odalar = Get(id);
            Db2.Odalar.Attach(odalar);
            Db2.Entry(odalar).State = System.Data.Entity.EntityState.Deleted;
            Db2.SaveChanges();
        }

        public Odalar Get(int id)
        {
            return Db2.Odalar.Find(id);
        }

        public Odalar Get(Expression<Func<Odalar, bool>> expression)
        {
            return Db2.Odalar.Where(expression).FirstOrDefault();
        }

        public List<Odalar> GetAll()
        {
            return Db2.Odalar.ToList();
        }

        public List<Odalar> GetAll(Expression<Func<Odalar, bool>> expression)
        {
            return Db2.Odalar.Where(expression).ToList();
        }

        public void Insert(Odalar entity)
        {
            Db2.Odalar.Add(entity);
            Db2.SaveChanges();
        }

        public void Update(Odalar entity)
        {
            Db2.Odalar.Attach(entity);
            Db2.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            Db2.SaveChanges();
        }
    }
}
