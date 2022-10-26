namespace DonutShop
{
    public class WholeWheatDonut : Donut
    {
        private decimal Cost { get; set; } = 3;
        public override decimal GetCost()
        {
            return Cost;
        }
    }
}