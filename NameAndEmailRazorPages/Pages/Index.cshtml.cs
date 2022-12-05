using System.Globalization;
using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace NameAndEmailRazorPages.Pages;

public class IndexModel : PageModel
{
    
    public string? Name;
    public string? Email;
    
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
        if (!string.IsNullOrEmpty(Request.Form["Name"]))
        {
            Name = Request.Form["Name"];
        }
        else
        {
            ViewData["Response"] = "No Name Provided, Please Provide a Name!";
            return;
        }

        if (!string.IsNullOrEmpty(Request.Form["Email"]))
        {
            Email = Request.Form["Email"];
        }
        else
        {
            ViewData["Response"] = "No Email Provided, Please Provide An Email!";
            return;
        }

        ViewData["Response"] = $"Welcome {Name} To The Website!";
    }
}