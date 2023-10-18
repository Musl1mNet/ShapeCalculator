using Microsoft.AspNetCore.Mvc;
using ShapeCalculator.Models;

namespace ShapeCalculator.Controllers;

[ApiController]
[Route("[controller]")]
public class ShapeCalculatorController : ControllerBase
{
    private readonly ILogger<ShapeCalculatorController> _logger;

    public ShapeCalculatorController(ILogger<ShapeCalculatorController> logger)
    {
        _logger = logger;
    }

    /// <summary>
    /// Retrieves a specific item.
    /// </summary>
    /// <param name="id">The ID of the item to retrieve.</param>
    /// <returns>The requested item.</returns>
    [HttpPost("ShapeCalculator")]
    public IActionResult Get([FromBody] ShapeDTO model)
    {
        try
        {
            Shape result;
            switch (model.Figure.ToLower())
            {
                case "kvadrat":
                    result = new Rectangle(model.Params[0], model.Params[0]);
                    return Ok(new { Area = result.CalculateArea(), Perimeter = result.CalculatePerimeter() });
                case "circle":
                    result = new Circle(model.Params[0]);
                    return Ok(new { Area = result.CalculateArea(), Perimeter = result.CalculatePerimeter() });
                case "triangle":
                    result = new Triangle(model.Params[0], model.Params[1], model.Params[2]);
                    return Ok(new { Area = result.CalculateArea(), Perimeter = result.CalculatePerimeter() });
                default:
                    result = new Rectangle(model.Params[0], model.Params[1]);
                    return Ok(new { Area = result.CalculateArea(), Perimeter = result.CalculatePerimeter() });
            }
        }
        catch (Exception ex)
        {
            return Ok(new { error = ex.Message });
        }
    }
}
