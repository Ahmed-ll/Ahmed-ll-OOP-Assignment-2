namespace SRC.CheckoutBasket;

public sealed class PackagingFeePolicy
{
    public decimal FeeFor(bool giftWrap) => giftWrap ? 4.99m : 0m;
}
