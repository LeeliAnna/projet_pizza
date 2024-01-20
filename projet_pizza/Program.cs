using projet_pizza.Models;

namespace projet_pizza
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Pizza> pizzas = new List<Pizza>()
            {
            new Pizza("A l'ail", 7.5f, true, new List<string> { "ail" }),
            new Pizza("Margherita", 10f, true, new List < string > {"sauce tomate", "mozzarella", "origan" }),
            new Pizza("proscuitto", 11.5f, false, new List < string > {"sauce tomate", "mozzarella", "jambon" }),
            new Pizza("Funghi", 11.5f, true, new List < string > {"sauce tomate", "mozzarella", "champignons" }),
            new Pizza("Salame", 11.5f, false, new List < string > {"sauce tomate", "mozzarella", "salami piquant" }),
            new Pizza("Hawaï", 12f, false, new List < string > {"sauce tomate", "mozzarella", "jambon", "ananas" }),
            new Pizza("Regina", 12f, false, new List < string > { "sauce tomate", "mozzarella", "jambon", "champignons" }),
            new Pizza("Napoli", 12.5f, false, new List < string > { "sauce tomate", "mozzarella", "câpres", "olives", "anchois" }),
            new Pizza("Calzone", 12.5f, false, new List < string > { "sauce tomate", "mozzarella", "jambon", "champignons" }),
            new Pizza("Tonno", 12.5f, false, new List < string > { "sauce tomate", "mozzarella", "thon", "oignons" }),
            new Pizza("Etna", 16f, false, new List < string > { "sauce tomate", "mozzarella", "champignons", "salami piquant", "oeuf", }),
            new Pizza("4 stagioni", 12.5f, false, new List < string > { "sauce tomate", "mozzarella", "jambon", "champignons", "olives", "artichaut"}),
            new Pizza("4 fromaggi", 11.5f, true, new List < string > { "sauce tomate", "mozzarella", "taleggio", "gorgonzola", "parmesan"}),
            new Pizza("Parmigiana", 13.5f, true, new List < string > { "sauce tomate", "mozzarella", "aubergines", "ail", "parmesan"}),
            new Pizza("Lardière", 13.5f, false, new List < string > { "sauce tomate", "mozzarella", "lardons", "oignons" }),
            new Pizza("Fermière", 13.5f, false, new List < string > { "sauce tomate", "mozzarella", "salami piquant", "jambon", "lardons"}),
            new Pizza("Pastore", 13.5f, false, new List < string > { "sauce tomate", "mozzarella", "lardons", "fromage de chèvre", "miel"}),
            new Pizza("Campagnola", 14f, false, new List < string > { "sauce tomate", "mozzarella", "jambon", "poivrons", "oignons", "ail", "parmesan"}),
            new Pizza("Végétarienne", 14.5f, true, new List < string > { "sauce tomate", "mozzarella", "aubergines", "poivrons", "oignons", "champignons", "artichaut"}),
            new Pizza("Casa", 14.5f, false, new List < string > { "sauce tomate", "mozzarella", "brocoli", "saucisses (faites maison)"}),
            new Pizza("Pecorina", 14f, false, new List < string > { "sauce tomate", "mozzarella", "salami piquant", "poivrons", "fromage de chèvre", "miel"}),
            new Pizza("Contadina", 15.5f, false, new List < string > { "sauce tomate", "mozzarella", "jambon", "salami piquant", "taleggio", "gorgonzola", "parmesan" }),
            new Pizza("Parma", 15.5f, false, new List < string > { "sauce tomate", "mozzarella", "jambon de Parme", "roquette", "copeaux de parmesan" }),
            new Pizza("Carpaccio", 15f, false, new List < string > { "sauce tomate", "mozzarella", "carpaccio de boeuf", "roquette", "copeaux de parmesan", "crème de balsamique" }),
            new Pizza("Scampis", 15.5f, false, new List < string > { "sauce tomate", "mozzarella", "scampis", "ail"}),
            new Pizza("Pasquale", 15.5f, false, new List < string > { "sauce tomate", "mozzarella", "épinards", "saucisse (faite maison)", "taleggio", "ail" }),
            new Pizza("Esplosiva", 16f, false, new List < string > { "sauce tomate", "mozzarella", "salami", "saucisse (faite maison)", "oignons", "poivrons", "ail", "parmesan" }),
            new Pizza("Argayon", 15.5f, false, new List < string > { "sauce tomate", "mozzarella", "aubergine", "saucisse (faite maison)", "parmesan", "huile à l'ail" }),
            new Pizza("Barbecue", 16f, false, new List < string > { "sauce barbecue (faite maison)", "mozzarella", "poulet mariné (fait maison)", "oigons rouges", "oignons frits", "speck (lard italien)" }),
            new Pizza("Nutella", 7.5f, true, new List < string > { "nutella" }),
            new PizzaPersonnalisee(),
            new PizzaPersonnalisee(),
            };


            //List<Pizza> pizzaVegeratienne = pizzas.Where(pizza => pizza.vegetarienne == true).ToList();
            //List<Pizza> pizzaTomates = pizzas.Where(pizza => pizza.ContientIngredient("scampi")).ToList();

            foreach (Pizza _pizza in pizzas)
            {
                _pizza.Afficher();
            }

            //5 + 1.5 par ingredient




        }

    }
}