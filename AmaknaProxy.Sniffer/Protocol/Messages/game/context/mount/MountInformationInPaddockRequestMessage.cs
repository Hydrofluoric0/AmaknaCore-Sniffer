

// Generated on 09/08/2021 14:21:48
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class MountInformationInPaddockRequestMessage : NetworkMessage
    {
        public const uint Id = 8490;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public int mapRideId;
        
        public MountInformationInPaddockRequestMessage()
        {
        }
        
        public MountInformationInPaddockRequestMessage(int mapRideId)
        {
            this.mapRideId = mapRideId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarInt((int)mapRideId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            mapRideId = reader.ReadVarInt();
        }
        
    }
    
}