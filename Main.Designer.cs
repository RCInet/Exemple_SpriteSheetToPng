namespace IconsExtractor
{
    partial class Main
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button_Select_Css = new System.Windows.Forms.Button();
            this.textBox_Css = new System.Windows.Forms.TextBox();
            this.Icons_Count_In_Css = new System.Windows.Forms.Label();
            this.button_Select_Picture = new System.Windows.Forms.Button();
            this.textBox_Picture = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.textBox_Output_Path = new System.Windows.Forms.TextBox();
            this.button_Extract_Icons = new System.Windows.Forms.Button();
            this.button_Path = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button_Select_Css
            // 
            this.button_Select_Css.AutoSize = true;
            this.button_Select_Css.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_Select_Css.Location = new System.Drawing.Point(3, 3);
            this.button_Select_Css.Name = "button_Select_Css";
            this.tableLayoutPanel1.SetRowSpan(this.button_Select_Css, 2);
            this.button_Select_Css.Size = new System.Drawing.Size(173, 59);
            this.button_Select_Css.TabIndex = 0;
            this.button_Select_Css.Text = "Select CSS";
            this.button_Select_Css.UseVisualStyleBackColor = true;
            this.button_Select_Css.Click += new System.EventHandler(this.button_Select_Css_Click);
            // 
            // textBox_Css
            // 
            this.textBox_Css.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_Css.Location = new System.Drawing.Point(182, 3);
            this.textBox_Css.Name = "textBox_Css";
            this.textBox_Css.Size = new System.Drawing.Size(1116, 26);
            this.textBox_Css.TabIndex = 1;
            // 
            // Icons_Count_In_Css
            // 
            this.Icons_Count_In_Css.AutoSize = true;
            this.Icons_Count_In_Css.Dock = System.Windows.Forms.DockStyle.Top;
            this.Icons_Count_In_Css.Location = new System.Drawing.Point(182, 32);
            this.Icons_Count_In_Css.Name = "Icons_Count_In_Css";
            this.Icons_Count_In_Css.Size = new System.Drawing.Size(1116, 20);
            this.Icons_Count_In_Css.TabIndex = 2;
            this.Icons_Count_In_Css.Text = "label1";
            // 
            // button_Select_Picture
            // 
            this.button_Select_Picture.AutoSize = true;
            this.button_Select_Picture.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_Select_Picture.Location = new System.Drawing.Point(3, 68);
            this.button_Select_Picture.Name = "button_Select_Picture";
            this.tableLayoutPanel1.SetRowSpan(this.button_Select_Picture, 2);
            this.button_Select_Picture.Size = new System.Drawing.Size(173, 59);
            this.button_Select_Picture.TabIndex = 3;
            this.button_Select_Picture.Text = "Select Picture";
            this.button_Select_Picture.UseVisualStyleBackColor = true;
            this.button_Select_Picture.Click += new System.EventHandler(this.button_Select_Picture_Click);
            // 
            // textBox_Picture
            // 
            this.textBox_Picture.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_Picture.Location = new System.Drawing.Point(182, 68);
            this.textBox_Picture.Name = "textBox_Picture";
            this.textBox_Picture.Size = new System.Drawing.Size(1116, 26);
            this.textBox_Picture.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.textBox_Output_Path, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.button_Select_Css, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox_Css, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBox_Picture, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.button_Select_Picture, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Icons_Count_In_Css, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.button_Extract_Icons, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.button_Path, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1301, 202);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // textBox_Output_Path
            // 
            this.textBox_Output_Path.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox_Output_Path.Location = new System.Drawing.Point(182, 133);
            this.textBox_Output_Path.Name = "textBox_Output_Path";
            this.textBox_Output_Path.Size = new System.Drawing.Size(1116, 26);
            this.textBox_Output_Path.TabIndex = 8;
            // 
            // button_Extract_Icons
            // 
            this.button_Extract_Icons.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.button_Extract_Icons, 2);
            this.button_Extract_Icons.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_Extract_Icons.Location = new System.Drawing.Point(3, 169);
            this.button_Extract_Icons.Name = "button_Extract_Icons";
            this.button_Extract_Icons.Size = new System.Drawing.Size(1295, 30);
            this.button_Extract_Icons.TabIndex = 6;
            this.button_Extract_Icons.Text = "Extract Icons";
            this.button_Extract_Icons.UseVisualStyleBackColor = true;
            this.button_Extract_Icons.Click += new System.EventHandler(this.button_Extract_Icons_Click);
            // 
            // button_Path
            // 
            this.button_Path.AutoSize = true;
            this.button_Path.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_Path.Location = new System.Drawing.Point(3, 133);
            this.button_Path.Name = "button_Path";
            this.button_Path.Size = new System.Drawing.Size(173, 30);
            this.button_Path.TabIndex = 7;
            this.button_Path.Text = "Output";
            this.button_Path.UseVisualStyleBackColor = true;
            this.button_Path.Click += new System.EventHandler(this.button_Path_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1301, 205);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Last Epoch Sprites Extractor";
            this.Shown += new System.EventHandler(this.Main_Shown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button_Select_Css;
        private System.Windows.Forms.TextBox textBox_Css;
        private System.Windows.Forms.Label Icons_Count_In_Css;
        private System.Windows.Forms.Button button_Select_Picture;
        private System.Windows.Forms.TextBox textBox_Picture;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button_Extract_Icons;
        private System.Windows.Forms.TextBox textBox_Output_Path;
        private System.Windows.Forms.Button button_Path;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

