﻿using Backend.Models;
using System.Linq;
using System.Web.Mvc;

namespace Backend.Controllers
{
    public class GenericController : Controller
    {
        private DataContextLocal db = new DataContextLocal();

        public JsonResult GetTeams(int leagueId)
        {
            db.Configuration.ProxyCreationEnabled = false;
            var teams = db.Teams.Where(m => m.LeagueId == leagueId).OrderBy(t => t.Name);
            return Json(teams);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

    }
}