
namespace gregSql.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CarsController : ControllerBase
{
  private readonly CarsService carsService;
  public CarsController(CarsService carsService)
  {
    this.carsService = carsService;
  }
}
