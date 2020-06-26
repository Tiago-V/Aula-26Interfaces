namespace Aula_26
{
    public interface ICarrinho
    {

        //CRUD = Create, Read, Update, Delete - Criar, Ler, Adicionar, Excluir

        void Ler();

        void Incluir(Produto _produto);

        void Excluir(Produto _produto);

        void Alterar(int _cod, Produto _produtoAlterado);    
        
    }
}