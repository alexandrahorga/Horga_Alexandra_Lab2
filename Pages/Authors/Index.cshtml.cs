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
    public class IndexModel : PageModel
    {
        private readonly Horga_Alexandra_Lab2.Data.Horga_Alexandra_Lab2Context _context;

        public IndexModel(Horga_Alexandra_Lab2.Data.Horga_Alexandra_Lab2Context context)
        {
            _context = context;
        }

        public IList<Author> Author { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Author_1 != null)
            {
                Author = await _context.Author_1.ToListAsync();
            }
        }
    }
}
