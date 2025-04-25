using System.Reflection;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Lecture47.Pages
{
    public class Index1Model : PageModel
    {
        public string DayName { get; set; } = string.Empty;
        public string CurrentTime { get; set; } = string.Empty;
        public void OnGet()
        {
            DayName = System.DateTime.Now.ToString("dddd");
            CurrentTime = System.DateTime.Now.ToString();

        }
    }
}
