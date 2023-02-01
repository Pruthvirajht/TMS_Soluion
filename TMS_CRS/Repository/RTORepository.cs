//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Reflection.Metadata;
//using System.Text;
//using System.Threading.Tasks;
//using TMS_CRS.Models;
//using TMS_CRS.Repository;

//namespace TMS_CRS.Repository
//{
//    public class RTORepository : IRTORepository
//    {
//        readonly TmsDatabaseContext db;
//        public RTORepository()
//        {
//            db = new TmsDatabaseContext();
//        }
//        public RTORepository(TmsDatabaseContext db)
//        {
//            this.db = db;
//        }

//        public async Task<TmOwnerdetail>AddOwner(TmOwnerdetail ownerdetail)
//        {
//           var context = await db.TmOwnerdetails.AddAsync(ownerdetail);
//            await db.SaveChangesAsync();
//            return context.Entity;
//        }

//        public async Task<TmVehicleDetail> AddVechile(TmVehicleDetail vehicleDetail)
//        {
//           var conetnt =  await db.TmVehicleDetails.AddAsync(vehicleDetail);
//            await db.SaveChangesAsync();
//            return conetnt.Entity;
//        }
//        public List<TmRegdetail> GenerateReport(int id)
//        {
//            return db.TmRegdetails.Where(x => x.OwnerId == id).ToList();
//        }

//        public async Task<IEnumerable<TmRegdetail>> GetAll()
//        {
//            return await db.TmRegdetails.ToListAsync();
//        }

//        public async Task <TmRegdetail> GetById(string appno)
//        {
//            return await db.TmRegdetails.FirstOrDefaultAsync(x => x.AppNo == appno);
//        }

//        public async Task<TmRegdetail> Registration(TmRegdetail r)
//        {
//           var content = await db.TmRegdetails.AddAsync(r);
//            await db.SaveChangesAsync();
//            return content.Entity;
//        }

//        public bool Transferdetails(TmRegdetail regdetail, string appno)
//        {
//            var olddata = db.TmRegdetails.Where(x => x.AppNo == appno).FirstOrDefault();
//            olddata.OldOwnerId = olddata.OwnerId;
//            olddata.OwnerId = regdetail.OwnerId;
//            db.Update(olddata);
//            var res = db.SaveChanges();
//            if (res == 1)
//                return true;
//            else
//                return false;
//        }

       

       
//    }
//}
