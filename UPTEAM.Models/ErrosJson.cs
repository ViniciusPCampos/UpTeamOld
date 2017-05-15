using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPTEAM.Models
{
    public class ErrosJson
    {
        public ErrosJson(string key, ICollection<string> value)
        {
            Chave = key;
            Valor = value;
        }
        public string Chave { get; set; }
        public ICollection<string> Valor { get; set; }
    }
}
