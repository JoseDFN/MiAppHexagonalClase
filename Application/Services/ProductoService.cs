using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MiAppHexagonal.Domain.Entities;
using MiAppHexagonal.Domain.Ports;

namespace MiAppHexagonal.Application.Services
{

    public class ProductoService
    {
        private readonly IProductoRepository _repo;

        public ProductoService(IProductoRepository repo)
        {
            _repo = repo;
        }
        public void MostrarTodos()
        {
            var lista = _repo.ObtenerTodos();
            foreach (var p in lista)
            {
                Console.WriteLine($"ID: {p.Id}, Nombre producto: {p.Nombre}, Stock: {p.Stock}");
            }
        }
        public void CrearProducto(Producto producto)
        {
            _repo.Crear(producto);
        }
        public void ActualizarProducto(int id, string nuevoNombre, int Nstock)
        {
            _repo.Actualizar(new Producto { Id = id, Nombre = nuevoNombre, Stock = Nstock });
        }
        public void EliminarProducto(int id)
        {
            _repo.Eliminar(id);
        }
    }
}