using System;

namespace pipelines_dotnet_core.Models
{   // test trigger
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
