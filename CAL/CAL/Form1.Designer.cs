namespace CAL
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbxScreen = new System.Windows.Forms.TextBox();
            this.btce = new System.Windows.Forms.Button();
            this.btc = new System.Windows.Forms.Button();
            this.btmas = new System.Windows.Forms.Button();
            this.btrest = new System.Windows.Forms.Button();
            this.btmult = new System.Windows.Forms.Button();
            this.btdiv = new System.Windows.Forms.Button();
            this.btig = new System.Windows.Forms.Button();
            this.btpor = new System.Windows.Forms.Button();
            this.bt0 = new System.Windows.Forms.Button();
            this.bt = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.bt4 = new System.Windows.Forms.Button();
            this.bt5 = new System.Windows.Forms.Button();
            this.bt6 = new System.Windows.Forms.Button();
            this.bt7 = new System.Windows.Forms.Button();
            this.bt8 = new System.Windows.Forms.Button();
            this.bt9 = new System.Windows.Forms.Button();
            this.bt1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxScreen
            // 
            this.tbxScreen.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxScreen.Location = new System.Drawing.Point(52, 61);
            this.tbxScreen.Name = "tbxScreen";
            this.tbxScreen.ReadOnly = true;
            this.tbxScreen.Size = new System.Drawing.Size(259, 29);
            this.tbxScreen.TabIndex = 39;
            this.tbxScreen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btce
            // 
            this.btce.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btce.Location = new System.Drawing.Point(264, 99);
            this.btce.Name = "btce";
            this.btce.Size = new System.Drawing.Size(47, 45);
            this.btce.TabIndex = 38;
            this.btce.Text = "CE";
            this.btce.UseVisualStyleBackColor = true;
            this.btce.Click += new System.EventHandler(this.Btce_Click);
            // 
            // btc
            // 
            this.btc.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btc.Location = new System.Drawing.Point(211, 99);
            this.btc.Name = "btc";
            this.btc.Size = new System.Drawing.Size(47, 45);
            this.btc.TabIndex = 37;
            this.btc.Text = "C";
            this.btc.UseVisualStyleBackColor = true;
            this.btc.Click += new System.EventHandler(this.Btc_Click);
            // 
            // btmas
            // 
            this.btmas.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmas.Location = new System.Drawing.Point(264, 201);
            this.btmas.Name = "btmas";
            this.btmas.Size = new System.Drawing.Size(47, 45);
            this.btmas.TabIndex = 36;
            this.btmas.Text = "+";
            this.btmas.UseVisualStyleBackColor = true;
            this.btmas.Click += new System.EventHandler(this.Btmas_Click);
            // 
            // btrest
            // 
            this.btrest.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btrest.Location = new System.Drawing.Point(264, 150);
            this.btrest.Name = "btrest";
            this.btrest.Size = new System.Drawing.Size(47, 45);
            this.btrest.TabIndex = 35;
            this.btrest.Text = "-";
            this.btrest.UseVisualStyleBackColor = true;
            this.btrest.Click += new System.EventHandler(this.Btrest_Click);
            // 
            // btmult
            // 
            this.btmult.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmult.Location = new System.Drawing.Point(211, 150);
            this.btmult.Name = "btmult";
            this.btmult.Size = new System.Drawing.Size(47, 45);
            this.btmult.TabIndex = 34;
            this.btmult.Text = "*";
            this.btmult.UseVisualStyleBackColor = true;
            this.btmult.Click += new System.EventHandler(this.Btmult_Click);
            // 
            // btdiv
            // 
            this.btdiv.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btdiv.Location = new System.Drawing.Point(211, 201);
            this.btdiv.Name = "btdiv";
            this.btdiv.Size = new System.Drawing.Size(47, 45);
            this.btdiv.TabIndex = 33;
            this.btdiv.Text = "/";
            this.btdiv.UseVisualStyleBackColor = true;
            this.btdiv.Click += new System.EventHandler(this.Btdiv_Click);
            // 
            // btig
            // 
            this.btig.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btig.Location = new System.Drawing.Point(264, 252);
            this.btig.Name = "btig";
            this.btig.Size = new System.Drawing.Size(47, 45);
            this.btig.TabIndex = 32;
            this.btig.Text = "=";
            this.btig.UseVisualStyleBackColor = true;
            this.btig.Click += new System.EventHandler(this.Btig_Click);
            // 
            // btpor
            // 
            this.btpor.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btpor.Location = new System.Drawing.Point(211, 252);
            this.btpor.Name = "btpor";
            this.btpor.Size = new System.Drawing.Size(47, 45);
            this.btpor.TabIndex = 31;
            this.btpor.Text = "%";
            this.btpor.UseVisualStyleBackColor = true;
            this.btpor.Click += new System.EventHandler(this.Btpor_Click);
            // 
            // bt0
            // 
            this.bt0.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt0.Location = new System.Drawing.Point(52, 252);
            this.bt0.Name = "bt0";
            this.bt0.Size = new System.Drawing.Size(100, 45);
            this.bt0.TabIndex = 30;
            this.bt0.Text = "0";
            this.bt0.UseVisualStyleBackColor = true;
            this.bt0.Click += new System.EventHandler(this.Bt0_Click);
            // 
            // bt
            // 
            this.bt.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt.Location = new System.Drawing.Point(158, 252);
            this.bt.Name = "bt";
            this.bt.Size = new System.Drawing.Size(47, 45);
            this.bt.TabIndex = 29;
            this.bt.Text = ".";
            this.bt.UseVisualStyleBackColor = true;
            this.bt.Click += new System.EventHandler(this.Bt_Click);
            // 
            // bt2
            // 
            this.bt2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt2.Location = new System.Drawing.Point(105, 99);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(47, 45);
            this.bt2.TabIndex = 28;
            this.bt2.Text = "2";
            this.bt2.UseVisualStyleBackColor = true;
            this.bt2.Click += new System.EventHandler(this.Bt2_Click);
            // 
            // bt3
            // 
            this.bt3.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt3.Location = new System.Drawing.Point(158, 99);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(47, 45);
            this.bt3.TabIndex = 27;
            this.bt3.Text = "3";
            this.bt3.UseVisualStyleBackColor = true;
            this.bt3.Click += new System.EventHandler(this.Bt3_Click);
            // 
            // bt4
            // 
            this.bt4.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt4.Location = new System.Drawing.Point(52, 150);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(47, 45);
            this.bt4.TabIndex = 26;
            this.bt4.Text = "4";
            this.bt4.UseVisualStyleBackColor = true;
            this.bt4.Click += new System.EventHandler(this.Bt4_Click);
            // 
            // bt5
            // 
            this.bt5.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt5.Location = new System.Drawing.Point(105, 150);
            this.bt5.Name = "bt5";
            this.bt5.Size = new System.Drawing.Size(47, 45);
            this.bt5.TabIndex = 25;
            this.bt5.Text = "5";
            this.bt5.UseVisualStyleBackColor = true;
            this.bt5.Click += new System.EventHandler(this.Bt5_Click);
            // 
            // bt6
            // 
            this.bt6.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt6.Location = new System.Drawing.Point(158, 150);
            this.bt6.Name = "bt6";
            this.bt6.Size = new System.Drawing.Size(47, 45);
            this.bt6.TabIndex = 24;
            this.bt6.Text = "6";
            this.bt6.UseVisualStyleBackColor = true;
            this.bt6.Click += new System.EventHandler(this.Bt6_Click);
            // 
            // bt7
            // 
            this.bt7.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt7.Location = new System.Drawing.Point(52, 201);
            this.bt7.Name = "bt7";
            this.bt7.Size = new System.Drawing.Size(47, 45);
            this.bt7.TabIndex = 23;
            this.bt7.Text = "7";
            this.bt7.UseVisualStyleBackColor = true;
            this.bt7.Click += new System.EventHandler(this.Bt7_Click);
            // 
            // bt8
            // 
            this.bt8.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt8.Location = new System.Drawing.Point(105, 201);
            this.bt8.Name = "bt8";
            this.bt8.Size = new System.Drawing.Size(47, 45);
            this.bt8.TabIndex = 22;
            this.bt8.Text = "8";
            this.bt8.UseVisualStyleBackColor = true;
            this.bt8.Click += new System.EventHandler(this.Bt8_Click);
            // 
            // bt9
            // 
            this.bt9.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt9.Location = new System.Drawing.Point(158, 201);
            this.bt9.Name = "bt9";
            this.bt9.Size = new System.Drawing.Size(47, 45);
            this.bt9.TabIndex = 21;
            this.bt9.Text = "9";
            this.bt9.UseVisualStyleBackColor = true;
            this.bt9.Click += new System.EventHandler(this.Bt9_Click);
            // 
            // bt1
            // 
            this.bt1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt1.Location = new System.Drawing.Point(52, 99);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(47, 45);
            this.bt1.TabIndex = 20;
            this.bt1.Text = "1";
            this.bt1.UseVisualStyleBackColor = true;
            this.bt1.Click += new System.EventHandler(this.Bt1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 363);
            this.Controls.Add(this.tbxScreen);
            this.Controls.Add(this.btce);
            this.Controls.Add(this.btc);
            this.Controls.Add(this.btmas);
            this.Controls.Add(this.btrest);
            this.Controls.Add(this.btmult);
            this.Controls.Add(this.btdiv);
            this.Controls.Add(this.btig);
            this.Controls.Add(this.btpor);
            this.Controls.Add(this.bt0);
            this.Controls.Add(this.bt);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.bt3);
            this.Controls.Add(this.bt4);
            this.Controls.Add(this.bt5);
            this.Controls.Add(this.bt6);
            this.Controls.Add(this.bt7);
            this.Controls.Add(this.bt8);
            this.Controls.Add(this.bt9);
            this.Controls.Add(this.bt1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxScreen;
        private System.Windows.Forms.Button btce;
        private System.Windows.Forms.Button btc;
        private System.Windows.Forms.Button btmas;
        private System.Windows.Forms.Button btrest;
        private System.Windows.Forms.Button btmult;
        private System.Windows.Forms.Button btdiv;
        private System.Windows.Forms.Button btig;
        private System.Windows.Forms.Button btpor;
        private System.Windows.Forms.Button bt0;
        private System.Windows.Forms.Button bt;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.Button bt4;
        private System.Windows.Forms.Button bt5;
        private System.Windows.Forms.Button bt6;
        private System.Windows.Forms.Button bt7;
        private System.Windows.Forms.Button bt8;
        private System.Windows.Forms.Button bt9;
        private System.Windows.Forms.Button bt1;
    }
}

