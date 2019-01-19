using System;
using System.Collections.Generic;
using System.Text;

namespace Haapanen.ConsoleApp.IoCDemo.Services
{
    public class ExampleService : IExampleService
    {
        public string GetExample()
        {
            return "Example string";
        }
    }
}
