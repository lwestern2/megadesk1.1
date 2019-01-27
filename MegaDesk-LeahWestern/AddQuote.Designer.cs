namespace MegaDesk_LeahWestern
{
    partial class AddQuote
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
            this.cancelQuoteButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.boxName = new System.Windows.Forms.TextBox();
            this.boxDepth = new System.Windows.Forms.TextBox();
            this.depthLabel = new System.Windows.Forms.Label();
            this.boxWidth = new System.Windows.Forms.TextBox();
            this.widthLabel = new System.Windows.Forms.Label();
            this.boxDrawer = new System.Windows.Forms.TextBox();
            this.drawerLabel = new System.Windows.Forms.Label();
            this.materialLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.rushGroup = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.boxMaterial = new System.Windows.Forms.ComboBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.rushGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancelQuoteButton
            // 
            this.cancelQuoteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelQuoteButton.Location = new System.Drawing.Point(27, 343);
            this.cancelQuoteButton.Name = "cancelQuoteButton";
            this.cancelQuoteButton.Size = new System.Drawing.Size(83, 39);
            this.cancelQuoteButton.TabIndex = 0;
            this.cancelQuoteButton.Text = "Cancel";
            this.cancelQuoteButton.UseVisualStyleBackColor = true;
            this.cancelQuoteButton.Click += new System.EventHandler(this.cancelQuoteButton_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(27, 23);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(113, 17);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Customer Name:";
            // 
            // boxName
            // 
            this.boxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxName.Location = new System.Drawing.Point(146, 22);
            this.boxName.Name = "boxName";
            this.boxName.Size = new System.Drawing.Size(170, 21);
            this.boxName.TabIndex = 1;
            // 
            // boxDepth
            // 
            this.boxDepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxDepth.Location = new System.Drawing.Point(81, 103);
            this.boxDepth.Name = "boxDepth";
            this.boxDepth.Size = new System.Drawing.Size(80, 21);
            this.boxDepth.TabIndex = 3;
            this.boxDepth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BoxDepth_KeyPress);
            // 
            // depthLabel
            // 
            this.depthLabel.AutoSize = true;
            this.depthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depthLabel.Location = new System.Drawing.Point(27, 103);
            this.depthLabel.Name = "depthLabel";
            this.depthLabel.Size = new System.Drawing.Size(50, 17);
            this.depthLabel.TabIndex = 3;
            this.depthLabel.Text = "Depth:";
            // 
            // boxWidth
            // 
            this.boxWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxWidth.Location = new System.Drawing.Point(81, 63);
            this.boxWidth.Name = "boxWidth";
            this.boxWidth.Size = new System.Drawing.Size(80, 21);
            this.boxWidth.TabIndex = 2;
            this.boxWidth.Validating += new System.ComponentModel.CancelEventHandler(this.BoxWidth_Validating);
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.widthLabel.Location = new System.Drawing.Point(27, 63);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(48, 17);
            this.widthLabel.TabIndex = 5;
            this.widthLabel.Text = "Width:";
            // 
            // boxDrawer
            // 
            this.boxDrawer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxDrawer.Location = new System.Drawing.Point(167, 183);
            this.boxDrawer.Name = "boxDrawer";
            this.boxDrawer.Size = new System.Drawing.Size(98, 21);
            this.boxDrawer.TabIndex = 5;
            // 
            // drawerLabel
            // 
            this.drawerLabel.AutoSize = true;
            this.drawerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drawerLabel.Location = new System.Drawing.Point(27, 183);
            this.drawerLabel.Name = "drawerLabel";
            this.drawerLabel.Size = new System.Drawing.Size(134, 17);
            this.drawerLabel.TabIndex = 7;
            this.drawerLabel.Text = "Number of Drawers:";
            // 
            // materialLabel
            // 
            this.materialLabel.AutoSize = true;
            this.materialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialLabel.Location = new System.Drawing.Point(27, 143);
            this.materialLabel.Name = "materialLabel";
            this.materialLabel.Size = new System.Drawing.Size(62, 17);
            this.materialLabel.TabIndex = 9;
            this.materialLabel.Text = "Material:";
            // 
            // submitButton
            // 
            this.submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.Location = new System.Drawing.Point(369, 343);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(83, 39);
            this.submitButton.TabIndex = 11;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            // 
            // rushGroup
            // 
            this.rushGroup.Controls.Add(this.radioButton3);
            this.rushGroup.Controls.Add(this.radioButton2);
            this.rushGroup.Controls.Add(this.radioButton1);
            this.rushGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rushGroup.Location = new System.Drawing.Point(30, 219);
            this.rushGroup.Name = "rushGroup";
            this.rushGroup.Size = new System.Drawing.Size(113, 102);
            this.rushGroup.TabIndex = 14;
            this.rushGroup.TabStop = false;
            this.rushGroup.Text = "Rush Order";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 47);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(56, 19);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "5 Day";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 23);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(56, 19);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "3 Day";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // boxMaterial
            // 
            this.boxMaterial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxMaterial.FormattingEnabled = true;
            this.boxMaterial.Items.AddRange(new object[] {
            "Oak - $200",
            "Laminate - $100",
            "Pine - $50",
            "Rosewood - $300",
            "Veneer - $125"});
            this.boxMaterial.Location = new System.Drawing.Point(95, 143);
            this.boxMaterial.Name = "boxMaterial";
            this.boxMaterial.Size = new System.Drawing.Size(158, 23);
            this.boxMaterial.TabIndex = 15;
            this.boxMaterial.Text = "Please choose material";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 71);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(56, 19);
            this.radioButton3.TabIndex = 8;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "7 Day";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(477, 398);
            this.Controls.Add(this.boxMaterial);
            this.Controls.Add(this.rushGroup);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.materialLabel);
            this.Controls.Add(this.boxDrawer);
            this.Controls.Add(this.drawerLabel);
            this.Controls.Add(this.boxWidth);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.boxDepth);
            this.Controls.Add(this.depthLabel);
            this.Controls.Add(this.boxName);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.cancelQuoteButton);
            this.Name = "AddQuote";
            this.Text = "AddQuote";
            this.rushGroup.ResumeLayout(false);
            this.rushGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelQuoteButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox boxName;
        private System.Windows.Forms.TextBox boxDepth;
        private System.Windows.Forms.Label depthLabel;
        private System.Windows.Forms.TextBox boxWidth;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.TextBox boxDrawer;
        private System.Windows.Forms.Label drawerLabel;
        private System.Windows.Forms.Label materialLabel;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.GroupBox rushGroup;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ComboBox boxMaterial;
        private System.Windows.Forms.RadioButton radioButton3;
    }
}