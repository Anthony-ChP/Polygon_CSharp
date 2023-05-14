using polygon;


DPoint a = new DPoint();
//Console.Write("Vvedi X: ");
a.x = 0;
//Console.Write("Vvedi Y: ");
a.y = 0;
DPolygon dacha = new DPolygon();
dacha.DAddVertex(10, 10);
dacha.DAddVertex(10, 0);
dacha.DAddVertex(0, 0);
dacha.DAddVertex(0, 10);

Console.WriteLine(dacha.DPerimeter());

//dacha.DPolygonPrint();


