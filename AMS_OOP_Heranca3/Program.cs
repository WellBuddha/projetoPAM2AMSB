// Classes de armazenamento -----------
IRepositoryBase repobase = new RepositoryBase();
IRepositoryBase irep = new RepositoryBase();
IProduct prodrepo = new ProductRepository();
IProduct iprod = new ProductRepository();
ICustomer custrepo = new CustomerRepository();
ICustomer icust = new CustomerRepository();
//  -----------

//Cliente 1 e Produto 1 ------------------
Customer a = new Customer(123, "Well");
custrepo.Add(a);
Console.WriteLine("---------------------");

Product b = new Product(321, "Batata");
prodrepo.Add(b);
Console.WriteLine("---------------------");
repobase.Add(a, b);
Console.WriteLine("---------------------");
//Adicionando Cliente 1 e Produto 1 ------------------

//Cliente 2 e Produto 2 ------------------
Customer c = new Customer(432, "Kauan");
custrepo.Add(c);
Console.WriteLine("---------------------");

Product d = new Product(543, "Frango");
prodrepo.Add(d);
Console.WriteLine("---------------------");
repobase.Add(c, d);
Console.WriteLine("---------------------");
//Adicionando Cliente 2 e Produto 2 ------------------

//Métodos de exibição-------------------
irep = repobase;
iprod = prodrepo;
icust = custrepo;
repobase.SendMail(c);
Console.WriteLine("---------------------");
iprod.GetProduct();
Console.WriteLine("---------------------");
icust.GetCustomer();
Console.WriteLine("---------------------");
irep.GetAll();
Console.WriteLine("---------------------");
// -------------------
/*Para adicionar um novo produto e cliente, só é preciso colar esse código depois das Classes de armazenamento e antes
dos Métodos de exibição:

Customer nomeClasse = new Customer(Id, "Nome");
custrepo.Add(nomeClasse);
Console.WriteLine("---------------------");

Product nomeClasse1 = new Product(ID, "Nome");
prodrepo.Add(nomeClasse1);
Console.WriteLine("---------------------");
repobase.Add(nomeClasse, nomeClasse1);
Console.WriteLine("---------------------");
*/