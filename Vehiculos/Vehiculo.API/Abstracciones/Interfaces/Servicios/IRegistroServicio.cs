using Abstracciones.Modelos;

namespace Abstracciones.Interfaces.Servicios
{
    public interface IRegistroServicio
    {
        Task<Propietario> Obtener(string placa);
    }
}
