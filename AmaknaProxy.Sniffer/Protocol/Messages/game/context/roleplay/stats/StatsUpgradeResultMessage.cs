

// Generated on 09/08/2021 14:21:58
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class StatsUpgradeResultMessage : NetworkMessage
    {
        public const uint Id = 5570;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        public sbyte result;
        public uint nbCharacBoost;
        
        public StatsUpgradeResultMessage()
        {
        }
        
        public StatsUpgradeResultMessage(sbyte result, uint nbCharacBoost)
        {
            this.result = result;
            this.nbCharacBoost = nbCharacBoost;
        }
        
        public override void Serialize(IDataWriter writer)
        {
            writer.WriteSbyte(result);
            writer.WriteVarShort((int)nbCharacBoost);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            result = reader.ReadSbyte();
            nbCharacBoost = reader.ReadVarUhShort();
        }
        
    }
    
}