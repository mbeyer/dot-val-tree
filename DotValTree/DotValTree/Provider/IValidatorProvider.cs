using DotValTree.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotValTree.Provider
{
    public interface IValidatorProvider
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Validator GetValidator(int id);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="node"></param>
        Validator SaveValidator(Validator node);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        void DeleteValidator(int id);
    }
}
