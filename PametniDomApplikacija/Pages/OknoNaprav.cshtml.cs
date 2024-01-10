using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PametniDomAPP;

namespace PametniDomApplikacija.Pages
{
    public class OknoNapravModel : PageModel
    {

 
        public string Ime_naprave { get; set; }

 
        public List<Naprava> NapraveList { get; set; }

        [BindProperty]
        public string Novo_Ime_naprave { get; set; }

        [BindProperty]
        public int EditNapravaId { get; set; }

      



        public void OnGet()
            {
                using (StockContext db = new StockContext())
                {
                    NapraveList = db.NapravaDB.ToList();
                }
            }

        


        public IActionResult OnPostRegister()
        {
            if (ModelState.IsValid)
            {
                StockContext db = new StockContext();
                Naprava naprava = new Naprava();
                naprava.n_ime = Novo_Ime_naprave;
                naprava.prvic_povezan = DateTime.Now;
   

                    db.NapravaDB.Add(naprava);
                    db.SaveChanges();
                    return RedirectToPage("/OknoNaprav");
                


             
            }

            return Page();
        }

        public IActionResult OnPostEdit()
        {
            if (ModelState.IsValid)
            {

                StockContext db = new StockContext();

                Naprava naprava = db.NapravaDB.FirstOrDefault(n => n.Id == EditNapravaId);

         
                if (naprava != null)
                {
                    naprava.n_ime = Novo_Ime_naprave;
                    db.SaveChanges();
                }

                return RedirectToPage("/OknoNaprav");
            }

            return Page();
        }
        public IActionResult OnPostDelete(int napravaId)
        {
            using (StockContext db = new StockContext())
            {
                Naprava napravaToDelete = db.NapravaDB.FirstOrDefault(n => n.Id == napravaId);

                if (napravaToDelete != null)
                {
                    db.NapravaDB.Remove(napravaToDelete);
                    db.SaveChanges();
                }

                return RedirectToPage("/OknoNaprav");
            }
        }


    }


}

