namespace dart_scpi_ui
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.two = new System.Windows.Forms.Button();
            this.none = new System.Windows.Forms.Button();
            this.all = new System.Windows.Forms.Button();
            this.s44 = new System.Windows.Forms.CheckBox();
            this.s34 = new System.Windows.Forms.CheckBox();
            this.s24 = new System.Windows.Forms.CheckBox();
            this.s14 = new System.Windows.Forms.CheckBox();
            this.s43 = new System.Windows.Forms.CheckBox();
            this.s33 = new System.Windows.Forms.CheckBox();
            this.s23 = new System.Windows.Forms.CheckBox();
            this.s13 = new System.Windows.Forms.CheckBox();
            this.s42 = new System.Windows.Forms.CheckBox();
            this.s32 = new System.Windows.Forms.CheckBox();
            this.s22 = new System.Windows.Forms.CheckBox();
            this.s12 = new System.Windows.Forms.CheckBox();
            this.s41 = new System.Windows.Forms.CheckBox();
            this.s31 = new System.Windows.Forms.CheckBox();
            this.s21 = new System.Windows.Forms.CheckBox();
            this.s11 = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.end = new dart_scpi_ui.NumericTextBox();
            this.start = new dart_scpi_ui.NumericTextBox();
            this.span = new dart_scpi_ui.NumericTextBox();
            this.center = new dart_scpi_ui.NumericTextBox();
            this.full = new System.Windows.Forms.Button();
            this.uEnd = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.uStart = new System.Windows.Forms.ComboBox();
            this.uSpan = new System.Windows.Forms.ComboBox();
            this.uCenter = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.browse = new System.Windows.Forms.Button();
            this.file = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.analyse = new System.Windows.Forms.Button();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.plot = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.numpoints = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plot)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numpoints)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.two);
            this.groupBox1.Controls.Add(this.none);
            this.groupBox1.Controls.Add(this.all);
            this.groupBox1.Controls.Add(this.s44);
            this.groupBox1.Controls.Add(this.s34);
            this.groupBox1.Controls.Add(this.s24);
            this.groupBox1.Controls.Add(this.s14);
            this.groupBox1.Controls.Add(this.s43);
            this.groupBox1.Controls.Add(this.s33);
            this.groupBox1.Controls.Add(this.s23);
            this.groupBox1.Controls.Add(this.s13);
            this.groupBox1.Controls.Add(this.s42);
            this.groupBox1.Controls.Add(this.s32);
            this.groupBox1.Controls.Add(this.s22);
            this.groupBox1.Controls.Add(this.s12);
            this.groupBox1.Controls.Add(this.s41);
            this.groupBox1.Controls.Add(this.s31);
            this.groupBox1.Controls.Add(this.s21);
            this.groupBox1.Controls.Add(this.s11);
            this.groupBox1.Location = new System.Drawing.Point(9, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 131);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "S-Parameters";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // two
            // 
            this.two.Location = new System.Drawing.Point(255, 27);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(76, 22);
            this.two.TabIndex = 18;
            this.two.Text = "Two Port";
            this.two.UseVisualStyleBackColor = true;
            this.two.Click += new System.EventHandler(this.two_Click);
            // 
            // none
            // 
            this.none.Location = new System.Drawing.Point(255, 87);
            this.none.Name = "none";
            this.none.Size = new System.Drawing.Size(76, 23);
            this.none.TabIndex = 17;
            this.none.Text = "Select None";
            this.none.UseVisualStyleBackColor = true;
            this.none.Click += new System.EventHandler(this.none_Click);
            // 
            // all
            // 
            this.all.Location = new System.Drawing.Point(255, 57);
            this.all.Name = "all";
            this.all.Size = new System.Drawing.Size(76, 22);
            this.all.TabIndex = 16;
            this.all.Text = "Select All";
            this.all.UseVisualStyleBackColor = true;
            this.all.Click += new System.EventHandler(this.all_Click);
            // 
            // s44
            // 
            this.s44.AutoSize = true;
            this.s44.Location = new System.Drawing.Point(187, 97);
            this.s44.Name = "s44";
            this.s44.Size = new System.Drawing.Size(45, 17);
            this.s44.TabIndex = 15;
            this.s44.Text = "S44";
            this.s44.UseVisualStyleBackColor = true;
            // 
            // s34
            // 
            this.s34.AutoSize = true;
            this.s34.Location = new System.Drawing.Point(187, 74);
            this.s34.Name = "s34";
            this.s34.Size = new System.Drawing.Size(45, 17);
            this.s34.TabIndex = 14;
            this.s34.Text = "S34";
            this.s34.UseVisualStyleBackColor = true;
            // 
            // s24
            // 
            this.s24.AutoSize = true;
            this.s24.Location = new System.Drawing.Point(187, 51);
            this.s24.Name = "s24";
            this.s24.Size = new System.Drawing.Size(45, 17);
            this.s24.TabIndex = 13;
            this.s24.Text = "S24";
            this.s24.UseVisualStyleBackColor = true;
            // 
            // s14
            // 
            this.s14.AutoSize = true;
            this.s14.Location = new System.Drawing.Point(187, 28);
            this.s14.Name = "s14";
            this.s14.Size = new System.Drawing.Size(45, 17);
            this.s14.TabIndex = 12;
            this.s14.Text = "S14";
            this.s14.UseVisualStyleBackColor = true;
            // 
            // s43
            // 
            this.s43.AutoSize = true;
            this.s43.Location = new System.Drawing.Point(136, 97);
            this.s43.Name = "s43";
            this.s43.Size = new System.Drawing.Size(45, 17);
            this.s43.TabIndex = 11;
            this.s43.Text = "S43";
            this.s43.UseVisualStyleBackColor = true;
            // 
            // s33
            // 
            this.s33.AutoSize = true;
            this.s33.Location = new System.Drawing.Point(136, 74);
            this.s33.Name = "s33";
            this.s33.Size = new System.Drawing.Size(45, 17);
            this.s33.TabIndex = 10;
            this.s33.Text = "S33";
            this.s33.UseVisualStyleBackColor = true;
            // 
            // s23
            // 
            this.s23.AutoSize = true;
            this.s23.Location = new System.Drawing.Point(136, 51);
            this.s23.Name = "s23";
            this.s23.Size = new System.Drawing.Size(45, 17);
            this.s23.TabIndex = 9;
            this.s23.Text = "S23";
            this.s23.UseVisualStyleBackColor = true;
            // 
            // s13
            // 
            this.s13.AutoSize = true;
            this.s13.Location = new System.Drawing.Point(136, 28);
            this.s13.Name = "s13";
            this.s13.Size = new System.Drawing.Size(45, 17);
            this.s13.TabIndex = 8;
            this.s13.Text = "S13";
            this.s13.UseVisualStyleBackColor = true;
            // 
            // s42
            // 
            this.s42.AutoSize = true;
            this.s42.Location = new System.Drawing.Point(85, 97);
            this.s42.Name = "s42";
            this.s42.Size = new System.Drawing.Size(45, 17);
            this.s42.TabIndex = 7;
            this.s42.Text = "S42";
            this.s42.UseVisualStyleBackColor = true;
            // 
            // s32
            // 
            this.s32.AutoSize = true;
            this.s32.Location = new System.Drawing.Point(85, 74);
            this.s32.Name = "s32";
            this.s32.Size = new System.Drawing.Size(45, 17);
            this.s32.TabIndex = 6;
            this.s32.Text = "S32";
            this.s32.UseVisualStyleBackColor = true;
            // 
            // s22
            // 
            this.s22.AutoSize = true;
            this.s22.Location = new System.Drawing.Point(85, 51);
            this.s22.Name = "s22";
            this.s22.Size = new System.Drawing.Size(45, 17);
            this.s22.TabIndex = 5;
            this.s22.Text = "S22";
            this.s22.UseVisualStyleBackColor = true;
            // 
            // s12
            // 
            this.s12.AutoSize = true;
            this.s12.Location = new System.Drawing.Point(85, 28);
            this.s12.Name = "s12";
            this.s12.Size = new System.Drawing.Size(45, 17);
            this.s12.TabIndex = 4;
            this.s12.Text = "S12";
            this.s12.UseVisualStyleBackColor = true;
            // 
            // s41
            // 
            this.s41.AutoSize = true;
            this.s41.Location = new System.Drawing.Point(34, 97);
            this.s41.Name = "s41";
            this.s41.Size = new System.Drawing.Size(45, 17);
            this.s41.TabIndex = 3;
            this.s41.Text = "S41";
            this.s41.UseVisualStyleBackColor = true;
            // 
            // s31
            // 
            this.s31.AutoSize = true;
            this.s31.Location = new System.Drawing.Point(34, 74);
            this.s31.Name = "s31";
            this.s31.Size = new System.Drawing.Size(45, 17);
            this.s31.TabIndex = 2;
            this.s31.Text = "S31";
            this.s31.UseVisualStyleBackColor = true;
            // 
            // s21
            // 
            this.s21.AutoSize = true;
            this.s21.Location = new System.Drawing.Point(34, 51);
            this.s21.Name = "s21";
            this.s21.Size = new System.Drawing.Size(45, 17);
            this.s21.TabIndex = 1;
            this.s21.Text = "S21";
            this.s21.UseVisualStyleBackColor = true;
            // 
            // s11
            // 
            this.s11.AutoSize = true;
            this.s11.Location = new System.Drawing.Point(34, 28);
            this.s11.Name = "s11";
            this.s11.Size = new System.Drawing.Size(45, 17);
            this.s11.TabIndex = 0;
            this.s11.Text = "S11";
            this.s11.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.end);
            this.groupBox2.Controls.Add(this.start);
            this.groupBox2.Controls.Add(this.span);
            this.groupBox2.Controls.Add(this.center);
            this.groupBox2.Controls.Add(this.full);
            this.groupBox2.Controls.Add(this.uEnd);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.uStart);
            this.groupBox2.Controls.Add(this.uSpan);
            this.groupBox2.Controls.Add(this.uCenter);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(9, 150);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(366, 103);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Frequency Control";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // end
            // 
            this.end.AllowSpace = false;
            this.end.Location = new System.Drawing.Point(232, 72);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(71, 20);
            this.end.TabIndex = 16;
            this.end.TextChanged += new System.EventHandler(this.end_TextChanged);
            // 
            // start
            // 
            this.start.AllowSpace = false;
            this.start.Location = new System.Drawing.Point(48, 73);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(71, 20);
            this.start.TabIndex = 15;
            this.start.TextChanged += new System.EventHandler(this.start_TextChanged);
            // 
            // span
            // 
            this.span.AllowSpace = false;
            this.span.Location = new System.Drawing.Point(107, 45);
            this.span.Name = "span";
            this.span.Size = new System.Drawing.Size(71, 20);
            this.span.TabIndex = 14;
            this.span.TextChanged += new System.EventHandler(this.span_TextChanged);
            // 
            // center
            // 
            this.center.AllowSpace = false;
            this.center.Location = new System.Drawing.Point(107, 19);
            this.center.Name = "center";
            this.center.Size = new System.Drawing.Size(71, 20);
            this.center.TabIndex = 13;
            this.center.TextChanged += new System.EventHandler(this.center_TextChanged);
            // 
            // full
            // 
            this.full.Location = new System.Drawing.Point(248, 18);
            this.full.Name = "full";
            this.full.Size = new System.Drawing.Size(84, 22);
            this.full.TabIndex = 12;
            this.full.Text = "Full Span";
            this.full.UseVisualStyleBackColor = true;
            this.full.Click += new System.EventHandler(this.full_Click);
            // 
            // uEnd
            // 
            this.uEnd.Enabled = false;
            this.uEnd.FormattingEnabled = true;
            this.uEnd.Items.AddRange(new object[] {
            "Hz",
            "KHz",
            "MHz",
            "GHz"});
            this.uEnd.Location = new System.Drawing.Point(309, 73);
            this.uEnd.Name = "uEnd";
            this.uEnd.Size = new System.Drawing.Size(48, 21);
            this.uEnd.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(197, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "End";
            // 
            // uStart
            // 
            this.uStart.Enabled = false;
            this.uStart.FormattingEnabled = true;
            this.uStart.Items.AddRange(new object[] {
            "Hz",
            "KHz",
            "MHz",
            "GHz"});
            this.uStart.Location = new System.Drawing.Point(125, 72);
            this.uStart.Name = "uStart";
            this.uStart.Size = new System.Drawing.Size(48, 21);
            this.uStart.TabIndex = 8;
            // 
            // uSpan
            // 
            this.uSpan.FormattingEnabled = true;
            this.uSpan.Items.AddRange(new object[] {
            "Hz",
            "KHz",
            "MHz",
            "GHz"});
            this.uSpan.Location = new System.Drawing.Point(184, 45);
            this.uSpan.Name = "uSpan";
            this.uSpan.Size = new System.Drawing.Size(48, 21);
            this.uSpan.TabIndex = 7;
            this.uSpan.SelectedIndexChanged += new System.EventHandler(this.uSpan_SelectedIndexChanged);
            // 
            // uCenter
            // 
            this.uCenter.FormattingEnabled = true;
            this.uCenter.Items.AddRange(new object[] {
            "Hz",
            "KHz",
            "MHz",
            "GHz"});
            this.uCenter.Location = new System.Drawing.Point(184, 19);
            this.uCenter.Name = "uCenter";
            this.uCenter.Size = new System.Drawing.Size(48, 21);
            this.uCenter.TabIndex = 6;
            this.uCenter.SelectedIndexChanged += new System.EventHandler(this.uCenter_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Start";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Frequency Span";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Center Frequency";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.browse);
            this.groupBox3.Controls.Add(this.file);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(9, 263);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(366, 79);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "File Options";
            // 
            // browse
            // 
            this.browse.Location = new System.Drawing.Point(289, 37);
            this.browse.Name = "browse";
            this.browse.Size = new System.Drawing.Size(68, 19);
            this.browse.TabIndex = 2;
            this.browse.Text = "Browse";
            this.browse.UseVisualStyleBackColor = true;
            this.browse.Click += new System.EventHandler(this.browse_click);
            // 
            // file
            // 
            this.file.Enabled = false;
            this.file.Location = new System.Drawing.Point(12, 37);
            this.file.Name = "file";
            this.file.Size = new System.Drawing.Size(271, 20);
            this.file.TabIndex = 1;
            this.file.TextChanged += new System.EventHandler(this.file_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Data Save Location";
            // 
            // analyse
            // 
            this.analyse.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.analyse.Location = new System.Drawing.Point(221, 352);
            this.analyse.Name = "analyse";
            this.analyse.Size = new System.Drawing.Size(154, 41);
            this.analyse.TabIndex = 3;
            this.analyse.Text = "Analyse";
            this.analyse.UseVisualStyleBackColor = true;
            this.analyse.Click += new System.EventHandler(this.analyse_Click);
            // 
            // progress
            // 
            this.progress.Location = new System.Drawing.Point(9, 402);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(995, 28);
            this.progress.TabIndex = 4;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.plot);
            this.groupBox4.Location = new System.Drawing.Point(381, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(623, 381);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "S-Parameter Magnitude";
            // 
            // plot
            // 
            chartArea1.AxisX.Maximum = 8.5D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisY.Maximum = 10D;
            chartArea1.AxisY.Minimum = -30D;
            chartArea1.CursorX.Interval = 0.5D;
            chartArea1.Name = "chart";
            this.plot.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.plot.Legends.Add(legend1);
            this.plot.Location = new System.Drawing.Point(3, 16);
            this.plot.Name = "plot";
            this.plot.Size = new System.Drawing.Size(614, 359);
            this.plot.TabIndex = 0;
            this.plot.Text = "S-Parameters";
            this.plot.Click += new System.EventHandler(this.plot_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.numpoints);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Location = new System.Drawing.Point(9, 345);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(206, 48);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Resolution Control";
            // 
            // numpoints
            // 
            this.numpoints.Location = new System.Drawing.Point(118, 18);
            this.numpoints.Maximum = new decimal(new int[] {
            1601,
            0,
            0,
            0});
            this.numpoints.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numpoints.Name = "numpoints";
            this.numpoints.Size = new System.Drawing.Size(74, 20);
            this.numpoints.TabIndex = 5;
            this.numpoints.Value = new decimal(new int[] {
            201,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Number of Points";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 442);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.progress);
            this.Controls.Add(this.analyse);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "DART-SCPI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.plot)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numpoints)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox s11;
        private System.Windows.Forms.CheckBox s44;
        private System.Windows.Forms.CheckBox s34;
        private System.Windows.Forms.CheckBox s24;
        private System.Windows.Forms.CheckBox s14;
        private System.Windows.Forms.CheckBox s43;
        private System.Windows.Forms.CheckBox s33;
        private System.Windows.Forms.CheckBox s23;
        private System.Windows.Forms.CheckBox s13;
        private System.Windows.Forms.CheckBox s42;
        private System.Windows.Forms.CheckBox s32;
        private System.Windows.Forms.CheckBox s22;
        private System.Windows.Forms.CheckBox s12;
        private System.Windows.Forms.CheckBox s41;
        private System.Windows.Forms.CheckBox s31;
        private System.Windows.Forms.CheckBox s21;
        private System.Windows.Forms.Button none;
        private System.Windows.Forms.Button all;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox uEnd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox uStart;
        private System.Windows.Forms.ComboBox uSpan;
        private System.Windows.Forms.ComboBox uCenter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button full;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button browse;
        private System.Windows.Forms.TextBox file;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button analyse;
        private System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataVisualization.Charting.Chart plot;
        private System.Windows.Forms.Button two;
        private NumericTextBox end;
        private NumericTextBox start;
        private NumericTextBox span;
        private NumericTextBox center;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.NumericUpDown numpoints;
        private System.Windows.Forms.Label label8;
    }
}

