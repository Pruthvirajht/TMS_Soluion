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
//    [Route("api/RTO")]
//    [ApiController]
//    public class RTOController : ControllerBase
//    {
//        readonly IRTORepository rtoRepository;
//        public RTOController(IRTORepository rtoRepository)
//        {
//            this.rtoRepository = rtoRepository;
//        }
//        [HttpPost]
//        [Route("/api/RTO/AddUser")]
//        public async Task<TmOwnerdetail> Post(TmOwnerdetail ownerdetail)
//        {
//            var context = await rtoRepository.AddOwner(ownerdetail);
//            return context;
//        }
//        [HttpPost]
//        [Route("/api/RTO/AddVehicle")]
//        public async Task<TmVehicleDetail> Post(TmVehicleDetail vehicleDetail)
//        {
//            var context= await rtoRepository.AddVechile(vehicleDetail);
//            return context;
//        }
//        [HttpPost]
//        [Route("/api/RTO/Register")]
//        public async Task<TmRegdetail> Post(TmRegdetail regdetail)
//        {
//            var context  = await rtoRepository.Registration(regdetail);
//            return context;
//        }
//        [HttpPut]
//        [Route("/api/RTO/Transferdetails/{appno}")]
//        public bool Put(TmRegdetail regdetail, string appno)
//        {
//            return rtoRepository.Transferdetails(regdetail, appno);
//        }
//        [HttpGet]
//        [Route("/api/RTO/GenerateReport/{id}")]
//        public List<TmRegdetail> Get(int id)
//        {
//            return rtoRepository.GenerateReport(id);
//        }
//        [HttpGet]
//        [Route("/api/RTO/GetAll")]
//        public async Task<IEnumerable<TmRegdetail>>Get()
//        {
//            return await rtoRepository.GetAll();
//        }
//        [HttpGet]
//        [Route("/api/RTO/GetById/{appno}")]
//        public async Task<TmRegdetail> Get(string appno)
//        {
//            return await  rtoRepository.GetById(appno);
//        }       

//    }
//}
