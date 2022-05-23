
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
            this.bonClient = new System.Windows.Forms.ListBox();
            this.stergeProdusClient = new System.Windows.Forms.Button();
            this.observatiiClient = new System.Windows.Forms.TextBox();
            this.observatiiLabelClient = new System.Windows.Forms.Label();
            this.labelTotalClient = new System.Windows.Forms.Label();
            this.textTotalClient = new System.Windows.Forms.TextBox();
            this.trimiteComandaClient = new System.Windows.Forms.Button();
            this.adaugaBauturiClient = new System.Windows.Forms.Button();
            this.adaugaMancareClient = new System.Windows.Forms.Button();
            this.labelBonClient = new System.Windows.Forms.Label();
            this.bauturiClient = new System.Windows.Forms.ComboBox();
            this.labelBauturiClient = new System.Windows.Forms.Label();
            this.labelMancareClient = new System.Windows.Forms.Label();
            this.mancareClient = new System.Windows.Forms.ComboBox();
            this.groupChelner = new System.Windows.Forms.GroupBox();
            this.labelComenzi = new System.Windows.Forms.Label();
            this.observatiiLabelChelner = new System.Windows.Forms.Label();
            this.observatiiChelner = new System.Windows.Forms.TextBox();
            this.labelTotalChelner = new System.Windows.Forms.Label();
            this.emiteBon = new System.Windows.Forms.Button();
            this.totalChelner = new System.Windows.Forms.TextBox();
            this.labelComandaChelner = new System.Windows.Forms.Label();
            this.detaliiComandaChelner = new System.Windows.Forms.TextBox();
            this.listaComenziChelner = new System.Windows.Forms.ListBox();
            this.groupClient.SuspendLayout();
            this.groupChelner.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupClient
            // 
            this.groupClient.Controls.Add(this.bonClient);
            this.groupClient.Controls.Add(this.stergeProdusClient);
            this.groupClient.Controls.Add(this.observatiiClient);
            this.groupClient.Controls.Add(this.observatiiLabelClient);
            this.groupClient.Controls.Add(this.labelTotalClient);
            this.groupClient.Controls.Add(this.textTotalClient);
            this.groupClient.Controls.Add(this.trimiteComandaClient);
            this.groupClient.Controls.Add(this.adaugaBauturiClient);
            this.groupClient.Controls.Add(this.adaugaMancareClient);
            this.groupClient.Controls.Add(this.labelBonClient);
            this.groupClient.Controls.Add(this.bauturiClient);
            this.groupClient.Controls.Add(this.labelBauturiClient);
            this.groupClient.Controls.Add(this.labelMancareClient);
            this.groupClient.Controls.Add(this.mancareClient);
            this.groupClient.Location = new System.Drawing.Point(16, 15);
            this.groupClient.Margin = new System.Windows.Forms.Padding(4);
            this.groupClient.Name = "groupClient";
            this.groupClient.Padding = new System.Windows.Forms.Padding(4);
            this.groupClient.Size = new System.Drawing.Size(1327, 309);
            this.groupClient.TabIndex = 0;
            this.groupClient.TabStop = false;
            this.groupClient.Text = "Client";
            // 
            // bonClient
            // 
            this.bonClient.FormattingEnabled = true;
            this.bonClient.ItemHeight = 16;
            this.bonClient.Location = new System.Drawing.Point(692, 61);
            this.bonClient.Name = "bonClient";
            this.bonClient.Size = new System.Drawing.Size(565, 180);
            this.bonClient.TabIndex = 20;
            // 
            // stergeProdusClient
            // 
            this.stergeProdusClient.Location = new System.Drawing.Point(899, 261);
            this.stergeProdusClient.Margin = new System.Windows.Forms.Padding(4);
            this.stergeProdusClient.Name = "stergeProdusClient";
            this.stergeProdusClient.Size = new System.Drawing.Size(169, 28);
            this.stergeProdusClient.TabIndex = 19;
            this.stergeProdusClient.Text = "Sterge Produs";
            this.stergeProdusClient.UseVisualStyleBackColor = true;
            this.stergeProdusClient.Click += new System.EventHandler(this.stergeProdusClient_Click);
            // 
            // observatiiClient
            // 
            this.observatiiClient.Location = new System.Drawing.Point(15, 209);
            this.observatiiClient.Margin = new System.Windows.Forms.Padding(4);
            this.observatiiClient.Multiline = true;
            this.observatiiClient.Name = "observatiiClient";
            this.observatiiClient.Size = new System.Drawing.Size(620, 80);
            this.observatiiClient.TabIndex = 12;
            // 
            // observatiiLabelClient
            // 
            this.observatiiLabelClient.AutoSize = true;
            this.observatiiLabelClient.Location = new System.Drawing.Point(11, 182);
            this.observatiiLabelClient.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.observatiiLabelClient.Name = "observatiiLabelClient";
            this.observatiiLabelClient.Size = new System.Drawing.Size(72, 17);
            this.observatiiLabelClient.TabIndex = 11;
            this.observatiiLabelClient.Text = "Observatii";
            // 
            // labelTotalClient
            // 
            this.labelTotalClient.AutoSize = true;
            this.labelTotalClient.Location = new System.Drawing.Point(689, 268);
            this.labelTotalClient.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTotalClient.Name = "labelTotalClient";
            this.labelTotalClient.Size = new System.Drawing.Size(40, 17);
            this.labelTotalClient.TabIndex = 10;
            this.labelTotalClient.Text = "Total";
            // 
            // textTotalClient
            // 
            this.textTotalClient.Location = new System.Drawing.Point(744, 263);
            this.textTotalClient.Margin = new System.Windows.Forms.Padding(4);
            this.textTotalClient.Name = "textTotalClient";
            this.textTotalClient.Size = new System.Drawing.Size(132, 22);
            this.textTotalClient.TabIndex = 9;
            // 
            // trimiteComandaClient
            // 
            this.trimiteComandaClient.Location = new System.Drawing.Point(1088, 262);
            this.trimiteComandaClient.Margin = new System.Windows.Forms.Padding(4);
            this.trimiteComandaClient.Name = "trimiteComandaClient";
            this.trimiteComandaClient.Size = new System.Drawing.Size(169, 28);
            this.trimiteComandaClient.TabIndex = 8;
            this.trimiteComandaClient.Text = "Trimite comanda";
            this.trimiteComandaClient.UseVisualStyleBackColor = true;
            this.trimiteComandaClient.Click += new System.EventHandler(this.trimiteComandaClient_Click);
            // 
            // adaugaBauturiClient
            // 
            this.adaugaBauturiClient.Location = new System.Drawing.Point(536, 132);
            this.adaugaBauturiClient.Margin = new System.Windows.Forms.Padding(4);
            this.adaugaBauturiClient.Name = "adaugaBauturiClient";
            this.adaugaBauturiClient.Size = new System.Drawing.Size(100, 28);
            this.adaugaBauturiClient.TabIndex = 7;
            this.adaugaBauturiClient.Text = "Adauga";
            this.adaugaBauturiClient.UseVisualStyleBackColor = true;
            // 
            // adaugaMancareClient
            // 
            this.adaugaMancareClient.Location = new System.Drawing.Point(536, 60);
            this.adaugaMancareClient.Margin = new System.Windows.Forms.Padding(4);
            this.adaugaMancareClient.Name = "adaugaMancareClient";
            this.adaugaMancareClient.Size = new System.Drawing.Size(100, 28);
            this.adaugaMancareClient.TabIndex = 6;
            this.adaugaMancareClient.Text = "Adauga";
            this.adaugaMancareClient.UseVisualStyleBackColor = true;
            this.adaugaMancareClient.Click += new System.EventHandler(this.adaugaMancareClient_Click);
            // 
            // labelBonClient
            // 
            this.labelBonClient.AutoSize = true;
            this.labelBonClient.Location = new System.Drawing.Point(689, 38);
            this.labelBonClient.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBonClient.Name = "labelBonClient";
            this.labelBonClient.Size = new System.Drawing.Size(33, 17);
            this.labelBonClient.TabIndex = 5;
            this.labelBonClient.Text = "Bon";
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
            this.bauturiClient.Location = new System.Drawing.Point(12, 133);
            this.bauturiClient.Margin = new System.Windows.Forms.Padding(4);
            this.bauturiClient.Name = "bauturiClient";
            this.bauturiClient.Size = new System.Drawing.Size(511, 24);
            this.bauturiClient.TabIndex = 3;
            // 
            // labelBauturiClient
            // 
            this.labelBauturiClient.AutoSize = true;
            this.labelBauturiClient.Location = new System.Drawing.Point(11, 103);
            this.labelBauturiClient.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBauturiClient.Name = "labelBauturiClient";
            this.labelBauturiClient.Size = new System.Drawing.Size(53, 17);
            this.labelBauturiClient.TabIndex = 2;
            this.labelBauturiClient.Text = "Bauturi";
            // 
            // labelMancareClient
            // 
            this.labelMancareClient.AutoSize = true;
            this.labelMancareClient.Location = new System.Drawing.Point(8, 38);
            this.labelMancareClient.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMancareClient.Name = "labelMancareClient";
            this.labelMancareClient.Size = new System.Drawing.Size(63, 17);
            this.labelMancareClient.TabIndex = 1;
            this.labelMancareClient.Text = "Mancare";
            // 
            // mancareClient
            // 
            this.mancareClient.FormattingEnabled = true;
            this.mancareClient.Items.AddRange(new object[] {
            "Meniu Crispy ( cartofi, salata, sos ) - 400g - 30 de lei",
            "Meniu Porc ( ceafa porc, salata, cartofi ) - 450g - 35 lei"});
            this.mancareClient.Location = new System.Drawing.Point(15, 64);
            this.mancareClient.Margin = new System.Windows.Forms.Padding(4);
            this.mancareClient.Name = "mancareClient";
            this.mancareClient.Size = new System.Drawing.Size(511, 24);
            this.mancareClient.TabIndex = 0;
            // 
            // groupChelner
            // 
            this.groupChelner.Controls.Add(this.labelComenzi);
            this.groupChelner.Controls.Add(this.observatiiLabelChelner);
            this.groupChelner.Controls.Add(this.observatiiChelner);
            this.groupChelner.Controls.Add(this.labelTotalChelner);
            this.groupChelner.Controls.Add(this.emiteBon);
            this.groupChelner.Controls.Add(this.totalChelner);
            this.groupChelner.Controls.Add(this.labelComandaChelner);
            this.groupChelner.Controls.Add(this.detaliiComandaChelner);
            this.groupChelner.Controls.Add(this.listaComenziChelner);
            this.groupChelner.Location = new System.Drawing.Point(16, 331);
            this.groupChelner.Margin = new System.Windows.Forms.Padding(4);
            this.groupChelner.Name = "groupChelner";
            this.groupChelner.Padding = new System.Windows.Forms.Padding(4);
            this.groupChelner.Size = new System.Drawing.Size(1327, 682);
            this.groupChelner.TabIndex = 1;
            this.groupChelner.TabStop = false;
            this.groupChelner.Text = "Chelner";
            // 
            // labelComenzi
            // 
            this.labelComenzi.AutoSize = true;
            this.labelComenzi.Location = new System.Drawing.Point(8, 43);
            this.labelComenzi.Name = "labelComenzi";
            this.labelComenzi.Size = new System.Drawing.Size(62, 17);
            this.labelComenzi.TabIndex = 17;
            this.labelComenzi.Text = "Comenzi";
            // 
            // observatiiLabelChelner
            // 
            this.observatiiLabelChelner.AutoSize = true;
            this.observatiiLabelChelner.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.observatiiLabelChelner.Location = new System.Drawing.Point(772, 43);
            this.observatiiLabelChelner.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.observatiiLabelChelner.Name = "observatiiLabelChelner";
            this.observatiiLabelChelner.Size = new System.Drawing.Size(134, 17);
            this.observatiiLabelChelner.TabIndex = 16;
            this.observatiiLabelChelner.Text = "Observatii comanda";
            // 
            // observatiiChelner
            // 
            this.observatiiChelner.Location = new System.Drawing.Point(775, 81);
            this.observatiiChelner.Margin = new System.Windows.Forms.Padding(4);
            this.observatiiChelner.Multiline = true;
            this.observatiiChelner.Name = "observatiiChelner";
            this.observatiiChelner.Size = new System.Drawing.Size(229, 304);
            this.observatiiChelner.TabIndex = 15;
            // 
            // labelTotalChelner
            // 
            this.labelTotalChelner.AutoSize = true;
            this.labelTotalChelner.Location = new System.Drawing.Point(209, 602);
            this.labelTotalChelner.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTotalChelner.Name = "labelTotalChelner";
            this.labelTotalChelner.Size = new System.Drawing.Size(40, 17);
            this.labelTotalChelner.TabIndex = 14;
            this.labelTotalChelner.Text = "Total";
            // 
            // emiteBon
            // 
            this.emiteBon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emiteBon.Location = new System.Drawing.Point(1043, 81);
            this.emiteBon.Margin = new System.Windows.Forms.Padding(4);
            this.emiteBon.Name = "emiteBon";
            this.emiteBon.Size = new System.Drawing.Size(169, 28);
            this.emiteBon.TabIndex = 11;
            this.emiteBon.Text = "Emite bon";
            this.emiteBon.UseVisualStyleBackColor = true;
            this.emiteBon.Click += new System.EventHandler(this.emiteBon_Click);
            // 
            // totalChelner
            // 
            this.totalChelner.Location = new System.Drawing.Point(264, 597);
            this.totalChelner.Margin = new System.Windows.Forms.Padding(4);
            this.totalChelner.Name = "totalChelner";
            this.totalChelner.Size = new System.Drawing.Size(132, 22);
            this.totalChelner.TabIndex = 13;
            // 
            // labelComandaChelner
            // 
            this.labelComandaChelner.AutoSize = true;
            this.labelComandaChelner.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labelComandaChelner.Location = new System.Drawing.Point(261, 43);
            this.labelComandaChelner.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelComandaChelner.Name = "labelComandaChelner";
            this.labelComandaChelner.Size = new System.Drawing.Size(109, 17);
            this.labelComandaChelner.TabIndex = 11;
            this.labelComandaChelner.Text = "Detalii comanda";
            // 
            // detaliiComandaChelner
            // 
            this.detaliiComandaChelner.Location = new System.Drawing.Point(264, 81);
            this.detaliiComandaChelner.Margin = new System.Windows.Forms.Padding(4);
            this.detaliiComandaChelner.Multiline = true;
            this.detaliiComandaChelner.Name = "detaliiComandaChelner";
            this.detaliiComandaChelner.Size = new System.Drawing.Size(503, 304);
            this.detaliiComandaChelner.TabIndex = 11;
            // 
            // listaComenziChelner
            // 
            this.listaComenziChelner.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listaComenziChelner.FormattingEnabled = true;
            this.listaComenziChelner.ItemHeight = 30;
            this.listaComenziChelner.Location = new System.Drawing.Point(7, 81);
            this.listaComenziChelner.Margin = new System.Windows.Forms.Padding(4);
            this.listaComenziChelner.Name = "listaComenziChelner";
            this.listaComenziChelner.Size = new System.Drawing.Size(249, 304);
            this.listaComenziChelner.TabIndex = 0;
            this.listaComenziChelner.SelectedIndexChanged += new System.EventHandler(this.listaComenziChelner_SelectedIndexChanged);
            // 
            // GUIRestaurant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1335, 1051);
            this.Controls.Add(this.groupChelner);
            this.Controls.Add(this.groupClient);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.ComboBox bauturiClient;
        private System.Windows.Forms.Button trimiteComandaClient;
        private System.Windows.Forms.Button adaugaBauturiClient;
        private System.Windows.Forms.Button adaugaMancareClient;
        private System.Windows.Forms.Label labelTotalClient;
        private System.Windows.Forms.TextBox textTotalClient;
        private System.Windows.Forms.ListBox listaComenziChelner;
        private System.Windows.Forms.Button emiteBon;
        private System.Windows.Forms.Label labelComandaChelner;
        private System.Windows.Forms.TextBox detaliiComandaChelner;
        private System.Windows.Forms.TextBox observatiiClient;
        private System.Windows.Forms.Label observatiiLabelClient;
        private System.Windows.Forms.Label labelTotalChelner;
        private System.Windows.Forms.TextBox totalChelner;
        private System.Windows.Forms.Label observatiiLabelChelner;
        private System.Windows.Forms.TextBox observatiiChelner;
        private System.Windows.Forms.Button stergeProdusClient;
        private System.Windows.Forms.ListBox bonClient;
        private System.Windows.Forms.Label labelComenzi;
    }
}

