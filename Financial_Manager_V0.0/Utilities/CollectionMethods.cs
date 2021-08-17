using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Financial_Manager_V0._0.Utilities
{
    public  class CollectionMethods
    {
        public string MaxDictValue(Dictionary<string, decimal> dict)
        {
            decimal max_value = 0;
            string max_key ="";
            foreach(KeyValuePair<string,decimal> entry in dict)
            {
                if (entry.Value > max_value)
                {
                    max_value = entry.Value;
                    max_key = entry.Key;
                }
            }
            return max_key;
        }
    }
}
