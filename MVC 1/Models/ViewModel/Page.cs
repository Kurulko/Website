using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_1.Models.ViewModel
{
    public class Page
    {
        public int PageNumber { get; set; }
        public int TotalPage { get; set; }
        public Page(int count, int sizePage, int pageNumber)
        {
            PageNumber = pageNumber;
            TotalPage = (int)Math.Ceiling((double)count / sizePage);
        }
        public bool IsNextPage { 
            get 
            {
                return PageNumber < TotalPage;
            } 
        }
        public bool IsPreviousPage
        { 
            get 
            {
                return PageNumber > 1;
            } 
        }
    }
}
