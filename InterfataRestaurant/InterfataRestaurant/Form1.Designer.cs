
namespace InterfataRestaurant
{
    partial class GUIRestaurant
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
            this.groupClient = new System.Windows.Forms.GroupBox();
            this.observatiiClient = new System.Windows.Forms.TextBox();
            this.observatiiLabelClient = new System.Windows.Forms.Label();
            this.labelTotalClient = new System.Windows.Forms.Label();
            this.textTotalClient = new System.Windows.Forms.TextBox();
            this.trimiteComandaClient = new System.Windows.Forms.Button();
            this.adaugaBauturiClient = new System.Windows.Forms.Button();
            this.adaugaMancareClient = new System.Windows.Forms.Button();
            this.labelBonClient = new System.Windows.Forms.Label();
            this.bonClient = new System.Windows.Forms.TextBox();
            this.bauturiClient = new System.Windows.Forms.ComboBox();
            this.labelBauturiClient = new System.Windows.Forms.Label();
            this.labelMancareClient = new System.Windows.Forms.Label();
            this.mancareClient = new System.Windows.Forms.ComboBox();
            this.groupChelner = new System.Windows.Forms.GroupBox();
            this.adaugareBauturiChelner = new System.Windows.Forms.Button();
            this.stergeProdusChelner = new System.Windows.Forms.Button();
            this.adaugareMancareChelner = new System.Windows.Forms.Button();
            this.observatiiLabelChelner = new System.Windows.Forms.Label();
            this.bauturiChelner = new System.Windows.Forms.ComboBox();
            this.labelBauturiChelner = new System.Windows.Forms.Label();
            this.observatiiChelner = new System.Windows.Forms.TextBox();
            this.labelMancareChelner = new System.Windows.Forms.Label();
            this.labelTotalChelner = new System.Windows.Forms.Label();
            this.mancareChelner = new System.Windows.Forms.ComboBox();
            this.emiteBon = new System.Windows.Forms.Button();
            this.totalChelner = new System.Windows.Forms.TextBox();
            this.labelComandaChelner = new System.Windows.Forms.Label();
            this.detaliiComandaChelner = new System.Windows.Forms.TextBox();
            this.listaMeseChelner = new System.Windows.Forms.ListBox();
            this.stergeProdusClient = new System.Windows.Forms.Button();
            this.groupClient.SuspendLayout();
            this.groupChelner.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupClient
            // 
            this.groupClient.Controls.Add(this.stergeProdusClient);
            this.groupClient.Controls.Add(this.observatiiClient);
            this.groupClient.Controls.Add(this.observatiiLabelClient);
            this.groupClient.Controls.Add(this.labelTotalClient);
            this.groupClient.Controls.Add(this.textTotalClient);
            this.groupClient.Controls.Add(this.trimiteComandaClient);
            this.groupClient.Controls.Add(this.adaugaBauturiClient);
            this.groupClient.Controls.Add(this.adaugaMancareClient);
            this.groupClient.Controls.Add(this.labelBonClient);
            this.groupClient.Controls.Add(this.bonClient);
            this.groupClient.Controls.Add(this.bauturiClient);
            this.groupClient.Controls.Add(this.labelBauturiClient);
            this.groupClient.Controls.Add(this.labelMancareClient);
            this.groupClient.Controls.Add(this.mancareClient);
            this.groupClient.Location = new System.Drawing.Point(12, 12);
            this.groupClient.Name = "groupClient";
            this.groupClient.Size = new System.Drawing.Size(995, 251);
            this.groupClient.TabIndex = 0;
            this.groupClient.TabStop = false;
            this.groupClient.Text = "Client";
            // 
            // observatiiClient
            // 
            this.observatiiClient.Location = new System.Drawing.Point(11, 170);
            this.observatiiClient.Multiline = true;
            this.observatiiClient.Name = "observatiiClient";
            this.observatiiClient.Size = new System.Drawing.Size(466, 66);
            this.observatiiClient.TabIndex = 12;
            this.observatiiClient.TextChanged += new System.EventHandler(this.observatiiClient_TextChanged);
            // 
            // observatiiLabelClient
            // 
            this.observatiiLabelClient.AutoSize = true;
            this.observatiiLabelClient.Location = new System.Drawing.Point(8, 148);
            this.observatiiLabelClient.Name = "observatiiLabelClient";
            this.observatiiLabelClient.Size = new System.Drawing.Size(54, 13);
            this.observatiiLabelClient.TabIndex = 11;
            this.observatiiLabelClient.Text = "Observatii";
            // 
            // labelTotalClient
            // 
            this.labelTotalClient.AutoSize = true;
            this.labelTotalClient.Location = new System.Drawing.Point(517, 218);
            this.labelTotalClient.Name = "labelTotalClient";
            this.labelTotalClient.Size = new System.Drawing.Size(31, 13);
            this.labelTotalClient.TabIndex = 10;
            this.labelTotalClient.Text = "Total";
            // 
            // textTotalClient
            // 
            this.textTotalClient.Location = new System.Drawing.Point(558, 214);
            this.textTotalClient.Name = "textTotalClient";
            this.textTotalClient.Size = new System.Drawing.Size(100, 20);
            this.textTotalClient.TabIndex = 9;
            // 
            // trimiteComandaClient
            // 
            this.trimiteComandaClient.Location = new System.Drawing.Point(816, 213);
            this.trimiteComandaClient.Name = "trimiteComandaClient";
            this.trimiteComandaClient.Size = new System.Drawing.Size(127, 23);
            this.trimiteComandaClient.TabIndex = 8;
            this.trimiteComandaClient.Text = "Trimite comanda";
            this.trimiteComandaClient.UseVisualStyleBackColor = true;
            // 
            // adaugaBauturiClient
            // 
            this.adaugaBauturiClient.Location = new System.Drawing.Point(402, 107);
            this.adaugaBauturiClient.Name = "adaugaBauturiClient";
            this.adaugaBauturiClient.Size = new System.Drawing.Size(75, 23);
            this.adaugaBauturiClient.TabIndex = 7;
            this.adaugaBauturiClient.Text = "Adauga";
            this.adaugaBauturiClient.UseVisualStyleBackColor = true;
            this.adaugaBauturiClient.Click += new System.EventHandler(this.aduagaBauturiClient_Click);
            // 
            // adaugaMancareClient
            // 
            this.adaugaMancareClient.Location = new System.Drawing.Point(402, 49);
            this.adaugaMancareClient.Name = "adaugaMancareClient";
            this.adaugaMancareClient.Size = new System.Drawing.Size(75, 23);
            this.adaugaMancareClient.TabIndex = 6;
            this.adaugaMancareClient.Text = "Adauga";
            this.adaugaMancareClient.UseVisualStyleBackColor = true;
            this.adaugaMancareClient.Click += new System.EventHandler(this.adaugaMancareClient_Click);
            // 
            // labelBonClient
            // 
            this.labelBonClient.AutoSize = true;
            this.labelBonClient.Location = new System.Drawing.Point(517, 31);
            this.labelBonClient.Name = "labelBonClient";
            this.labelBonClient.Size = new System.Drawing.Size(26, 13);
            this.labelBonClient.TabIndex = 5;
            this.labelBonClient.Text = "Bon";
            // 
            // bonClient
            // 
            this.bonClient.Location = new System.Drawing.Point(519, 52);
            this.bonClient.Multiline = true;
            this.bonClient.Name = "bonClient";
            this.bonClient.Size = new System.Drawing.Size(424, 146);
            this.bonClient.TabIndex = 4;
            // 
            // bauturiClient
            // 
            this.bauturiClient.FormattingEnabled = true;
            this.bauturiClient.Items.AddRange(new object[] {
            "Apa Dorna  - 0.5l  - 5 lei",
            "Apa Dorna Carbogazoaga  - 0.5l  - 5 lei",
            "Pepsi  - 0.5l  - 7 lei",
            "Coca Cola  - 0.5l  - 7 lei",
            "Fanta  - 0.5l  - 7 lei",
            "Sprite - 0.5l - 7 lei",
            "Vin Beciul Domnesc - 0.75l - 40 lei"});
            this.bauturiClient.Location = new System.Drawing.Point(9, 108);
            this.bauturiClient.Name = "bauturiClient";
            this.bauturiClient.Size = new System.Drawing.Size(384, 21);
            this.bauturiClient.TabIndex = 3;
            // 
            // labelBauturiClient
            // 
            this.labelBauturiClient.AutoSize = true;
            this.labelBauturiClient.Location = new System.Drawing.Point(8, 84);
            this.labelBauturiClient.Name = "labelBauturiClient";
            this.labelBauturiClient.Size = new System.Drawing.Size(40, 13);
            this.labelBauturiClient.TabIndex = 2;
            this.labelBauturiClient.Text = "Bauturi";
            // 
            // labelMancareClient
            // 
            this.labelMancareClient.AutoSize = true;
            this.labelMancareClient.Location = new System.Drawing.Point(6, 31);
            this.labelMancareClient.Name = "labelMancareClient";
            this.labelMancareClient.Size = new System.Drawing.Size(49, 13);
            this.labelMancareClient.TabIndex = 1;
            this.labelMancareClient.Text = "Mancare";
            // 
            // mancareClient
            // 
            this.mancareClient.FormattingEnabled = true;
            this.mancareClient.Items.AddRange(new object[] {
            "Meniu Crispy ( cartofi, salata, sos ) - 400g - 30 de lei",
            "Meniu Porc ( ceafa porc, salata, cartofi ) - 450g - 35 lei"});
            this.mancareClient.Location = new System.Drawing.Point(11, 52);
            this.mancareClient.Name = "mancareClient";
            this.mancareClient.Size = new System.Drawing.Size(384, 21);
            this.mancareClient.TabIndex = 0;
            // 
            // groupChelner
            // 
            this.groupChelner.Controls.Add(this.adaugareBauturiChelner);
            this.groupChelner.Controls.Add(this.stergeProdusChelner);
            this.groupChelner.Controls.Add(this.adaugareMancareChelner);
            this.groupChelner.Controls.Add(this.observatiiLabelChelner);
            this.groupChelner.Controls.Add(this.bauturiChelner);
            this.groupChelner.Controls.Add(this.labelBauturiChelner);
            this.groupChelner.Controls.Add(this.observatiiChelner);
            this.groupChelner.Controls.Add(this.labelMancareChelner);
            this.groupChelner.Controls.Add(this.labelTotalChelner);
            this.groupChelner.Controls.Add(this.mancareChelner);
            this.groupChelner.Controls.Add(this.emiteBon);
            this.groupChelner.Controls.Add(this.totalChelner);
            this.groupChelner.Controls.Add(this.labelComandaChelner);
            this.groupChelner.Controls.Add(this.detaliiComandaChelner);
            this.groupChelner.Controls.Add(this.listaMeseChelner);
            this.groupChelner.Location = new System.Drawing.Point(12, 269);
            this.groupChelner.Name = "groupChelner";
            this.groupChelner.Size = new System.Drawing.Size(995, 554);
            this.groupChelner.TabIndex = 1;
            this.groupChelner.TabStop = false;
            this.groupChelner.Text = "Chelner";
            // 
            // adaugareBauturiChelner
            // 
            this.adaugareBauturiChelner.Location = new System.Drawing.Point(420, 126);
            this.adaugareBauturiChelner.Name = "adaugareBauturiChelner";
            this.adaugareBauturiChelner.Size = new System.Drawing.Size(75, 23);
            this.adaugareBauturiChelner.TabIndex = 18;
            this.adaugareBauturiChelner.Text = "Adauga";
            this.adaugareBauturiChelner.UseVisualStyleBackColor = true;
            this.adaugareBauturiChelner.Click += new System.EventHandler(this.adaugaBauturiChelner_Click);
            // 
            // stergeProdusChelner
            // 
            this.stergeProdusChelner.Location = new System.Drawing.Point(793, 245);
            this.stergeProdusChelner.Name = "stergeProdusChelner";
            this.stergeProdusChelner.Size = new System.Drawing.Size(127, 23);
            this.stergeProdusChelner.TabIndex = 13;
            this.stergeProdusChelner.Text = "Sterge Produs";
            this.stergeProdusChelner.UseVisualStyleBackColor = true;
            // 
            // adaugareMancareChelner
            // 
            this.adaugareMancareChelner.Location = new System.Drawing.Point(420, 68);
            this.adaugareMancareChelner.Name = "adaugareMancareChelner";
            this.adaugareMancareChelner.Size = new System.Drawing.Size(75, 23);
            this.adaugareMancareChelner.TabIndex = 17;
            this.adaugareMancareChelner.Text = "Adauga";
            this.adaugareMancareChelner.UseVisualStyleBackColor = true;
            this.adaugareMancareChelner.Click += new System.EventHandler(this.adaugaMancareChelner_Click);
            // 
            // observatiiLabelChelner
            // 
            this.observatiiLabelChelner.AutoSize = true;
            this.observatiiLabelChelner.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.observatiiLabelChelner.Location = new System.Drawing.Point(591, 221);
            this.observatiiLabelChelner.Name = "observatiiLabelChelner";
            this.observatiiLabelChelner.Size = new System.Drawing.Size(101, 13);
            this.observatiiLabelChelner.TabIndex = 16;
            this.observatiiLabelChelner.Text = "Observatii comanda";
            // 
            // bauturiChelner
            // 
            this.bauturiChelner.FormattingEnabled = true;
            this.bauturiChelner.Items.AddRange(new object[] {
            "Apa Dorna  - 0.5l  - 5 lei",
            "Apa Dorna Carbogazoaga  - 0.5l  - 5 lei",
            "Pepsi  - 0.5l  - 7 lei",
            "Coca Cola  - 0.5l  - 7 lei",
            "Fanta  - 0.5l  - 7 lei",
            "Sprite - 0.5l - 7 lei",
            "Vin Beciul Domnesc - 0.75l - 40 lei"});
            this.bauturiChelner.Location = new System.Drawing.Point(27, 127);
            this.bauturiChelner.Name = "bauturiChelner";
            this.bauturiChelner.Size = new System.Drawing.Size(384, 21);
            this.bauturiChelner.TabIndex = 16;
            // 
            // labelBauturiChelner
            // 
            this.labelBauturiChelner.AutoSize = true;
            this.labelBauturiChelner.Location = new System.Drawing.Point(26, 103);
            this.labelBauturiChelner.Name = "labelBauturiChelner";
            this.labelBauturiChelner.Size = new System.Drawing.Size(40, 13);
            this.labelBauturiChelner.TabIndex = 15;
            this.labelBauturiChelner.Text = "Bauturi";
            // 
            // observatiiChelner
            // 
            this.observatiiChelner.Location = new System.Drawing.Point(587, 247);
            this.observatiiChelner.Multiline = true;
            this.observatiiChelner.Name = "observatiiChelner";
            this.observatiiChelner.Size = new System.Drawing.Size(173, 232);
            this.observatiiChelner.TabIndex = 15;
            // 
            // labelMancareChelner
            // 
            this.labelMancareChelner.AutoSize = true;
            this.labelMancareChelner.Location = new System.Drawing.Point(24, 50);
            this.labelMancareChelner.Name = "labelMancareChelner";
            this.labelMancareChelner.Size = new System.Drawing.Size(49, 13);
            this.labelMancareChelner.TabIndex = 14;
            this.labelMancareChelner.Text = "Mancare";
            // 
            // labelTotalChelner
            // 
            this.labelTotalChelner.AutoSize = true;
            this.labelTotalChelner.Location = new System.Drawing.Point(157, 489);
            this.labelTotalChelner.Name = "labelTotalChelner";
            this.labelTotalChelner.Size = new System.Drawing.Size(31, 13);
            this.labelTotalChelner.TabIndex = 14;
            this.labelTotalChelner.Text = "Total";
            // 
            // mancareChelner
            // 
            this.mancareChelner.FormattingEnabled = true;
            this.mancareChelner.Items.AddRange(new object[] {
            "Meniu Crispy ( cartofi, salata, sos ) - 400g - 30 de lei",
            "Meniu Porc ( ceafa porc, salata, cartofi ) - 450g - 35 lei"});
            this.mancareChelner.Location = new System.Drawing.Point(29, 71);
            this.mancareChelner.Name = "mancareChelner";
            this.mancareChelner.Size = new System.Drawing.Size(384, 21);
            this.mancareChelner.TabIndex = 13;
            // 
            // emiteBon
            // 
            this.emiteBon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emiteBon.Location = new System.Drawing.Point(793, 309);
            this.emiteBon.Name = "emiteBon";
            this.emiteBon.Size = new System.Drawing.Size(127, 23);
            this.emiteBon.TabIndex = 11;
            this.emiteBon.Text = "Emite bon";
            this.emiteBon.UseVisualStyleBackColor = true;
            // 
            // totalChelner
            // 
            this.totalChelner.Location = new System.Drawing.Point(198, 485);
            this.totalChelner.Name = "totalChelner";
            this.totalChelner.Size = new System.Drawing.Size(100, 20);
            this.totalChelner.TabIndex = 13;
            // 
            // labelComandaChelner
            // 
            this.labelComandaChelner.AutoSize = true;
            this.labelComandaChelner.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labelComandaChelner.Location = new System.Drawing.Point(155, 221);
            this.labelComandaChelner.Name = "labelComandaChelner";
            this.labelComandaChelner.Size = new System.Drawing.Size(83, 13);
            this.labelComandaChelner.TabIndex = 11;
            this.labelComandaChelner.Text = "Detalii comanda";
            // 
            // detaliiComandaChelner
            // 
            this.detaliiComandaChelner.Location = new System.Drawing.Point(152, 247);
            this.detaliiComandaChelner.Multiline = true;
            this.detaliiComandaChelner.Name = "detaliiComandaChelner";
            this.detaliiComandaChelner.Size = new System.Drawing.Size(424, 232);
            this.detaliiComandaChelner.TabIndex = 11;
            this.detaliiComandaChelner.TextChanged += new System.EventHandler(this.detaliiComandaChelner_TextChanged);
            // 
            // listaMeseChelner
            // 
            this.listaMeseChelner.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaMeseChelner.FormattingEnabled = true;
            this.listaMeseChelner.ItemHeight = 25;
            this.listaMeseChelner.Items.AddRange(new object[] {
            "Masa 1",
            "Masa 2",
            "Masa 3",
            "Masa 4",
            "Masa 5"});
            this.listaMeseChelner.Location = new System.Drawing.Point(27, 247);
            this.listaMeseChelner.Name = "listaMeseChelner";
            this.listaMeseChelner.Size = new System.Drawing.Size(86, 129);
            this.listaMeseChelner.TabIndex = 0;
            // 
            // stergeProdusClient
            // 
            this.stergeProdusClient.Location = new System.Drawing.Point(674, 212);
            this.stergeProdusClient.Name = "stergeProdusClient";
            this.stergeProdusClient.Size = new System.Drawing.Size(127, 23);
            this.stergeProdusClient.TabIndex = 19;
            this.stergeProdusClient.Text = "Sterge Produs";
            this.stergeProdusClient.UseVisualStyleBackColor = true;
            // 
            // GUIRestaurant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 854);
            this.Controls.Add(this.groupChelner);
            this.Controls.Add(this.groupClient);
            this.Name = "GUIRestaurant";
            this.Text = "Restaurant";
            this.groupClient.ResumeLayout(false);
            this.groupClient.PerformLayout();
            this.groupChelner.ResumeLayout(false);
            this.groupChelner.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupClient;
        private System.Windows.Forms.Label labelMancareClient;
        private System.Windows.Forms.ComboBox mancareClient;
        private System.Windows.Forms.GroupBox groupChelner;
        private System.Windows.Forms.Label labelBauturiClient;
        private System.Windows.Forms.Label labelBonClient;
        private System.Windows.Forms.TextBox bonClient;
        private System.Windows.Forms.ComboBox bauturiClient;
        private System.Windows.Forms.Button trimiteComandaClient;
        private System.Windows.Forms.Button adaugaBauturiClient;
        private System.Windows.Forms.Button adaugaMancareClient;
        private System.Windows.Forms.Label labelTotalClient;
        private System.Windows.Forms.TextBox textTotalClient;
        private System.Windows.Forms.ListBox listaMeseChelner;
        private System.Windows.Forms.Button emiteBon;
        private System.Windows.Forms.Label labelComandaChelner;
        private System.Windows.Forms.TextBox detaliiComandaChelner;
        private System.Windows.Forms.TextBox observatiiClient;
        private System.Windows.Forms.Label observatiiLabelClient;
        private System.Windows.Forms.Label labelTotalChelner;
        private System.Windows.Forms.TextBox totalChelner;
        private System.Windows.Forms.Button adaugareBauturiChelner;
        private System.Windows.Forms.Button stergeProdusChelner;
        private System.Windows.Forms.Button adaugareMancareChelner;
        private System.Windows.Forms.Label observatiiLabelChelner;
        private System.Windows.Forms.ComboBox bauturiChelner;
        private System.Windows.Forms.Label labelBauturiChelner;
        private System.Windows.Forms.TextBox observatiiChelner;
        private System.Windows.Forms.Label labelMancareChelner;
        private System.Windows.Forms.ComboBox mancareChelner;
        private System.Windows.Forms.Button stergeProdusClient;
    }
}

