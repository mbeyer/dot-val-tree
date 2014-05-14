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

        /// <summary>
        /// Adds a validation trunk to the validator
        /// </summary>
        /// <param name="trunk">The trunk to add</param>
        void AddTrunk(Trunk trunk);

        /// <summary>
        /// Removes a validation trunk from the validator
        /// </summary>
        /// <param name="trunk">The trunk to remove</param>
        void RemoveTrunk(Trunk trunk);

        /// <summary>
        /// Returns all trunks that are held by the validator
        /// </summary>
        /// <returns></returns>
        ICollection<Trunk> GetAllTrunks();
    }
}
