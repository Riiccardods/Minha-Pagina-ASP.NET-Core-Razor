using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

public class IndexModel : PageModel
{
    [BindProperty]
    public string Mensagem { get; set; } = "OLA";

    public void OnGet()
    {
    }

    public async Task<IActionResult> OnPostAsync(string novaMensagem)
    {
        if (!string.IsNullOrWhiteSpace(novaMensagem))
        {
            Mensagem = novaMensagem;
        }

        return Page();
    }
}
