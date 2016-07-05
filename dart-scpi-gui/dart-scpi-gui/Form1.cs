using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dart_scpi;
using System.Threading;
using System.Windows.Forms.DataVisualization.Charting;

namespace dart_scpi_ui
{

    public partial class Form1 : Form
    {
        int unitCenter = 3;
        int unitSpan = 3;
        int unitStart = 3;
        int unitEnd = 3;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            full_span();
            s11.Checked = true; s12.Checked = true; s21.Checked = true; s22.Checked = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void browse_click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Comma Seperated List|*.csv";
            saveFileDialog1.Title = "Designate Data Export File";

            var thread = new Thread(new ParameterizedThreadStart(param => { saveFileDialog1.ShowDialog(); }));
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            thread.Join();

            if (saveFileDialog1.FileName != "")
            {
                // Saves the Image via a FileStream created by the OpenFile method.
                file.Text = saveFileDialog1.FileName;
            }
        }

        private void all_Click(object sender, EventArgs e)
        {
            s11.Checked = true; s12.Checked = true; s13.Checked = true; s14.Checked = true;
            s21.Checked = true; s22.Checked = true; s23.Checked = true; s24.Checked = true;
            s31.Checked = true; s32.Checked = true; s33.Checked = true; s34.Checked = true;
            s41.Checked = true; s42.Checked = true; s43.Checked = true; s44.Checked = true;
        }

        private void none_Click(object sender, EventArgs e)
        {
            s11.Checked = false; s12.Checked = false; s13.Checked = false; s14.Checked = false;
            s21.Checked = false; s22.Checked = false; s23.Checked = false; s24.Checked = false;
            s31.Checked = false; s32.Checked = false; s33.Checked = false; s34.Checked = false;
            s41.Checked = false; s42.Checked = false; s43.Checked = false; s44.Checked = false;
        }

        private void full_Click(object sender, EventArgs e)
        {
            full_span();
        }

        private void full_span()
        {
            updateCenter = false; updateSpan = false; updateStart = false; updateEnd = false;
            unitCenter = 3; unitSpan = 3; unitStart = 3; unitEnd = 3;
            center.Text = "4.25"; uCenter.SelectedIndex = 3;
            span.Text = "8.5"; uSpan.SelectedIndex = 3;
            start.Text = "0.0"; uStart.SelectedIndex = 3;
            end.Text = "8.5"; uEnd.SelectedIndex = 3;
            updateCenter = true; updateSpan = true; updateStart = true; updateEnd = true;
        }

        private void two_Click(object sender, EventArgs e)
        {
            s11.Checked = true; s12.Checked = true; s13.Checked = false; s14.Checked = false;
            s21.Checked = true; s22.Checked = true; s23.Checked = false; s24.Checked = false;
            s31.Checked = false; s32.Checked = false; s33.Checked = false; s34.Checked = false;
            s41.Checked = false; s42.Checked = false; s43.Checked = false; s44.Checked = false;
        }


        bool updateCenter = true;
        bool updateSpan = true;
        bool updateStart = true;
        bool updateEnd = true;

        private void center_TextChanged(object sender, EventArgs e)
        {
            if (!updateCenter)
            {
                return;
            }
            double fo = rescale(rectify(center.DoubleValue, uCenter.SelectedIndex), uCenter.SelectedIndex - uSpan.SelectedIndex);
            double bw = span.DoubleValue;

            updateStart = false;
            updateEnd = false;

            uStart.SelectedIndex = uSpan.SelectedIndex;
            uEnd.SelectedIndex = uSpan.SelectedIndex;

            double hbw = bw / 2;
            start.Text = format(fo-hbw, uSpan.SelectedIndex).ToString();
            end.Text = format(fo+hbw, uSpan.SelectedIndex).ToString();

            updateStart = true;
            updateEnd = true;
        }

        private double rectify(double val, int unit)
        {
            double value = rescale(val, unit);
            if (val < 0.0d)
                return 0.0d;
            else if (value > 8500000000d)
                return rescale(8500000000d, -unit);
            else
                return val;
        }

        private double resround(double val, int unit)
        {
            val = rescale(val, unit);
            return Math.Round(val * 1000.0d) / 1000.0d;
        }

        //Rescales in bandwidth frequency unit
        private double format(double val, int unit)
        {
            val = rectify(val, unit);
            return rescale(Math.Round(val* 1000.0) / 1000.0, unit - uSpan.SelectedIndex);
        }

        private double rescale(double val, int unit)
        {
            return val*Math.Pow(10.0d, unit*3);
        }

        private void span_TextChanged(object sender, EventArgs e)
        {
            if (!updateSpan)
            {
                return;
            }

            double fo = rescale(rectify(center.DoubleValue, uCenter.SelectedIndex), uCenter.SelectedIndex - uSpan.SelectedIndex);
            double bw = span.DoubleValue;

            updateStart = false;
            updateEnd = false;

            uStart.SelectedIndex = uSpan.SelectedIndex;
            uEnd.SelectedIndex = uSpan.SelectedIndex;

            double hbw = bw / 2;
            start.Text = format(fo - hbw, uSpan.SelectedIndex).ToString();
            end.Text = format(fo + hbw, uSpan.SelectedIndex).ToString();

            updateStart = true;
            updateEnd = true;
        }

        private void uCenter_SelectedIndexChanged(object sender, EventArgs e)
        {
            center.Text = Convert.ToString(rescale(center.DoubleValue,  unitCenter-uCenter.SelectedIndex));
            unitCenter = uCenter.SelectedIndex;
        }

        private void uSpan_SelectedIndexChanged(object sender, EventArgs e)
        {
            span.Text = Convert.ToString(rescale(span.DoubleValue, unitSpan - uSpan.SelectedIndex));
            unitSpan = uSpan.SelectedIndex;
        }

        private void start_TextChanged(object sender, EventArgs e)
        {
            if (!updateStart)
            {
                return;
            }
            updateCenter = false;
            updateSpan = false;

            double sVal = rescale(start.DoubleValue, uStart.SelectedIndex - uSpan.SelectedIndex);
            double eVal = rescale(end.DoubleValue, uEnd.SelectedIndex - uSpan.SelectedIndex);

            double bw = eVal - sVal;
            double hbw = bw / 2;

            center.Text = rectify(resround(hbw + sVal, uSpan.SelectedIndex - uCenter.SelectedIndex), uCenter.SelectedIndex)
                .ToString();
            span.Text = rectify(bw, uSpan.SelectedIndex).ToString();

            updateCenter = true;
            updateSpan = true;
        }

        private void end_TextChanged(object sender, EventArgs e)
        {
            if (!updateEnd)
            {
                return;
            }
            updateCenter = false;
            updateSpan = false;

            double sVal = rescale(start.DoubleValue, uStart.SelectedIndex - uSpan.SelectedIndex);
            double eVal = rescale(end.DoubleValue, uEnd.SelectedIndex - uSpan.SelectedIndex);

            double bw = eVal - sVal;
            double hbw = bw / 2;

            center.Text = rectify(resround(hbw + sVal, uSpan.SelectedIndex - uCenter.SelectedIndex), uCenter.SelectedIndex)
                .ToString();
            span.Text = rectify(bw, uSpan.SelectedIndex).ToString();

            updateCenter = true;
            updateSpan = true;
        }

        private void analyse_Click(object sender, EventArgs e)
        {
            string filename = file.Text;
            //open file
            FileStream fs;
            try
            {
                fs = File.Open(filename, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
            } catch (IOException ex)
            {
                MessageBox.Show("Cannot open file to writing. Make sure other programs are not currently using the file", 
                    "Save file occupied.",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
                return;
            } catch (ArgumentException ex)
            {
                MessageBox.Show("Please Choose a Save File.", "Invalid File",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Error);
                return;
            }

            StreamWriter sw = new StreamWriter(fs);

            analyse.Enabled = false;
            scpi s = new scpi();
            s.connect();

            plot.Series.Clear();

            //set frequency control
            s.SetFrequency(rescale(start.DoubleValue, uStart.SelectedIndex), rescale(end.DoubleValue, uEnd.SelectedIndex));

            int num = s.GetPoints();

            Thread.Sleep(500);

            s.SetPoints(Decimal.ToInt32(numpoints.Value));

            Thread.Sleep(500);

            //iterate through all S-Parameters
            Boolean[] stoggle = new Boolean[16];
            stoggle[0] = s11.Checked; stoggle[1] = s12.Checked; stoggle[2] = s13.Checked; stoggle[3] = s14.Checked;
            stoggle[4] = s21.Checked; stoggle[5] = s22.Checked; stoggle[6] = s23.Checked; stoggle[7] = s24.Checked;
            stoggle[8] = s31.Checked; stoggle[9] = s32.Checked; stoggle[10] = s33.Checked; stoggle[11] = s34.Checked;
            stoggle[12] = s41.Checked; stoggle[13] = s42.Checked; stoggle[14] = s43.Checked; stoggle[15] = s44.Checked;

            int maxprog = 0;
            for(int i=0; i<16; i++)
            {
                if (stoggle[i])
                {
                    maxprog++;
                }
            }
            progress.Minimum = 0;
            progress.Maximum = maxprog;
            progress.Value = progress.Minimum;

            double[] freqs = s.GetFrequencies();
            Thread.Sleep(200);
            string freqstr = "Frequency,"+String.Join(",", freqs.Select(p => p.ToString()).ToArray());
            sw.WriteLine(freqstr);


            for (int i=0; i<freqs.Length; i++)
            {
                double freq = freqs[i];
                freqs[i] = rescale(freq, -uStart.SelectedIndex);
            }

            plot.ChartAreas["chart"].AxisX.Minimum = freqs[0];
            plot.ChartAreas["chart"].AxisX.Maximum = freqs[freqs.Length-1];
            plot.ChartAreas["chart"].AxisX.Title = "Frequency "+uStart.Text;
            plot.ChartAreas["chart"].AxisX.LabelStyle.Format = "{0:0}.#";

            //plot.ChartAreas["chart"].AxisX.Interval = freqs[0];

            double yMax = Double.MinValue;
            double yMin = Double.MaxValue;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (stoggle[i * 4 + j])
                    {
                        string sparam = "S"+(i+1).ToString() + (j+1).ToString();
                        Double[] magnitudes;
                        Double[] phases;
                        s.GetData(sparam, out magnitudes, out phases);
                        Thread.Sleep(500);
                        string magcsv = String.Join(",", magnitudes.Select(p => p.ToString()).ToArray());
                        string phacsv = String.Join(",", phases.Select(p => p.ToString()).ToArray());

                        magcsv = "Mag(" + sparam + ")," + magcsv;
                        phacsv = "Pha(" + sparam + ")," + phacsv;
                        sw.WriteLine(magcsv);
                        sw.WriteLine(phacsv);

                        var series = new System.Windows.Forms.DataVisualization.Charting.Series
                        {
                            Name = sparam,
                            IsVisibleInLegend = true,
                            IsXValueIndexed = false,
                            ChartType = SeriesChartType.Line,
                        };
                        
                        plot.Series.Add(series);
                        for(int k=0; k<magnitudes.Length; k++)
                        {
                            series.Points.AddXY(freqs[k], magnitudes[k]);
                        }
                        plot.Invalidate();
                        if (magnitudes.Min() < yMin)
                            yMin = magnitudes.Min();
                        if (magnitudes.Max() > yMax)
                            yMax = magnitudes.Max();
                        progress.Value++;
                    }
                }
            }
            fs.Close();

            plot.ChartAreas["chart"].AxisY.Minimum = yMin-5;
            plot.ChartAreas["chart"].AxisY.Maximum = yMax+5;
            plot.ChartAreas["chart"].AxisY.LabelStyle.Format = "{0:0}.#";
            plot.ChartAreas["chart"].AxisY.Title = "Magnitude (dB)";

            s.SetPoints(num);
            s.close();
            analyse.Enabled = true;

        }

        private void file_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void plot_Click(object sender, EventArgs e)
        {

        }

        private void aboutDARTSCPIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Copyright \u00A9 Davis Adaptive RF Technology Laboratory \nand Jun D. Ouyang 2016. All Rights Reserved.",
                "About DART-SCPI",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
            return;
        }
    }
}
