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

                Example.gunTemp = 17;
                Example.rounds = 4012;
                Example.targets = 0;
                Example.mode = "aggressive/overkill";

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