using System.Collections.Generic;

namespace WingtipToys.Api.Validation
{
    public class ErrorResponse
    {
        public List<ErrorModel> Errors { get; set; } = new List<ErrorModel>();
    }
}