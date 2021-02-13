using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPageMove.Data;
using RazorPageMove.Models;

namespace RazorPageMove.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly RazorPageMove.Data.RazorPagesMoveContext _context;

        public IndexModel(RazorPageMove.Data.RazorPagesMoveContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
