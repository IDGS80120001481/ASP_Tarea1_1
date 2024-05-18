using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Apps_Razor_1._1.Pages
{
    public class ProgramaUnoModel : PageModel
    {
        [BindProperty]
        public string Peso { get; set; } = "";
        [BindProperty]
        public string Altura { get; set; } = "";
        public double imc;


        public void OnPost()
        {
            imc = double.Parse(Peso) / Math.Pow((double.Parse(Altura) / 100), 2);
            ModelState.Clear();
        }
}
}
