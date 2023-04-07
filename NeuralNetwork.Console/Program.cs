using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.DataVisualization.Charting;

using NeuralNetwork.Classes;

namespace NeuralNetwork.Konsole
{
    public class Program
    {
        private static void Main(string[] args)
        {
            //for (int i = 0; i < 1000; i++)
            //{
            //    Console.WriteLine();
            //    Test1();
            //}

            Console.WriteLine();
            Test1();
        }
        private static void Test1()
        {
            Network nn = new Network(21.5, new int[] { 2, 4, 2 }); //21.5 learningRate , 2 4 2 - слои
            List<double> ins = new List<double>
            {
                0,
                1
            };

            //Network nn = new Network(21.5, new int[] { 4, 3, 3 }); //21.5 learningRate , 2 4 2 - слои
            /*List<double> ins = new List<double>
            {
                0,
                1,
                2,
                3,
            };*/

            //double[] ots = nn.Run(ins);
            //for (int i = 0; i < ots.Length; i++)
            //{
            //    Console.WriteLine(ots[i].ToString());
            //}

            List<double> ots = new List<double> 
            {
                1
            };
            Console.WriteLine(nn.Train(ins, ots));
        }
    }
}
