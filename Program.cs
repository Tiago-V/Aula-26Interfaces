using System;

namespace Aula_26
{
    class Program
    {
        static void Main(string[] args)
        {

            // Produtos
            Produto p1 = new Produto(1, "Sprite 2L", 5);
            Produto p2 = new Produto(2, "Coca-Cola 2L", 7);
            Produto p3 = new Produto(3, "Schweppes 1,5L", 5);
            Produto p4 = new Produto(4, "Guaraná Antarctica 2L", 6);
            Produto p5 = new Produto(5, "Pepsi 2L", 6);

            // Incluir

            Carrinho minicart = new Carrinho();

            minicart.Incluir(p1);
            minicart.Incluir(p2);
            minicart.Incluir(p3);
            minicart.Incluir(p4);
            minicart.Incluir(p5);

            // Mostrar Carrinho

            minicart.Ler();

            // Calcular Total

            minicart.CalcularTotal();
        }
    }
}
