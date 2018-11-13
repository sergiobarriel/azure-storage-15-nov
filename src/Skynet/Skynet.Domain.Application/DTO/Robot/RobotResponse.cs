using System;
using Skynet.Domain.CrossModels.Enums;

namespace Skynet.Domain.Application.DTO.Robot
{
    public class RobotResponse
    {
        public Guid Id { get; set; }
        public Model Model { get; set; }
        public int Captures { get; set; }
    }
}
