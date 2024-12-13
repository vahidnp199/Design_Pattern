public abstract class DataSourceDecorator : DataSource
{
    private readonly DataSource _wrappee;
    protected DataSourceDecorator(DataSource wrappee)
    {
        _wrappee = wrappee;
    }

    public override void ReadData()
    {
      _wrappee.ReadData();
    }
}
