using System;
using System.Collections.Generic;
using Skynet.Domain;
using Skynet.Domain.CrossModels.Enums;

namespace Skynet.Infrastructure.Persistence.Data
{
    public static class RobotRepository
    {
        public static Robot[] Get()
        {
            return new List<Robot>()
            {
                new Robot()
                {
                    Id = new Guid("8d225a2f-2bed-45a6-ae73-b756e1528948"),
                    Model = Model.T800
                },
                new Robot()
                {
                    Id = new Guid("53386d46-fe61-4487-89f0-29664276c3a6"),
                    Model = Model.T1
                },
                new Robot()
                {
                    Id = new Guid("40860581-1be3-4f28-b131-96ad5fb65d23"),
                    Model = Model.T1000
                },
                new Robot()
                {
                    Id = new Guid("2cc291e3-2930-4cbf-affa-e820ffd56cff"),
                    Model = Model.Tx
                },
                new Robot()
                {
                    Id = new Guid("aa90f569-ca56-440c-beee-5fc951921992"),
                    Model = Model.T400
                },
                new Robot()
                {
                    Id = new Guid("bb0296d1-0482-4ff8-a7c3-d856feb1eed6"),
                    Model = Model.T500
                },
                new Robot()
                {
                    Id = new Guid("801c58bc-4a32-42fd-b536-2672513db4de"),
                    Model = Model.T700
                },
                new Robot()
                {
                    Id = new Guid("7b851a63-c544-4fad-a015-6204a3da66ad"),
                    Model = Model.T1000000
                },
                new Robot()
                {
                    Id = new Guid("605d763e-72f4-4009-bfd7-165508523256"),
                    Model = Model.T70
                },
            }.ToArray();
        }
    }
}