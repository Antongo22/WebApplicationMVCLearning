using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TextEditorApp.Pages
{
    public class EditTextModel : PageModel
    {
        private static string _savedText = "";

        [BindProperty]
        public string Text { get; set; }

        public string SavedText => _savedText;

        public string Message { get; set; }

        public void OnGet()
        {
            Text = _savedText;
        }

        public IActionResult OnPost()
        {
            _savedText = Text;

            Message = "Text saved successfully!";

            return Page();
        }
    }
}
