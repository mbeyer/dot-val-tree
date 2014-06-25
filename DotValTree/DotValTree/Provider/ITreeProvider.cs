using DotValTree.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotValTree.Provider
{
    public interface ITreeProvider
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        AbstractNode GetTree(int id);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="node"></param>
        AbstractNode SaveTree(AbstractNode node);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        void DeleteTree(int id);
    }
}
