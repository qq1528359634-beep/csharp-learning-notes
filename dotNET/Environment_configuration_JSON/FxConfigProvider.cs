using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace JasonExample
{
    class FxConfigProvider : FileConfigurationProvider
    {
        public FxConfigProvider(FxConfigSource source) : base(source)
        {
        }
   
        public override void Load(Stream stream)
        {
            var date = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(stream);
            XmlNodeList csNodes = xmlDoc.SelectNodes("/configuration/connetionStrings/add");
            foreach (XmlNode xmlNode in csNodes.Cast<XmlNode>())
            {
                string name = xmlNode.Attributes["name"].Value;
                string connectionString = xmlNode.Attributes["connectionString"].Value;
                date[$"{name}:connectionString"] = connectionString;
                var attProviderName = xmlNode.Attributes["providerName"];
                if (attProviderName != null)
                {
                    date[$"{name}:providerName"] = attProviderName.Value;

                }
            }

            XmlNodeList asNodes = xmlDoc.SelectNodes("/configuration/appSettings/add");
            foreach (XmlNode xmlNode in asNodes.Cast<XmlNode>())
            {
                string key = xmlNode.Attributes["key"].Value;
                key=key.Replace(".", ":");
                string value = xmlNode.Attributes["value"].Value;
                date[key] = value;
            }
            //扁平化数据需要赋值到Date里
            this.Data= date;
        }
    }
}
