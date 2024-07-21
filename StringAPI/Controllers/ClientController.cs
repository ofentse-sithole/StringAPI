using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StringAPI.Model;

namespace StringAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly ClientService _clientService;

        // Constructor
        public ClientController(ClientService clientService)
        {
            _clientService = clientService;
        }

        // GET: api/Client/string/{input}
        [HttpGet("string/{input}")]
        public IActionResult GetStringInfo(string input)
        {
            var reversed = _clientService.ReverseString(input);
            var isPalindrome = _clientService.IsPalindrome(input);

            return Ok(new { ReversedString = reversed, IsPalindrome = isPalindrome });
        }

        
    }
}

