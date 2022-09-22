using resDesli.Models;

namespace resDesli
{
    public class PlatosDelMenu
    {
        public platos Obtenerplato()
        {
            return new platos() { 
            Nombre ="Ensalada Cesar",
            Descripcion="Lechuga romana, pollo a la plancha y salta ranch",
            Precio ="$200.98"
            };
        }

        public List<platos> ObtenerPlatos()
        {
            var plato1 = new platos()
            {
                Nombre = "Pasta Pesto",
                Descripcion = "Pasta en Penne o Linguinni en salta pesto",
                Precio = "$230.98"
            };

            var plato2 = new platos()
            {
                Nombre = "Pollo Rostizado",
                Descripcion = "Porción de pollo aromatizado con finas especias",
                Precio = "$430.98"
            };


            var plato2_1 = new platos()
            {
                Nombre = "Pollo FRITO",
                Descripcion = "Porción de pollo aromatizado con finas especias",
                Precio = "$430.98"
            };

            var plato3 = new platos()
            {
                Nombre = "Arroz de colores",
                Descripcion = "Arroz de grano largo acompañado de ajíes variaos",
                Precio = "$160.00"
            };

            var plato4 = new platos()
            {
                Nombre = "Flan de leche",
                Descripcion = "Delicioso flan de leche con cubierta de caramelo",
                Precio = "$130.00"
            };

            var plato4_1 = new platos()
            {
                Nombre = "Browny FLAN",
                Descripcion = "Delicioso flan de leche con cubierta de caramelo",
                Precio = "$130.00"
            };

            return new List<platos> { plato1, plato2, plato3, plato4 };


        }

    }
}
