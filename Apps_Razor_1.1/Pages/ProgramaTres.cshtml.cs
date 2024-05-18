using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Apps_Razor_1._1.Pages
{
    public class ProgramaTresModel : PageModel
    {
        [BindProperty]
        public int a { get; set; } = 0;
        [BindProperty]
        public int b { get; set; } = 0;
        [BindProperty]
        public int x { get; set; } = 0;
        [BindProperty]
        public int y { get; set; } = 0;
        [BindProperty]
        public int n { get; set; } = 0;

        public double solucion_uno = 0;
        public double k0 = 0;
        public double k1 = 0;
        public double k2 = 0;

        public void OnPost()
        {
            solucion_uno = Math.Pow(((a * x) + (b * y)), n);
            

        }
    }
}
