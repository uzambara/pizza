﻿using System;
using System.Collections.Generic;

namespace Innoscripta.Pizza.Data.Domain
{
    public class OrderEntity: IEntityBase
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int UserId { get; set; }
        public UserEntity User { get; set; }
        public string Comment { get; set; }
        public decimal TotalPrice { get; set; }
        public List<OrderItemEntity> OrderItems { get; set; }
        public DateTime? Deleted { get; set; }
        public string Address { get; set; }
    }
}