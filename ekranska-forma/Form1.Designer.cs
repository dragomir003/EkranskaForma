
namespace ekranska_forma
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nameTb = new System.Windows.Forms.TextBox();
            this.prijemniIspitTb = new System.Windows.Forms.TextBox();
            this.maxUcenikaTb = new System.Windows.Forms.TextBox();
            this.trajanjeTb = new System.Windows.Forms.TextBox();
            this.gotoStartButton = new System.Windows.Forms.Button();
            this.gotoPrevButton = new System.Windows.Forms.Button();
            this.gotoNextButton = new System.Windows.Forms.Button();
            this.gotoEndButton = new System.Windows.Forms.Button();
            this.izmeniButton = new System.Windows.Forms.Button();
            this.dodajButton = new System.Windows.Forms.Button();
            this.obrisiButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(112, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Naziv";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(103, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Max ucenika";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(112, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "Trajanje";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(94, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Prijemni Ispit";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameTb
            // 
            this.nameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.nameTb.Location = new System.Drawing.Point(276, 26);
            this.nameTb.Name = "nameTb";
            this.nameTb.Size = new System.Drawing.Size(267, 29);
            this.nameTb.TabIndex = 4;
            // 
            // prijemniIspitTb
            // 
            this.prijemniIspitTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.prijemniIspitTb.Location = new System.Drawing.Point(276, 229);
            this.prijemniIspitTb.Name = "prijemniIspitTb";
            this.prijemniIspitTb.Size = new System.Drawing.Size(267, 29);
            this.prijemniIspitTb.TabIndex = 5;
            // 
            // maxUcenikaTb
            // 
            this.maxUcenikaTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.maxUcenikaTb.Location = new System.Drawing.Point(276, 157);
            this.maxUcenikaTb.Name = "maxUcenikaTb";
            this.maxUcenikaTb.Size = new System.Drawing.Size(267, 29);
            this.maxUcenikaTb.TabIndex = 6;
            // 
            // trajanjeTb
            // 
            this.trajanjeTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.trajanjeTb.Location = new System.Drawing.Point(276, 87);
            this.trajanjeTb.Name = "trajanjeTb";
            this.trajanjeTb.Size = new System.Drawing.Size(267, 29);
            this.trajanjeTb.TabIndex = 7;
            // 
            // gotoStartButton
            // 
            this.gotoStartButton.Location = new System.Drawing.Point(50, 314);
            this.gotoStartButton.Name = "gotoStartButton";
            this.gotoStartButton.Size = new System.Drawing.Size(91, 34);
            this.gotoStartButton.TabIndex = 8;
            this.gotoStartButton.Text = "<<";
            this.gotoStartButton.UseVisualStyleBackColor = true;
            // 
            // gotoPrevButton
            // 
            this.gotoPrevButton.Location = new System.Drawing.Point(195, 314);
            this.gotoPrevButton.Name = "gotoPrevButton";
            this.gotoPrevButton.Size = new System.Drawing.Size(85, 34);
            this.gotoPrevButton.TabIndex = 9;
            this.gotoPrevButton.Text = "<";
            this.gotoPrevButton.UseVisualStyleBackColor = true;
            // 
            // gotoNextButton
            // 
            this.gotoNextButton.Location = new System.Drawing.Point(326, 314);
            this.gotoNextButton.Name = "gotoNextButton";
            this.gotoNextButton.Size = new System.Drawing.Size(91, 34);
            this.gotoNextButton.TabIndex = 10;
            this.gotoNextButton.Text = ">";
            this.gotoNextButton.UseVisualStyleBackColor = true;
            // 
            // gotoEndButton
            // 
            this.gotoEndButton.Location = new System.Drawing.Point(450, 313);
            this.gotoEndButton.Name = "gotoEndButton";
            this.gotoEndButton.Size = new System.Drawing.Size(91, 35);
            this.gotoEndButton.TabIndex = 11;
            this.gotoEndButton.Text = ">>";
            this.gotoEndButton.UseVisualStyleBackColor = true;
            // 
            // izmeniButton
            // 
            this.izmeniButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.izmeniButton.Location = new System.Drawing.Point(78, 412);
            this.izmeniButton.Name = "izmeniButton";
            this.izmeniButton.Size = new System.Drawing.Size(93, 41);
            this.izmeniButton.TabIndex = 12;
            this.izmeniButton.Text = "Izmeni";
            this.izmeniButton.UseVisualStyleBackColor = true;
            // 
            // dodajButton
            // 
            this.dodajButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.dodajButton.Location = new System.Drawing.Point(231, 412);
            this.dodajButton.Name = "dodajButton";
            this.dodajButton.Size = new System.Drawing.Size(93, 41);
            this.dodajButton.TabIndex = 13;
            this.dodajButton.Text = "Dodaj";
            this.dodajButton.UseVisualStyleBackColor = true;
            // 
            // obrisiButton
            // 
            this.obrisiButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.obrisiButton.Location = new System.Drawing.Point(383, 412);
            this.obrisiButton.Name = "obrisiButton";
            this.obrisiButton.Size = new System.Drawing.Size(93, 41);
            this.obrisiButton.TabIndex = 14;
            this.obrisiButton.Text = "Obrisi";
            this.obrisiButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.ClientSize = new System.Drawing.Size(579, 616);
            this.Controls.Add(this.obrisiButton);
            this.Controls.Add(this.dodajButton);
            this.Controls.Add(this.izmeniButton);
            this.Controls.Add(this.gotoEndButton);
            this.Controls.Add(this.gotoNextButton);
            this.Controls.Add(this.gotoPrevButton);
            this.Controls.Add(this.gotoStartButton);
            this.Controls.Add(this.trajanjeTb);
            this.Controls.Add(this.maxUcenikaTb);
            this.Controls.Add(this.prijemniIspitTb);
            this.Controls.Add(this.nameTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Ekranska Forma";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nameTb;
        private System.Windows.Forms.TextBox prijemniIspitTb;
        private System.Windows.Forms.TextBox maxUcenikaTb;
        private System.Windows.Forms.TextBox trajanjeTb;
        private System.Windows.Forms.Button gotoStartButton;
        private System.Windows.Forms.Button gotoPrevButton;
        private System.Windows.Forms.Button gotoNextButton;
        private System.Windows.Forms.Button gotoEndButton;
        private System.Windows.Forms.Button izmeniButton;
        private System.Windows.Forms.Button dodajButton;
        private System.Windows.Forms.Button obrisiButton;
    }
}

