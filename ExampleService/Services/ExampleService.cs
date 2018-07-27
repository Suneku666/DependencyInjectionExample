using System.Collections.Generic;
using ExampleRepo.Repositories;
using ExampleCommon.Exceptions;
using ExampleCommon.Interfaces;
using ExampleRepo;

namespace ExampleService
{
    public class ExampleService : IExampleService
    {
        private ExampleRepo.Repositories.ExampleRepo _ExampleRepository;

        private List<string> whitelist = new List<string>(new string[] { "markiemoo", "lakyluki", "neighbourino" });

        public ExampleService(ExampleRepo.Repositories.ExampleRepo ExampleRepository)
        {
            this._ExampleRepository = ExampleRepository;
        }

        public IExampleData StatusCheck(IStatusCheckRequest payload)
        {
            if(payload != null) { 
                if (!whitelist.Contains(payload.user))
                {
                    throw new IllegalExampleUserException();
                }

                return _ExampleRepository.GetSumData(payload);
            }

            throw new IllegalExampleUserException();
        }
    }

    public interface IExampleService
    {
        IExampleData StatusCheck(IStatusCheckRequest payload);
    }
}