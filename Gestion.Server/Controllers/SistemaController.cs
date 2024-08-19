using Gestion.Logic;
using Gestion.Model;
using Microsoft.AspNetCore.Mvc;

namespace Gestion.Server.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class SistemaController : ControllerBase
    {
        private readonly GestionLogic _gestion;

        public SistemaController(GestionLogic gestion)
        {
            _gestion = gestion;
        }

        [HttpGet]
        public bool Setup()
        {
            _gestion.Setup();

            return true;
        }
    }
}
