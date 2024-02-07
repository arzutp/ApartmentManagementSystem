using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentManagementSystem.Core.Utilities
{
    public interface IResult
    {
        bool IsSuccess { get; }
        //string Message { get; }
        public List<string>? Message { get; set; }
    }
}
