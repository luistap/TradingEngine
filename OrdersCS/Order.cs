﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TradingEngineServer.Orders
{
    public class Order : IOrderCore
    {
        public Order(IOrderCore orderCore, bool isBuySide, long price, uint quantity)
        {
            // PROPERTIES // 
            Price = price;
            IsBuySide = isBuySide;
            InitialQuantity = quantity;
            CurrentQuantity = quantity;


            // FIELDS //
            _orderCore = orderCore;

        }

        public Order(ModifyOrder modifyOrder) : this(modifyOrder, modifyOrder.IsBuySide, modifyOrder.Price, modifyOrder.Quantity)
        {

        }

        // PROPERTIES //
        public long Price { get; private set; }
        public uint InitialQuantity { get; private set; }
        public uint CurrentQuantity { get; private set; }

        public bool IsBuySide { get; private set; }

        public long OrderId => _orderCore.OrderId;

        public string Username => _orderCore.Username;

        public int SecurityId => _orderCore.SecurityId;

        // METHODS //

        public void IncreaseQuantity(uint quantityDelta)
        {
            CurrentQuantity += quantityDelta;
        }
        public void DecreaseQuantity(uint quanitityDelta)
        {
            if (quanitityDelta > CurrentQuantity)
                throw new InvalidOperationException($"Quantity Delta > Current Quantity for OrderId={OrderId}");
            CurrentQuantity -= quanitityDelta;
        }

        // FIELDS //
        private readonly IOrderCore _orderCore;


    }


   
   

}
