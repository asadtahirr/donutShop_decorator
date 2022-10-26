namespace DonutShop
{   
    public class StrawberryDecorator : Donut
    {
        public Donut Donut { get; set; }

        public StrawberryDecorator(Donut donut)
        {
            Donut = donut;
        }

        public override decimal GetCost()
        {
            decimal cost = (decimal)0.80 + Donut.GetCost();

            return cost;
        }
    }
}
