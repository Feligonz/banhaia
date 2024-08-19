using Gestion.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Gestion.Logic.Services
{
    public class ContactoService
    {
        private readonly GestionLogic _logic;

        public ContactoService(GestionLogic logic) { 
            _logic = logic;
        }

        public List<Contacto> Contactos()
        {
            return _logic._context.Contactos.ToList();
        }

        public void TestData()
        {
            _logic._context.Contactos.ExecuteDelete();

            for (int i = 1; i <= 20; i++)
            {
                Contacto contacto = new Contacto
                {
                    Nombre = "Contacto" + i,
                    Email = "contacto" + i + "@mail.com"
                };

                _logic._context.Contactos.Add(contacto);
            }

            _logic._context.SaveChanges();
        }
    }
}
