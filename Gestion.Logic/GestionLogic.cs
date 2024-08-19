using Gestion.Data;
using Gestion.Logic.Services;

namespace Gestion.Logic
{
    public class GestionLogic
    {
        internal GestionDbContext _context;
        public GestionLogic(GestionDbContext context)
        {
            _context = context;
        }

        public void Setup()
        {
            _context.Setup();
        }

        public ContactoService Contactos
        {
            get
            {
                return new ContactoService(this);
            }
        }
    }
}
