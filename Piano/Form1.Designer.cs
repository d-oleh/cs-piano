namespace Piano
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.C = new System.Windows.Forms.Button();
            this.D = new System.Windows.Forms.Button();
            this.E = new System.Windows.Forms.Button();
            this.F = new System.Windows.Forms.Button();
            this.G = new System.Windows.Forms.Button();
            this.A = new System.Windows.Forms.Button();
            this.B = new System.Windows.Forms.Button();
            this.Csharp = new System.Windows.Forms.Button();
            this.Dsharp = new System.Windows.Forms.Button();
            this.Fsharp = new System.Windows.Forms.Button();
            this.Gsharp = new System.Windows.Forms.Button();
            this.Asharp = new System.Windows.Forms.Button();
            this.panel_melody = new System.Windows.Forms.FlowLayoutPanel();
            this.Whole = new System.Windows.Forms.RadioButton();
            this.Half = new System.Windows.Forms.RadioButton();
            this.Quarter = new System.Windows.Forms.RadioButton();
            this.Eighth = new System.Windows.Forms.RadioButton();
            this.Sixteenth = new System.Windows.Forms.RadioButton();
            this.btn_play = new System.Windows.Forms.Button();
            this.btn_clean = new System.Windows.Forms.Button();
            this.Pause = new System.Windows.Forms.Button();
            this.panel_duration = new System.Windows.Forms.GroupBox();
            this.panel_duration.SuspendLayout();
            this.SuspendLayout();
            // 
            // C
            // 
            this.C.Location = new System.Drawing.Point(0, 0);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(60, 222);
            this.C.TabIndex = 0;
            this.C.Text = "C";
            this.C.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.C.UseVisualStyleBackColor = true;
            this.C.Click += new System.EventHandler(this.btn_key_Click);
            // 
            // D
            // 
            this.D.Location = new System.Drawing.Point(66, 0);
            this.D.Name = "D";
            this.D.Size = new System.Drawing.Size(60, 222);
            this.D.TabIndex = 1;
            this.D.Text = "D";
            this.D.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.D.UseVisualStyleBackColor = true;
            this.D.Click += new System.EventHandler(this.btn_key_Click);
            // 
            // E
            // 
            this.E.Location = new System.Drawing.Point(132, 0);
            this.E.Name = "E";
            this.E.Size = new System.Drawing.Size(60, 222);
            this.E.TabIndex = 2;
            this.E.Text = "E";
            this.E.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.E.UseVisualStyleBackColor = true;
            this.E.Click += new System.EventHandler(this.btn_key_Click);
            // 
            // F
            // 
            this.F.Location = new System.Drawing.Point(198, 0);
            this.F.Name = "F";
            this.F.Size = new System.Drawing.Size(60, 222);
            this.F.TabIndex = 3;
            this.F.Text = "F";
            this.F.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.F.UseVisualStyleBackColor = true;
            this.F.Click += new System.EventHandler(this.btn_key_Click);
            // 
            // G
            // 
            this.G.Location = new System.Drawing.Point(264, 0);
            this.G.Name = "G";
            this.G.Size = new System.Drawing.Size(60, 222);
            this.G.TabIndex = 4;
            this.G.Text = "G";
            this.G.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.G.UseVisualStyleBackColor = true;
            this.G.Click += new System.EventHandler(this.btn_key_Click);
            // 
            // A
            // 
            this.A.Location = new System.Drawing.Point(330, 0);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(60, 222);
            this.A.TabIndex = 5;
            this.A.Text = "A";
            this.A.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.A.UseVisualStyleBackColor = true;
            this.A.Click += new System.EventHandler(this.btn_key_Click);
            // 
            // B
            // 
            this.B.Location = new System.Drawing.Point(396, 0);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(60, 222);
            this.B.TabIndex = 6;
            this.B.Text = "B";
            this.B.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.B.UseVisualStyleBackColor = true;
            this.B.Click += new System.EventHandler(this.btn_key_Click);
            // 
            // Csharp
            // 
            this.Csharp.BackColor = System.Drawing.Color.Black;
            this.Csharp.ForeColor = System.Drawing.Color.White;
            this.Csharp.Location = new System.Drawing.Point(47, 0);
            this.Csharp.Name = "Csharp";
            this.Csharp.Size = new System.Drawing.Size(32, 149);
            this.Csharp.TabIndex = 7;
            this.Csharp.Text = "C#";
            this.Csharp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Csharp.UseVisualStyleBackColor = false;
            this.Csharp.Click += new System.EventHandler(this.btn_key_Click);
            // 
            // Dsharp
            // 
            this.Dsharp.BackColor = System.Drawing.Color.Black;
            this.Dsharp.ForeColor = System.Drawing.Color.White;
            this.Dsharp.Location = new System.Drawing.Point(113, 0);
            this.Dsharp.Name = "Dsharp";
            this.Dsharp.Size = new System.Drawing.Size(32, 149);
            this.Dsharp.TabIndex = 8;
            this.Dsharp.Text = "D#";
            this.Dsharp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Dsharp.UseVisualStyleBackColor = false;
            this.Dsharp.Click += new System.EventHandler(this.btn_key_Click);
            // 
            // Fsharp
            // 
            this.Fsharp.BackColor = System.Drawing.Color.Black;
            this.Fsharp.ForeColor = System.Drawing.Color.White;
            this.Fsharp.Location = new System.Drawing.Point(245, 0);
            this.Fsharp.Name = "Fsharp";
            this.Fsharp.Size = new System.Drawing.Size(32, 149);
            this.Fsharp.TabIndex = 9;
            this.Fsharp.Text = "F#";
            this.Fsharp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Fsharp.UseVisualStyleBackColor = false;
            this.Fsharp.Click += new System.EventHandler(this.btn_key_Click);
            // 
            // Gsharp
            // 
            this.Gsharp.BackColor = System.Drawing.Color.Black;
            this.Gsharp.ForeColor = System.Drawing.Color.White;
            this.Gsharp.Location = new System.Drawing.Point(311, 0);
            this.Gsharp.Name = "Gsharp";
            this.Gsharp.Size = new System.Drawing.Size(32, 149);
            this.Gsharp.TabIndex = 10;
            this.Gsharp.Text = "G#";
            this.Gsharp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Gsharp.UseVisualStyleBackColor = false;
            this.Gsharp.Click += new System.EventHandler(this.btn_key_Click);
            // 
            // Asharp
            // 
            this.Asharp.BackColor = System.Drawing.Color.Black;
            this.Asharp.ForeColor = System.Drawing.Color.White;
            this.Asharp.Location = new System.Drawing.Point(377, 0);
            this.Asharp.Name = "Asharp";
            this.Asharp.Size = new System.Drawing.Size(32, 149);
            this.Asharp.TabIndex = 11;
            this.Asharp.Text = "A#";
            this.Asharp.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Asharp.UseVisualStyleBackColor = false;
            this.Asharp.Click += new System.EventHandler(this.btn_key_Click);
            // 
            // panel_melody
            // 
            this.panel_melody.Location = new System.Drawing.Point(0, 228);
            this.panel_melody.Name = "panel_melody";
            this.panel_melody.Size = new System.Drawing.Size(554, 210);
            this.panel_melody.TabIndex = 12;
            // 
            // Whole
            // 
            this.Whole.AutoSize = true;
            this.Whole.Checked = true;
            this.Whole.Location = new System.Drawing.Point(6, 19);
            this.Whole.Name = "Whole";
            this.Whole.Size = new System.Drawing.Size(31, 17);
            this.Whole.TabIndex = 13;
            this.Whole.TabStop = true;
            this.Whole.Text = "1";
            this.Whole.UseVisualStyleBackColor = true;
            // 
            // Half
            // 
            this.Half.AutoSize = true;
            this.Half.Location = new System.Drawing.Point(6, 42);
            this.Half.Name = "Half";
            this.Half.Size = new System.Drawing.Size(42, 17);
            this.Half.TabIndex = 14;
            this.Half.Text = "1/2";
            this.Half.UseVisualStyleBackColor = true;
            // 
            // Quarter
            // 
            this.Quarter.AutoSize = true;
            this.Quarter.Location = new System.Drawing.Point(6, 65);
            this.Quarter.Name = "Quarter";
            this.Quarter.Size = new System.Drawing.Size(42, 17);
            this.Quarter.TabIndex = 15;
            this.Quarter.Text = "1/4";
            this.Quarter.UseVisualStyleBackColor = true;
            // 
            // Eighth
            // 
            this.Eighth.AutoSize = true;
            this.Eighth.Location = new System.Drawing.Point(6, 88);
            this.Eighth.Name = "Eighth";
            this.Eighth.Size = new System.Drawing.Size(42, 17);
            this.Eighth.TabIndex = 16;
            this.Eighth.Text = "1/8";
            this.Eighth.UseVisualStyleBackColor = true;
            // 
            // Sixteenth
            // 
            this.Sixteenth.AutoSize = true;
            this.Sixteenth.Location = new System.Drawing.Point(6, 111);
            this.Sixteenth.Name = "Sixteenth";
            this.Sixteenth.Size = new System.Drawing.Size(48, 17);
            this.Sixteenth.TabIndex = 17;
            this.Sixteenth.Text = "1/16";
            this.Sixteenth.UseVisualStyleBackColor = true;
            // 
            // btn_play
            // 
            this.btn_play.Location = new System.Drawing.Point(462, 170);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(79, 23);
            this.btn_play.TabIndex = 18;
            this.btn_play.Text = "Play";
            this.btn_play.UseVisualStyleBackColor = true;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // btn_clean
            // 
            this.btn_clean.Location = new System.Drawing.Point(462, 199);
            this.btn_clean.Name = "btn_clean";
            this.btn_clean.Size = new System.Drawing.Size(79, 23);
            this.btn_clean.TabIndex = 19;
            this.btn_clean.Text = "Clean";
            this.btn_clean.UseVisualStyleBackColor = true;
            this.btn_clean.Click += new System.EventHandler(this.btn_clean_Click);
            // 
            // Pause
            // 
            this.Pause.Location = new System.Drawing.Point(462, 0);
            this.Pause.Name = "Pause";
            this.Pause.Size = new System.Drawing.Size(79, 23);
            this.Pause.TabIndex = 20;
            this.Pause.Text = "P";
            this.Pause.UseVisualStyleBackColor = true;
            this.Pause.Click += new System.EventHandler(this.btn_key_Click);
            // 
            // panel_duration
            // 
            this.panel_duration.Controls.Add(this.Whole);
            this.panel_duration.Controls.Add(this.Half);
            this.panel_duration.Controls.Add(this.Quarter);
            this.panel_duration.Controls.Add(this.Sixteenth);
            this.panel_duration.Controls.Add(this.Eighth);
            this.panel_duration.Location = new System.Drawing.Point(462, 29);
            this.panel_duration.Name = "panel_duration";
            this.panel_duration.Size = new System.Drawing.Size(79, 135);
            this.panel_duration.TabIndex = 21;
            this.panel_duration.TabStop = false;
            this.panel_duration.Text = "Duration";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 440);
            this.Controls.Add(this.Pause);
            this.Controls.Add(this.btn_clean);
            this.Controls.Add(this.btn_play);
            this.Controls.Add(this.panel_melody);
            this.Controls.Add(this.Asharp);
            this.Controls.Add(this.Gsharp);
            this.Controls.Add(this.Fsharp);
            this.Controls.Add(this.Dsharp);
            this.Controls.Add(this.Csharp);
            this.Controls.Add(this.B);
            this.Controls.Add(this.A);
            this.Controls.Add(this.G);
            this.Controls.Add(this.F);
            this.Controls.Add(this.E);
            this.Controls.Add(this.D);
            this.Controls.Add(this.C);
            this.Controls.Add(this.panel_duration);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel_duration.ResumeLayout(false);
            this.panel_duration.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button C;
        private System.Windows.Forms.Button D;
        private System.Windows.Forms.Button E;
        private System.Windows.Forms.Button F;
        private System.Windows.Forms.Button G;
        private System.Windows.Forms.Button A;
        private System.Windows.Forms.Button B;
        private System.Windows.Forms.Button Csharp;
        private System.Windows.Forms.Button Dsharp;
        private System.Windows.Forms.Button Fsharp;
        private System.Windows.Forms.Button Gsharp;
        private System.Windows.Forms.Button Asharp;
        private System.Windows.Forms.FlowLayoutPanel panel_melody;
        private System.Windows.Forms.RadioButton Whole;
        private System.Windows.Forms.RadioButton Half;
        private System.Windows.Forms.RadioButton Quarter;
        private System.Windows.Forms.RadioButton Eighth;
        private System.Windows.Forms.RadioButton Sixteenth;
        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.Button btn_clean;
        private System.Windows.Forms.Button Pause;
        private System.Windows.Forms.GroupBox panel_duration;
    }
}

