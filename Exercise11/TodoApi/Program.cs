using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using Newtonsoft.Json;
namespace TodoApi
{
    // public class Program
    // {
    //     public static void Main(string[] args)
    //     {
    //         CreateHostBuilder(args).Build().Run();
    //     }

    //     public static IHostBuilder CreateHostBuilder(string[] args) =>
    //         Host.CreateDefaultBuilder(args)
    //             .ConfigureWebHostDefaults(webBuilder =>
    //             {
    //                 webBuilder.UseStartup<Startup>();
    //             });
    // }
    public class Program{

        public static void Main(string[] args){
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>{
                    webBuilder.UseStartup<Startup>();
        });
    
    }
}
