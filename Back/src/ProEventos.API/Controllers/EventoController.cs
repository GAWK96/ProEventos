using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Evento> _evento = new Evento[] {
                new Evento() {
                EventoId = 1,
                Tema = "Angular 11 e .NET 5",
                local = "Belo Horizonte",
                Lote = "Primeiro Lote",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(2).ToString(),
                ImagemUrl = "foto.png"
                 },
                 new Evento(){
                EventoId = 2,
                Tema = "Angular e Suas Novidades",
                local = "São Paulo",
                Lote = "Segundo Lote",
                QtdPessoas = 350,
                DataEvento = DateTime.Now.AddDays(3).ToString("dd/mm/yyyy"),
                ImagemUrl = "foto1.png"
                 }
        };
        public EventoController()
        {
            
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
             
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return _evento.Where(evento => evento.EventoId == id);
             
        }


        [HttpPost]
        public string Post()
        {
            return "example of Post";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"example of Put {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"example of Delete {id}";
        }
    }
}
