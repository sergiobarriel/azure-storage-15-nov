using System;

namespace SkynetPI.Eye.DTO
{
    public class CreateCapture
    {
        public CreateCapture(Guid robotId, byte[] bytes, string extension = "jpg")
        {
            RobotId = robotId;
            Base64 = $"{ Convert.ToBase64String(bytes) }";
            Extension = extension;

            Helper.Message($"Capture created: { Helper.ConvertBytesToKb(bytes.LongLength) } Kb.");
        }

        public Guid RobotId { get; set; }
        public string Extension { get; set; }
        public string Base64 { get; set; }
    }
}
