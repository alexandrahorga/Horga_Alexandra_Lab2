﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Horga_Alexandra_Lab2.Data;
using Horga_Alexandra_Lab2.Models;

namespace Horga_Alexandra_Lab2.Pages.Authors
{
    public class DeleteModel : PageModel
    {
        private readonly Horga_Alexandra_Lab2.Data.Horga_Alexandra_Lab2Context _context;

        public DeleteModel(Horga_Alexandra_Lab2.Data.Horga_Alexandra_Lab2Context context)
        {
            _context = context;
        }

        [BindProperty]
      public Author Author { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Author_1 == null)
            {
                return NotFound();
            }

            var author = await _context.Author_1.FirstOrDefaultAsync(m => m.ID == id);

            if (author == null)
            {
                return NotFound();
            }
            else 
            {
                Author = author;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Author_1 == null)
            {
                return NotFound();
            }
            var author = await _context.Author_1.FindAsync(id);

            if (author != null)
            {
                Author = author;
                _context.Author_1.Remove(Author);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
