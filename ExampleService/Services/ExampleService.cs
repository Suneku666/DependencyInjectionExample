using System.Collections.Generic;
using ExampleRepo.Repositories;
using ExampleCommon.Exceptions;
using ExampleCommon.Interfaces;

namespace ExampleService
{
    public class ExampleService
    {
        private ExampleRepo.Repositories.ExampleRepo _ExampleRepository;

        private List<string> whitelist = new List<string>(new string[] { "markiemoo", "lakyluki", "neighbourino" });

        public ExampleService()
        {
            this._ExampleRepository = new ExampleRepo.Repositories.ExampleRepo();
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
}