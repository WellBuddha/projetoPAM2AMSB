public class CustomerRepository : RepositoryBase, ICustomer
{
    List<int> Ids = new List<int>{};
    List<string?> Names = new List<string?>{};    
    void ICustomer.Add(Customer c)
    {
        Id = c.Id;
        Name = c.Name;
        Ids.Add(Id);
        Names.Add(Name);
        Console.WriteLine($"Cliente adicionado. Id: {Id}, Nome: {Name}");
    }
    void ICustomer.GetCustomer()
    {
        Console.WriteLine("Lista de Clientes:");
        foreach(var item in Ids){
            Console.WriteLine($"ID {I}: {item}");
            I++;
        }
        I = 1;
        foreach(var item in Names){
            Console.WriteLine($"Nome {I}: {item}");
            I++;
        }
    } 
}