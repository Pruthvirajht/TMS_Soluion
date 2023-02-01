//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using TMS_CRS;
//using TMS_CRS.Repository;
//using TMS_CRS.Models;

//namespace TMS_CRS.Controller
//{
//    [Route("api/TrafficPolice")]
//    [ApiController]
//    public class TrafficPoliceController : ControllerBase
//    {
//        readonly ITrafficPoliceRepository trafficPoliceRepository;
        
//        public TrafficPoliceController(ITrafficPoliceRepository trafficPoliceRepository)
//        {
//            this.trafficPoliceRepository= trafficPoliceRepository;
            
//        }
//        [HttpPost]
//        [Route("/api/TrafficPolice/Addpenalty")]
//        public int Post(OffenceDetail offenceDetail)
//        {
//            return trafficPoliceRepository.Addpenalty(offenceDetail);
//        }
//        [HttpPut]
//        [Route("/api/TrafficPolice/Editpentaly/{offenceNo}")]
//        public bool Put(OffenceDetail newValue, int offenceNo)
//        {
//            return trafficPoliceRepository.EditPenalty(newValue, offenceNo);
//        }
//        [HttpGet]
//        [Route("/api/TrafficPolice/GenerateReport/{vehicleNo}")]
//        public List<OffenceDetail> Get(string vehicleNo)
//        {
//            return trafficPoliceRepository.GenerateReport(vehicleNo);
//        }
//        [HttpGet]
//        [Route("/api/TrafficPolice/Showalloffence")]
//        public async Task<IEnumerable<OffenceDetail>> Get()

//        {
//            return await trafficPoliceRepository.Showalloffence();
//        }
//        [HttpGet]
//        [Route("/api/TrafficPolice/Getoffencebyoffno/{offenceNo}")]
//        public OffenceDetail Get(int offenceNo)
//        {
//            return trafficPoliceRepository.GetoffencebyOffno(offenceNo);
//        }

//        [HttpDelete]
//        [Route("/api/TrafficPolice/DeleteOffenceDeatils/{offenceNo}")]
//        public async Task <OffenceDetail> Delete(int offenceNo)
//        {
//            return await trafficPoliceRepository.DeleteOffenceDeatils(offenceNo);
//        }

//    }
//}
