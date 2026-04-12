namespace Abstracciones.Interfaces.Reglas
{
    public interface IVehiculoReglas
    {
        Task<bool> RevisionEsValida(string placa);

    }
}
