//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using TMS_CRS.Repository;
//using TMS_CRS.Models;
//using Microsoft.EntityFrameworkCore;

//namespace TMS_CRS.Repository
//{
//    public class TrafficPoliceRepository : ITrafficPoliceRepository
//    {
//        readonly TmsDatabaseContext db;
//        public TrafficPoliceRepository()
//        {
//            db = new TmsDatabaseContext();
//        }
//        public TrafficPoliceRepository(TmsDatabaseContext db)
//        {
//            this.db = db;
//        }
//        //traffic police can add penalty 
//        public int Addpenalty(OffenceDetail offenceDetail)
//        {
//            db.OffenceDetails.Add(offenceDetail);
//            var res = db.SaveChanges();
//            if (res == 1)
//                return 1;
//            return 0;
//        }
//        //traffic police can edit penalty status once the user pay penalty
//        public bool EditPenalty(OffenceDetail newValue, int offenceNo)
//        {
//            var oldval = db.OffenceDetails.Where(x => x.OffenceNo == offenceNo).FirstOrDefault();
//            oldval.Status = newValue.Status;
//            db.Update(oldval);
//            var res = db.SaveChanges();
//            if (res == 1)
//                return true;
//            return false;
//        }

//        public OffenceDetail GetoffencebyOffno(int offenceNo)
//        {
//            return db.OffenceDetails.Where(x => x.OffenceNo == offenceNo).FirstOrDefault();
//        }

//        public async Task<OffenceDetail> DeleteOffenceDeatils(int offenceNo)
//        {
//            var result = await db.OffenceDetails.Where(x => x.OffenceNo == offenceNo).FirstOrDefaultAsync();
//            if (result != null)
//            {
//                db.OffenceDetails.Remove(result);
//                await db.SaveChangesAsync();
//                return result;
//            }

//            return null;
//        }

//        public async Task<IEnumerable<OffenceDetail>> Showalloffence()
//        {
//            return await db.OffenceDetails.ToListAsync();
//        }

//        //traffic police can generate a report by using vehno
//        //public offencedetail generatereport(string vno)
//        //{
//        //    return db.offencedetails.where(x => x.vehno == vno).firstordefault();

//        //}

//        List<OffenceDetail> ITrafficPoliceRepository.GenerateReport(string vehicleNo)
//        {
//            return db.OffenceDetails.Where(x => x.VehNo == vehicleNo).ToList();
//        }
//    }
//}
