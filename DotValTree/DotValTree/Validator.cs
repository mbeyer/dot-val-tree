using DotValTree.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotValTree
{
    public class Validator : IValidation
    {
        public delegate void ValidationEventHandler(object sender, ValidationEventArgs args);
        public event ValidationEventHandler OnValidate;
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<ITrunk> Trunks { get; set; }
        
        public bool Validate(object obj)
        {
            return false;
        }

        public void AddTrunk(ITrunk trunk)
        {
            Trunks.Add(trunk);
            OnValidate += trunk.Validate;
        }

        public void RemoveTrunk(ITrunk trunk)
        {
            throw new NotImplementedException();
        }

        public ICollection<ITrunk> GetAllTrunks()
        {
            throw new NotImplementedException();
        }
    }
}
