
namespace mcr_2
{
    partial class searchForm
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
            this.picItem = new System.Windows.Forms.PictureBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.lblIng = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblItemIng = new System.Windows.Forms.Label();
            this.lblItemname = new System.Windows.Forms.Label();
            this.lblLogo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picItem)).BeginInit();
            this.SuspendLayout();
            // 
            // picItem
            // 
            this.picItem.Image = global::mcr_2._0.Properties.Resources.Empty_crafting_table;
            this.picItem.Location = new System.Drawing.Point(79, 135);
            this.picItem.Name = "picItem";
            this.picItem.Size = new System.Drawing.Size(201, 100);
            this.picItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picItem.TabIndex = 5;
            this.picItem.TabStop = false;
            // 
            // txtSearch
            // 
            this.txtSearch.AutoCompleteCustomSource.AddRange(new string[] {
            "Chest",
            "Crafting Table",
            "Furnace",
            "Stick",
            "Torches",
            "Wood Planks",
            "Axes",
            "Bucket",
            "Carrot on a Stick",
            "Clock",
            "Compass",
            "Fishing Rod",
            "Flint and Steel",
            "Hoe",
            "Map",
            "Pickaxe",
            "Shears",
            "Shovel",
            "Arrows",
            "Bow",
            "Damaged Shield",
            "Patterned Shield",
            "Shield",
            "Spectral Arrow",
            "Sword",
            "Tipped Arrows",
            "Boots",
            "Chestplate",
            "Helmet",
            "Leggings",
            "Andesite",
            "Anvil",
            "Beacon",
            "Block of Coal",
            "Block of Quartz",
            "Block of Redstone",
            "Bone Block",
            "Bookshelf",
            "Brick Block",
            "Chiseled Sandstone",
            "Chiseled Stone Brick",
            "Clay Block",
            "Coarse Dirt",
            "Dark Prismarine",
            "Diorite",
            "End Stone Bricks",
            "Glowstone",
            "Granite",
            "Hay Bale"});
            this.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(183)))), ((int)(((byte)(136)))));
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.DimGray;
            this.txtSearch.Location = new System.Drawing.Point(79, 62);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(178, 20);
            this.txtSearch.TabIndex = 6;
            this.txtSearch.Text = "Search...";
            this.txtSearch.Click += new System.EventHandler(this.txtSearch_Click);
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // btnSearch
            // 
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Location = new System.Drawing.Point(263, 62);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 20);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseMnemonic = false;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.DarkRed;
            this.lblError.Location = new System.Drawing.Point(75, 97);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(113, 20);
            this.lblError.TabIndex = 9;
            this.lblError.Text = "Error Message";
            this.lblError.Visible = false;
            // 
            // lblIng
            // 
            this.lblIng.AutoSize = true;
            this.lblIng.Location = new System.Drawing.Point(145, 299);
            this.lblIng.Name = "lblIng";
            this.lblIng.Size = new System.Drawing.Size(59, 13);
            this.lblIng.TabIndex = 14;
            this.lblIng.Text = "Ingredients";
            this.lblIng.Visible = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(145, 260);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(35, 13);
            this.lblName.TabIndex = 13;
            this.lblName.Text = "Name";
            this.lblName.Visible = false;
            // 
            // lblItemIng
            // 
            this.lblItemIng.AutoSize = true;
            this.lblItemIng.Location = new System.Drawing.Point(76, 299);
            this.lblItemIng.Name = "lblItemIng";
            this.lblItemIng.Size = new System.Drawing.Size(62, 13);
            this.lblItemIng.TabIndex = 11;
            this.lblItemIng.Text = "Ingredients:";
            this.lblItemIng.Visible = false;
            // 
            // lblItemname
            // 
            this.lblItemname.AutoSize = true;
            this.lblItemname.Location = new System.Drawing.Point(76, 260);
            this.lblItemname.Name = "lblItemname";
            this.lblItemname.Size = new System.Drawing.Size(38, 13);
            this.lblItemname.TabIndex = 12;
            this.lblItemname.Text = "Name:";
            this.lblItemname.Visible = false;
            // 
            // lblLogo
            // 
            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(28)))), ((int)(((byte)(21)))));
            this.lblLogo.Location = new System.Drawing.Point(71, -3);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(232, 42);
            this.lblLogo.TabIndex = 15;
            this.lblLogo.Text = "MC Recipes";
            // 
            // searchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(106)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(516, 393);
            this.Controls.Add(this.lblLogo);
            this.Controls.Add(this.lblIng);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblItemIng);
            this.Controls.Add(this.lblItemname);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.picItem);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "searchForm";
            this.Text = "searchForm";
            ((System.ComponentModel.ISupportInitialize)(this.picItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picItem;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblIng;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblItemIng;
        private System.Windows.Forms.Label lblItemname;
        private System.Windows.Forms.Label lblLogo;
    }
}