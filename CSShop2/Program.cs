// See https://aka.ms/new-console-template for more information

using CSShop2;

Shop supermercato = new Shop("Pick up", "Salerno", "Via dei Mille", 21);

Water ferrarelle = new Water("Acqua Ferrarelle", "Effervescente Naturale", 1.5f, 1.0, "Riardo" );

ferrarelle.Drink(1.2);

ferrarelle.FillBottle(1);

ferrarelle.CodeName();

