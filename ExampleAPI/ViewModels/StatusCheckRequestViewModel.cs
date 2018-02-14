using ExampleCommon.Interfaces;


namespace ExampleAPI.ViewModels
{
    public class StatusCheckRequestViewModel : IStatusCheckRequest
    {
        public string auth { get; set; }
        public string user { get; set; }
        public string sumData { get; set; }
    }
}