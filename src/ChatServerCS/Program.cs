using System;
using Microsoft.AspNet.SignalR;
using Microsoft.Owin.Cors;
using Microsoft.Owin.Hosting;
using Owin;

namespace ChatServerCS
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var url = "http://+:9900/";
                //var url = ConfigurationManager.AppSettings["url"];
                using (WebApp.Start<Startup>(url))
                {
                    Console.WriteLine($"Server running at {url}");
                    Console.ReadLine();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"OPPS! THERE IS ERROR!");
                Console.WriteLine("");
                Console.WriteLine($"============================");
                Console.WriteLine($"Running the program as administrator!!!");
                Console.WriteLine("");
                Console.ReadLine();
            }
            
        }
    }

    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseCors(CorsOptions.AllowAll);
            app.MapSignalR("/signalchat", new HubConfiguration());

            GlobalHost.Configuration.MaxIncomingWebSocketMessageSize = null;

        }
    }
}
