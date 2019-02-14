namespace PiotrKoleczeklab1
{
    partial class FormMain
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonChange = new System.Windows.Forms.Button();
            this.text1 = new System.Windows.Forms.TextBox();
            this.buttonMore = new System.Windows.Forms.Button();
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.textMultiply = new System.Windows.Forms.TextBox();
            this.timerStart = new System.Windows.Forms.Timer(this.components);
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.labelCounter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(467, 327);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(103, 60);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.Text = "Zamknij";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(119, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 67);
            this.label1.TabIndex = 1;
            this.label1.Text = "Piotr Kołeczek";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonChange
            // 
            this.buttonChange.Location = new System.Drawing.Point(12, 79);
            this.buttonChange.Name = "buttonChange";
            this.buttonChange.Size = new System.Drawing.Size(99, 70);
            this.buttonChange.TabIndex = 2;
            this.buttonChange.Text = "Zmień kolory";
            this.buttonChange.UseVisualStyleBackColor = true;
            this.buttonChange.Click += new System.EventHandler(this.buttonChange_Click);
            // 
            // text1
            // 
            this.text1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.text1.Location = new System.Drawing.Point(420, 79);
            this.text1.Name = "text1";
            this.text1.Size = new System.Drawing.Size(150, 22);
            this.text1.TabIndex = 3;
            this.text1.TextChanged += new System.EventHandler(this.text1_TextChanged);
            // 
            // buttonMore
            // 
            this.buttonMore.Location = new System.Drawing.Point(235, 79);
            this.buttonMore.Name = "buttonMore";
            this.buttonMore.Size = new System.Drawing.Size(99, 70);
            this.buttonMore.TabIndex = 4;
            this.buttonMore.Text = "Zwiększ liczbę";
            this.buttonMore.UseVisualStyleBackColor = true;
            this.buttonMore.Click += new System.EventHandler(this.buttonMore_Click);
            // 
            // buttonMultiply
            // 
            this.buttonMultiply.Location = new System.Drawing.Point(12, 327);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(99, 60);
            this.buttonMultiply.TabIndex = 5;
            this.buttonMultiply.Text = "Przemnóż liczby";
            this.buttonMultiply.UseVisualStyleBackColor = true;
            this.buttonMultiply.Click += new System.EventHandler(this.buttonMultiply_Click);
            // 
            // textMultiply
            // 
            this.textMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textMultiply.Location = new System.Drawing.Point(296, 351);
            this.textMultiply.Name = "textMultiply";
            this.textMultiply.Size = new System.Drawing.Size(100, 21);
            this.textMultiply.TabIndex = 6;
            this.textMultiply.TextChanged += new System.EventHandler(this.textMultiply_TextChanged);
            // 
            // timerStart
            // 
            this.timerStart.Tick += new System.EventHandler(this.timerStart_Tick);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(420, 126);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(59, 23);
            this.buttonStart.TabIndex = 7;
            this.buttonStart.Text = "Start!";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(508, 126);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(62, 23);
            this.buttonStop.TabIndex = 8;
            this.buttonStop.Text = "Stop!";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.resultLabel.Location = new System.Drawing.Point(190, 354);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(100, 15);
            this.resultLabel.TabIndex = 9;
            this.resultLabel.Text = "Wynik mnożenia:";
            // 
            // labelCounter
            // 
            this.labelCounter.AutoSize = true;
            this.labelCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelCounter.Location = new System.Drawing.Point(366, 82);
            this.labelCounter.Name = "labelCounter";
            this.labelCounter.Size = new System.Drawing.Size(48, 15);
            this.labelCounter.TabIndex = 10;
            this.labelCounter.Text = "Licznik:";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 399);
            this.Controls.Add(this.labelCounter);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.textMultiply);
            this.Controls.Add(this.buttonMultiply);
            this.Controls.Add(this.buttonMore);
            this.Controls.Add(this.text1);
            this.Controls.Add(this.buttonChange);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonClose);
            this.Name = "FormMain";
            this.Text = "Okienko";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonChange;
        private System.Windows.Forms.TextBox text1;
        private System.Windows.Forms.Button buttonMore;
        private System.Windows.Forms.Button buttonMultiply;
        private System.Windows.Forms.TextBox textMultiply;
        private System.Windows.Forms.Timer timerStart;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Label labelCounter;
    }
}

