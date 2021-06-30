using System;

namespace pipelines_dotnet_core.Models
{   // test trigger 1
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
