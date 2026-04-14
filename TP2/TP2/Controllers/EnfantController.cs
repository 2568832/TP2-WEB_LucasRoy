using Microsoft.AspNetCore.Mvc;
using TP2.Models;

namespace TP2.Controllers
{
    public class EnfantController : Controller
    {
        private BaseDeDonnees _baseDeDonnees { get; set; }

        public EnfantController(BaseDeDonnees baseDeDonnees) 
        { 
            _baseDeDonnees = baseDeDonnees;
        }
        [Route("/Enfant/Recherche")]

        public IActionResult Recherche()
        {

            return View( _baseDeDonnees.Carte_Graphiques.ToList());
        }

        [Route("/Enfant/Detail/{id:int}")]
        [Route("/Enfant/{id:int}")]
        [Route("/{id:int}")]

        public IActionResult Detail(int id)
        {
            var objSelectionné = _baseDeDonnees.Carte_Graphiques.Where(p => p.ID == id).SingleOrDefault();
            if (objSelectionné == null)
            {
                return View("NonTrouve","Le numéro de la carte n'a pas été trouvé!");
            }
            else
            {
                return View(objSelectionné);

            }
        }


        [Route("/Enfant/Detail/{name}")]
        [Route("/Enfant/{name}")]
        [Route("/{name}")]
        public IActionResult Detail(string name)
        {
            var objSelectionné = _baseDeDonnees.Carte_Graphiques.Where(p => p.Nom == name).SingleOrDefault();
            if (objSelectionné == null)
            {
                return View("NonTrouve", "Le numéro de la carte n'a pas été trouvé!");
            }
            else
            {
                return View(objSelectionné);

            }
        }

    }
}
