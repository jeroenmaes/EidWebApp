using EidShared;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EidWebApp.Pages
{
    public class EidModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public string Message { get; set; }

        public EidModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            Message = string.Empty;
        }
        public void OnPost()
        {
            Message = string.Empty;
                        
            var reader = new EidReader();
            var eid = reader.Read();
            var eidJson = eid.ToJson();

            Message = eidJson;
        }
    }
}