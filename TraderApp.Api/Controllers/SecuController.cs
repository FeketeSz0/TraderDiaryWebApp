using Microsoft.AspNetCore.Mvc;
using TraderApp.Api.Repositories;
using TraderApp.Model;

namespace TraderApp.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SecuController : ControllerBase
    {
        private readonly ISecuritiesRepositories securitiesRepositories;

        public SecuController(ISecuritiesRepositories securitiesRepositories)
        {
            this.securitiesRepositories = securitiesRepositories;
        }



        [HttpGet("list")]
        public ActionResult<Securities> ListAllSecu()
        {
            return Ok(securitiesRepositories.getAll());

        }
        [HttpPost("add")]
        public ActionResult<Securities> addSecu(Securities secu)
        {
            securitiesRepositories.addSecu(secu);
            return Ok(secu);

        }

        [HttpDelete]
        public ActionResult<Securities> deleteSecu(int id) {
            securitiesRepositories.deleteSecu(id);
            return Ok();
        }
    }
}