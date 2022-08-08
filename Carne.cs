class Carne : Decorador
{
    public Carne(OrdenBase pedido) : base(pedido){}

    public override double CalcularTotalPrecio()
    {
        return base.CalcularTotalPrecio() + 1.0;
    }
}