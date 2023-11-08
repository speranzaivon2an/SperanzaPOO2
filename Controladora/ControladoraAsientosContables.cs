using Entidad;
using Modelo;

namespace Controladora
{
    public class ControladoraAsientosContables
    {
        public Modelo.Context context;
        public string Eliminar(AsientosContables asientosContables)
        {

            var asientoEncontrado = context.AsientosContable.FirstOrDefault(x => x.AsientosContablesID == asientosContables.AsientosContablesID);
            if (asientoEncontrado == null)
            {
                context.Remove(asientosContables);
                asientoEncontrado.ToString();
                return "Movimiento eliminado";
            }
            else return "movimiento no habilitado";
        }
        public string Agregar(AsientosContables asientosContables)
        {

            var asientoEncontrado = context.AsientosContable.FirstOrDefault(x => x.AsientosContablesID == asientosContables.AsientosContablesID);
            if (asientoEncontrado == null)
            {
                context.Add(asientosContables);
                asientoEncontrado.ToString();
                return "movimiento agregado";
            }
            else return "movimiento no habilitado";
        } }
         


    }
