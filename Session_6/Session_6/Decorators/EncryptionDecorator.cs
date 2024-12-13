public class EncryptionDecorator : DataSourceDecorator
{
    public EncryptionDecorator(DataSource wrappee) : base(wrappee)
    {

    }

    public override void ReadData()
    { 
        base.ReadData();
        Console.WriteLine("EncryptionDecorator read");
    }
}
