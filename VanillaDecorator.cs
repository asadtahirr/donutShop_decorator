namespace DonutShop
{
    public class VanillaDecorator : Donut
    {
        public Donut Donut { get; set; }

        public VanillaDecorator(Donut donut)
        {
            Donut = donut;
        }

        public override decimal GetCost()
        {
            decimal cost = (decimal)0.20 + Donut.GetCost();

            return cost;
        }
    }
}
