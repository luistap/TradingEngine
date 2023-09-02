using System;
using System.Collections.Generic;
using System.Text;

namespace TradingEngineServer.Orders
{
    // Read-only representation of an order.

    public record OrderRecord(long OrderId, uint Quantity, long Price,
        bool IsBuySide, string Username, int SecurityId, uint TheoreticalQueuePosition);
}

// Temporarily enable record types in C#9 due to Visual Studio 2019 bug.

namespace System.Runtime.CompilerServices
{
    internal static class IsExternalInit { };
}

