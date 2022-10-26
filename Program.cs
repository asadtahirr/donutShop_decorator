using DonutShop;

Donut donut = new SesameSeedDonut();

donut = new MapleDecorator(donut);

donut = new MapleDecorator(donut);

donut = new ChocolateDecorator(donut);

donut = new StrawberryDecorator(donut);

donut = new VanillaDecorator(donut);




donut.SetName("Crazy donut");

Console.WriteLine(donut.GetCost());


Donut donut1 = new PlainDonut();
donut1 = new ChocolateDecorator(donut1);
donut1 = new VanillaDecorator(donut1);
donut1 = new ChocolateDecorator(donut1);

Console.WriteLine(donut1.GetCost());