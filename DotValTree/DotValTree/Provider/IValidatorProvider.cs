using DotValTree.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotValTree.Provider
{
    /// <summary>
    /// Provides a contract for instance providing classes that manage Validators.
    /// </summary>
    public interface IValidatorProvider
    {
        /// <summary>
        /// Retrieve an instance of Validator from the underlying persistence layer
        /// </summary>
        /// <param name="id">The unique identifier for the instance</param>
        /// <returns></returns>
        Validator GetValidator(int id);

        /// <summary>
        /// Saves an instance of Validator to the underlying persistence layer
        /// </summary>
        /// <param name="node">The instance to persist.</param>
        Validator SaveValidator(Validator validator);

        /// <summary>
        /// Deletes an instance of Validator from the underlying persistence layer
        /// </summary>
        /// <param name="id">The unique identifier for the instance</param>
        void DeleteValidator(int id);
    }
}
