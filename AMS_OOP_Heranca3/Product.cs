public class Product :  ProductRepository, IProduct
{
    // Essa Classe foi feita para melhor a manipulação das propriedades e parâmetros
    public Product (int _id, string? _name){
        Id = _id;
        Name = _name;
    }
}