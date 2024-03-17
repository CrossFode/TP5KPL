// See https://aka.ms/new-console-template for more information
class DataGeneric<T>
{
    T Data { get; set; }
    public DataGeneric(T data)
    {
        Data = data;
    }
    public void PrintData()
    {
        Console.WriteLine($"Data yang tersimpan adalah: {Data}");
    }
}
class Program
{


    static void Main(string[] args)
    {
        DataGeneric<string> stringData = new DataGeneric<string>("Y");
        stringData.PrintData();
        DataGeneric<string> nimData = new DataGeneric<string>("1302220004");
        nimData.PrintData();
        Console.ReadLine();
    }
}