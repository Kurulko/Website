using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC_1.Models;
using MVC_1.Models.Database;
using MVC_1.Models.Abstract;

namespace MVC_1.Controllers
{
    public class TopController : Controller
    {
        IBTSMContext db;
        List<RatingSubject> ratingSubjects = new List<RatingSubject>();

        public TopController(IBTSMContext context)
        {
            db = context;
            for (int i = 0; i < db.HighMathScores.ToList().Count; i++)
            {
                ratingSubjects.Add(
                    new RatingSubject()
                    {
                        HighMath = db.HighMathScores.ToList()[i],
                        Philosophy = db.PhilosophyScores.ToList()[i],
                        KompBaza = db.KompBazaScores.ToList()[i],
                        Metrologia = db.MetrologiaScores.ToList()[i],
                        OTK = db.OTKScores.ToList()[i]
                    });
            }
        }
        public IActionResult Rating()
        {
            //List<IdRating> ratings = WhoTheBestRating.GetRating(ratingSubjects, db);
            //foreach (var item in ratings)
            //{
            //    db.Ratings.Add(item);
            //    db.SaveChanges();
            //}

            return View(db.Ratings.ToList());
        }
    }
}
