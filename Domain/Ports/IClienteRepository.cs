using System;
using MiAppHexagonal.Domain.Entities;

namespace MiAppHexagonal.Domain.Ports;

public interface IClienteRepository
{
    List<Cliente> ObtenerTodos();
    void Crear(Cliente cliente);
    void Actualizar(Cliente cliente);
    void Eliminar(int id);
}
