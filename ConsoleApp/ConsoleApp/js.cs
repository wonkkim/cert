//using System;
//using System.Text;
//using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Collections.Generic;


namespace ConsoleApp
{
    class js
    {
        public void Generate()
        {
            double[] pos1 = new[] { 100.0, 200, 300 };
            double[] pos2 = new[] { -10.0, -20, -30 };
            double[] pos3 = new[] { 100.0, 200, 300 };
            List<double> pos5 = new List<double>() { 1.0, 2, 3 };
            List<double> pos6 = new List<double>() { 5.0, 1, 0 };
            List<double> pos7 = new List<double>() { 6.0, -2, 8 };

            List<double[]> posarr = new List<double[]>();
            posarr.Add(pos1); posarr.Add(pos2); posarr.Add(pos3);

            List<List<double>> poslist = new List<List<double>>();
            poslist.Add(pos5); poslist.Add(pos6); poslist.Add(pos7);

            JArray jarr = new JArray();
            for (int i = 0; i < posarr.Count; i++)
            {
                JObject jo = new JObject(
                    new JProperty("Name", string.Format("Pos{0}", i)),
                    new JProperty("Pos", posarr[i])
                    );
                jarr.Add(jo);
            };

            JArray jlist = new JArray();
            for (int i = 0; i < poslist.Count; i++)
            {
                JObject jo = new JObject(
                    new JProperty("Name", string.Format("Pos{0}", i+5)),
                    new JProperty("Pos", poslist[i])
                    );
                jlist.Add(jo);
            }

            JObject j0 = new JObject(
                new JProperty("Interpolation", jarr)
                );
            File.WriteAllText("jarr.json", j0.ToString());

            JObject j1 = new JObject(
                new JProperty("Interpolation", jlist)
                );
            File.WriteAllText("jlist.json", j1.ToString());
        }
    }
}
