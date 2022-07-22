using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ASP_NET_HW_Module_01_part_01.Pages.Tasks
{
    public class Task1Model : PageModel
    {
        public string NumberDay = DateTime.Now.DayOfYear.ToString();

        public void OnGet()
        {
           
        }
    }
}
