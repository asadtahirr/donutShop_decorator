namespace DonutShop
{
    public class MapleDecorator : Donut
    {
        public Donut Donut { get; set; }

        public MapleDecorator(Donut donut)
        {
            Donut = donut;
        }

        public override decimal GetCost()
        {
            decimal cost = (decimal)0.40 + Donut.GetCost();

            return cost;
        }
    }
}
