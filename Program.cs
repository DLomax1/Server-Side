namespace Lab3
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string dbPath = "D:\\Fall 23\\Server side\\Labs\\Lab3\\QueryBuilderStarterKit\\Lab3\\Lab3\\Data\\data.db";
            var queryBuilder = new QueryBuilder(dbPath);
            queryBuilder.DeleteAll<Pokemon>();

            List<Pokemon> pokemon = new List<Pokemon>
            {
                new Pokemon() { Id = 23, DexNumber = 23, Name = "Eknas",Form = string.Empty, Type1= "Posion", Type2 = string.Empty, Total = 288, Hp= 35,Attack = 60, Defense = 44, SpecialAttack =40, SpecialDefense = 54,speed = 55,Generation = 1 } ,
                new Pokemon() {Id = 357 , DexNumber = 357, Name = "Banette", Form = string.Empty, Type1 = "Ghost", Type2 = string.Empty, Total = 455, Hp = 64, Attack =115 , Defense = 65 , SpecialAttack = 83, SpecialDefense = 63 , speed = 65, Generation = 3}
            };

            foreach (Pokemon pokemonn in pokemon)
            {
                queryBuilder.Create(pokemonn);
            }

            Pokemon NewPokemon = new Pokemon { Id = 450, DexNumber = 450, Name = "Spiritomb", Form = string.Empty, Type1 = "Ghost", Type2 = "Dark", Total = 485, Hp = 50, Attack = 92, Defense = 108, SpecialAttack = 92, SpecialDefense = 108, speed = 35, Generation = 4 };

            queryBuilder.Create(NewPokemon);

            foreach(Pokemon poke in pokemon)
            {
                Console.WriteLine(poke);
            }

            List<BannedGame> bannedGames = new List<BannedGame> 
            {
                new BannedGame() {Id = 4 },
                new BannedGame() {Id = 25}
            };
            foreach (BannedGame banned in bannedGames) 
            { 
                queryBuilder.Create(banned);
            }

            BannedGame NewBan = new BannedGame {Id = 6};
            queryBuilder.Create(NewBan);
        }
    }
}