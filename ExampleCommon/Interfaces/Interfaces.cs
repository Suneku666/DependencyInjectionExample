namespace ExampleCommon.Interfaces
{
    public interface IStatusCheckRequest
    {
        string auth { get; set; }
        string user { get; set; }
        string sumData { get; set; }
    }

    public interface IExampleData
    {
        int gunTemp { get; set; }
        int rounds { get; set; }
        int targets { get; set; }
        string mode { get; set; }
    }

}