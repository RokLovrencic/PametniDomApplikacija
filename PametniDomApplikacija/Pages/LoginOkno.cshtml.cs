using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PametniDomAPP;
using System.Text.Json;

namespace PametniDomApplikacija.Pages
{
    public class LoginOknoModel : PageModel
    {
        [BindProperty]
        public string Naziv_Uporabnika { get; set; }

        [BindProperty]
        public string Geslo { get; set; }

        public IActionResult OnPostLogin()
        {
            if (ModelState.IsValid)
            {
                StockContext db = new StockContext();
                Uporabnik uporabnik = new Uporabnik
                {
                    uime = Naziv_Uporabnika,
                    geslo = Geslo
                };

                if (db.ObjectExists(Naziv_Uporabnika) && db.PasswordMatch(Geslo))
                {
                    uporabnik = db.UporabnikDB.FirstOrDefault(u => u.uime == Naziv_Uporabnika);


                    TempData["ObjectData"] = JsonSerializer.Serialize(uporabnik);

                    return RedirectToPage("/Moj_Profil", new { area = "", username = uporabnik.uime });
                }
            }

            return Page();
        }
    }
}

