namespace ExercicioJogos.src.Entities
{
    public abstract class Hero
    {
        public Hero(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public Hero()
        {
            
        }

      public string Name;
      public int Level;
      public string HeroType;

      public override string ToString()
      {
          return this.Name + " " + this.Level + " " + this.HeroType;
      }
      public virtual string Attack()
      {
          throw new System.Exception("Implementar metodo");
      }
      public virtual string Attack(int Bonus)
        {
            if (Bonus > 5)
            {
                return this.Name + " Ataque efetivo com bônus de: " + Bonus;
            }else{
                return this.Name + " Ataque fraco com bônus de: " + Bonus;
            }
        }
    }
}