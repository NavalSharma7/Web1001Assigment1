using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Web1001HW1.Pages
{
    public class IntroModel : PageModel
    {
        public void OnGet()
        {
            if (firstNo > 0 && secondNo > 0)
            {
                result = firstNo * secondNo;
                resultSet = true;
            }
        }

        [FromQuery(Name = "firstNo")]

        public int firstNo { get; set; }

        [FromQuery(Name = "secondNo")]

        public int secondNo{ get; set; }


        public int result { get; set; }

        public bool resultSet { get; set; }
    }
}
