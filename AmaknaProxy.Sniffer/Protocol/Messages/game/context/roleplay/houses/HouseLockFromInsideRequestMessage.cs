

// Generated on 08/19/2021 23:34:32
using System;
using System.Collections.Generic;
using System.Linq;
using AmaknaProxy.API.Protocol.Types;
using AmaknaProxy.API.IO;
using AmaknaProxy.API.Network;

namespace AmaknaProxy.API.Protocol.Messages
{
    public class HouseLockFromInsideRequestMessage : LockableChangeCodeMessage
    {
        public const uint Id = 3332;
        public override uint MessageId
        {
            get { return Id; }
        }
        
        
        public HouseLockFromInsideRequestMessage()
        {
        }
        
        public HouseLockFromInsideRequestMessage(string code)
         : base(code)
        {
        }
        
        public override void Serialize(IDataWriter writer)
        {
            base.Serialize(writer);
        }
        
        public override void Deserialize(IDataReader reader)
        {
            base.Deserialize(reader);
        }
        
    }
    
}