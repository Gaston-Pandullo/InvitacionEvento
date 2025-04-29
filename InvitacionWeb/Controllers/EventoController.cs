using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InvitacionWeb.Data;
using InvitacionWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace InvitacionWeb.Controllers
{
    public class EventoController : Controller
    {
        private readonly AppDbContext _context;

        public EventoController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index(){
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Confirmar (string nombre, string apellido){
            
            if(!string.IsNullOrWhiteSpace(nombre) && !string.IsNullOrWhiteSpace(apellido)){
                var invitado = new Invitado {Nombre = nombre, Apellido = apellido};
                
                _context.Invitados.Add(invitado);

                await _context.SaveChangesAsync();

                return RedirectToAction("Gracias");
            }

            return View("Index");
        }

        public IActionResult Gracias(){
            ViewBag.Direccion = "Av. Siempre Viva 123, Springfield";
            return View();
        }
    }
}