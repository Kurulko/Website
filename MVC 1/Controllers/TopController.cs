using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC_1.Models;
using MVC_1.Models.Database;
using MVC_1.Models.Abstract;
using MVC_1.Sort;
using MVC_1.Models.ViewModel;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace MVC_1.Controllers
{
    [Authorize]
    public class TopController : Controller
    {
        IBTSMContext db;
        public TopController(IBTSMContext context)
        {
            db = context;
        }

        [HttpGet]
        public IActionResult Rating(IEnumerable<IdRating> ratings, string name, SortIdRating sort = SortIdRating.ResultDesc)
        {
            if (ratings == null || ratings.Count() == 0)
                ratings = WhoTheBestRating.GetRating(
                    db.Students
                    .Include(s => s.Person)
                    .Include(s => s.HighMath)
                    .Include(s => s.KompBaza)
                    .Include(s => s.Metrologia)
                    .Include(s => s.OTK)
                    .Include(s => s.Philosophy)
                    .ToList());

            if (name != null)
                ratings = ratings.Where(a => a.Name.Contains(name)).ToList();

            ViewData["SortName"] = sort == SortIdRating.NameAsc ? SortIdRating.NameDesc : SortIdRating.NameAsc;
            ViewData["SortResult"] = sort == SortIdRating.ResultAsc ? SortIdRating.ResultDesc : SortIdRating.ResultAsc;

            ratings = sort switch
            {
                SortIdRating.NameAsc => ratings.OrderBy(n => n.Name).ToList(),
                SortIdRating.NameDesc => ratings.OrderByDescending(n => n.Name).ToList(),
                SortIdRating.ResultAsc => ratings.OrderBy(n => n.Sum).ToList(),
                SortIdRating.ResultDesc => ratings.OrderByDescending(n => n.Sum).ToList(),
                _ => (List<IdRating>)ratings.OrderByDescending(n => n.Sum).ToList()
            };
            RatingsAndSelected ratingsAndSelected = new RatingsAndSelected()
            {
                Ratings = ratings,
                Selected = new Selected() { Name = name, SortIdRating = sort }
            };
            return View(ratingsAndSelected);
        }
    }
}
