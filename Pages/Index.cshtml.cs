using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace azureapp_swar.Pages;

public class IndexModel : PageModel
{
    public readonly ILogger<IndexModel> ILogger;
    private readonly IConfiguration _configuration;
    public IndexModel( ILogger<IndexModel> logger , IConfiguration configuration)
    {
        ILogger = logger;
        this._configuration = configuration;
        // GreetingMessage = _configuration["Greeting"];
    }
    public void OnGet()
    {
        ViewData["GreetingMessage"] = _configuration["Greeting"];
    }
}
