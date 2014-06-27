using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotValTree.Provider.XML
{
    /// <summary>
    /// This class is an Entity Framework representation of the Validation class with the Validation tree represented as XML
    /// </summary>
    public class XmlValidationTree
    {
        /// <summary>
        /// Unique identifier set by the database
        /// </summary>
        public int ValidationId { get; set; }

        /// <summary>
        /// Free form field intended to describe the logic behind the built Validation tree
        /// </summary>
        public String Description { get; set; }

        /// <summary>
        /// The Validation tree in XML format
        /// </summary>
        public String Tree { get; set; }
    }
}
