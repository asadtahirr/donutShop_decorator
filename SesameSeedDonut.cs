namespace DonutShop
{
    public class SesameSeedDonut : Donut
    {
        private decimal Cost { get; set; } = 2;
        public override decimal GetCost()
        {
            return Cost;
        } 
    }
}