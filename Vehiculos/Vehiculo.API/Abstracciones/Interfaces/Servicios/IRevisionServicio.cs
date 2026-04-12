using Abstracciones.Modelos;

namespace Abstracciones.Interfaces.Servicios
{
    public interface IRevisionServicio
    {
        Task<Revision> Obtener(string placa);
    }
}
