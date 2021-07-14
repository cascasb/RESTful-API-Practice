namespace RESTful_API_Practice.Models
{
    public interface IFoodProduct : IBakeryProduct
    {
        int Calories { get; set; }
    }
}