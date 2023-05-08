using Microsoft.AspNetCore.Mvc;

namespace reverse_string.Controllers
{
    [ApiController]
    [Route("api/[controller],[action]")]
    public class reverseClass : ControllerBase
    {
        [HttpGet]
        public string num(string input)
        {
            char[] output = input.ToCharArray();
            Array.Reverse(output);
            string reversename = new string(output);
            return reversename;
        }
    }
}
