namespace JeverlyStroe.Domain.Models;

public class Product
{
    public Guid Id { get; set; }
    public Guid CategoryId { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public DateTime CreatedAt { get; set; }

    public List<PicturesProduct> PicturesProduct { get; set; }
}