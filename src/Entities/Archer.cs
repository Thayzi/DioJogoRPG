namespace ExercicioJogos.src.Entities
{
    public class Archer : Hero
    {
        public Archer(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public override string Attack()
        {
            return this.Name + " Atirou com arco e flecha";
        }
    }
}