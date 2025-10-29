#  Northwind API REST: Backend del Proyecto Final FullStack 
Este es el repositorio del **Backend** de mi proyecto final para el curso FullStack. Se desarrolló como una **API REST** que usa la famosa base de datos de ejemplo **Northwind** para gestionar información de **Empleados y Productos**.

La idea principal era poner en práctica todo lo aprendido: usar el **Patrón Repositorio** para manejar la lógica de datos de forma limpia y trabajar con **Entity Framework Core** para interactuar con la base de datos SQL Server.

---

El objetivo principal es demostrar la aplicación práctica de arquitectura limpia utilizando el **Patrón Repositorio** y el acceso a datos eficiente con **Entity Framework Core**.

---

## 🚀 Tecnologías Clave

Este proyecto está construido con la pila de tecnologías de Microsoft y los siguientes componentes:

* **ASP.NET Core 8:** Framework robusto para construir la API.
* **C#:** Lenguaje de programación principal.
* **Entity Framework Core (EF Core):** ORM para la interacción con la base de datos **SQL Server (Northwind)**.
* **Swagger / Swashbuckle:** Para la autogeneración de la documentación de la API.
* **Patrón Repositorio:** Implementación para desacoplar la lógica de negocio de la capa de persistencia.
* **Inyección de Dependencias (DI):** Manejo de servicios y contextos.

---

## 🧠 Estructura del Proyecto (`OrmAPI`)

La solución sigue una arquitectura organizada y fácil de mantener:

| Carpeta | Responsabilidad | Descripción |
| :--- | :--- | :--- |
| `Controllers/` | **Presentación** | Maneja las peticiones HTTP y las dirige a la lógica de negocio. |
| `Repository/` | **Lógica de Datos** | Implementación del Patrón Repositorio para operaciones CRUD. |
| `Data/` | **Persistencia** | Contiene el `DataContext` para la conexión a la base de datos. |
| `Modelo/` | **Dominio** | Clases que representan las entidades de la base de datos (Ej: `Employee`, `Products`). |
---

## 🌐 Endpoints de la API: Servicios y Consultas
Empleados (/api/Empleados) 🧑‍💼: 
* GET /TodosLosEmpleados: Retorna la lista completa de todos los empleados en Northwind.

* GET /CantidadEmpleados: Indica el conteo total de empleados registrados en el sistema.

* GET /EmpleadoPorID?empleadoID={id}: Permite buscar un empleado específico utilizando su ID.

* GET /EmpleadosPorNombre?nombreEmpleado={nombre}: Devuelve empleados cuyos nombres o apellidos contienen la cadena de texto proporcionada.

* GET /IDempleadoPorTitulo?titulo={titulo}: Recupera al empleado que ocupa el cargo o título especificado.

* GET /EmpleadoPorPais?country={país}: Obtiene una instancia de un empleado que resida en el país indicado.

* GET /TodosLosEmpleadosPorPais?country={país}: Lista todos los empleados que trabajan desde el país especificado.

* GET /ElEmpleadoMasGrande: Identifica al empleado con la mayor edad (basado en la fecha de nacimiento).

* GET /CantidadEmpleadosPorTitulos: Muestra la distribución de empleados agrupados por su tipo de cargo.

Productos (/api/Productos) 📦: 
* GET /ObtenerProductosConCategoria: Lista todos los productos y muestra el nombre de su categoría relacionada.

* GET /ObtenerProductosQueContienen?palabra={palabra}: Filtra los productos cuyos nombres incluyen la palabra clave dada (búsqueda parcial).
---

