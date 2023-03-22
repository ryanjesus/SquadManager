using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class UserController : ControllerBase
	{
		/// <summary>
		/// Autentica o usuário
		/// </summary>
		/// <param name="username">Username do usuário</param>
		/// <param name="password">Senha do usuário</param>
		/// <returns></returns>
		[HttpGet]
		public IActionResult Login(string username, string password)
		{
			return Ok(new { response = "Está logado" });

		}
	}
}
