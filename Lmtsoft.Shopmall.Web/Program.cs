using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace Lmtsoft.Shopmall.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                 .ConfigureLogging((context, loggingBuilder) =>
                 {
                     loggingBuilder.AddFilter("System", LogLevel.Warning);//过滤掉命名空间
                     loggingBuilder.AddFilter("Microsoft", LogLevel.Warning);
                     loggingBuilder.AddLog4Net();//使用log4net 测试合并至master
                 })//扩展日志
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
