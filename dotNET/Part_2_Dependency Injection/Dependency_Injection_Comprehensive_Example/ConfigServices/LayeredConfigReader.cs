using System;
using System.Collections.Generic;
using System.Text;

namespace ConfigServices
{
    class LayeredConfigReader : IConfigReader
    {                      //IConfigReader 就变成我调用我自己
        private readonly IEnumerable<IConfigService> services;

        public LayeredConfigReader(IEnumerable<IConfigService> services)
        {
            this.services = services;
        }
        public string GetValue(string name)
        {    string value = null;   
            foreach (var service in services)
            {
                 var newValue = service.GetValue(name);
                if (newValue != null)
                {
                   value= newValue;
                }
            }//the last one will be last override
            return value;
        }
         
    }
}
