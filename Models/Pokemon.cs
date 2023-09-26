using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class Pokemon : IClassModel
    {
        public int Id { get; set; }
        public int DexNumber { get; set; }
        public string Name { get; set; }
        public string Form { get; set; }
        public string Type1 { get; set; }
        public string Type2 { get; set; }
        public int Total { get; set; }
        public int Hp { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int SpecialAttack { get; set; }
        public int SpecialDefense { get; set;}
        public int speed { get; set; }
        public int Generation { get; set; }

        public Pokemon() 
        {
          Id = 0;
            DexNumber = 0;
            Name = string.Empty;
            Form = string.Empty;
            Type1 = string.Empty;
            Type2 = string.Empty;
            Total = 0;
            Hp = 0;
            Attack = 0;
            Defense = 0;
            SpecialAttack = 0;
            SpecialDefense = 0;
            speed = 0;
            Generation = 0;
        }

        public Pokemon(int id, int dexNumber, string name, string form, string type1, string type2, int total, int hp, int attack, int defense, int specialAttack, int specialDefense, int speed, int generation)
        {
            Id = id;
            DexNumber = dexNumber;
            Name = name;
            Form = form;
            Type1 = type1;
            Type2 = type2;
            Total = total;
            Hp = hp;
            Attack = attack;
            Defense = defense;
            SpecialAttack = specialAttack;
            SpecialDefense = specialDefense;
            this.speed = speed;
            Generation = generation;
        }

        public override string ToString()
        {
            string PokeString = string.Empty;

            PokeString += $"Id: {Id}\n";
            PokeString += $"DexNumber: {DexNumber}\n";
            PokeString += $"Name: {Name} \n";
            PokeString += $"Form: {Form} \n";
            PokeString += $"Type1: {Type1} \n";
            PokeString += $"Type2: {Type2} \n";
            PokeString += $"Total: {Total} \n";
            PokeString += $"Hp: {Hp} \n";
            PokeString += $"Attack: {Attack} \n";
            PokeString += $"Defense: {Defense} \n";
            PokeString += $"Special Attack: {SpecialAttack}  \n";
            PokeString += $"Special Defense: {SpecialDefense}  \n";
            PokeString += $"Speed: {speed}  \n";
            PokeString += $"Generation: {Generation}  \n";

            return PokeString;
        }
    }
}
