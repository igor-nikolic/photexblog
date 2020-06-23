using Application.UseCase;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Implementation.Loggers
{
    public class ConsoleLogger : IUseCaseLogger
    {
        public void Log(IUseCase useCase, object useCaseData)
        {
            Console.WriteLine($"{DateTime.Now} - {useCase.Name} - {JsonConvert.SerializeObject(useCaseData)}");
        }
    }
}
