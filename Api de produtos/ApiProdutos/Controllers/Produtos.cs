using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace ApiProdutos
{
    public class Produtos
    {
        private string nome;
        private int id;
        private double preco;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public double Preco
        {
            get { return preco; }
            set { preco = value; }
        }
    }

    [ApiController]
    [Route("api/[controller]")]

    public class ApiDeProdutos:ControllerBase
    {

        private static List<Produtos> listaProdutos = new List<Produtos>
        {
            new Produtos {Id = 1, Nome = "Carro", Preco = 40000.00},
            new Produtos {Id = 2, Nome = "Moto", Preco = 20000.00},
            new Produtos {Id = 3, Nome = "Caminhão", Preco = 80000.00}
        };

        private static int proximoId = 4;

        [HttpGet]
		public IActionResult listagemDeProdutos()
		{
            return Ok(listaProdutos);
        }

        [HttpGet("id")]
        public IActionResult BuscarProdutoID(int id)
        {
            if (id <= 0)
            {
                return BadRequest("Não existe um id igual ou menor do que 0.");
            }

            var produtos = listaProdutos.FirstOrDefault(produtinhos => produtinhos.Id == id);

            if(produtos == null)
            {
                return NotFound($"Não existe produto com esse id: {id}");
            }

            return Ok(produtos);
        }

        [HttpPost]
        public IActionResult criarProduto([FromBody] Produtos produtoNovo)
        {
            if (string.IsNullOrWhiteSpace(produtoNovo.Nome)){
                return BadRequest("O nome do produto é obrigatório");
            }

            if(produtoNovo.Preco <= 0)
            {
                return BadRequest("O Produto não deve ser de graça");
            }
            if (produtoNovo.Id > 0 && listaProdutos.Any(p => p.Id == produtoNovo.Id))
            {
                return BadRequest($"Já existe um produto com esse Id {produtoNovo.Id}");
            }

            if(produtoNovo.Id <= 0)
            {
                produtoNovo.Id = proximoId++;
            }

            return CreatedAtAction(
                nameof(BuscarProdutoID),
                new { id = produtoNovo.Id },
                produtoNovo);
        }

        [HttpPut("{id}")]
        public IActionResult atualizarProduto(int id, [FromBody] Produtos produtoAtualizado)
        {
           if(id < 0)
            {
                return BadRequest("Id tem que ser maior que zero");
            }

            var produtoExistente = listaProdutos.FirstOrDefault(p => p.Id == id);

            if(produtoExistente == null)
            {
                return BadRequest("Produto com a Id inexistente");
            }
            if (string.IsNullOrWhiteSpace(produtoAtualizado.Nome))
            {
                return BadRequest("O nome é obrigatório");
            }

            if(produtoAtualizado.Preco <= 0)
            {
                return BadRequest("O preço deve ser maior que zero");
            }

            produtoExistente.Nome = produtoAtualizado.Nome;
            produtoExistente.Preco = produtoAtualizado.Preco;

            return Ok(new
            {
                mensagem = "Produto atualizado com sucesso !!!",
                produto = produtoExistente
            });
        }

        [HttpDelete("{id}")]

        public IActionResult deletarProduto(int id)
        {
            if (id <= 0)
            {
                return BadRequest("Esse Id não existe");
            }
            var produto = listaProdutos.FirstOrDefault(p => p.Id == id);

            if (produto == null)
            {
                return NotFound($"Id do produto não encontrada");
            }

            listaProdutos.Remove(produto);

            return Ok(new
            {
                mensagem = $"Produto: '{produto.Nome}' deletado com sucesso !!!",
                idDeletado = id
            });
        }

    }
}
