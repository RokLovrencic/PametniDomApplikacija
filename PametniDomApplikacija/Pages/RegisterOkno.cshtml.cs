using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PametniDomAPP;

namespace PametniDomApplikacija.Pages
{
    public class RegisterOknoModel : PageModel
    {
 
            [BindProperty]
            public string Naziv_Uporabnika { get; set; }

            [BindProperty]
            public string Geslo { get; set; }

            [BindProperty]
            public string pGeslo { get; set; }

            [BindProperty]
            public string Enaslov { get; set; }


            public void OnGet()
            {
            }


            public IActionResult OnPostRegister()
            {
                if (ModelState.IsValid)
                {
                    StockContext db = new StockContext();
                    Uporabnik uporabnik = new Uporabnik();
                    uporabnik.uime = Naziv_Uporabnika;
                    uporabnik.geslo = Geslo;
                    uporabnik.uenaslov = Enaslov;
                

                    if (!db.ObjectExists(Naziv_Uporabnika))
                    {
                        db.UporabnikDB.Add(uporabnik);
                        db.SaveChanges();
                        return RedirectToPage("/Index");
                    }
                    

                else { 

                    throw new Exception("Uporabnik obstaja!"); 
                    }
                }

                return Page();
            }
        }
    }

