using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UPTEAM.Models
{
    public class JsonResult<T>
    {
        public JsonResult()
        {
            Erros = new List<ErrosJson>();
        }
        public ICollection<ErrosJson> Erros { get; set; }
        public ICollection<string> Msgs { get; set; }
        public T Src { get; set; }
        public bool Sucesso { get { return !Erros.Any(); } }
    }
}
