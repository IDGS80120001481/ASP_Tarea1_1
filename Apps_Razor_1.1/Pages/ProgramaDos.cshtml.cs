using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Apps_Razor_1._1.Pages
{
    public class ProgramaDosModel : PageModel
    {
        [BindProperty]
        public string frase { get; set; } = "";
        [BindProperty]
        public string opcion { get; set; } = "";
        [BindProperty]
        public int n { get; set; } = 0;
        public char[] alfabeto = {'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'X', 'Y', 'Z'};
        public string encriptada = "";

        public void OnPost()
        {

            frase = frase.ToUpper();
            if (opcion == "Encriptar")
            {
                for (int i = 0; i < frase.Length; i++)
                {
                    int index = Array.IndexOf(alfabeto, frase[i]);

                    if (index != -1)
                    {
                        index = (index + n) % alfabeto.Length;
                        encriptada += alfabeto[index];
                    }
                    else
                    {
                        encriptada += ' ';
                    }
                }
            }
            else 
            {
                for (int i = 0; i < frase.Length; i++)
                {
                    int index = Array.IndexOf(alfabeto, frase[i]);

                    if (index != -1)
                    {
                        index = (index - n + alfabeto.Length) % alfabeto.Length;
                        encriptada += alfabeto[index];
                    }
                    else
                    {
                        encriptada += ' ';
                    }
                }
            }
        }
    }
}
