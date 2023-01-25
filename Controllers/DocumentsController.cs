using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DocumentingSwagger.Models;
using Microsoft.AspNetCore.Mvc;

namespace DocumentingSwagger.Controllers
{
    [ApiController]
    [Route("api/documents")]
    public class DocumentsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(new List<DocumentViewModel> {  new DocumentViewModel("Teste", "Conteudo")});
        }

        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            return Ok(new DocumentViewModel("Teste", "Conteudo"));
        }

        /// <summary>
        /// Cadastrar um Documento
        /// </summary>
        /// <remarks>
        /// { "id": "3fa85f64-5717-4562-b3fc-2c963f66afa6", "title": "string", "content": "string" }
        /// </remarks>
        /// <param name="model">Dados do documento</param>
        /// <returns>Objeto recém-criado</returns>
        /// <response code="201">Success</response>
        [HttpPost]
        public IActionResult Post(DocumentInputModel model)
        {
            return CreatedAtAction(nameof(GetById), new {id = model.Id}, model);
        }
    }
}