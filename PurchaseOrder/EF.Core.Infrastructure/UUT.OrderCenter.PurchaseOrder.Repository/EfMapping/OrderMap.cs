using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UUT.OrderCenter.PurchaseOrder.Domain.Root;

namespace UUT.OrderCenter.PurchaseOrder.RepositoryCore.EfMapping
{
    internal class OrderMap
    {
        public static void SetConfig(EntityTypeBuilder<Order> entityBuilder)
        {
            entityBuilder.ToTable("Purchase_Order");
            entityBuilder.HasKey(p => p.Id);

            entityBuilder.HasMany(o => o.OperationLogs);
            entityBuilder.HasMany(o => o.OrderItems).WithOne(i => i.Order).HasForeignKey("Order_Id");
            entityBuilder.HasMany(o => o.Tourists).WithOne().HasForeignKey("OrderId");
            entityBuilder.HasMany(o => o.Refunds).WithOne(r => r.Order).HasForeignKey("Order_Id");

            entityBuilder.Ignore(p => p.OrderState);
            entityBuilder.Ignore(p => p.RemovedTourists);
            entityBuilder.Ignore(p => p.ProductName);

            entityBuilder.Property(p => p.OrderNumber).IsRequired();

#if EFCore
            entityBuilder.Property(o => o.OrderMoneyDealAmount).HasColumnName("OrderMoney_DealAmount");
            entityBuilder.Property(o => o.OrderMoneyDealCurrencyCode).HasColumnName("OrderMoney_DealCurrencyCode");
            entityBuilder.Property(o => o.OrderMoneyCurrencyRate).HasColumnName("OrderMoney_CurrencyRate");
            entityBuilder.Property(o => o.OrderMoneyBaseCurrencyCode).HasColumnName("OrderMoney_BaseCurrencyCode");

            entityBuilder.Property(i => i.UserCreatedId).HasColumnName("UserCreated_Id");
            entityBuilder.Property(i => i.UserCreatedFullName).HasColumnName("UserCreated_FullName");
            entityBuilder.Property(i => i.UserCreatedPhone).HasColumnName("UserCreated_Phone");
            entityBuilder.Property(i => i.UserCreatedAgencyId).HasColumnName("UserCreated_AgencyId");
            entityBuilder.Property(i => i.UserCreatedAgencyName).HasColumnName("UserCreated_AgencyName");

            entityBuilder.Property(i => i.PriceConcessionType).HasColumnName("PriceConcession_ConcessionType");
            entityBuilder.Property(i => i.PriceConcessionName).HasColumnName("PriceConcession_ConcessionName");
            entityBuilder.Property(i => i.PriceConcessionNumber).HasColumnName("PriceConcession_ConcessionNumber");

            entityBuilder.Property(i => i.SellerOnlineType).HasColumnName("Seller_OnlineType");
            entityBuilder.Property(i => i.SellerType).HasColumnName("Seller_SellerType");
            entityBuilder.Property(i => i.SellerId).HasColumnName("Seller_SellerId");
            entityBuilder.Property(i => i.SellerName).HasColumnName("Seller_SellerName");
            entityBuilder.Property(i => i.SellerAgencyRelationId).HasColumnName("Seller_AgencyRelationId");

            entityBuilder.Property(i => i.SellerContactFullName).HasColumnName("SellerContact_FullName");
            entityBuilder.Property(i => i.SellerContactPhone).HasColumnName("SellerContact_Phone");
            entityBuilder.Property(i => i.SellerContactEmail).HasColumnName("SellerContact_Email");
            entityBuilder.Property(i => i.SellerContactQQ).HasColumnName("SellerContact_QQ");
            entityBuilder.Property(i => i.SellerContactWechat).HasColumnName("SellerContact_Wechat");
            entityBuilder.Property(i => i.SellerContactWechatQrImg).HasColumnName("SellerContact_WechatQrImg");

            entityBuilder.Property(i => i.BuyerContactFullName).HasColumnName("BuyerContact_FullName");
            entityBuilder.Property(i => i.BuyerContactPhone).HasColumnName("BuyerContact_Phone");
            entityBuilder.Property(i => i.BuyerContactEmail).HasColumnName("BuyerContact_Email");
            entityBuilder.Property(i => i.BuyerContactQQ).HasColumnName("BuyerContact_QQ");
            entityBuilder.Property(i => i.BuyerContactWechat).HasColumnName("BuyerContact_Wechat");
            entityBuilder.Property(i => i.BuyerContactWechatQrImg).HasColumnName("BuyerContact_WechatQrImg");

            entityBuilder.Property(i => i.SettlementSchemeType).HasColumnName("Settlement_SettlementSchemeType");
            entityBuilder.Property(i => i.SettlementType).HasColumnName("Settlement_SettlementType");
            entityBuilder.Property(i => i.SettlementDay).HasColumnName("Settlement_Day");
            entityBuilder.Property(i => i.SettlementWeekday).HasColumnName("Settlement_Weekday");
            entityBuilder.Property(i => i.SettlementItemsJson).HasColumnName("SettlementItems");
            entityBuilder.Property(i => i.SettlementDeposit).HasColumnName("Settlement_Deposit");
            entityBuilder.Property(i => i.SettlementDepositCurrencyCode).HasColumnName("Settlement_DepositCurrencyCode");

            entityBuilder.Property(i => i.InvoiceType).HasColumnName("Invoice_InvoiceType");
            entityBuilder.Property(i => i.InvoiceTitle).HasColumnName("Invoice_Title");
            entityBuilder.Property(i => i.InvoiceNote).HasColumnName("Invoice_Note");

            entityBuilder.Property(i => i.ShippingType).HasColumnName("Shipping_ShippingType");
            entityBuilder.Property(i => i.ShippingAddress).HasColumnName("Shipping_Address");

            entityBuilder.Ignore(o => o.OrderMoney);
            entityBuilder.Ignore(o => o.UserCreated);
            entityBuilder.Ignore(o => o.PriceConcession);
            entityBuilder.Ignore(o => o.Seller);
            entityBuilder.Ignore(o => o.SellerContact);
            entityBuilder.Ignore(o => o.BuyerContact);
            entityBuilder.Ignore(o => o.Settlement);
            entityBuilder.Ignore(o => o.Invoice);
            entityBuilder.Ignore(o => o.Shipping);
#endif
        }
    }
}
