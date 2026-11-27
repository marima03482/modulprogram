using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mari
{

    class cat
    {
        string breed;
        string name;
        string color;
        int age;
        static void Main(string[] args)
        {
            cat cat1 = new cat();
            cat1.breed = "персидская";
            cat1.name = "барсик";
            cat1.color = "белый";
            cat1.age = 3;


            cat cat2 = new cat();
            cat2.breed = " мейн-кун";
            cat2.name = "лео";
            cat2.color = "рыжий";
            cat2.age = 5;


            cat cat3 = new cat();
            cat3.breed = "сфинкс";
            cat3.name = "локи";
            cat3.color = "серый";
            cat3.age = 2;
        }
    }
}
