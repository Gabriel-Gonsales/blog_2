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
    public class PostController : ControllerBase
    {

        private readonly ILogger<PostController> _logger;

        // Declaration of the service used
        private IPostBusiness _postBusiness;

        // Injection of an instance of IPostService
        // when creating an instance of PostController
        public PostController(ILogger<PostController> logger, IPostBusiness postBusiness)
        {
            _logger = logger;
            _postBusiness = postBusiness;
        }

        [HttpGet]
        [ProducesResponseType((200), Type = typeof(List<PostVO>))]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Get()
        {
            return Ok(_postBusiness.FindAll());
        }

        // Maps GET requests to https://localhost:{port}/api/book
        // Get no parameters for FindAll -> Search All
        [HttpGet("{sortDirection}/{pageSize}/{page}")]
        [ProducesResponseType((200), Type = typeof(List<PostVO>))]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Get(
            [FromQuery] string title,
            string sortDirection,
            int pageSize,
            int page)
        {
            return Ok(_postBusiness.FindWithPagedSearch(title,sortDirection, pageSize, page));
        }

        // Maps GET requests to https://localhost:{port}/api/book/{id}
        // receiving an ID as in the Request Path
        // Get with parameters for FindById -> Search by ID
        [HttpGet("{id}")]
        [ProducesResponseType((200), Type = typeof(PostVO))]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Get(long id)
        {
            var post = _postBusiness.FindByID(id);
            if (post == null) return NotFound();
            return Ok(post);
        }

        [HttpGet("findPostByTitle")]
        [ProducesResponseType((200), Type = typeof(PostVO))]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Get([FromQuery] string title)
        {
            var post = _postBusiness.FindByTitle(title);
            if (post == null) return NotFound();
            return Ok(post);
        }

        // Maps POST requests to https://localhost:{port}/api/book/
        // [FromBody] consumes the JSON object sent in the request body
        [HttpPost]
        [ProducesResponseType((200), Type = typeof(PostVO))]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Post([FromBody] PostVO post)
        {
            if (post == null) return BadRequest();
            return Ok(_postBusiness.Create(post));
        }

        // Maps PUT requests to https://localhost:{port}/api/book/
        // [FromBody] consumes the JSON object sent in the request body
        [HttpPut]
        [ProducesResponseType((200), Type = typeof(PostVO))]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        [TypeFilter(typeof(HyperMediaFilter))]
        public IActionResult Put([FromBody] PostVO post)
        {
            if (post == null) return BadRequest();
            return Ok(_postBusiness.Update(post));
        }

        // Maps DELETE requests to https://localhost:{port}/api/book/{id}
        // receiving an ID as in the Request Path
        [HttpDelete("{id}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        public IActionResult Delete(long id)
        {
            _postBusiness.Delete(id);
            return NoContent();
        }
    }
}
