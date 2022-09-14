using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ProyectoCiclo3.App.Persistencia.AppRepositorios;
using ProyectoCiclo3.App.Dominio;
 
namespace ProyectoCiclo3.App.Frontend.Pages
{
    public class DetailsRutaModel : PageModel
    {
        #region constructor
        private readonly RepositorioRutas repositorioRutas;
        public Dominio.Rutas Ruta {get;set;}
        
        #endregion
        public DetailsRutaModel(RepositorioRutas repositorioRutas)
       {
            this.repositorioRutas=repositorioRutas;
       }
 
        public IActionResult OnGet(int rutaId)
        {
            Ruta=repositorioRutas.GetWithId(rutaId);
            return Page();
 
        }
    }
}