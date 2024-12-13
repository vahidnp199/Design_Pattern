

//var data = new FileDataSource();
//ReaData(data);

//var ecrypt = new EncryptionDecorator(data);
//ReaData(ecrypt);

//var compress = new CompressionDecorator(ecrypt);
//ReaData(compress);
//var compress2 = new CompressionDecorator(compress);
//ReaData(compress2);

//static void ReaData(DataSource dataSource)
//{
//    dataSource.ReadData();  
//}


using Session_6;

var compos = new CompoundGraphic();
var circle = new Circle();
compos.Add(circle);
var compos2 = new CompoundGraphic();
compos2.Add(new Circle());
compos.Add(compos2);
Draw(compos);
static void Draw(Graphic graphic)
{
    graphic.draw();
}