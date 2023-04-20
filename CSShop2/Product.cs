using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSShop2
{
    public class Product
    {
        //ATTRUBUTI
        private string productName;
        private int productCode;
        private string productDescription;
        private float productPrice;
        private int taxIva;
        

        //COSTRUTTORE
        public Product(string productName, int productCode, string productDescription, float productPrice, int taxIva = 22)
        {
            this.productName = productName;
            this.productCode = RandomGen();
            this.productDescription = productDescription;
            this.productPrice = productPrice;
            this.taxIva = taxIva;
            
        }


        //GETTERS
        public string GetProductName()
        {
            return this.productName;
        }

        public int GetProductCode()
        {
            return this.productCode;

        }

        public string GetProductDescription()
        {
            return this.productDescription;
        }

        public float GetProductPrice()
        {
            return this.productPrice;
        }

        public float GetTaxIva()
        {
            float iva = (productPrice * taxIva) / 100;
            return iva;

        }

        

        //SETTERS
        public void SetProductName(string productName)
        {
            this.productName = productName;
        }

        public void SetProductDescriptione(string productDescription)
        {
            this.productDescription = productDescription;
        }

        public void SetProductPrice(float productPrice)
        {
            this.productPrice = productPrice;
        }

        //METODI

        //Generiamo un numero random intero per il codice del nostro prodotto
        private int RandomGen()
        {
            Random rnd = new Random();
            int numeroCifre = rnd.Next(1, 9);

            int codeInt = 0;

            switch (numeroCifre)
            {
                case 1:
                    codeInt = rnd.Next(1, 10);
                    break;
                case 2:
                    codeInt = rnd.Next(10, 100);
                    break;
                case 3:
                    codeInt = rnd.Next(100, 1000);
                    break;
                case 4:
                    codeInt = rnd.Next(1000, 10000);
                    break;
                case 5:
                    codeInt = rnd.Next(10000, 1000000);
                    break;
                case 6:
                    codeInt = rnd.Next(100000, 1000000);
                    break;
                case 7:
                    codeInt = rnd.Next(1000000, 10000000);
                    break;
                case 8:
                    codeInt = rnd.Next(10000000, 100000000);
                    break;

            }

            return codeInt;

        }

        public string FormattedNum()
        {
            int padding = 0;
            padding = productCode.ToString().Length;
            padding = 8 - padding;
            string zeros = "";

            for (int i = 0; i < padding; i++)
            {
                zeros += "0";

            }

            zeros = zeros + productCode;
            return zeros;

        }

        public virtual void CodeName()
        {
            string codeName = FormattedNum() + productName;
            Console.WriteLine("Il tuo prodotto è: ");
            Console.WriteLine(codeName);
        }

        public string GetProductString()
        {
            string rapprStr = "Codice prodotto: " + this.productCode + "\n";
            rapprStr += "Nome: " + this.productName + "\n";
            rapprStr += "Descrizione: " + this.productDescription + " ";
            rapprStr += "Prezzo: " + this.productPrice + "\n";
            return rapprStr;
        }

    }
}
