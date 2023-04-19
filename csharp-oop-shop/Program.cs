// See https://aka.ms/new-console-template for more information
using csharp_oop_shop;

Product yogurtBianco = new Product("yogurt bianco", "yogurt bianco ideale per chi segue una dieta", 3.5f);

Console.WriteLine("Nome : " + yogurtBianco.GetProductName());
Console.WriteLine("Descrizione : " + yogurtBianco.GetProductDescription());
Console.WriteLine("Prezzo : " + yogurtBianco.GetProductPrice());
Console.WriteLine("Codice : " + yogurtBianco.FormattedNum());
Console.WriteLine("Codice + Nome : " + yogurtBianco.CodeName());
Console.WriteLine("L'Iva invece ammonta a : " + yogurtBianco.GetTaxIva());
