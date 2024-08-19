using Gestion.Logic;
using Gestion.Model;
using Microsoft.AspNetCore.Mvc;

namespace Gestion.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class ContactosController : ControllerBase
    {
        private readonly GestionLogic _gestion;

        public ContactosController(GestionLogic gestion)
        {
            _gestion = gestion;
        }

        [HttpGet]
        public IEnumerable<Contacto> Todos()
        {
            return _gestion.Contactos.Contactos();
        }


        [HttpGet]
        public bool TestData()
        {
            _gestion.Contactos.TestData();

            return true;
        }
    }
}
