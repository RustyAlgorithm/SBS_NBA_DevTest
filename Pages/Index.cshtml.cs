using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using SBS_NBA_DavTest.Context;
using SBS_NBA_DavTest.Models;

namespace SBS_NBA_DavTest.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        //public List<NBATeam> NBATeams { get; set; }

        public void OnGet()
        {
            using (var dbContext = new ApplicationDbContext())
            {
                var nbaData = dbContext.NBATeams.FromSqlRaw("EXEC CalculateNBAData").ToList();
            }

        }
    }
}