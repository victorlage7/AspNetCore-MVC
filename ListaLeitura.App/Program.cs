using ListaLeitura.App.Negocio;
using ListaLeitura.App.Repositorio;
using Microsoft.AspNetCore.Hosting;
using System;


namespace ListaLeitura.App
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebHost host = new WebHostBuilder()
                .UseKestrel()
                .UseStartup<Startup>()
                .Build();
            host.Run();
        }
    }
}
