using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UPTEAM.Models;

namespace UPTEAM.Presentation.Web.Controllers
{
    public class BaseController : Controller
    {

        public ActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            return RedirectToAction("Index", "Home");
        }

        public ICollection<ErrosJson> ModelStateError(string key)
        {
            var result = from ms in ModelState
                         let id = ms.Key.Replace(key + ".", "")
                         let errors = ms.Value.Errors.Select(e => e.ErrorMessage).ToList()
                         from erro in errors
                         select new ErrosJson(id, errors);

            return result.ToList();
        }

        /// <summary>
        /// Remove do ModelState as validação de Atributos
        /// 
        /// </summary>
        /// <param name="ignoreKeys">Nomes dos atributos a ser removido da validação;</param>
        public void RemoveAttributeValidate(string[] ignoreKeys)
        {
            if (ignoreKeys == null) return;

            foreach (var key in ignoreKeys)
            {
                ModelState.Remove(key);
            }
        }
    }
}