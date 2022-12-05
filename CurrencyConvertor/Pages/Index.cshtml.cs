using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CurrencyConvertor.Pages;

public class IndexModel : PageModel
{
    [BindProperty]
    public double? Amount { get; set; }

    [BindProperty]
    public string Currency { get; set; } = string.Empty;
    
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
    }

    public void OnPost()
    {
        
        
        if (Amount == null)
        {
            ViewData["Response"] = "Missing Amount, Please Input an Amount.";
            return;
        }
        
        switch (Currency)
        {
            case "EUR":
                ViewData["Response"] = $"Converted £{Amount} GBP To €{Math.Round((double) (Amount! * 1.17), 2)} EUR.";
                break;
            case "USD":
                ViewData["Response"] = $"Converted £{Amount} GBP To ${Math.Round((double) (Amount! * 1.23), 2)} USD.";
                break;
            case "AUD":
                ViewData["Response"] = $"Converted £{Amount} GBP To ${Math.Round((double) (Amount! * 1.81), 2)} AUD.";
                break;
            default:
                ViewData["Response"] = "Missing Currency, Please Select a Currency.";
                break;
        }
    }
}