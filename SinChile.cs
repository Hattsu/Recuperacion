class SinChile : Decorador
{
    public SinChile(OrdenBase pedido) : base(pedido){}

    public override double CalcularTotalPrecio()
    {
        return base.CalcularTotalPrecio() + 0;
    }
}