using polygon;


DPoint a = new DPoint();
//Console.Write("Vvedi X: ");
a.x = 0;
//Console.Write("Vvedi Y: ");
a.y = 0;
DPolygon dacha = new DPolygon();
a.CreatePointXY(10, 10);
dacha.DAddVertex(a);
a.CreatePointXY(10, 0);
dacha.DAddVertex(a);
a.CreatePointXY(0, 0);
dacha.DAddVertex(a);
a.CreatePointXY(0, 10);
dacha.DAddVertex(a);

dacha.DPolygonPrint();
Console.WriteLine($"Периметр многоугольника равен: {dacha.DPerimeter()}") ;
