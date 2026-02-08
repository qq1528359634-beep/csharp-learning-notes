using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using JasonExample;
using Microsoft.Extensions.Configuration.CommandLine;
using Microsoft.Extensions.Configuration.EnvironmentVariables;


class JsonExample
{
    static void Main(string[] args)
    {
        ServiceCollection services = new ServiceCollection();
        services.AddScoped<TextController>();
        services.AddScoped<Test2>();
        services.AddScoped<TestWebConfig>();

        ConfigurationBuilder configBuilder = new ConfigurationBuilder();
        // configBuilder.AddJsonFile("Config.json", optional: false, reloadOnChange: true);
        //configBuilder.AddCommandLine(args);

       // configBuilder.Add(new FxConfigSource() { Path = "web.config" });
        configBuilder.AddFxConfig();
        //add a source to builder
        configBuilder.AddEnvironmentVariables("C1_");
        //Provider
        IConfigurationRoot configRoot = configBuilder.Build();


        /* services.AddOptions();
         services.Configure<Config>(e => configRoot.Bind(e));
         services.Configure<Proxy>(e => configRoot.GetSection("Proxy").Bind(e));*/
        services.AddOptions();
        services.Configure<WebConfig>(e => configRoot.Bind(e));

        using (ServiceProvider sp = services.BuildServiceProvider())
        {
            var c = sp.GetRequiredService<TestWebConfig>();
            c.Test();
            /*  while (true)
              {
                  using (IServiceScope scope = sp.CreateScope())
                  {
                      TextController textConfig = scope.ServiceProvider.GetRequiredService<TextController>();
                      textConfig.Test();
                      //var proxyConfig = scope.ServiceProvider.GetRequiredService<Test2>();
                      //proxyConfig.Test();

                  }
                  Console.WriteLine("enter any key to continue");
                  Console.ReadKey();
              }*/


        }



        /*    string name = configurationRoot["name"];
            Console.WriteLine($"name is {name}");
            string address = configurationRoot.GetSection("Proxy:address").Value;
            Console.WriteLine($"ddress is {address}");*/

        /* Proxy proxy = configurationRoot.GetSection("Proxy").Get<Proxy>();
         Console.WriteLine($"Address = {proxy.Address}" +
             $" Port = {proxy.Port}");
        Config config = configurationRoot.Get<Config>();
        Console.WriteLine(config.Name);
        Console.WriteLine(config.Age);
        Console.WriteLine(config.Proxy.Address);
        Console.WriteLine(config.Proxy.Port);*/

    }
}
class Proxy
{
    public string Address { get; set; }
    public int Port { get; set; }
    public int[] Ids { get; set; }
}
class Config
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Proxy Proxy { get; set; }
}