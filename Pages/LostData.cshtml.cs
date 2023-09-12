using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SBS_NBA_DavTest.Pages
{
    public class LostDataModel : PageModel
    {
        public void OnGet()
        {
            // Logic to fetch the "Lost" data from your database or source
            var lostData = new
            {
                labels = new[] { "Team A", "Team B", "Team C" }, // Example team names
                values = new[] { 10, 15, 8 } // Example "Lost" data
            };

            // Serialize and store the "Lost" data in a page property
            ViewData["LostData"] = lostData;
        }

    }
}
