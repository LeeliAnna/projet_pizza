using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet_pizza.Models
{
    public class Pizza
    {
        #region Propriétés
        public string nom { get; init; }

        public float prix { get; init; }

        public bool vegetarienne { get; init; }

        public List<string> ingredients { get; protected set; }
        #endregion

        #region Constructeur
        public Pizza(string nom, float prix, bool vegetarienne, List<string> ingredients)
        {
            this.nom = nom;
            this.prix = prix;
            this.vegetarienne = vegetarienne;
            this.ingredients = ingredients;
        }
        #endregion

        #region Méthodes

        public void Afficher()
        {
            Console.OutputEncoding = Encoding.UTF8;

            string nomAfficher = FormatPremiereLettreMajuscule(nom);

            Console.Write(nomAfficher);
            if (vegetarienne is true) Console.Write(" (V)");
            Console.Write(" - " + prix + "€");
            Console.WriteLine();
            //Console.WriteLine(string.Join(", " , ingredients));
            Console.Write("Ingrédients : ");
            AfficherIngredients(ingredients);
            
        }

        public void AfficherIngredients(List<string> ingredients) 
        {
            //Selction d'ingredient pour y passer une fonction 
            //List<string> ingredientsAfficher = ingredients.Select(i => FormatPremiereLettreMajuscule(i)).ToList();

            List<string> ingredientsAfficher = new List<string>();

            foreach (var ingredient in ingredients)
            {
                string ingredientAfficher = FormatPremiereLettreMajuscule(ingredient);
                ingredientsAfficher.Add(ingredientAfficher);
            }
            Console.WriteLine(string.Join(", ", ingredientsAfficher));
            // Sans fonction string.Join()
            //        string chaineConcat = "";
            //        foreach (var ingredient in ingredients)
            //        {
            //            if (chaineConcat != "") chaineConcat += ", ";
            //            chaineConcat += ingredient;
            //        }
            //        Console.WriteLine(chaineConcat);
            //        Console.WriteLine();
        }

        private static string FormatPremiereLettreMajuscule(string s)
        {
            //verification si la chaine de caractere est vide ou null
            if (string.IsNullOrEmpty(s)) return s;

            string minuscule = s.ToLower();
            string majuscule = s.ToUpper();

            // autre sintaxe pour selectionner des lettres dans une chaine de caractere
            //string resultat = majuscule[0] + minuscule.Substring(1);
            string resultat = majuscule[0] + minuscule[1..];

            return resultat;
        }

        public bool ContientIngredient(string ingredient)
        {
            return ingredients.Where(i => i.ToLower().Contains(ingredient)).ToList().Count > 0;
        }

        #endregion


    }
}
