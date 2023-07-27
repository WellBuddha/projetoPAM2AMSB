public class Customer : CustomerRepository, ICustomer
{
    // Essa Classe foi feita para melhor a manipulação das propriedades e parâmetros
    public Customer (int _id, string? _name){
        Id = _id;
        Name = _name;
    }
}