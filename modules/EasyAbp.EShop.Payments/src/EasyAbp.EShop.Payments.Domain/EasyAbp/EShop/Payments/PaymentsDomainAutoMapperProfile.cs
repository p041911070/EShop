﻿using AutoMapper;
using EasyAbp.EShop.Payments.Payments;

namespace EasyAbp.EShop.Payments
{
    public class PaymentsDomainAutoMapperProfile : Profile
    {
        public PaymentsDomainAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */
            CreateMap<Payment, PaymentEto>();
            CreateMap<PaymentItem, PaymentItemEto>();
        }
    }
}
