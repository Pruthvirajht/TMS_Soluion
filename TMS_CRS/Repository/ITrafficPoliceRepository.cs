//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using TMS_CRS.Models;

//namespace TMS_CRS.Repository
//{
//    public interface ITrafficPoliceRepository
//    {
//        int Addpenalty(OffenceDetail offenceDetail);
//        bool EditPenalty(OffenceDetail newValue, int offenceNo);
//        List<OffenceDetail> GenerateReport(string vehicleNo);
//        Task<IEnumerable<OffenceDetail>> Showalloffence();
//        OffenceDetail GetoffencebyOffno(int offenceNo);

//        Task<OffenceDetail> DeleteOffenceDeatils(int offenceNo);
//    }
//}
////Traffic police has three funcationality that is add,edit,Delete and generate report