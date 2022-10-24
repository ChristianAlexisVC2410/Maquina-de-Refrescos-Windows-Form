using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maquinaRefrescos
{
    class MaquinaRefrescos
    {

        private double precio=4.5;
        private double insertar;
        private double cambio;
        private double desStockCoca=5;
        private double resultInsert;
        private double desStockFresca=5;
        private double desStockFanta = 5;
        private double desStockSprite = 5;
        private double desStrockManazanita = 5;


        public double Precio { get => precio; set => precio = value; }
        public double Cambio { get => cambio; set => cambio = value; }
        public double DesStockCoca { get => desStockCoca; set => desStockCoca = value; }
        public double DesStockFresca { get => desStockFresca; set => desStockFresca = value; }
        public double DesStockFanta { get => desStockFanta; set => desStockFanta = value; }
        public double DesStockSprite { get => desStockSprite; set => desStockSprite = value; }
        public double Insertar { get => insertar; set => insertar = value; }
        public double ResultInsert { get => resultInsert; set => resultInsert = value; }
        public double DesStockManzanita { get => desStrockManazanita; set => desStrockManazanita = value; }

        public void metodoValidacion()
        {
            this.ResultInsert += this.Insertar;

            this.Cambio = this.ResultInsert - this.precio;

        }

        public void cantidadFresca()
        {
            if (this.DesStockFresca > 0)
            {
                this.DesStockFresca -= 1;

            }
        }

        public void cantidadCocaCola()
        {
            if (this.DesStockCoca > 0)
            {
                this.DesStockCoca -= 1;

            }
        }

        public void cantidadFanta()
        {
            if (this.DesStockFanta > 0)
            {
                this.DesStockFanta -= 1;

            }
        }

        public void cantidadSprite()
        {
            if(this.DesStockSprite > 0)
            {
                this.DesStockSprite -= 1;
            }
        }

        public void cantidadManzanita()
        {
            if(this.DesStockManzanita > 0)
            {
                this.DesStockManzanita -= 1;
            }
        }

        public int validarExistenciasTotales()
        {

            if (this.DesStockCoca == 0 && this.DesStockFanta == 0 && this.DesStockFresca == 0 && this.DesStockSprite == 0 && this.DesStockManzanita == 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public int noValidarCero()
        {
            if (this.Precio > 0)
            {
                return 1;

            }
            else
            {
                return 0;
            }
        }

    }
}
