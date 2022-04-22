using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_6
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = 1213.045;
            double y1 = 1040.663;
            double x2 = 1401.734;
            double y2 = 1143.376;
            double x3 = 1434.466;
            double y3 = 1331.594;
            double x4 = 1385.811;
            double y4 = 1549.016;
            double x5 = 1351.343;
            double y5 = 1757.744;
            double x6 = 1119.667;
            double y6 = 1629.719;
            double x7 = 1064.57;
            double y7 = 1360.432;
            double x8 = 1072.567;
            double y8 = 1170.905;
            double AB = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
            double BC = Math.Sqrt((x2 - x3) * (x2 - x3) + (y2 - y3) * (y2 - y3));
            double CD = Math.Sqrt((x3 - x4) * (x3 - x4) + (y3 - y4) * (y3 - y4));
            double DE = Math.Sqrt((x4 - x5) * (x4 - x5) + (y4 - y5) * (y4 - y5));
            double EF = Math.Sqrt((x5 - x6) * (x5 - x6) + (y5 - y6) * (y5 - y6));
            double FG = Math.Sqrt((x6 - x7) * (x6 - x7) + (y6 - y7) * (y6 - y7));
            double GH = Math.Sqrt((x7 - x8) * (x7 - x8) + (y7 - y8) * (y7 - y8));
            double HA = Math.Sqrt((x8 - x1) * (x8 - x1) + (y8 - y1) * (y8 - y1));
            double BH = Math.Sqrt((x2 - x8) * (x2 - x8) + (y2 - y8) * (y2 - y8));
            double CH = Math.Sqrt((x3 - x8) * (x3 - x8) + (y3 - y8) * (y3 - y8));
            double CG = Math.Sqrt((x3 - x7) * (x3 - x7) + (y3 - y7) * (y3 - y7));
            double DG = Math.Sqrt((x4 - x7) * (x4 - x7) + (y4 - y7) * (y4 - y7));
            double DF = Math.Sqrt((x4 - x6) * (x4 - x6) + (y4 - y6) * (y4 - y6));
            double s1 = (AB + BH + HA) / 2;
            double area1 = Math.Sqrt(s1 * (s1 - AB) * (s1 - BH) * (s1 - HA));
            double s2 = (BH + BC + CH) / 2;
            double area2 = Math.Sqrt(s2 * (s2 - BH) * (s2 - BC) * (s2 - CH));
            double s3 = (CH + CG + GH) / 2;
            double area3 = Math.Sqrt(s3 * (s3 - CH) * (s3 - CG) * (s3 - GH));
            double s4 = (CG + CD + DG) / 2;
            double area4 = Math.Sqrt(s4 * (s4 - CG) * (s4 - CD) * (s4 - DG));
            double s5 = (DG + DF + FG) / 2;
            double area5 = Math.Sqrt(s5 * (s5 - DG) * (s5 - DF) * (s5 - FG));
            double s6 = (DF + DE + EF) / 2;
            double area6 = Math.Sqrt(s6 * (s6 - DF) * (s6 - DE) * (s6 - EF));
            double area = area1 + area2 + area3 + area4 + area5 + area6;
            Console.WriteLine("1 AB={0:0.000} BH={1:0.000} HA={2:0.000} area1={3:0.000}", AB, BH, HA, area1);
            Console.WriteLine("2 BH={0:0.000} BC={1:0.000} CH={2:0.000} area2={3:0.000}", BH, BC, CH, area2);
            Console.WriteLine("3 CH={0:0.000} CG={1:0.000} GH={2:0.000} area3={3:0.000}", CH, CG, GH, area3);
            Console.WriteLine("4 CG={0:0.000} CD={1:0.000} DG={2:0.000} area4={3:0.000}", CG, CD, DG, area4);
            Console.WriteLine("5 DG={0:0.000} DF={1:0.000} FG={2:0.000} area5={3:0.000}", DG, DF, FG, area5);
            Console.WriteLine("6 DF={0:0.000} DE={1:0.000} EF={2:0.000} area6={3:0.000}", DF, DE, EF, area6);
            Console.WriteLine("area={0:0.000}", area);
            Console.ReadKey();
        }
    }
}
