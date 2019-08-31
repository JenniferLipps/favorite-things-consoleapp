using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings.FavThings
{
    enum AnimalColor
    {
        Brown,
        Black,
        Red,
        Green,
        White,
        Spots,
        Stripes
    }

    enum AnimalSpecies
    {
        Dog,
        Cat,
        Horse,
        Snake,
        Bird,
        Lizard
    }

    class Animal
    {
        public AnimalSpecies Species { get; set; }

        public AnimalColor Color { get; set; }

        public string Name { get; set; }


        public Animal(string name, AnimalSpecies species, AnimalColor color)
        {
            Name = name;
            Species = species;
            Color = color;

        }
        

    }
    
}
