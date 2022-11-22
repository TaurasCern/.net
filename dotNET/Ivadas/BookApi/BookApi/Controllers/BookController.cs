using BookApi.Interfaces;
using BookApi.Models.Concrete;
using BookApi.Models.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookSet _bookSet;
        private readonly IBookWrapper _bookWrapper;
        private readonly IBookManager _bookManager;
        public BookController(IBookSet bookSet, IBookWrapper bookWrapper, IBookManager bookManager)
        {
            _bookSet = bookSet;
            _bookWrapper = bookWrapper;
            _bookManager = bookManager;
        }

        [HttpGet]
        public ActionResult<List<GetBookDTO>> Get() 
        {
            return Ok(_bookManager.Get());
        }
        [HttpGet("{id}")]
        public ActionResult<GetBookDTO> GetById(int id)
        {
            return Ok(_bookManager.Get(id));
        }

        [HttpGet("filter")]
        public ActionResult<List<GetBookDTO>> GetFilter(FilterBookRequest request)
        {
            Dictionary<string, string> filter = new Dictionary<string, string>();

            filter.Add(nameof(request.Pavadinimas), request.Pavadinimas);
            filter.Add(nameof(request.Autorius), request.Autorius);
            filter.Add(nameof(request.KnygosTipas), request.KnygosTipas);
            
            return Ok(_bookManager.Filter(filter));
        }

        [HttpPost]
        public ActionResult Post(CreateBookDTO book)
        {
            return Ok(_bookManager.Add(book));
        }

        [HttpPut]
        public ActionResult Put(UpdateBookDTO book)
        {
            _bookManager.Update(book);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _bookManager.Delete(id);
            return Ok();
        }
    }
}
