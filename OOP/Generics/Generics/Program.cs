namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IUser businessClient = new BusinessClient(1, "vardas1");
            IUser administrator = new Administrator(2, "vardas2");
            IUser privateClient = new PrivateClient(3, "vardas3");

            EntityRepository<IUser> rep = new EntityRepository<IUser>();
            rep.Add(businessClient);
            rep.Add(administrator);
            rep.Add(privateClient);
            rep.Print();
        }
    }
}