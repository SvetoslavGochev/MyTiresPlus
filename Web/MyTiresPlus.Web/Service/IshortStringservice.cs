using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyTiresPlus.Web.Service
{
    public interface IshortStringservice
    {
        string GetShort(string str, int maxLength);
    }

    public class ShortStringservice : IshortStringservice
    {
        public string GetShort(string str, int maxLength)
        {
            if (str == null)
            {
                return str;
            }

            if (str.Length <= maxLength)
            {
                return str;
            }

            return str.Substring(0, maxLength) + "...";
            //trqbva da se registrira v start up public void ConfigureServices(IServiceCollection services)
        }
    }
}
