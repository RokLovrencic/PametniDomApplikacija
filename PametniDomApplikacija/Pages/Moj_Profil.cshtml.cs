using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PametniDomAPP;
using System.Text.Json;

namespace PametniDomApplikacija.Pages
{
    public class Moj_ProfilModel : PageModel
    {
        public Uporabnik loggedUser { get; set; }



        public void OnGet()
        {
            var json = TempData.Peek("ObjectData") as string;
            Console.WriteLine(json);
            if (!string.IsNullOrEmpty(json))
            {
                loggedUser = JsonSerializer.Deserialize<Uporabnik>(json);
            }
        
            loggedUser ??= new Uporabnik { uime = "DefaultUsername" };
            System.Diagnostics.Debug.WriteLine($"OnGet - Username: {loggedUser.uime}");

        
        }
    }

}
