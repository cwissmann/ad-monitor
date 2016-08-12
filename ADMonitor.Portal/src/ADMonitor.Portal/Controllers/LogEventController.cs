using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ADMonitor.Portal.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Logging;

namespace ADMonitor.Portal.Controllers
{
    [Authorize]
    public class LogEventController : Controller
    {
        private readonly ApplicationDbContext dbContext;
        private readonly ILogger logger;

        public LogEventController(ApplicationDbContext dbContext, ILoggerFactory loggerFactory)
        {
            this.dbContext = dbContext;
            this.logger = loggerFactory.CreateLogger<LogEventController>();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult UserLogEvents(string user)
        {
            if (ModelState.IsValid)
            {
                var filter = "duda";

                var logEvents = dbContext.LogEvents.Where(u => u.User.Equals(filter)).ToList();
            }

            return View();
        }
    }
}