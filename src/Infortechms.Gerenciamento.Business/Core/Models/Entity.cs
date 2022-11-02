﻿using System;

namespace Infortechms.Gerenciamento.Business.Core.Models
{
    public abstract class Entity
    {
        protected Entity()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        
    }
}