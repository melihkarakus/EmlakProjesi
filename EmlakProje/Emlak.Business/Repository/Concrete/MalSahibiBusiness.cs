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
    public class MalSahibiBusiness : IDatabaseBusiness<MalSahibi>
    {
        EmlakDbEntities Db = new EmlakDbEntities();
        public void Delete(MalSahibi entity)
        {
            Db.MalSahibi.Attach(entity);
            Db.Entry(entity).State = System.Data.Entity.EntityState.Deleted;
            Db.SaveChanges();
        }

        public void Delete(int id)
        {
            var malsahibi = Get(id);
            Db.MalSahibi.Attach(malsahibi);
            Db.Entry(malsahibi).State = System.Data.Entity.EntityState.Deleted;
            Db.SaveChanges();
        }

        public MalSahibi Get(int id)
        {
            return Db.MalSahibi.Find(id);
        }

        public MalSahibi Get(Expression<Func<MalSahibi, bool>> expression)
        {
            return Db.MalSahibi.Where(expression).FirstOrDefault();
        }

        public List<MalSahibi> GetAll()
        {
            return Db.MalSahibi.ToList();
        }

        public List<MalSahibi> GetAll(Expression<Func<MalSahibi, bool>> expression)
        {
            return Db.MalSahibi.Where(expression).ToList();
        }

        public void Insert(MalSahibi entity)
        {
            Db.MalSahibi.Add(entity);
            Db.SaveChanges();
        }

        public void Update(MalSahibi entity)
        {
            Db.MalSahibi.Attach(entity);
            Db.Entry(entity).State=System.Data.Entity.EntityState.Modified;
            Db.SaveChanges();
        }
    }
}
