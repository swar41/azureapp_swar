using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using azureapp_swar.Data;
using azureapp_swar.Models;

namespace azureapp_swar.Pages_Persons
{
    public class IndexModel : PageModel
    {
        private readonly azureapp_swar.Data.AppDbContext _context;

        public IndexModel(azureapp_swar.Data.AppDbContext context)
        {
            _context = context;
        }

        public IList<Person> Person { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Person = await _context.Persons.ToListAsync();
        }
    }
}
