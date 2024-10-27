﻿using gourmet_express.modelos;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("http://127.0.0.1:8000/foods");
        var json = JsonSerializer.Deserialize<List<Food>>(resposta);
        Console.WriteLine(json);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Erro: {ex}");
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
