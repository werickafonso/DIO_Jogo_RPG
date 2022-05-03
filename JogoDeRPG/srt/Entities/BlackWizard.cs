namespace JogoDeRPG.srt.Entities
{
    public class BlackWizard : Hero
    {
         public BlackWizard(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public override string Attack()
        {
            return this.Name + " Lançou Magia expecto patronum";
        }

         public string Attack(int Bonus)
        {
            if(Bonus > 9)
            {
                return this.Name + " Lançou Magia ridiculous com bônus de " + Bonus;
            }
            else
            {
                return this.Name + " Lançou Magia wingardium leviosa com bônus de " + Bonus;
            }
        }
    }
}