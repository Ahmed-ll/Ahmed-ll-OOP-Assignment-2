namespace SRC.CheckoutBasket;

public sealed class CheckoutPricer
{
    private readonly CouponDiscountCalculator _coupons;
    private readonly PackagingFeePolicy _packaging;

    public CheckoutPricer(CouponDiscountCalculator coupons, PackagingFeePolicy packaging)
    {
        _coupons = coupons ?? throw new ArgumentNullException(nameof(coupons));
        _packaging = packaging ?? throw new ArgumentNullException(nameof(packaging));
    }

    public decimal GrandTotal(CheckoutBasket basket, string? couponText, bool giftWrap)
    {
        var subTotal = basket.SubTotal();
        var total = subTotal - _coupons.DiscountAmount(couponText, subTotal);
        total += _packaging.FeeFor(giftWrap);
        return Math.Max(0m, total);
    }
}
