using System.Runtime.InteropServices.Marshalling;

namespace OOP.UnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            Rectanle rectanle = new Square();
            var area = Area(rectanle);
            Assert.Equal(120, area);
        }

        public int Area(Rectanle rectanle)
        {
            if (rectanle is Rectanle)
            {

                rectanle.SetH(10);
                rectanle.SetW(12);

            }
            else
            {
                rectanle.SetH(10);
                rectanle.SetW(10);
            }
            return rectanle.Area();
        }
    }


    public class Rectanle
    {
        protected int _h, _w;
        public virtual void SetH(int h)
        {
            _h = h;
        }
        public virtual void SetW(int w)
        {
            _w = w;
        }
        public virtual int Area()
        {
            return _h * _w;
        }

    }

    public class Square : Rectanle
    {
        public void setSide(int side)
        {
            _h = side;
        }
        public override int Area()
        {
            return _h * _h;
        }
    }
}