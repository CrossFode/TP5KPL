// See https://aka.ms/new-console-template for more information
public class HaloGeneric
{
    public void SapaUser<T>(T userName)
    {
        Console.WriteLine($"Halo user {userName}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        HaloGeneric halo = new HaloGeneric();


        string namaPanggilan = "Fauzan";
        halo.SapaUser(namaPanggilan);
        Console.Read();
    }
}
