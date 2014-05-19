using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotValTree
{
    public interface IValidation
    {
        /// <summary>
        /// Validates a given object based on pre-configured property values
        /// </summary>
        /// <param name="obj">The object to be validated</param>
        /// <returns>True if the object is valid, otherwise false</returns>
        bool Validate(object obj);
    }
}
