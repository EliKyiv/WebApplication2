using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace WebApplication2.Pages
{
    public class HobbiesModel : PageModel
    {
        public List<Hobby> Hobbies { get; set; }

        public void OnGet()
        {
            Hobbies = new List<Hobby>
        {
            new Hobby { Name = "Reading", Description = "I love reading books on a variety of topics." },
            new Hobby { Name = "Traveling", Description = "I enjoy exploring new places and cultures." },
            new Hobby { Name = "Playing music", Description = "I play the guitar and bass in my free time." }
        };
        }
    }
}
