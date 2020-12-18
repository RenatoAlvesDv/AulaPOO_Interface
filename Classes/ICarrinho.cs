namespace AulaPOO_Interface.Classes
{
    public interface ICarrinho
    {

        // CRUD
        // Create - Cadastrar
        void Cadastar(Produto produto);

        // Red-Ler
        void Listar();

        // Update- Alterar
        void Alterar( int cod, Produto produto);

        // Delete - Deletar
        void Deletar ( Produto produto);
  
       
    }
}