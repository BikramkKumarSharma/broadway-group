using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broadway.ConsoleApp.Subject
{
   public interface Bikram
    {
        void BikramName();
        void BikramClass();
    }

    //public class Bikesh : Bikram
    //{
    //    public void BikramClass()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void BikramName()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}

    public class Bijay : Bikram
    {

        public int lenght = 4; //{ get; set; }
        public int breadth = 3;//{ get; set; }
        public void BikramClass()
        {
            Console.WriteLine($"Area={this.lenght * this.breadth}");
            
        }

        public void BikramName()
        {
            Console.WriteLine($"Perimeter={2*(this.lenght * this.breadth)}");
            
        }
    }

}
