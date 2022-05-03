namespace JogoDeRPG.srt.Entities
{
    public class Ninja : Hero
    {
         public Ninja(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public override string Attack()
        {
            return this.Name + " Executou uma finalização de ninja";
        }

         public string Attack(int Bonus)
        {
            if(Bonus > 8)
            {
                return this.Name + " Efetuou golpe mortal com bônus de " + Bonus;
            }
            else
            {
                return this.Name + " efetuou golpe fraco com bônus de " + Bonus;
            }
        }
    }
}