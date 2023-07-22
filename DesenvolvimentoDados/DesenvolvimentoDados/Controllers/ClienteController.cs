using DesenvolvimentoDados.Models;
using DesenvolvimentoDados.Repositorio.Interface;
using Microsoft.AspNetCore.Mvc;

namespace DesenvolvimentoDados.Controllers
{
    public class ClienteController : Controller
    {
        private readonly IClienteRepositorio _clienteRepositorio;

        public ClienteController(IClienteRepositorio clienteRepositorio)
        {
            _clienteRepositorio = clienteRepositorio;
        }

        public IActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Criar(ClienteModel cliente)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _clienteRepositorio.Adicionar(cliente);
                    return RedirectToAction("Index");
                }

                return View(cliente);
            }
            catch (System.Exception)
            {

                return RedirectToAction("Index");
            }
        }

        public IActionResult Consulta()
        {
            return View();
        }

        public IActionResult Editar()
        {
            return View();
        }

        public IActionResult ApagarConfirmacao()
        {
            return View();
        }
        
        public IActionResult Apagar()
        {
            return View();
        }

        public IActionResult ListarPorNome()
        {
            return View();
        }
    }
}
