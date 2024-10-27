using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("http://127.0.0.1:8000/foods");
        Console.WriteLine(resposta);
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex);
    }
}
namespace gourmet_express
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo ao gourmet express!");
        }
    }
}
