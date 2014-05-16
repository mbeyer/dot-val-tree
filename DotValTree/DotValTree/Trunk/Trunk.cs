using DotValTree.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DotValTree
{
    /// <summary>
    /// Describes the AND validation logic. The trunk holds multiple leafs all of which
    /// have to be validated with TRUE, in order for the trunk to be TRUE
    /// </summary>
    public class Trunk : ITrunk
    {
        public ICollection<Leaf> Leafs { get; set; }

        public void Validate(object obj, ValidationEventArgs args)
        {
            foreach(var element in Leafs)
            {
                if (element.Validate(args.CompareObject))
                    args.IsValid = true;
            }
        }
    }
}
