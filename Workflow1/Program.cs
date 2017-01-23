using System;
using System.Linq;
using System.Activities;
using System.Activities.Statements;

namespace Workflow1
{

    class Program
    {
        static void Main(string[] args)
        {
            Activity workflow1 = new Activity1();
            WorkflowInvoker.Invoke(workflow1);
            Console.WriteLine("Press ENTER to quit");
            Console.ReadLine();
        }
    }
}
