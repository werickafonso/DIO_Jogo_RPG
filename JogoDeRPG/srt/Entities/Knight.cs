namespace JogoDeRPG.srt.Entities
{
    public class Knight : Hero
    {
        public Knight(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public override string ToString()
        {
            return this.Name + " " + this.Level + " " + this.HeroType;
        }

        public override string Attack()
        {
            return this.Name + " Atacou com sua espada";
        }

    }
}