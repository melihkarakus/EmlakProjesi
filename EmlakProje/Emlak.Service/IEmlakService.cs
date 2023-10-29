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
    
    [ServiceContract]
    public interface IEmlakService
    {
        [OperationContract]
        Users GetUsers(string username, string password);
        [OperationContract]
        List<Müsteri> GetMüsteris();
        [OperationContract]
        List<Daire> GetDaires();
        [OperationContract]
        List<Odalar> GetOdalars();
        [OperationContract]
        void AddMüsteri(Müsteri müsteri);
        [OperationContract]
        void RemoveMüsteri(int id);
        [OperationContract]
        void EditMüsteri(Müsteri müsteri);
        [OperationContract]
        void AddOda(Odalar odalar);
        [OperationContract]
        void RemoveOda(Odalar odalar);
        [OperationContract]
        void EditOda(Odalar odalar);
        [OperationContract]
        void AddDaire(Daire daire);
        [OperationContract]
        void RemoveDaire(int id);
        [OperationContract]
        void EditDaire(Daire daire);
        [OperationContract]
        List<MalSahibi> GetMalSahibis();
        [OperationContract]
        void AddMalSahibi(MalSahibi malSahibi);
        [OperationContract]
        void RemoveMalSahibi(int id);
        [OperationContract]
        void EditMalSahibi(MalSahibi malSahibi);
        [OperationContract]
        List<Kiralık> GetKiralıks();
        [OperationContract]
        void AddKiralık(Kiralık kiralık);
        [OperationContract]
        void RemoveKiralık(int id);
        [OperationContract]
        void EditKiralık(Kiralık kiralık);
        [OperationContract]
        List<Satılık> GetSatılıks();
        [OperationContract]
        void AddSatılık(Satılık satılık);
        [OperationContract]
        void RemoveSatılık(int id);
        [OperationContract]
        void EditSatılık(Satılık satılık);


    }
 }

