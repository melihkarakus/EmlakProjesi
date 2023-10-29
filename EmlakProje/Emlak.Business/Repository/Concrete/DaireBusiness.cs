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
    public class DaireBusiness : IDatabaseBusiness<Daire>
    {
        EmlakDbEntities Db1 = new EmlakDbEntities();
        public void Delete(Daire entity)
        {
            Db1.Daire.Attach(entity);
            Db1.Entry(entity).State = System.Data.Entity.EntityState.Deleted;
            Db1.SaveChanges();
        }

        public void Delete(int id)
        {
            var daire = Get(id);
            Db1.Daire.Attach(daire);
            Db1.Entry(daire).State = System.Data.Entity.EntityState.Deleted;
            Db1.SaveChanges();
        }

        public Daire Get(int id)
        {
            return Db1.Daire.Find(id);
        }

        public Daire Get(Expression<Func<Daire, bool>> expression)
        {
            return Db1.Daire.Where(expression).FirstOrDefault();
        }

        public List<Daire> GetAll()
        {
            return Db1.Daire.ToList();
        }

        public List<Daire> GetAll(Expression<Func<Daire, bool>> expression)
        {
            return Db1.Daire.Where(expression).ToList();
        }

        public void Insert(Daire entity)
        {
            Db1.Daire.Add(entity);
            Db1.SaveChanges();
        }

        public void Update(Daire entity)
        {
            Db1.Daire.Attach(entity);
            Db1.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            Db1.SaveChanges();
        }
    }
}
