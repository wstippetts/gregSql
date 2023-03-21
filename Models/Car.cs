namespace gregSql.Models;

public class Car
{
  public int Id { get; set; }
  public string Make { get; set; }
  public string Model { get; set; }
  public int Year { get; set; }
  public double? Price { get; set; } = 1.00;
  public string ImgUrl { get; set; }
  public string Description { get; set; }
  public string Color { get; set; }
}

