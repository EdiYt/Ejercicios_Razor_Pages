using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Ejercicios_Razor_Pages.Pages
{
    public class programa1Model : PageModel
    {
        [BindProperty]
        public string peso { get; set; } = "";
        [BindProperty]
        public string altura { get; set; } = "";
        public float imc = 0;
        public void OnGet()
        {
        }

        public void OnPost()
        {
            float peso1 = Convert.ToSingle(peso);
            float altura1 = Convert.ToSingle(altura);

            imc = peso1 / (altura1 * altura1);

            ModelState.Clear();
        }
    }
}
