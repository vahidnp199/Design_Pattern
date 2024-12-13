public class CompoundGraphic : Graphic
{
    private readonly List<Graphic> _graphics=new();

    public void Add(Graphic graphic)
    {
        _graphics.Add(graphic);
    }
    public void draw()
    {
        Console.WriteLine("CompoundGraphic draw");
        foreach (Graphic graphic in _graphics)
        {
            graphic.draw();
        }
    }
}
