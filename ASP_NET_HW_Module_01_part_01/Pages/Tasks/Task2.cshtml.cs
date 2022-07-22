using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASP_NET_HW_Module_01_part_01.Pages.Tasks
{
    public class Task2Model : PageModel
    {
        public char GetRandomLetter()
        {
            var rnd = new Random();
            var letter = ((char)rnd.Next(65, 90));

            return letter;
        }

        

        public void OnGet()
        {
        }
    }
}
