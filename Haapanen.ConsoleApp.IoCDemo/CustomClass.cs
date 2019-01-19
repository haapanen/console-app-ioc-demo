using System;
using System.Collections.Generic;
using System.Text;
using Haapanen.ConsoleApp.IoCDemo.Services;

namespace Haapanen.ConsoleApp.IoCDemo
{
    public class CustomClass
    {
        private readonly IExampleService _exampleService;

        public CustomClass(IExampleService exampleService)
        {
            _exampleService = exampleService;
        }

        public void DoCustomStuff()
        {
            Console.WriteLine("Stuff");
            Console.WriteLine("Let's also print example: " + _exampleService.GetExample());
        }
    }
}
