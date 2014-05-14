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
        public ICollection<Trunk> Trunks { get; set; }
        
        public bool Validate(object obj)
        {
            return false;
        }

        public void AddTrunk(Trunk trunk)
        {
            throw new NotImplementedException();
        }

        public void RemoveTrunk(Trunk trunk)
        {
            throw new NotImplementedException();
        }

        public ICollection<Trunk> GetAllTrunks()
        {
            throw new NotImplementedException();
        }
    }
}
