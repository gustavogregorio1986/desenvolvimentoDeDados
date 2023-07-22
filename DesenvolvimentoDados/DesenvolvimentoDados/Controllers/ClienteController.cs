﻿using DesenvolvimentoDados.Models;
using DesenvolvimentoDados.Repositorio.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

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
                    TempData["MensagemSucesso"] = "Cliente cadastrado com sucesso";
                    return RedirectToAction("Criar");
                }

                return View(cliente);
            }
            catch (System.Exception erro)
            {
                TempData["MensagemErro"] = $"Ops, não conseguimos cadastrar seu cliente, tente novamente, detalhe do erro: {erro.Message}";
                return RedirectToAction("Index");
            }
        }

        public IActionResult Consulta()
        {
            List<ClienteModel> lista = _clienteRepositorio.ListarTodos();
            return View(lista);
        }

        public IActionResult Editar(int id)
        {
            ClienteModel cliente = _clienteRepositorio.ListarPorId(id);
            return View(cliente);
        }

        public IActionResult Alterar(ClienteModel cliente)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _clienteRepositorio.Atualizar(cliente);
                    TempData["MensagemSucesso"] = "Cliente Cadastrado com sucesso";
                    return RedirectToAction("Consulta");
                }
            }
            catch (System.Exception erro)
            {
                TempData["MensagemErro"] = $"Ops, não conseguimos cadastrar seu cliente, tente novamente, detalhe do erro: {erro.Message}";
                return RedirectToAction("Consulta");
            }

            return View("Editar", cliente);
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
