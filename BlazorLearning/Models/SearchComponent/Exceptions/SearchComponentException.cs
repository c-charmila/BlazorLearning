using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorLearning.Models.SearchComponent.Exceptions
{
    public class SearchComponentException : Exception
    {
        public SearchComponentException(Exception innerException)
           : base("Error occurred, contact support.", innerException)
        { }
    }
}
