using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ApartmentManagementSystem.Core.Utilities
{
    public class Result : IResult
    {
        public Result(bool isSuccess, List<string> message) : this(isSuccess)
        {
            Message =  message ;
        }
        public Result(bool isSuccess, string message) : this(isSuccess) { 
            Message = new List<string> { message };
        }
        public Result(bool isSuccess)
        {
            IsSuccess = isSuccess;
        }
        public bool IsSuccess { get; }
        public List<string>? Message { get; set; }
    }
}
