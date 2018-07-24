using ExampleCommon.Exceptions;
using ExampleCommon.Interfaces;

namespace ExampleRepo.Repositories
{
    public class ExampleRepo : IExampleRepository
    {
        public IExampleData GetBot(IStatusCheckRequest payload)
        {
            if (payload.sumData.Equals("killatron19Ca"))
            {
                ExampleDTO Example = new ExampleDTO();

                Example.routine = 17;
                Example.gummieBears = 4012;
                Example.recipients = 4;
                Example.mode = "giveaway";

                return Example;
            }
            throw new ExampleStatusNotFound();
        }
    }

    public interface IExampleRepository
    {
        IExampleData GetBot(IStatusCheckRequest payload);
    }
}