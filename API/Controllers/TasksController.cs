using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using App = API.Entities;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")] // https://localhost:5001/api/tasks
    public class TasksController(AppDbContext context) : Controller
    {
        [HttpGet]
        public async Task<ActionResult<List<App.Task>>> GetTasks()
        {
            return await context.Tasks.ToListAsync();
        }

        [HttpGet("{id}")] // https://localhost:5001/api/tasks/1
        public async Task<ActionResult<App.Task>> GetTask(int id)
        {
            var task = await context.Tasks.FindAsync(id);

            if (task == null) return NotFound();

            return task;
        }
    }
}