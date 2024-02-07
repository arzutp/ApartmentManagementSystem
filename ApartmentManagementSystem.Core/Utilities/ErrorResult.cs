using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagementSystem.Core.Utilities
{
    public class ErrorResult : Result
    {
        public ErrorResult(List<string> errors) : base(false, errors) { 
        }
        public ErrorResult(string message) : base(false, message)
        {
        }

        public ErrorResult() : base(false)
        {

        }
    }
}
