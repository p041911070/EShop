﻿using System;
using JetBrains.Annotations;
using Volo.Abp.Domain.Entities;

namespace EasyAbp.EShop.Products.ProductHistories
{
    public class ProductHistory : AggregateRoot<Guid>
    {
        public virtual Guid ProductId { get; protected set; }
        
        public virtual DateTime ModificationTime { get; protected set; }
        
        [NotNull]
        public virtual string SerializedDto { get; protected set; }
        
        protected ProductHistory() {}

        public ProductHistory(
            Guid id,
            Guid productId,
            DateTime modificationTime,
            [NotNull] string serializedDto) : base(id)
        {
            ProductId = productId;
            ModificationTime = modificationTime;
            SerializedDto = serializedDto;
        }
    }
}