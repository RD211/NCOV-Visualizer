using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VIZ_NCOV
{
    public class Country
    {
        public string name;
        public string iso;
        //public string continent;
        //public string capital;
        //public string religion;
        //public string rulling;
        //public string flag;
        //public string population;
        //public string area;
        //public string density; 
        public List<int> infected;
        public List<int> dead;
        public List<int> recovered;
        //public string lifeExpectancy;
        public List<Polygon> polygons;
        public Country(string name, string iso)
        {
            this.name = name;
            this.iso = iso;
            //this.flag = "";
            //this.rulling = "";
            //this.infected = 0;
            //this.dead = 0;
            //this.area = "0";
            //this.population = "0";
            //this.density = "0";
            //this.religion = "";
            //this.capital = "";
            //this.continent = "";
            this.infected = new List<int>();
            this.dead = new List<int>();
            this.recovered = new List<int>();
            this.polygons = new List<Polygon>();
        }
        public void AddPoly(Polygon poly)
        {
            polygons.Add(poly);
        }
    }
}
