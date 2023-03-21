
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
  [HttpGet]
  public ActionResult<List<Car>> Find()
  {
    try
    {
      List<Car> cars = carsService.Find();
      return Ok(cars);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  [HttpGet("{id}")]
  public ActionResult<Car> Find(int id)
  {
    try
    {
      Car car = carsService.Find(id);
      return Ok(car);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  //   [HttpPost]
}
