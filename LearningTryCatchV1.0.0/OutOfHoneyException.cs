using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningTryCatchV1._0._0
{
    class OutOfHoneyException: System.Exception //creating own exception
    {
        public OutOfHoneyException(string message) : base(message) { }
    }
}
