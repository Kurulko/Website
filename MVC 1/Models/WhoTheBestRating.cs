using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVC_1.Models.Data;
using MVC_1.Models.Database;
using MVC_1.Models.Abstract;

namespace MVC_1.Models
{
    public class WhoTheBestRating
    {
        private static void SumOfList(string collection,ref int sum)
        {
            string[] array = collection.Split(',');
            byte[] collectionOfBytes = new byte[array.Length];

            for (int i = 0; i < array.Length; i++)
                byte.TryParse(array[i],out collectionOfBytes[i]);

            foreach (var item in collectionOfBytes)
                sum += item;
        }
        public static List<IdRating> GetRating(List<RatingSubject> ratingSubjects,IBTSMContext db)
        {
            List<int> sums = new List<int>();

            foreach (var item in ratingSubjects)
            {
                int sum = 0;

                SumOfList(item.HighMath.SR, ref sum);
                SumOfList(item.Philosophy.Seminar, ref sum);
                SumOfList(item.KompBaza.KR, ref sum);
                SumOfList(item.KompBaza.Laba, ref sum);
                SumOfList(item.Metrologia.DZ, ref sum);
                SumOfList(item.Metrologia.KR, ref sum);
                SumOfList(item.Metrologia.Laba, ref sum);
                SumOfList(item.OTK.DZ, ref sum);
                SumOfList(item.OTK.KR, ref sum);
                SumOfList(item.OTK.Laba, ref sum);

                sums.Add(sum);
            }

            List<IdRating> ratings = new List<IdRating>();

            for (int i = 0; i < sums.Count; i++)
                ratings.Add(new IdRating()
                {
                    //Id = db.Students.ToList()[i].Id,
                    Name = db.Students.ToList()[i].LastName + " " + db.Students.ToList()[i].FirstName,
                    Sum = sums[i]
                }); 

            ratings.Sort((IdRating sum1, IdRating sum2) => sum2.Sum.CompareTo(sum1.Sum));


            return /*db.Ratings.ToList()*/ratings;
        }
    }
}
