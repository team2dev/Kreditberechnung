﻿
namespace Kreditberechnung
{
    partial class KreditAuswahl
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
            this.btn_EinmalKredit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_EinmalKredit
            // 
            this.btn_EinmalKredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EinmalKredit.Location = new System.Drawing.Point(259, 56);
            this.btn_EinmalKredit.Name = "btn_EinmalKredit";
            this.btn_EinmalKredit.Size = new System.Drawing.Size(282, 82);
            this.btn_EinmalKredit.TabIndex = 0;
            this.btn_EinmalKredit.Text = "Kredit mit einmaliger Rückzahlung";
            this.btn_EinmalKredit.UseVisualStyleBackColor = true;
            this.btn_EinmalKredit.Click += new System.EventHandler(this.btn_EinmalKredit_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(259, 184);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(282, 82);
            this.button1.TabIndex = 1;
            this.button1.Text = "Ratenkredit, Vorgabe der Laufzeit";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(259, 311);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(282, 82);
            this.button2.TabIndex = 2;
            this.button2.Text = "Ratenkredit, Vorgabe der Ratenhöhe";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // KreditAuswahl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_EinmalKredit);
            this.Name = "KreditAuswahl";
            this.Text = "Form3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_EinmalKredit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}