using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Diagnostics;

namespace TP3_DotNet.Controllers
{
    public class DocumentsController : Controller
    {
        public IActionResult Liste(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                id = "";
            }
            Console.WriteLine(id);
            Models.Documents listfile = new Models.Documents();
            ViewData["Documents"] = listfile.GetListeDocuments().FindAll(c => c.Extension.Contains(id));
            return View();
        }
    }
}
