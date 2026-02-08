using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;

namespace JasonExample
{
    static  class FxConfigExtensions
    {
        public static  IConfigurationBuilder AddFxConfig(this IConfigurationBuilder cb)
        {
            if (cb == null) throw new ArgumentNullException(nameof(cb));
            cb.Add(new FxConfigSource() { Path = "web.config" });
            return cb;
        }
    }
}
