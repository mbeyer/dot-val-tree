using DotValTree.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotValTree
{
    /// <summary>
    /// A Validator checks class properties based on underlying criteria that are organized in a tree-structure
    /// </summary>
    public class Validator
    {
        /// <summary>
        /// The unique identifier
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Free-form field describing the logic of the tree accessed with RootNode.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The root node of the Validation tree
        /// </summary>
        public Node RootNode { get; set; }

        /// <summary>
        /// Validates the given objects based on the criteria that has been added with the RootNode object
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public bool Validate(object obj)
        {
            return RootNode.Validate(obj);
        }
    }
}
