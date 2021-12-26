using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistance;

namespace API.Controllers
{
  
    public class ActivitiesController : BaseApiController
    {
        private readonly DataContext _context;

        public ActivitiesController(DataContext context)
        {
            this._context = context;

            var str ="";
        }

        [HttpGet]
        public async Task<ActionResult<List<Activity>>> GetActivties(){
            
            return await _context.Activities.ToListAsync();
        }

        [HttpGet("{id}")] //activity/id
        public async Task<ActionResult<Activity>> GetActivties(Guid id){
            
            return await _context.Activities.FindAsync(id);
        }

    }
}