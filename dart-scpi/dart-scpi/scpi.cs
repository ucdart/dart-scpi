using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Ivi.Visa;
using Keysight.Visa;
using System.Threading;

namespace dart_scpi
{
    public class scpi
    {
        public void connect()
        {
            this.session = new GpibSession("GPIB0::16::INSTR", Ivi.Visa.AccessModes.None, TimeSpan.MaxValue);
        }

        public void write(string str)
        {
            IMessageBasedFormattedIO io = session.FormattedIO;
            try
            {
                io.PrintfAndFlush(str);
            }
            catch
            {
                Console.WriteLine("PrintfAndFlush failed");
                session.Dispose();
                session = null;
                return;
            }
        }

        public string read()
        {
            IMessageBasedFormattedIO io = session.FormattedIO;
            //string[] response = new string[] { "", "", "", "" };
            string response;
            try
            {
                response = io.ReadLine();
            }
            catch
            {
                Console.WriteLine("Scanf failed");
                session.Dispose();
                session = null;
                return null;
            }

            Debug.WriteLine(response);
            return response;
        }

        public int GetPoints()
        {
            IMessageBasedFormattedIO io = session.FormattedIO;
            write(":SENS:SWE:POIN?");
            long num = io.ReadInt64();
            Debug.Print("Num points: {0}", num);
            return (int)num;
        }

        public double[] GetFrequencies()
        {
            int numpoints = GetPoints();
            Double[] frequencies = new Double[numpoints];

            IMessageBasedFormattedIO io = session.FormattedIO;
            write(":SENS1:FREQ:DATA?");
            Thread.Sleep(500);
            io.Scanf("%,f", out frequencies);
            return frequencies;
        }

        public string GetMode()
        {
            IMessageBasedFormattedIO io = session.FormattedIO;
            write(":CALC1:FORM?");
            string mode = read();
            return mode;
        }

        public int GetWaitTime(int numpoints)
        {
            int baseTime = 200;
            double val = baseTime + 108 * Math.Log((Double)numpoints);
            return (int)Math.Round(val);
        }

        public int GetData(string sparam, out Double[] MagData, out Double[] PhaData)
        {
            string mode = GetMode();

            SetSmithChart();

            int numpoints = GetPoints();
            Double[] data = new Double[numpoints];

            IMessageBasedFormattedIO io = session.FormattedIO;
            write(":CALC1:PAR1:DEF "+sparam);

            Thread.Sleep(GetWaitTime(numpoints));
            write(":CALC1:DATA:FDAT?");
            io.Scanf("%,f", out data);

            MagData = new Double[numpoints];
            PhaData = new Double[numpoints];

            for(int i = 0; i < numpoints; i++)
            {
                double magnitude = data[i * 2];
                double phase = data[i * 2+1];
                MagData[i] = magnitude;
                PhaData[i] = phase;
            }

            SetMode(mode);
            return numpoints;
        }

        public void SetPoints(int num)
        {
            IMessageBasedFormattedIO io = session.FormattedIO;
            write(":SENS1:SWE:POIN "+num.ToString());
        }

        public void SetFrequency(double start, double end)
        {
            IMessageBasedFormattedIO io = session.FormattedIO;
            write(":SENS1:FREQ:STAR " + start.ToString());
            Thread.Sleep(10);
            write(":SENS1:FREQ:STOP " + end.ToString());
            Thread.Sleep(10);
        }

        public void SetMode(string mode)
        {
            IMessageBasedFormattedIO io = session.FormattedIO;
            write(":CALC1:FORM "+mode);
        }

        public void SetSmithChart()
        {
            SetMode("SLOG");
        }

        public void SetLogMag()
        {
            SetMode("MLOG");
        }

        public void close()
        {
            this.session.Dispose();
        }

        private GpibSession session;
    }
}
