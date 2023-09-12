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
        private readonly ApplicationDbContext _context;
        public IndexModel(ILogger<IndexModel> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;            
        }

        public void OnGet()
        {
            //generate a way for me to call the stored procedure
            //Q:how do i call this variable in the html?

            var nbaData = _context.NBADataStats.FromSqlRaw("EXEC CalculateNBAData").ToList();
            

        }
    }
}