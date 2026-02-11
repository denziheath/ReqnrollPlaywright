using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

//Runs both tests at the same time
[assembly:Parallelizable(ParallelScope.Fixtures)]

namespace ReqnrollPlaywright.Hooks
{
    [Binding]
    public class Hooks
    {

    }
}
