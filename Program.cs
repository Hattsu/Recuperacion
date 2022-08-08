class  Program
{
    public static void Main (string []args)
    {
        
        var orden1=new Taco();
        Console.WriteLine($"El precio de un Taco es de: {orden1.CalcularTotalPrecio()}");
        var chile=new Chile(orden1);
        Console.WriteLine($"Al agregarle un chile el precio es de: {chile.CalcularTotalPrecio()}");

        Console.WriteLine("");
        Console.WriteLine("------------------------------------");


        var orden2=new Tamales();
        Console.WriteLine($"El precio de un Tamal es de: {orden2.CalcularTotalPrecio()}");
        var chile2=new Chile(orden2);
        Console.WriteLine($"Al agregarle un chile el precio es de: {chile2.CalcularTotalPrecio()}");
        var carne =new Carne(orden2);
        Console.WriteLine($"Al agregarle un chile el precio es de: {carne.CalcularTotalPrecio()}");

        Console.WriteLine("");
        Console.WriteLine("------------------------------------");


        var orden3=new Taco();
        Console.WriteLine($"El precio de un Taco es de: {orden3.CalcularTotalPrecio()}");
        var sinchile=new SinChile(orden3);
        Console.WriteLine($"Al agregarle un chile el precio es de: {sinchile.CalcularTotalPrecio()}");
        var pollo=new Pollo(orden3);
        Console.WriteLine($"Al agregarle un chile el precio es de: {pollo.CalcularTotalPrecio()}");
        Console.WriteLine("");
        Console.WriteLine("------------------------------------");
    }
}