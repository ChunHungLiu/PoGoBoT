namespace PokemonGo.RocketAPI.Window
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.logTextBox = new System.Windows.Forms.RichTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.showAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAllToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.largePokemonImageList = new System.Windows.Forms.ImageList(this.components);
            this.smallPokemonImageList = new System.Windows.Forms.ImageList(this.components);
            this.dGrid = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnuseincense = new System.Windows.Forms.Button();
            this.btnForceUnban = new System.Windows.Forms.Button();
            this.btnLuckyEgg = new System.Windows.Forms.Button();
            this.btnStartFarming = new System.Windows.Forms.Button();
            this.btnPokemon = new System.Windows.Forms.Button();
            this.btnadvoptions = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // logTextBox
            // 
            this.logTextBox.BackColor = System.Drawing.Color.Black;
            this.logTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.logTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logTextBox.ForeColor = System.Drawing.Color.White;
            this.logTextBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.logTextBox.Location = new System.Drawing.Point(219, 264);
            this.logTextBox.Name = "logTextBox";
            this.logTextBox.ReadOnly = true;
            this.logTextBox.Size = new System.Drawing.Size(551, 222);
            this.logTextBox.TabIndex = 0;
            this.logTextBox.Text = "";
            this.logTextBox.TextChanged += new System.EventHandler(this.logTextBox_TextChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 497);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(775, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(39, 17);
            this.statusLabel.Text = "Status";
            // 
            // showAllToolStripMenuItem
            // 
            this.showAllToolStripMenuItem.Name = "showAllToolStripMenuItem";
            this.showAllToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // showAllToolStripMenuItem1
            // 
            this.showAllToolStripMenuItem1.Name = "showAllToolStripMenuItem1";
            this.showAllToolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
            // 
            // gMapControl1
            // 
            this.gMapControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemmory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(12, 185);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 2;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(201, 244);
            this.gMapControl1.TabIndex = 23;
            this.gMapControl1.Zoom = 0D;
            // 
            // largePokemonImageList
            // 
            this.largePokemonImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.largePokemonImageList.ImageSize = new System.Drawing.Size(96, 96);
            this.largePokemonImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // smallPokemonImageList
            // 
            this.smallPokemonImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.smallPokemonImageList.ImageSize = new System.Drawing.Size(32, 32);
            this.smallPokemonImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // dGrid
            // 
            this.dGrid.AllowUserToAddRows = false;
            this.dGrid.AllowUserToDeleteRows = false;
            this.dGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGrid.Location = new System.Drawing.Point(219, 12);
            this.dGrid.Name = "dGrid";
            this.dGrid.ReadOnly = true;
            this.dGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGrid.Size = new System.Drawing.Size(551, 246);
            this.dGrid.TabIndex = 30;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnuseincense);
            this.groupBox1.Controls.Add(this.btnForceUnban);
            this.groupBox1.Controls.Add(this.btnLuckyEgg);
            this.groupBox1.Controls.Add(this.btnStartFarming);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(201, 167);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Farming Control";
            // 
            // btnuseincense
            // 
            this.btnuseincense.Location = new System.Drawing.Point(6, 106);
            this.btnuseincense.Name = "btnuseincense";
            this.btnuseincense.Size = new System.Drawing.Size(189, 23);
            this.btnuseincense.TabIndex = 17;
            this.btnuseincense.Text = "Use Incense";
            this.btnuseincense.UseVisualStyleBackColor = true;
            this.btnuseincense.Click += new System.EventHandler(this.btnuseincense_Click);
            // 
            // btnForceUnban
            // 
            this.btnForceUnban.Location = new System.Drawing.Point(6, 135);
            this.btnForceUnban.Name = "btnForceUnban";
            this.btnForceUnban.Size = new System.Drawing.Size(189, 23);
            this.btnForceUnban.TabIndex = 16;
            this.btnForceUnban.Text = "Force Unban";
            this.btnForceUnban.UseVisualStyleBackColor = true;
            this.btnForceUnban.Click += new System.EventHandler(this.btnForceUnban_Click);
            // 
            // btnLuckyEgg
            // 
            this.btnLuckyEgg.Location = new System.Drawing.Point(6, 77);
            this.btnLuckyEgg.Name = "btnLuckyEgg";
            this.btnLuckyEgg.Size = new System.Drawing.Size(189, 23);
            this.btnLuckyEgg.TabIndex = 7;
            this.btnLuckyEgg.Text = "Use Lucky egg";
            this.btnLuckyEgg.UseVisualStyleBackColor = true;
            this.btnLuckyEgg.Click += new System.EventHandler(this.btnLuckyEgg_Click);
            // 
            // btnStartFarming
            // 
            this.btnStartFarming.Location = new System.Drawing.Point(6, 22);
            this.btnStartFarming.Name = "btnStartFarming";
            this.btnStartFarming.Size = new System.Drawing.Size(189, 49);
            this.btnStartFarming.TabIndex = 0;
            this.btnStartFarming.Text = "Start Farming";
            this.btnStartFarming.UseVisualStyleBackColor = true;
            this.btnStartFarming.Click += new System.EventHandler(this.btnStartFarming_Click);
            // 
            // btnPokemon
            // 
            this.btnPokemon.Location = new System.Drawing.Point(12, 435);
            this.btnPokemon.Name = "btnPokemon";
            this.btnPokemon.Size = new System.Drawing.Size(201, 23);
            this.btnPokemon.TabIndex = 33;
            this.btnPokemon.Text = "Pokemon";
            this.btnPokemon.UseVisualStyleBackColor = true;
            this.btnPokemon.Click += new System.EventHandler(this.btnPokemon_Click);
            // 
            // btnadvoptions
            // 
            this.btnadvoptions.Location = new System.Drawing.Point(12, 464);
            this.btnadvoptions.Name = "btnadvoptions";
            this.btnadvoptions.Size = new System.Drawing.Size(201, 23);
            this.btnadvoptions.TabIndex = 32;
            this.btnadvoptions.Text = "Advanced Options";
            this.btnadvoptions.UseVisualStyleBackColor = true;
            this.btnadvoptions.Click += new System.EventHandler(this.btnadvoptions_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 519);
            this.Controls.Add(this.btnPokemon);
            this.Controls.Add(this.btnadvoptions);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dGrid);
            this.Controls.Add(this.gMapControl1);
            this.Controls.Add(this.logTextBox);
            this.Controls.Add(this.statusStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PoGoBoT - GUI";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox logTextBox;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.ToolStripMenuItem showAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showAllToolStripMenuItem1;
        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.ImageList smallPokemonImageList;
        private System.Windows.Forms.ImageList largePokemonImageList;
        private System.Windows.Forms.DataGridView dGrid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnuseincense;
        private System.Windows.Forms.Button btnForceUnban;
        private System.Windows.Forms.Button btnLuckyEgg;
        private System.Windows.Forms.Button btnStartFarming;
        private System.Windows.Forms.Button btnPokemon;
        private System.Windows.Forms.Button btnadvoptions;
    }
}
