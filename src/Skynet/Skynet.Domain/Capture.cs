using System;

namespace Skynet.Domain
{
    public class Capture : Base
    {
        public Capture() : base()
        {

        }

        public Capture(Guid robotId) : base()
        {
            RobotId = robotId;
        }

        public string Path { get; set; }
        public string BlobId { get; set; }

        public Guid RobotId { get; set; }
        public virtual Robot Robot { get; set; }        
    }
}
