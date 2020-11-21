using System.Collections.Generic;

namespace WingtipToys.Web.Mvc.ValidationErrors
{
    public class ErrorResponse
    {
        public List<ErrorModel> Errors { get; set; } = new List<ErrorModel>();
    }
}
