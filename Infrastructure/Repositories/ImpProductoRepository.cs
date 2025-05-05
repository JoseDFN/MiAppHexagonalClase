
using MiAppHexagonal.Domain.Entities;
using MiAppHexagonal.Domain.Ports;
using MiAppHexagonal.Infrastructure.Mysql;
using MySql.Data.MySqlClient;

namespace MiAppHexagonal.Infrastructure.Repositories;

public class ImpProductoRepository : IGenericRepository<Producto>, IProductoRepository
{
    private readonly ConexionSingleton _conexion;

    public ImpProductoRepository(string connectionString)
    {
        _conexion = ConexionSingleton.Instancia(connectionString);
    }

    public void Actualizar(Producto producto)
    {
        var connection = _conexion.ObtenerConexion();
        string query = "UPDATE productos SET nombre = @nombre, stock = @stock WHERE id = @id";
        using var cmd = new MySqlCommand(query, connection);
        cmd.Parameters.AddWithValue("@nombre", producto.Nombre);
        cmd.Parameters.AddWithValue("@stock", producto.Stock);
        cmd.Parameters.AddWithValue("@id", producto.Id);
        cmd.ExecuteNonQuery();
    }

    public void Crear(Producto producto)
    {
        var connection = _conexion.ObtenerConexion();
        string query = "INSERT INTO productos (nombre, stock) VALUES (@nombre, @stock)";
        using var cmd = new MySqlCommand(query, connection);
        cmd.Parameters.AddWithValue("@nombre", producto.Nombre);
        cmd.Parameters.AddWithValue("@stock", producto.Stock);
        cmd.ExecuteNonQuery();
       
    }

    public void Eliminar(int id)
    {
        var connection = _conexion.ObtenerConexion();
        string query = "DELETE FROM productos WHERE id = @id";
        using var cmd = new MySqlCommand(query, connection);
        cmd.Parameters.AddWithValue("@id", id);
        cmd.ExecuteNonQuery();
    }

    public List<Producto> ObtenerTodos()
    {
        var productos = new List<Producto>();
        var connection = _conexion.ObtenerConexion();

        string query = "SELECT id, nombre, stock FROM productos";
        using var cmd = new MySqlCommand(query, connection);
        using var reader = cmd.ExecuteReader();

        while (reader.Read())
        {
            productos.Add(new Producto
            {
                Id = reader.GetInt32("id"),
                Nombre = reader.GetString("nombre"),
                Stock = reader.GetInt32("stock")
            });
        }

        return productos;
    }
}
