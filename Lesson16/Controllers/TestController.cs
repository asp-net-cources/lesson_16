using Lesson16.Data;
using Lesson16.LifetimeExamples;
using Lesson16.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lesson16.Controllers;

[Route("[controller]")]
public class TestController : ControllerBase
{
    private readonly Service1 _service1;
    private readonly Service2 _service2;

    public TestController(Service1 service1, Service2 service2)
    {
        _service1 = service1;
        _service2 = service2;
    }
    
    [HttpGet]
    public string GetTest()
    {
        return $"{_service1.ScopeNumber} {_service2.ScopeNumber}";
    }
}