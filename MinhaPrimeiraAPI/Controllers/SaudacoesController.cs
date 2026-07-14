using Microsoft.AspNetCore.Mvc;

namespace minhaPrimeiraAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class saudacaoController : ControllerBase
    {
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(new { mensagem = "Olá, mundo ! Seja bem vindo a minha primeira API" });
        }

        [HttpGet("nome")]
        public IActionResult GetNome([FromQuery] string nome)
        {
            if (string.IsNullOrWhiteSpace(nome))
            {
                return BadRequest("Você é obrigado a colocar seu nome, por favor, nos diga qual é o seu nome ?");
            }

            return Ok(new { mensagem = $"Olá {nome}! Prazer em te conhecer, juntos quebramos a maldição do olá mundo !!!" });
        }
    }
}