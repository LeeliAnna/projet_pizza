using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_pizza.Models
{
    public class PizzaPersonnalisee : Pizza
    {
        static int index;
        public PizzaPersonnalisee() : base("Personnalisée", 5, false, null) 
        {
            index++;
            nom = "Personnalisée " + index; 
            ingredients = new List<string>();

            bool IsOk = true;

            while(IsOk is true)
            {
                Console.Write($"Rentrez un ingrédient pour la pizza {nom} (ENTER pour terminer): ");
                string choix = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(choix))
                {
                    IsOk = false;
                }
                else if (ingredients.Contains(choix))
                {
                    Console.WriteLine($"ERREUR : Cet ingrédient est déjà présent dans la pizza {nom}");
                }
                else
                {
                    ingredients.Add(choix);
                    AfficherIngredients(ingredients);
                }
                Console.WriteLine();
            }

            prix = 5 + (ingredients.Count * 1.5f);
        }
    }
}
