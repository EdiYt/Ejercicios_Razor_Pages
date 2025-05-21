using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Ejercicios_Razor_Pages.Pages
{
    public class programa2Model : PageModel
    {
        [BindProperty]
        public string Mensaje { get; set; } = "";

        [BindProperty]
        public int Desplazamiento { get; set; } = 3;

        [BindProperty]
        public string Accion { get; set; } = "cifrar";

        public string Resultado { get; set; } = "";

        private const string Alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        public void OnGet()
        {
        }

        public void OnPost()
        {
            if (Accion == "cifrar")
            {
                Resultado = Cifrar(Mensaje.ToUpper(), Desplazamiento);
            }
            else
            {
                Resultado = Descifrar(Mensaje.ToUpper(), Desplazamiento);
            }
        }

        private string Cifrar(string texto, int n)
        {
            string resultado = "";
            foreach (char c in texto)
            {
                if (Alfabeto.Contains(c))
                {
                    int indice = (Alfabeto.IndexOf(c) + n) % 26;
                    resultado += Alfabeto[indice];
                }
                else
                {
                    resultado += c;
                }
            }
            return resultado;
        }

        private string Descifrar(string texto, int n)
        {
            string resultado = "";
            foreach (char c in texto)
            {
                if (Alfabeto.Contains(c))
                {
                    int indice = (Alfabeto.IndexOf(c) - n + 26) % 26;
                    resultado += Alfabeto[indice];
                }
                else
                {
                    resultado += c;
                }
            }
            return resultado;
        }
    }
}
