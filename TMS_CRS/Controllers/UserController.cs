//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using TMS_CRS.Repository;
//using TMS_CRS.Models;

//namespace TMS_CRS.Controller
//{
//    [Route("/api/User")]
//    [ApiController]
//    public class UserController : ControllerBase
//    {
//        readonly IUserRepository user;
//        readonly TmsDatabaseContext db;
//        public UserController(IUserRepository user, TmsDatabaseContext db)
//        {
//            this.user = user;
//            this.db = db;
//        }
//        [HttpPost]
//        [Route("/api/User/AddUser")]
//        public bool Post(TmUserMaster userMaster)
//        {
//            return user.AddUser(userMaster);
//        }
//    }
//}
