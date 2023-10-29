using Emlak.Business.Repository.Concrete;
using Emlak.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Emlak.Service
{

    public class EmlakService : IEmlakService
    {
        UserBusiness userBusiness = new UserBusiness();
        MüsteriBusiness müsteriBusiness = new MüsteriBusiness();
        DaireBusiness daireBusiness = new DaireBusiness();
        OdaBusiness odaBusiness = new OdaBusiness();
        MalSahibiBusiness malSahibiBusiness = new MalSahibiBusiness();
        KiralıkBusiness kiralıkBusiness = new KiralıkBusiness();
        SatılıkBusiness satılıkBusiness = new SatılıkBusiness();

        public void AddDaire(Daire daire)
        {
            daireBusiness.Insert(daire);
        }

        public void AddMalSahibi(MalSahibi malSahibi)
        {
            malSahibiBusiness.Insert(malSahibi);
        }
        public void AddMüsteri(Müsteri müsteri)
        {
            müsteriBusiness.Insert(müsteri);
        }

        public void AddOda(Odalar odalar)
        {
            odaBusiness.Insert(odalar);
        }

        public void EditDaire(Daire daire)
        {
            daireBusiness.Update(daire);
        }

        public void EditKiralık(Kiralık kiralık)
        {
            kiralıkBusiness.Update(kiralık);
        }

        public void EditMalSahibi(MalSahibi malSahibi)
        {
            malSahibiBusiness.Update(malSahibi);
        }

        public void EditMüsteri(Müsteri müsteri)
        {
            müsteriBusiness.Update(müsteri);
        }

        public void EditOda(Odalar odalar)
        {
            odaBusiness.Update(odalar);
        }

        public List<Daire> GetDaires()
        {
            return daireBusiness.GetAll();
        }
        public List<MalSahibi> GetMalSahibis()
        {
            return malSahibiBusiness.GetAll();
        }

        public List<Müsteri> GetMüsteris()
        {
            return müsteriBusiness.GetAll();
        }

        public List<Odalar> GetOdalars()
        {
            return odaBusiness.GetAll();
        }

        public Users GetUsers(string username, string password)
        {   
            return userBusiness.Get(u => u.UserName == username && u.Password == password);
        }

        public void RemoveDaire(int id)
        {
            daireBusiness.Delete(id);
        }

        public void RemoveKiralık(int id)
        {
            kiralıkBusiness.Delete(id);
        }

        public void RemoveMalSahibi(int id)
        {
            malSahibiBusiness.Delete(id);
        }

        public void RemoveMüsteri(int id)
        {
            müsteriBusiness.Delete(id);
        }

        public void RemoveOda(Odalar odalar)
        {
            odaBusiness.Delete(odalar);
        }
        public List<Kiralık> GetKiralıks()
        {
            return kiralıkBusiness.GetAll();
        }

        public void AddKiralık(Kiralık kiralık)
        {
            kiralıkBusiness.Insert(kiralık);
        }

        public List<Satılık> GetSatılıks()
        {
            return satılıkBusiness.GetAll();
        }

        public void AddSatılık(Satılık satılık)
        {
            satılıkBusiness.Insert(satılık);
        }

        public void RemoveSatılık(int id)
        {
            satılıkBusiness.Delete(id);
        }

        public void EditSatılık(Satılık satılık)
        {
            satılıkBusiness.Update(satılık);
        }
    }
}
