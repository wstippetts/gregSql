namespace gregSql.Services;

public class CarsService
{
  private readonly CarsRepository _repo;
  public CarsService(CarsRepository repo)
  {
    _repo = repo;
  }
  internal List<Car> Find()
  {
    List<Car> cars = _repo.FindAll();
    return cars;
  }
}
