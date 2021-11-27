using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC_1.Models.Data;
using MVC_1.Models.Rating;
using MVC_1.Models.Abstract;
using MVC_1.Models.Database;
using Microsoft.EntityFrameworkCore;

namespace MVC_1.Controllers
{
    public class RatingController : Controller
    {
        IBTSMContext db;
        List<RatingSubject> ratingSubjects = new List<RatingSubject>();

        public RatingController(IBTSMContext context)
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
        public IActionResult Subjects() => View(new RatingAndLinks(ratingSubjects, db));
    }
    public class RatingAndLinks
    {
        public IBTSMContext db { get; set; }
        public List<RatingSubject> ratingSubjects { get; set; }
        public RatingAndLinks(List<RatingSubject> ratingSubjects, IBTSMContext db)
        {
            this.ratingSubjects = ratingSubjects;
            this.db = db;
        }
    }
}
