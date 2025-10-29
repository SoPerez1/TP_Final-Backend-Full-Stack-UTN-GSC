using TP_Final.ResponseQuery;
using TP_Final.Modelo;

namespace TP_Final.Repository
{
    public interface INorthwindRepository
    {
        Task<List<Employee>> TodosLosEmpleados();
        Task<int> CantidadDeEmpleados();
        Task<Employee?> EmpleadoPorID(int idEmpleado);
        Task<Employee?> EmpleadosPorNombre(string nombreEmpleado);
        Task<List<Employee>> EmpleadosPorPais(string country);
        Task<int> IDempleadoPorTitulo(string titulo);
        Task<Employee?> TodosLosEmpleadosPorPais(string country);
        Task<List<Employee>> CantidadEmpleadosPorTitulos(string titulo);
        Task<Employee?> EmpleadoMasGrande();
        Task<List<CantidadEmpleadosResponse>> ObtenerEmpleadosPorTitulosGroupBy();
        Task<List<ProductoCategoriaResponse>> ObtenerProductosConCategorias();
        Task<List<Products>> ObtenerProductosQueContienen(string palabra);
    }
}
