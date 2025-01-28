// See https://aka.ms/new-console-template for more information
using System;
using System.Net.Http;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        string url = "https://www.example.com";
        string content = await FetchContentAsync(url);
        Console.WriteLine(content);
    }

    static async Task<string> FetchContentAsync(string url)
    {
        using HttpClient client = new HttpClient();
        string result = await client.GetStringAsync(url);
        return result;
    }
}

