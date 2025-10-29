using TP_Final.Modelo;
using TP_Final.ResponseQuery;
using Microsoft.EntityFrameworkCore;
using TP_Final.Data;

namespace TP_Final.Repository
{
    public class NorthwindRepository : INorthwindRepository
    {
        private readonly DataContext _NorthwindDataContext;

        public NorthwindRepository(DataContext context)
        {
            _NorthwindDataContext = context;
        }

        public async Task<List<Employee>> TodosLosEmpleados()
        {
            return await _NorthwindDataContext.Employees.ToListAsync();
        }

        public async Task<int> CantidadDeEmpleados()
        {
            return await _NorthwindDataContext.Employees.CountAsync();
        }

        public async Task<Employee?> EmpleadoPorID(int idEmpleado)
        {
            return await _NorthwindDataContext.Employees
                .FirstOrDefaultAsync(e => e.EmployeeId == idEmpleado);
        }

        public async Task<Employee?> EmpleadosPorNombre(string nombreEmpleado)
        {
            return await _NorthwindDataContext.Employees
                .FirstOrDefaultAsync(e => e.FirstName == nombreEmpleado);
        }

        public async Task<List<Employee>> EmpleadosPorPais(string country)
        {
            return await _NorthwindDataContext.Employees
                .Where(e => e.Country == country)
                .ToListAsync();
        }

        public async Task<int> IDempleadoPorTitulo(string titulo)
        {
            var empleado = await _NorthwindDataContext.Employees
                .FirstOrDefaultAsync(e => e.Title == titulo);

            return empleado?.EmployeeId ?? 0;
        }

        public async Task<Employee?> TodosLosEmpleadosPorPais(string country)
        {
            return await _NorthwindDataContext.Employees
                .FirstOrDefaultAsync(e => e.Country == country);
        }

        public async Task<List<Employee>> CantidadEmpleadosPorTitulos(string titulo)
        {
            return await _NorthwindDataContext.Employees
                .Where(e => e.Title == titulo)
                .ToListAsync();
        }

        public async Task<Employee?> EmpleadoMasGrande()
        {
            return await _NorthwindDataContext.Employees
                .OrderBy(e => e.BirthDate)
                .FirstOrDefaultAsync();
        }

        public async Task<List<CantidadEmpleadosResponse>> ObtenerEmpleadosPorTitulosGroupBy()
        {
            return await _NorthwindDataContext.Employees
                .GroupBy(e => e.Title)
                .Select(g => new CantidadEmpleadosResponse
                {
                    Title = g.Key,
                    EmployeeCount = g.Count()
                })
                .ToListAsync();
        }

        public async Task<List<ProductoCategoriaResponse>> ObtenerProductosConCategorias()
        {
            return await _NorthwindDataContext.Products
                .Join(_NorthwindDataContext.Categories,
                      p => p.CategoryID,
                      c => c.CategoryID,
                      (p, c) => new ProductoCategoriaResponse
                      {
                          ProductName = p.ProductName,
                          CategoryName = c.CategoryName
                      })
                .ToListAsync();
        }

        public async Task<List<Products>> ObtenerProductosQueContienen(string palabra)
        {
            return await _NorthwindDataContext.Products
                .Where(p => p.ProductName.Contains(palabra))
                .ToListAsync();
        }

    }
}
