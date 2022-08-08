class Decorador:OrdenBase
{
    protected OrdenBase pedido;

    public Decorador(OrdenBase pedido)
    {
        this.pedido = pedido;
    }

    public virtual double CalcularTotalPrecio()
    {
        Console.WriteLine("Calculando desde el decorador...");
        return pedido.CalcularTotalPrecio();
    }
}