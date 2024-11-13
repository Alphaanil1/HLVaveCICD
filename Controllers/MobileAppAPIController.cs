using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HLVave.Models;
namespace HLVave.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MobileAppAPIController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<RoomViewModel> Get()
        {

            List<RoomViewModel> obj = new List<RoomViewModel>();
            obj.Add(new RoomViewModel { RoomID = 1, RoomName = "R101", RoomNo = "101" });
            obj.Add(new RoomViewModel { RoomID = 2, RoomName = "R102", RoomNo = "102" });
            obj.Add(new RoomViewModel { RoomID = 3, RoomName = "R103", RoomNo = "103" });
            obj.Add(new RoomViewModel { RoomID = 4, RoomName = "R104", RoomNo = "104" });
            obj.Add(new RoomViewModel { RoomID = 5, RoomName = "R105", RoomNo = "105" });
            return obj;
        }
    }
}
