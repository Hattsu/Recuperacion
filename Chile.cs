class Chile : Decorador
{
    public Chile(OrdenBase pedido) : base(pedido){}

    public override double CalcularTotalPrecio()
    {
        return base.CalcularTotalPrecio() + 0.50;
    }
}