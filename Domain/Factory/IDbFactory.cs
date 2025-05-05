using System;
using MiAppHexagonal.Domain.Ports;
using MiAppHexagonalClase.Domain.Ports;

namespace MiAppHexagonal.Domain.Factory;

public interface IDbFactory
{
    IClienteRepository CrearClienteRepository();
    IProductoRepository CrearProductoRepository();
    IDireccionRepository CrearDireccionRepository();
}
