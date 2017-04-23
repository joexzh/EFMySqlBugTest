using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UUT.OrderCenter.PurchaseOrder.Domain.Entity;
using UUT.OrderCenter.PurchaseOrder.Domain.Root;

namespace UUT.OrderCenter.PurchaseOrder.Domain.MapperProfile
{
    public class DomainMapperProfile: Profile
    {
        public DomainMapperProfile()
        {
            CreateMap<Order, Order>()
                .ForMember(d => d.Id, o => o.Ignore())
                .ForMember(d => d.Tourists, o => o.Ignore())
                .ForMember(d => d.OperationLogs, o => o.Ignore())
                .ForMember(d => d.OrderItems, o => o.Ignore())
                .ForMember(d => d.OrderSource, o => o.Ignore())
                .ForMember(d => d.Refunds, o => o.Ignore())
                .ForMember(d => d.UserCreated, o => o.Ignore())
                .ForMember(d => d.TimeCreated, o => o.Ignore())
                .ForMember(d => d.Seller, o => o.Ignore())
                .ForMember(d => d.OrderNumber, o => o.Ignore())
                .ForMember(d => d.SellerContact, o => o.Ignore())
                .ForMember(d => d.MallOrderId, o => o.Ignore())
                .ForMember(d => d.BusinessState, o => o.Ignore())
                .ForMember(d => d.OrderState, o => o.Ignore())
                .ForMember(d => d.Tourists, o => o.Ignore())
                .ForMember(d => d.OrderItems, o => o.Ignore())
                .ForMember(d => d.OrderMoney, o => o.Ignore());

            CreateMap<OrderItem, OrderItem>()
                .ForMember(d => d.Id, o => o.Ignore())
                .ForMember(d => d.Order, o => o.Ignore())
                .ForMember(d => d.UserCreated, o => o.Ignore())
                .ForMember(d => d.TimeCreated, o => o.Ignore())
                .ForMember(d => d.IsPriceItem, o => o.Ignore())
                .ForMember(d => d.TaxRate, o => o.Ignore())
                .ForMember(d => d.RequirementItem, o => o.Ignore());

            CreateMap<Tourist, Tourist>()
                .ForMember(d => d.Id, o => o.Ignore())
                .ForMember(d => d.OrderId, o => o.Ignore());

            CreateMap<OrderAttachment, OrderAttachment>()
                .ForMember(d => d.Id, o => o.Ignore())
                .ForMember(d => d.OrderId, o => o.Ignore());

            CreateMap<Refund, Refund>()
                .ForMember(d => d.Id, o => o.Ignore())
                .ForMember(d => d.TimeCreated, o => o.Ignore())
                .ForMember(d => d.UserCreated, o => o.Ignore())
                .ForMember(d => d.RefundState, o => o.Ignore())
                .ForMember(d => d.RefundBusinessState, o => o.Ignore());

            CreateMap<RefundItem, RefundItem>()
                .ForMember(d => d.Id, o => o.Ignore())
                .ForMember(d => d.OrderItem, o => o.Ignore());
        }
    }
}
