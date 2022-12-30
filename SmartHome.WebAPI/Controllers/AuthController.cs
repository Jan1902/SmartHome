using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;

namespace SmartHome.WebAPI.Controllers
{
    [ApiController]
    public class AuthController : ControllerBase
    {
        [HttpGet("auth")]
        public IActionResult Auth(string? redirect_uri, string? state)
        {
            var byteArray = new byte[64];
            new Random().NextBytes(byteArray);
            var authCode = Encoding.UTF8.GetString(byteArray);
            authCode = "abcdefg";

            var redirectUrl = $"{redirect_uri}?code={authCode}?state={state}";

            return Redirect(redirectUrl);
        }

        [HttpPost("token")]
        public IActionResult Token(string? client_id, string? client_secret, string? code, string? redirect_uri, string? refresh_token)
        {
            var byteArray = new byte[64];

            new Random().NextBytes(byteArray);
            var accessToken = Encoding.UTF8.GetString(byteArray);

            new Random().NextBytes(byteArray);
            var refreshToken = Encoding.UTF8.GetString(byteArray);

            var json = new
            {
                token_type = "Bearer",
                access_token = accessToken,
                refresh_token = refreshToken,
                expires_in = 60 * 60 * 24 * 30
            };

            return Content(JsonConvert.SerializeObject(json), "text/json");
        }
    }

    [Route(".well-known")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet("pki-validation/3E609EE9E9DB7BE610ED4B974D82AE20.txt")]
        public IActionResult Get()
        {
            return File(Encoding.UTF8.GetBytes("99769A17CD8B076072D872FF2B94282071DEE3C806E47804EFDFD5D58E259318\r\ncomodoca.com\r\nb6e5a2fc7f1f974"), "text/plain");
        }
    }
}
