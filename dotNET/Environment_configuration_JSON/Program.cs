using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;



class JsonExample
{
    static void Main(string[] args)
    {
        ConfigurationBuilder configuration = new ConfigurationBuilder();
        string path1 = "Config.json";
        configuration.AddJsonFile(path1, optional: true, reloadOnChange: true);
        IConfigurationRoot configurationRoot = configuration.Build();
        /*    string name = configurationRoot["name"];
            Console.WriteLine($"name is {name}");
            string address = configurationRoot.GetSection("Proxy:address").Value;
            Console.WriteLine($"ddress is {address}");*/

        /* Proxy proxy = configurationRoot.GetSection("Proxy").Get<Proxy>();
         Console.WriteLine($"Address = {proxy.Address}" +
             $" Port = {proxy.Port}");*/
        Config config = configurationRoot.Get<Config>();
        Console.WriteLine(config.Name);
        Console.WriteLine(config.Age);
        Console.WriteLine(config.Proxy.Address);
        Console.WriteLine(config.Proxy.Port);

    }
}
class Proxy
{
    public string Address { get; set; }
    public int Port { get; set; }
}
class Config
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Proxy Proxy { get; set; }
}