using polygon;


DPoint a = new DPoint();
//Console.Write("Vvedi X: ");
a.x = 0;
//Console.Write("Vvedi Y: ");
a.y = 0;
DPolygon dacha = new DPolygon();
a.CreatePointXY(885.92, 285.23);
dacha.DAddVertex(a);
a.CreatePointXY(905.23, 289.76);
dacha.DAddVertex(a);
a.CreatePointXY(884.55, 330.37);
dacha.DAddVertex(a);
a.CreatePointXY(867.07, 329.62);
dacha.DAddVertex(a);

dacha.DPolygonPrint();
Console.WriteLine($"Perimeter: {dacha.DPerimeter()}") ;
