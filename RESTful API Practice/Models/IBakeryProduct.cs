namespace RESTful_API_Practice.Models
{
    public interface IBakeryProduct
    {
        int NumInStock { get; set; }
        string Price { get; set; }
        string ProductName { get; set; }
    }
}