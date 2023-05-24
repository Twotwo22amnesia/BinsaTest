using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BinsaTest.Data;
using BinsaTest.Models;

namespace BinsaTest.Controllers
{
    public class ContactosClientesController : Controller
    {
        private readonly BinsaTestContext _context;

        public ContactosClientesController(BinsaTestContext context)
        {
            _context = context;
        }

        // GET: ContactosClientes
        public async Task<IActionResult> Index(int ClienteId)
        {
            var contactos = _context.ContactosCliente.Where(z => z.ClienteId.Equals(ClienteId)).ToList(); 
            ViewBag.cliente = _context.Clientes.Find(ClienteId);
            return View(contactos);
        } 

        // GET: ContactosClientes/Create
        public IActionResult Create(int ClienteId)
        {
            ViewBag.cliente = _context.Clientes.Find(ClienteId);
            //var Contacto = new ContactosCliente { Id = ClienteId };
            //return PartialView(Contacto);
            return PartialView();
        }

        // POST: ContactosClientes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create( ContactosCliente contactosCliente)
        {
            if (ModelState.IsValid)
            {
                _context.Add(contactosCliente);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index", new { ClienteId = contactosCliente.ClienteId }); 
            }
            return View(contactosCliente);
        }

        // GET: ContactosClientes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.ContactosCliente == null)
            {
                return NotFound();
            }

            var contactosCliente = await _context.ContactosCliente.FindAsync(id);
            if (contactosCliente == null)
            {
                return NotFound();
            }
            return PartialView(contactosCliente);
        }

        // POST: ContactosClientes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ClienteId,Nombre,Telefono,Email")] ContactosCliente contactosCliente)
        {
            if (id != contactosCliente.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(contactosCliente);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ContactosClienteExists(contactosCliente.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index", new { ClienteId = contactosCliente.ClienteId }); 
            }
            return View(contactosCliente);
        }

        // GET: ContactosClientes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.ContactosCliente == null)
            {
                return NotFound();
            }
            var contactosCliente = await _context.ContactosCliente
                .FirstOrDefaultAsync(m => m.Id == id);
            if (contactosCliente == null)
            {
                return NotFound();
            }
            ViewBag.cliente = await _context.Clientes.FindAsync(contactosCliente.ClienteId);


            return PartialView(contactosCliente);
        }

        // POST: ContactosClientes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.ContactosCliente == null)
            {
                return Problem("Entity set 'BinsaTestContext.ContactosCliente'  is null.");
            }
            var contactosCliente = await _context.ContactosCliente.FindAsync(id);
            if (contactosCliente != null)
            {
                _context.ContactosCliente.Remove(contactosCliente);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction("Index", new { ClienteId = contactosCliente.ClienteId }); 
        }

        private bool ContactosClienteExists(int id)
        {
            return (_context.ContactosCliente?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
