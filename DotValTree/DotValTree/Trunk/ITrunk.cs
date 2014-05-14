using DotValTree.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotValTree
{
    public interface ITrunk
    {
        /// <summary>
        /// Validate pre-configured properties of a given object
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        void Validate(object sender, ValidationEventArgs args);
    }
}
