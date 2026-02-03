using System;
using System.Collections.Generic;
using System.Text;

namespace ConfigServices
{
    public interface IConfigReader
    {
        /// <summary>
        /// /if can not find ,return null
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public string GetValue(string name);
    }
}
