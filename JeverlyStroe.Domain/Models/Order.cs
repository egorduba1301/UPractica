namespace JeverlyStroe.Domain.Models;

public class Order
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public Guid ProductId { get; set; }
    public Guid RequestId { get; set; }
    public string CustomerName { get; set; }
    public double TotalCost { get; set; }
    public DateTime OrderDate { get; set; }
    public List<Product> Products { get; set; }
    public User User { get; set; }
}
