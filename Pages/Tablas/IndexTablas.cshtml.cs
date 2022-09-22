using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPagesMovie44.Pages.Tablas;

public class IndexTablasModel : PageModel
{
    private readonly ILogger<IndexTablasModel> _logger;

    public IndexTablasModel(ILogger<IndexTablasModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }
}

