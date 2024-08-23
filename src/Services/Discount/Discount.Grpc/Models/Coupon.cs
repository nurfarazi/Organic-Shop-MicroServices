using System.ComponentModel.DataAnnotations;

namespace Discount.Grpc.Models;

public class Coupon
{
    public Coupon()
    {
        ProductName = "No Discount";
        Description = "No Discount Desc";
        Amount = 0;
    }

    [Key] public int Id { get; set; }

    [MaxLength(40)] public string ProductName { get; set; } = default!;
    [MaxLength(40)] public string Description { get; set; } = default!;
    [Range(0, 10000)] public int Amount { get; set; }
}