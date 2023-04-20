using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSShop2
{
    public class Fruit : Product
    {
        //ATTRIBUTI
        private string typeOfFruit;
        private int piecesOfFruit;

        //COSTRUTTORE
        public Fruit (string productName, string productDescription, float productPrice, string typeOfFruit, int piecesOfFruit) : base(productName, productDescription, productPrice)
        {
            this.typeOfFruit = typeOfFruit;
            this.piecesOfFruit = piecesOfFruit;
        }
        //GETTERS
        public string GetTypeOfFruit()
        {
            return typeOfFruit;
        }

        public int GetPiecesOfFruit()
        {
            return piecesOfFruit; 
        }
    

        //SETTERS

        public void SetPiecesOfFruit(int piecesOfFruit)
        {
            if (piecesOfFruit < 0)
            {
                Console.WriteLine("Non possono esserci valori negativi per i pezzi di frutta!");
            } else if (piecesOfFruit > 5)
            {
                Console.WriteLine("La tua bustina non può contenere più di 5 pezzi di frutta!");
                
            } else 
            { 
                this.piecesOfFruit = piecesOfFruit;
            }
        }


        //METODI

        public int Eat(int eatFruit)
        {
            if (eatFruit > piecesOfFruit)
            {
                Console.WriteLine("Non c'è abbastanza frutta nella tua bustina");
                piecesOfFruit = 0;

            }
            else
            {
                piecesOfFruit -= eatFruit;
                Console.WriteLine("Ora hai: " + piecesOfFruit + " di frutta");
            }

            return piecesOfFruit;
        }

        public double FillPiecesFruit(double fillPiecesFruit)
        {
            if (fillPiecesFruit > 1.5)
            {
                Console.WriteLine("La tua bottiglia non può contenere così tanta acqua");
                waterLiters = 1.5;
            }
            double fillBottle = waterLiters + fillPiecesFruit;
            if (fillBottle > 1.5)
            {
                Console.WriteLine("la tua bottiglia sta strabordando!");
                waterLiters = 1.5;
            }
            else
            {
                waterLiters += fillPiecesFruit;
                Console.WriteLine("La tua bottiglia ora ha: " + waterLiters + " Litri");
            }

            return waterLiters;

        }

        public void ToEmpty()
        {
            waterLiters = 0;

        }

        public override void CodeName()
        {
            base.CodeName();
            Console.WriteLine("Sorgente: " + this.waterSource + "\n");
            Console.WriteLine("pH: " + this.waterPH + "\n");
            Console.WriteLine("Litri: " + this.waterLiters + "\n");
        }
    }
}
