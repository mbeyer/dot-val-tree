using DotValTree.Nodes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotValTree.Persistence
{
    public interface IAbstractNodeStorageProvider
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        AbstractNode GetNode(int id);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="node"></param>
        AbstractNode SaveNode(AbstractNode node);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        void DeleteNode(int id);
    }
}
