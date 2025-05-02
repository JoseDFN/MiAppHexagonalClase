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
        public void CrearProducto(Producto producto)
        {
            _repo.Crear(producto);
        }
    }
}