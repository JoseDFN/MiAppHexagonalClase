using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MiAppHexagonal.Domain.Entities;
using MiAppHexagonal.Domain.Ports;
using MiAppHexagonal.Infrastructure.Mysql;
using MiAppHexagonalClase.Domain.Ports;

namespace MiAppHexagonalClase.Infrastructure.Repositories
{
    public class ImpDireccionRepository : IGenericRepository<Direccion>, IDireccionRepository
    {
        private readonly ConexionSingleton _conexion;

        public ImpDireccionRepository(string connectionString)
        {
            _conexion = ConexionSingleton.Instancia(connectionString);
        }

        public void Actualizar(Direccion entity)
        {
            throw new NotImplementedException();
        }

        public void Crear(Direccion entity)
        {
            throw new NotImplementedException();
        }

        public void Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public List<Direccion> ObtenerTodos()
        {
            throw new NotImplementedException();
        }
    }
}