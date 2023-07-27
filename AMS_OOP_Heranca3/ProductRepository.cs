public class ProductRepository : RepositoryBase, IProduct
{
    List<int> Ids = new List<int>{};
    List<string?> Names = new List<string?>{};
    void IProduct.Add(Product p)
    {
        Id = p.Id;
        Name = p.Name;
        Ids.Add(Id);
        Names.Add(Name);
        Console.WriteLine($"Produto adicionado. Id: {Id}, Nome: {Name}");
    }
    void IProduct.GetProduct()
    {
        Console.WriteLine("Lista de Produtos:");
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