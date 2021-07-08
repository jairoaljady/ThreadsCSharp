
namespace MultiThread
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnHilo1 = new System.Windows.Forms.Button();
            this.btnHilo2 = new System.Windows.Forms.Button();
            this.btnHilo3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnHilo1
            // 
            this.btnHilo1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHilo1.Image = ((System.Drawing.Image)(resources.GetObject("btnHilo1.Image")));
            this.btnHilo1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnHilo1.Location = new System.Drawing.Point(12, 12);
            this.btnHilo1.Name = "btnHilo1";
            this.btnHilo1.Size = new System.Drawing.Size(69, 74);
            this.btnHilo1.TabIndex = 0;
            this.btnHilo1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnHilo1.UseVisualStyleBackColor = true;
            this.btnHilo1.Click += new System.EventHandler(this.btnHilo1_Click);
            // 
            // btnHilo2
            // 
            this.btnHilo2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHilo2.Image = ((System.Drawing.Image)(resources.GetObject("btnHilo2.Image")));
            this.btnHilo2.Location = new System.Drawing.Point(105, 12);
            this.btnHilo2.Name = "btnHilo2";
            this.btnHilo2.Size = new System.Drawing.Size(75, 74);
            this.btnHilo2.TabIndex = 0;
            this.btnHilo2.UseVisualStyleBackColor = true;
            this.btnHilo2.Click += new System.EventHandler(this.btnHilo2_Click);
            // 
            // btnHilo3
            // 
            this.btnHilo3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHilo3.Image = ((System.Drawing.Image)(resources.GetObject("btnHilo3.Image")));
            this.btnHilo3.Location = new System.Drawing.Point(197, 12);
            this.btnHilo3.Name = "btnHilo3";
            this.btnHilo3.Size = new System.Drawing.Size(75, 74);
            this.btnHilo3.TabIndex = 0;
            this.btnHilo3.UseVisualStyleBackColor = true;
            this.btnHilo3.Click += new System.EventHandler(this.btnHilo3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hilo 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hilo 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(215, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Hilo 3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHilo3);
            this.Controls.Add(this.btnHilo2);
            this.Controls.Add(this.btnHilo1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Actividad 2: Desarrollo de aplicaciones multitarea (multithread)";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHilo1;
        private System.Windows.Forms.Button btnHilo2;
        private System.Windows.Forms.Button btnHilo3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

