using System;
using System.Collections.Generic;

namespace Aula_26
{
    public class Carrinho : ICarrinho
    {

        List<Produto> carrinho = new List<Produto>();

        public float ValorTotal { get; set; }

        public void Alterar(int _cod, Produto _produtoAlterado)
        {
            carrinho.Find( i => i.Codigo == _cod).Nome = _produtoAlterado.Nome;
            carrinho.Find( i => i.Codigo == _cod).Preco = _produtoAlterado.Preco;
        }

        public void Excluir(Produto _produto)
        {
            carrinho.Remove(_produto);
        }

        public void Incluir(Produto _produto)
        {
            carrinho.Add(_produto);
        }

        public void Ler()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            foreach(Produto item in carrinho){
                System.Console.WriteLine($"Produto: {item.Nome} --- Preço: R${item.Preco} ");
            }
            Console.ResetColor();        

        }

        public void CalcularTotal(){

            foreach(Produto p in carrinho){
                ValorTotal += p.Preco;
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Valor Total: R$"+ValorTotal);
            Console.ResetColor();        
        }
    }
}