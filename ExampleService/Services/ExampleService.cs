using System.Collections.Generic;
using ExampleRepo.Repositories;
using ExampleCommon.Exceptions;
using ExampleCommon.Interfaces;

namespace ExampleService
{
    public class ExampleService : IExampleService
    {
        private IExampleRepository _ExampleRepository;

        private List<string> whitelist = new List<string>(new string[] { "markiemoo", "lakyluki", "neighbourino" });

        public ExampleService(IExampleRepository ExampleRepository)
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

                return _ExampleRepository.GetBot(payload);
            }

            throw new IllegalExampleUserException();
        }
    }

    public interface IExampleService
    {
        IExampleData StatusCheck(IStatusCheckRequest payload);
    }
}