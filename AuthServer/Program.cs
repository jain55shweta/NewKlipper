﻿using Common;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace AuthServer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .UseUrls(new string[]
                    {
                        AddressResolver.GetAddress("AuthServer", true),
                        AddressResolver.GetAddress("AuthServer", false),
                    })
            ;
    }
}
