using DomainModel.Models;
using FlightManagementWebAPI.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FlightManagementWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocumentController : ControllerBase
    {
        private readonly DocumentRepository _documentRepository;
        public DocumentController(DocumentRepository documentRepository)
        {
            _documentRepository = documentRepository;
        }
        [HttpPost]
        public IActionResult AddDocument([FromBody] Document document)
        {
            if (document == null)
                return BadRequest();

            try
            {
                _documentRepository.AddDocument(document);
                return Ok();
            }
            catch (System.Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
        [HttpGet("EditDocument/{passengerId:int}")]
        public IActionResult GetDocument(int passengerId)
        {
            try
            {
                var document = _documentRepository.GetDocument(passengerId);
                return Ok(document);
            }
            catch (System.Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }

        }
        [HttpPut]
        public IActionResult UpdateDocument([FromBody] Document document)
        {
            if (document == null)
                return BadRequest();
            try
            {
                _documentRepository.UpdateDocument(document);
                return Ok();
            }
            catch (System.Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}
