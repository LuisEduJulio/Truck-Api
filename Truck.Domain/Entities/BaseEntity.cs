﻿using System;

namespace Truck.Domain.Entities
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime DateCreation { get; set; }
        public DateTime? DateUpdated { get; set; }
        public DateTime? DateDeleted { get; set; }
    }
}