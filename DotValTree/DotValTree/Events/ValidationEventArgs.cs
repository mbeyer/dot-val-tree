using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotValTree.Events
{
    public class ValidationEventArgs : EventArgs
    {
        public bool IsValid { get; set; }

        public ValidationEventArgs()
        {
            IsValid = false;
        }
    }
}
