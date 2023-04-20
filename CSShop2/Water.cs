using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSShop2
{
    public class Water : Product
    {
        //ATTRIBUTI
        private double waterLiters;
        private double waterPH;
        private string waterSource;
        //COSTRUTTORE
        public Water (string productName, int productCode, string productDescription, float productPrice, int taxIva, double waterLiters, string waterSource) : base (productName, productCode, productDescription, productPrice, taxIva)
        {
            this.waterLiters = waterLiters;
            this.waterPH = 6.5;
            this.waterSource = waterSource;
        }

        //GETTERS
        public double GetWaterLiters()
        {
            return waterLiters;
        }

        public double GetWaterPH()
        {
            return waterPH;
        }

        public string GetWaterSource()
        {
            return waterSource;
        }

        //SETTERS
        public void SetWaterLiters(double waterLiters)
        {
            if (waterLiters < 0)
            {
                Console.WriteLine("I litri nella bottiglia non possono essere negativi!");
            } else if (waterLiters > 1.5) 
            {
                Console.WriteLine("La tua bottiglia non può contenere più di 1,5L! ");
            } else
            {
                this.waterLiters = waterLiters;
            }
        }


        //METODI

        public double Drink(double drinkLiters)
        {
            if (drinkLiters > waterLiters)
            {
                Console.WriteLine("Non c'è abbastanza acqua nella tua bottiglia");
                waterLiters = 0;

            } 
            waterLiters -= drinkLiters;  
            return waterLiters;
        }

        public double FillBottle (double fillLiters)
        {
            if (fillLiters < 1.5)
            {
                Console.WriteLine("La tua bottiglia non può contenere così tanta acqua");
                waterLiters = 1.5;
            }
            waterLiters += fillLiters;
            if (waterLiters > 1.5)
            {
                Console.WriteLine("la tua bottiglia sta strabordando!");
                waterLiters = 1.5;
            }
            Console.WriteLine("La tua bottiglia ora ha: " + waterLiters + " Litri");
            return waterLiters;

        }

        public void ToEmpty()
        {
            waterLiters = 0;
        
        }

        public override void CodeName()
        {
            base.CodeName();
            Console.WriteLine("Sorgente: " + this.waterSource + "/n");
            Console.WriteLine("pH: " + this.waterPH + "/n");
            Console.WriteLine("Litri: " + this.waterLiters + "/n");
        }
    }
}
