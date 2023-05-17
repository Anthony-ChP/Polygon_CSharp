using polygon;



DPolygon dacha = new DPolygon();

dacha.DAddVertex(885.92, 285.23);
dacha.DAddVertex(905.23, 289.76);
dacha.DAddVertex(884.55, 330.37);
dacha.DAddVertex(867.07, 329.62);

dacha.DPolygonPrint();
Console.WriteLine($"Perimeter: {dacha.DPerimeter()}") ;
Console.WriteLine($"Square: {dacha.DSquare()}");