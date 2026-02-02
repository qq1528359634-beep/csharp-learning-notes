 using System.Linq;



namespace ConfigServices
{
    public class ConfigService : IConfigService
    {
        public string GetValue(string name)
        {
            return Environment.GetEnvironmentVariable(name);
        }
    }
   
}
