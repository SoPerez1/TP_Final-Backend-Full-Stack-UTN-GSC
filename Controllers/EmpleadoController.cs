using Microsoft.AspNetCore.Mvc;
using TP_Final.Repository;
using TP_Final.Modelo;
using TP_Final.ResponseQuery;

namespace TP_Final.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmpleadosController : ControllerBase
    {
        private readonly INorthwindRepository _repository;

        public EmpleadosController(INorthwindRepository repository)
        {
            _repository = repository;
        }

        //GET api/Empleados/TodosLosEmpleados
        [HttpGet("TodosLosEmpleados")]
        public async Task<ActionResult<List<Employee>>> ObtenerTodosLosEmpleados()
        {
            var empleados = await _repository.TodosLosEmpleados();
            return Ok(empleados);
        }

        //GET api/Empleados/CantidadEmpleados
        [HttpGet("CantidadEmpleados")]
        public async Task<ActionResult<int>> ObtenerCantidadEmpleados()
        {
            var cantidad = await _repository.CantidadDeEmpleados();
            return Ok(cantidad);
        }

        //GET api/Empleados/EmpleadoPorID?empleadoID=5
        [HttpGet("EmpleadoPorID")]
        public async Task<ActionResult<Employee>> ObtenerEmpleadoPorID([FromQuery] int empleadoID)
        {
            var empleado = await _repository.EmpleadoPorID(empleadoID);
            return empleado != null ? Ok(empleado) : NotFound("Empleado no encontrado");
        }

        //GET api/Empleados/EmpleadosPorNombre?nombreEmpleado=...
        [HttpGet("EmpleadosPorNombre")]
        public async Task<ActionResult<Employee>> ObtenerEmpleadoPorNombre([FromQuery] string nombreEmpleado)
        {
            var empleado = await _repository.EmpleadosPorNombre(nombreEmpleado);
            return empleado != null ? Ok(empleado) : NotFound("Empleado no encontrado");
        }

        //GET api/Empleados/IDempleadoPorTitulo?titulo=Manager
        [HttpGet("IDempleadoPorTitulo")]
        public async Task<ActionResult<int>> ObtenerIDEmpleadoPorTitulo([FromQuery] string titulo)
        {
            var id = await _repository.IDempleadoPorTitulo(titulo);
            return Ok(id);
        }

        //GET api/Empleados/EmpleadosPorPais?country=USA
        [HttpGet("EmpleadosPorPais")]
        public async Task<ActionResult<List<Employee>>> ObtenerEmpleadosPorPais([FromQuery] string country)
        {
            var empleados = await _repository.EmpleadosPorPais(country);
            return Ok(empleados);
        }

        //GET api/Empleados/TodosLosEmpleadosPorPais?country=USA
        [HttpGet("TodosLosEmpleadosPorPais")]
        public async Task<ActionResult<Employee>> ObtenerTodosLosEmpleadosPorPais([FromQuery] string country)
        {
            var empleado = await _repository.TodosLosEmpleadosPorPais(country);
            return empleado != null ? Ok(empleado) : NotFound("Empleado no encontrado");
        }

        //GET api/Empleados/ElEmpleadoMasGrande
        [HttpGet("ElEmpleadoMasGrande")]
        public async Task<ActionResult<Employee>> ObtenerEmpleadoMasGrande()
        {
            var empleado = await _repository.EmpleadoMasGrande();
            return Ok(empleado);
        }

        //GET api/Empleados/CantidadEmpleadosPorTitulos
        [HttpGet("CantidadEmpleadosPorTitulos")]
        public async Task<ActionResult<List<CantidadEmpleadosResponse>>> ObtenerCantidadEmpleadosPorTitulos()
        {
            var resultado = await _repository.ObtenerEmpleadosPorTitulosGroupBy();
            return Ok(resultado);
        }

        //GET api/Empleados/ObtenerProductosConCategoria
        [HttpGet("ObtenerProductosConCategoria")]
        public async Task<ActionResult<List<ProductoCategoriaResponse>>> ObtenerProductosConCategoria()
        {
            var resultado = await _repository.ObtenerProductosConCategorias();
            return Ok(resultado);
        }

        //GET api/Empleados/ObtenerProductosQueContienen?palabra=choco
        [HttpGet("ObtenerProductosQueContienen")]
        public async Task<ActionResult<List<Products>>> ObtenerProductosQueContienen([FromQuery] string palabra)
        {
            var productos = await _repository.ObtenerProductosQueContienen(palabra);
            return Ok(productos);
        }
    }
}
