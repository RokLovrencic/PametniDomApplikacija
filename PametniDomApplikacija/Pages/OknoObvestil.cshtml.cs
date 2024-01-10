using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PametniDomAPP;

namespace PametniDomApplikacija.Pages
{
    public class OknoObvestilModel : PageModel
    {


        public List<Obvestilo> ObvestilaList { get; set; }

        public int SteviloObvestil { get; set; }


        public void OnGet()
        {
            using (StockContext db = new StockContext())
            {
                ObvestilaList = db.ObvestiloDB.Include(o => o.Naprava).ToList();
                ViewData["SteviloObvestil"] = ObvestilaList.Count;
            }

          
        }
        public IActionResult OnPostDelete(int id)
        {
            using (StockContext db = new StockContext())
            {
                var notificationToDelete = db.ObvestiloDB.Find(id);
                if (notificationToDelete != null)
                {
                    db.ObvestiloDB.Remove(notificationToDelete);
                    db.SaveChanges();
                }
            }

            return RedirectToPage("/OknoObvestil");
        }





    }
}
