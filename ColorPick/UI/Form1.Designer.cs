namespace ColorPick
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
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBoxImg = new System.Windows.Forms.PictureBox();
            this.buttonLoadImg = new System.Windows.Forms.Button();
            this.pictureBoxColor = new System.Windows.Forms.PictureBox();
            this.labelColor = new System.Windows.Forms.Label();
            this.labelImgColor = new System.Windows.Forms.Label();
            this.tableLayoutPanelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColor)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelMain.AutoScroll = true;
            this.tableLayoutPanelMain.AutoSize = true;
            this.tableLayoutPanelMain.ColumnCount = 1;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMain.Controls.Add(this.pictureBoxImg, 0, 0);
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(12, 87);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 1;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanelMain.TabIndex = 0;
            // 
            // pictureBoxImg
            // 
            this.pictureBoxImg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxImg.InitialImage = null;
            this.pictureBoxImg.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxImg.Name = "pictureBoxImg";
            this.pictureBoxImg.Size = new System.Drawing.Size(194, 94);
            this.pictureBoxImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImg.TabIndex = 0;
            this.pictureBoxImg.TabStop = false;
            this.pictureBoxImg.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxImg_MouseDown);
            this.pictureBoxImg.MouseHover += new System.EventHandler(this.pictureBoxImg_MouseHover);
            // 
            // buttonLoadImg
            // 
            this.buttonLoadImg.Font = new System.Drawing.Font("Corbel", 16F);
            this.buttonLoadImg.Location = new System.Drawing.Point(12, 10);
            this.buttonLoadImg.Name = "buttonLoadImg";
            this.buttonLoadImg.Size = new System.Drawing.Size(173, 61);
            this.buttonLoadImg.TabIndex = 1;
            this.buttonLoadImg.Text = "Load img";
            this.buttonLoadImg.UseVisualStyleBackColor = true;
            this.buttonLoadImg.Click += new System.EventHandler(this.buttonLoadImg_Click);
            // 
            // pictureBoxColor
            // 
            this.pictureBoxColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBoxColor.Location = new System.Drawing.Point(220, 10);
            this.pictureBoxColor.Name = "pictureBoxColor";
            this.pictureBoxColor.Size = new System.Drawing.Size(64, 61);
            this.pictureBoxColor.TabIndex = 2;
            this.pictureBoxColor.TabStop = false;
            // 
            // labelColor
            // 
            this.labelColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelColor.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelColor.Location = new System.Drawing.Point(290, 10);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(331, 45);
            this.labelColor.TabIndex = 3;
            // 
            // labelImgColor
            // 
            this.labelImgColor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelImgColor.Location = new System.Drawing.Point(663, 9);
            this.labelImgColor.Name = "labelImgColor";
            this.labelImgColor.Size = new System.Drawing.Size(100, 46);
            this.labelImgColor.TabIndex = 4;
            this.labelImgColor.Text = "C";
            this.labelImgColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelImgColor);
            this.Controls.Add(this.labelColor);
            this.Controls.Add(this.pictureBoxColor);
            this.Controls.Add(this.buttonLoadImg);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.PictureBox pictureBoxImg;
        private System.Windows.Forms.Button buttonLoadImg;
        private System.Windows.Forms.PictureBox pictureBoxColor;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.Label labelImgColor;
    }
}

