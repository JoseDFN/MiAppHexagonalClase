using System;
using MiAppHexagonal.Domain.Factory;
using MiAppHexagonal.Domain.Ports;
using MiAppHexagonal.Infrastructure.Repositories;
using MiAppHexagonalClase.Domain.Ports;
using MiAppHexagonalClase.Infrastructure.Repositories;

namespace MiAppHexagonal.Infrastructure.Mysql;

public class MySqlDbFactory : IDbFactory
{
    private readonly string _connectionString;

    public MySqlDbFactory(string connectionString)
    {
        _connectionString = connectionString;
    }

    public IClienteRepository CrearClienteRepository()
    {
        return new lmpClienteRepository(_connectionString);
    }

    public IProductoRepository CrearProductoRepository()
    {
        return new ImpProductoRepository(_connectionString);
    }
    public IDireccionRepository CrearDireccionRepository()
    {
        return new ImpDireccionRepository(_connectionString);
    }
}
