using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using dart_scpi;
using System.Diagnostics;

namespace ut_dart_scpi
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestReadWrite()
        {
            scpi s = new scpi();
            s.connect();
            s.write(":CALC1:PAR1:DEF S11");
            //s.write(":SENS1:FREQ:DATA?");
            //s.write(":SENS:SWE:POIN?");
            s.write(":CALC1:DATA:FDAT?");
            string response = s.read();
            string[] vals = response.Split(',');
            Debug.WriteLine("Num params: {0}", vals.Length);
            s.close();
        }

        [TestMethod]
        public void TestWrite()
        {
            scpi s = new scpi();
            s.connect();
            s.write(":CALC1:PAR1:DEF S12");
            s.close();
        }

        [TestMethod]
        public void TestSParam()
        {
            scpi s = new scpi();
            s.connect();

            Double[] mags;
            Double[] phas;
            s.GetData("S11",out mags,out phas);

            foreach (Double mag in mags)
            {
                Debug.Write(mag.ToString());
                Debug.Write(", ");
            }

            Debug.WriteLine("\nMAG Total: {0} ", mags.Length);

            foreach (Double pha in phas)
            {
                Debug.Write(pha.ToString());
                Debug.Write(", ");
            }

            Debug.WriteLine("\nPHA Total: {0} ", phas.Length);
            s.close();
        }

        [TestMethod]
        public void TestGetMode()
        {
            scpi s = new scpi();
            s.connect();
            string mode = s.GetMode();
            Debug.Print("Mode: " + mode);
            s.close();
        }

        [TestMethod]
        public void TestSetPoints()
        {
            scpi s = new scpi();
            s.connect();
            s.SetPoints(402);
            s.GetPoints();
            s.close();
        }

        [TestMethod]
        public void TestGetPoints()
        {
            scpi s = new scpi();
            s.connect();
            s.GetPoints();
            s.close();
        }

        [TestMethod]
        public void TestSetSmith()
        {
            scpi s = new scpi();
            s.connect();
            s.SetSmithChart();
            s.close();
        }

        [TestMethod]
        public void TestSetMLOG()
        {
            scpi s = new scpi();
            s.connect();
            s.SetLogMag();
            s.close();
        }

        [TestMethod]
        public void TestGetFrequencies()
        {
            scpi s = new scpi();
            s.connect();
            Double[] fs = s.GetFrequencies();
            foreach(Double f in fs)
            {
                Debug.Write (f.ToString());
                Debug.Write(", ");
            }
            Debug.WriteLine("\nTotal: {0} ", fs.Length);
            s.close();
        }
    }
}
