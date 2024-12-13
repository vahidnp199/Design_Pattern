using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_6.Decorators
{
    public class CompressionDecorator : DataSourceDecorator
    {
        public CompressionDecorator(DataSource wrappee) : base(wrappee)
        {

        }

        public override void ReadData()
        {
            base.ReadData();
            Console.WriteLine("CompressionDecorator read");
        }
    }
}
