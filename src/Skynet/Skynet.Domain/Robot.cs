using System.Collections.Generic;
using Skynet.Domain.CrossModels.Enums;

namespace Skynet.Domain
{
    public class Robot : Base
    {
        public Robot() : base()
        {
            Captures = new HashSet<Capture>();
        }

        public Model Model { get; set; }

        public virtual ICollection<Capture> Captures { get; set; }
    }
}
