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

        public Validator()
        {
            Trunks = new List<ITrunk>();
        }

        #region PUBLIC_METHODS

        public bool Validate(object obj)
        {
            var args = new ValidationEventArgs() { IsValid = false, CompareObject = obj };
            var handler = OnValidate;
            if (handler != null)
                handler(this, args);

            return args.IsValid;
        }

        public void AddTrunk(ITrunk trunk)
        {
            Trunks.Add(trunk);
            OnValidate += trunk.Validate;
        }

        public void RemoveTrunk(ITrunk trunk)
        {
            Trunks.Remove(trunk);
            OnValidate -= trunk.Validate;
        }
        #endregion
    }
}
