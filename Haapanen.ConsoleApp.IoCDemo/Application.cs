using System;
using System.Collections.Generic;
using System.Text;
using Haapanen.ConsoleApp.IoCDemo.Services;

namespace Haapanen.ConsoleApp.IoCDemo
{
    public class Application
    {
        private readonly IExampleService _exampleService;
        private readonly CustomClass _customClass;

        public Application(IExampleService exampleService, CustomClass customClass)
        {
            _exampleService = exampleService;
            _customClass = customClass;
        }

        public void Run(string[] args)
        {
            Console.WriteLine(_exampleService.GetExample());
            _customClass.DoCustomStuff();
        }
    }
}
