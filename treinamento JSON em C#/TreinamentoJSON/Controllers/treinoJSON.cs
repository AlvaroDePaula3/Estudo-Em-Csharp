using Microsoft.AspNetCore.Mvc;
using System;

namespace MinhaApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PerfilController : ControllerBase
    {
        // =========================================================
        // DTO: Modelo de dados (separado da lógica)
        // =========================================================
        public class PerfilDto
        {
            public string Nome { get; set; }
            public int Idade { get; set; }
            public string Cidade { get; set; }
            public string Profissao { get; set; }
            public DateTime DataCadastro { get; set; }
        }

        // =========================================================
        // GET: /api/perfil
        // =========================================================
        [HttpGet]
        public IActionResult Get()
        {
            var perfil = new PerfilDto
            {
                Nome = "Courtney Laplante",
                Idade = 37,
                Cidade = "Bangor",
                Profissao = "Cantora",
                DataCadastro = DateTime.Now
            };

            return Ok(perfil);
        }

        // =========================================================
        // GET: /api/perfil/dados?nome=...&idade=...
        // =========================================================
        [HttpGet("dados")]
        public IActionResult GetDados(
            [FromQuery] string nome,
            [FromQuery] int idade,
            [FromQuery] string cidade,
            [FromQuery] string profissao)
        {
            var perfil = new PerfilDto
            {
                Nome = nome ?? "Não informado",
                Idade = idade,
                Cidade = cidade ?? "Não informada",
                Profissao = profissao ?? "Não informada",
                DataCadastro = DateTime.Now
            };

            return Ok(perfil);
        }

        // =========================================================
        // POST: /api/perfil
        // =========================================================
        [HttpPost]
        public IActionResult Post([FromBody] PerfilDto perfil)
        {
            if (perfil == null)
                return BadRequest(new { erro = "Dados inválidos." });

            return Ok(new
            {
                mensagem = $"Perfil de {perfil.Nome} cadastrado com sucesso!",
                dados = perfil,
                data_cadastro = DateTime.Now
            });
        }
    }
}