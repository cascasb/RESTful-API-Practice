namespace RESTful_API_Practice.Models
{
    public interface IDrinkProduct : IBakeryProduct, IFoodProduct
    {
        bool IsDecaf { get; set; }
    }
}