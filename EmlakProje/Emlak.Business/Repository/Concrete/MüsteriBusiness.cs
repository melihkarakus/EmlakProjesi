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
    public class MüsteriBusiness : IDatabaseBusiness<Müsteri>
    {
        EmlakDbEntities Db = new EmlakDbEntities();
        public void Delete(Müsteri entity)
        {
            Db.Müsteri.Attach(entity);
            Db.Entry(entity).State = System.Data.Entity.EntityState.Deleted;
            Db.SaveChanges();
        }

        public void Delete(int id)
        {
            var müsteri = Get(id);
            Db.Müsteri.Attach(müsteri);
            Db.Entry(müsteri).State = System.Data.Entity.EntityState.Deleted;
            Db.SaveChanges();
        }

        public Müsteri Get(int id)
        {
            return Db.Müsteri.Find(id);
        }

        public Müsteri Get(Expression<Func<Müsteri, bool>> expression)
        {
            return Db.Müsteri.Where(expression).FirstOrDefault();
        }

        public List<Müsteri> GetAll()
        {
            return Db.Müsteri.ToList();
        }

        public List<Müsteri> GetAll(Expression<Func<Müsteri, bool>> expression)
        {
            return Db.Müsteri.Where(expression).ToList();
        }

        public void Insert(Müsteri entity)
        {
            Db.Müsteri.Add(entity);
            Db.SaveChanges();
        }

        public void Update(Müsteri entity)
        {
            Db.Müsteri.Attach(entity);
            Db.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            Db.SaveChanges();
        }
    }
}
