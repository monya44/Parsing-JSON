using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parsing_JSON
{
    public static class Extensions
    {
        public static string formated(this Models.Root settings)
        {
            return string.Format("Id: {0}\nHistory: 1663016400 Price: {1:c2}\nHistory: 1663102800 Price: {2:c2}\nHistory: 1663189200 Price: {3:c2}\nHistory: 1663275600 Price: {4:c2}", settings.currency_id, settings.history._1663016400, settings.history._1663102800, settings.history._1663189200,
                settings.history._1663275600);
        }
    }
}
