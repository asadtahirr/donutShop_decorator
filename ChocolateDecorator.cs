namespace DonutShop
{
    public class ChocolateDecorator : Donut
    {
        public Donut Donut { get; set; }

        public ChocolateDecorator(Donut donut)
        {
            Donut = donut;
        }

        public override decimal GetCost()
        {
            decimal cost = (decimal)0.60 + Donut.GetCost();

            return cost;
        }
    }
}
