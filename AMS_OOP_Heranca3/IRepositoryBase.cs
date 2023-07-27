public interface IRepositoryBase
{
    void Add(Customer c, Product p);
    void GetAll();
    void SendMail(Customer c);
}