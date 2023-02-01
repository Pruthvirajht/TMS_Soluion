//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using TMS_CRS.Models;

//namespace TMS_CRS.Repository
//{
//    public class UserRepository : IUserRepository
//    {
//        readonly TmsDatabaseContext db;
//        public UserRepository()
//        {
//            db = new TmsDatabaseContext();
//        }
//        public UserRepository(TmsDatabaseContext db)
//        {
//            this.db = db;
//        }
//        public bool AddUser(TmUserMaster user)
//        {
//            db.TmUserMasters.Add(user);
//            var res = db.SaveChanges();
//            if (res == 1)
//                return true;
//            return false;
//        }
//    }
//}
