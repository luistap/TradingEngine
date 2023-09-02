using System;
using System.Collections.Generic;
using System.Text;
using TradingEngineServer.Orders;

namespace TradingEngineServer.Rejects
{
    public sealed class RejectCreator
    {
        public static Rejection GenerateOrderCoreRejection(IOrderCore rejectedOrder, RejectionReason rejectedReason)
        {
            return new Rejection(rejectedOrder, rejectedReason);

        } 


    }
}
