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
        int routine { get; set; }
        int gummieBears { get; set; }
        int recipients { get; set; }
        string mode { get; set; }
    }

}