using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RestWithASPNETUdemy.Business;
using RestWithASPNETUdemy.Data.VO;
using RestWithASPNETUdemy.Hypermedia.Filters;
using System.Collections.Generic;

namespace RestWithASPNETUdemy.Controllers
{

    [ApiVersion("1")]
    [ApiController]
    [Route("api/[controller]/v{version:apiVersion}")]
    public class CommentController : ControllerBase
    {

        private readonly ILogger<CommentController> _logger;

        // Declaration of the service used
        private ICommentBusiness _commentBusiness;

        // Injection of an instance of ICommentService
        // when creating an instance of CommentController
        public CommentController(ILogger<CommentController> logger, ICommentBusiness commentBusiness)
        {
            _logger = logger;
            _commentBusiness = commentBusiness;
        }

        [HttpGet]
        [ProducesResponseType((200), Type = typeof(List<CommentVO>))]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Get()
        {
            return Ok(_commentBusiness.FindAll());
        }


        // Maps GET requests to https://localhost:{port}/api/book/{id}
        // receiving an ID as in the Request Path
        // Get with parameters for FindById -> Search by ID
        [HttpGet("{id}")]
        [ProducesResponseType((200), Type = typeof(CommentVO))]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Get(long id)
        {
            var comment = _commentBusiness.FindByID(id);
            if (comment == null) return NotFound();
            return Ok(comment);
        }

        [HttpGet("findByPostId")]
        [ProducesResponseType((200), Type = typeof(CommentVO))]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Get([FromQuery] string Id)
        {
            var comment = _commentBusiness.FindByPostId(Id);
            if (comment == null) return NotFound();
            return Ok(comment);
        }

        // Maps POST requests to https://localhost:{port}/api/book/
        // [FromBody] consumes the JSON object sent in the request body
        [HttpPost]
        [ProducesResponseType((200), Type = typeof(CommentVO))]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Comment([FromBody] CommentVO comment)
        {
            if (comment == null) return BadRequest();
            return Ok(_commentBusiness.Create(comment));
        }

        // Maps PUT requests to https://localhost:{port}/api/book/
        // [FromBody] consumes the JSON object sent in the request body
        [HttpPut]
        [ProducesResponseType((200), Type = typeof(CommentVO))]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Put([FromBody] CommentVO comment)
        {
            if (comment == null) return BadRequest();
            return Ok(_commentBusiness.Update(comment));
        }

        // Maps DELETE requests to https://localhost:{port}/api/book/{id}
        // receiving an ID as in the Request Path
        [HttpDelete("{id}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        public IActionResult Delete(long id)
        {
            _commentBusiness.Delete(id);
            return NoContent();
        }
    }
}
