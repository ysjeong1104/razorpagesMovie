using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Data;
using RazorPagesMovie.Models;

namespace RazorPagesMovie.Pages.Actors
{
    public class DetailsModel : PageModel
    {
        private readonly RazorPagesMovie.Data.RazorPagesActorContext _context;

        public DetailsModel(RazorPagesMovie.Data.RazorPagesActorContext context)
        {
            _context = context;
        }

        public Actor Actor { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var actor = await _context.Actor.FirstOrDefaultAsync(m => m.Id == id);
            if (actor == null)
            {
                return NotFound();
            }
            else
            {
                Actor = actor;
            }
            return Page();
        }
    }
}
