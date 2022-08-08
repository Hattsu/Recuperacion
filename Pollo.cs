class Pollo: Decorador
{
    public Pollo(OrdenBase pedido) : base(pedido){}

    public override double CalcularTotalPrecio()
    {
        return base.CalcularTotalPrecio() + 1.50;
    }
}