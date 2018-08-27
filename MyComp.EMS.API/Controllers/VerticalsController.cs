using MyComp.EMS.Repositories.Models;
using MyComp.EMS.Repositories.Interfaces;
using System.Web.Http;
using System;

namespace MyComp.EMS.API.Controllers
{
    public class VerticalsController : ApiController
    {
        private readonly IVerticalRepository VerticalRepository;
        public VerticalsController(IVerticalRepository verticalRepository)
        {
            this.VerticalRepository = verticalRepository;
        }

        [HttpGet]
        public IHttpActionResult Get()
        {
            return Ok(VerticalRepository.GetVerticals());
        }
        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            if (ModelState.IsValid)
            {
                return Ok(VerticalRepository.GetVerticalByID(id));
            }
            else
            {
                return BadRequest("Bad Request - Model State is not valid");
            }
        }
        [HttpPost]
        public IHttpActionResult Post([FromBody] Vertical vertical)
        {
            if(ModelState.IsValid)
            {
                VerticalRepository.AddVertical(vertical);
                return Ok("Vertical saved successfully");
            }
            else
            {
                return BadRequest("Bad Request - Model State is not valid");
            }
        }
    }
}
