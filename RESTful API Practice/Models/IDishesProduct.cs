namespace RESTful_API_Practice.Models
{
    public interface IDishesProduct : IBakeryProduct
    {
        string Color { get; set; }
        bool IsDishwasherSafe { get; set; }
    }
}