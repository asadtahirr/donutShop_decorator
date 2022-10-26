namespace DonutShop
{
    public abstract class Donut
    {
        private string Name { get; set; }
        private decimal Cost { get; set; }

        public string GetName()
        {
            return Name;
        }

        public void SetName(string name)
        {
            Name = name;
        }

        public virtual decimal GetCost()
        {
            return Cost;
        }

        public void SetCost(decimal cost)
        {
            Cost = cost;
        }
    }
}
