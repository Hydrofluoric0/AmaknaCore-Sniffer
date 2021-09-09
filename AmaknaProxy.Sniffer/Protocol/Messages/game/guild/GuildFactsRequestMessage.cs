

// Generated on 09/08/2021 14:22:00
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class GuildFactsRequestMessage : NetworkMessage
    {
        public const uint Id = 8501;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public uint guildId;
        
        public GuildFactsRequestMessage()
        {
        }
        
        public GuildFactsRequestMessage(uint guildId)
        {
            this.guildId = guildId;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteVarInt((int)guildId);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            guildId = reader.ReadVarUhInt();
        }
        
    }
    
}