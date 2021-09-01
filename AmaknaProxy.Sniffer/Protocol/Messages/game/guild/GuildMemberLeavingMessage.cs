

// Generated on 09/01/2021 10:11:59
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GuildMemberLeavingMessage : NetworkMessage
    {
        public const uint Id = 1501;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public bool kicked;
        public double memberId;
        
        public GuildMemberLeavingMessage()
        {
        }
        
        public GuildMemberLeavingMessage(bool kicked, double memberId)
        {
            this.kicked = kicked;
            this.memberId = memberId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteBoolean(kicked);
            writer.WriteVarLong(memberId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            kicked = reader.ReadBoolean();
            memberId = reader.ReadVarUhLong();
        }
        
    }
    
}