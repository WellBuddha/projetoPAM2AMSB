public class RepositoryBase : IRepositoryBase
{
    
    public int Id {get; set;}
    public string? Name {get; set;}
    List<int> IdsProd = new List<int>{};
    List<string?> NamesProd = new List<string?>{};
    List<int> IdsCust = new List<int>{};
    List<string?> NamesCust = new List<string?>{};
    public int I = 1;
    void IRepositoryBase.Add(Customer c, Product p)
    {
        Id = c.Id;
        Name = c.Name;
        IdsCust.Add(Id);
        NamesCust.Add(Name);
        Console.WriteLine($"Cliente adicionado na base. Id: {Id}, Nome: {Name}");
        Id = p.Id;
        Name = p.Name;
        IdsProd.Add(Id);
        NamesProd.Add(Name);
        Console.WriteLine($"Produto adicionado na base. Id: {Id}, Nome: {Name}");
    }

    void IRepositoryBase.GetAll()
    {
        Console.WriteLine("Lista Geral:");
        foreach(var item in IdsProd){
            Console.WriteLine($"ID do Produto {I}: {item}");
            I++;
        }
        I = 1;
        foreach(var item in NamesProd){
            Console.WriteLine($"Nome do Produto {I}: {item}");
            I++;
        }
        Console.WriteLine("~~~~~~~~~~~~");
        I = 1;
        foreach(var item in IdsCust){
            Console.WriteLine($"ID do Cliente {I}: {item}");
            I++;
        }
        I = 1;
        foreach(var item in NamesCust){
            Console.WriteLine($"Nome do Cliente {I}: {item}");
            I++;
        }
    }
    void IRepositoryBase.SendMail(Customer c){ 
        Id = c.Id; 
        Name = c.Name; 
        Console.WriteLine($"Email mandado para: Id: {Id}, Nome: {Name}");
    }
}