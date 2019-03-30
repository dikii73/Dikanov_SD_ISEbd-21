namespace Tank
{
    partial class FormTank
    {
   
        private System.ComponentModel.IContainer components = null;

        
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTank));
            this.pictureBoxTank = new System.Windows.Forms.PictureBox();
            this.buttonCreateCar = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonCreateTank = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTank)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxTank
            // 
            this.pictureBoxTank.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxTank.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxTank.Name = "pictureBoxTank";
            this.pictureBoxTank.Size = new System.Drawing.Size(882, 453);
            this.pictureBoxTank.TabIndex = 0;
            this.pictureBoxTank.TabStop = false;
            // 
            // buttonCreateCar
            // 
            this.buttonCreateCar.Location = new System.Drawing.Point(730, 21);
            this.buttonCreateCar.Name = "buttonCreateCar";
            this.buttonCreateCar.Size = new System.Drawing.Size(140, 30);
            this.buttonCreateCar.TabIndex = 1;
            this.buttonCreateCar.Text = "Создать броневик";
            this.buttonCreateCar.UseVisualStyleBackColor = true;
            this.buttonCreateCar.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.Image = ((System.Drawing.Image)(resources.GetObject("buttonRight.Image")));
            this.buttonRight.Location = new System.Drawing.Point(822, 402);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(30, 30);
            this.buttonRight.TabIndex = 2;
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonUp
            // 
            this.buttonUp.Image = ((System.Drawing.Image)(resources.GetObject("buttonUp.Image")));
            this.buttonUp.Location = new System.Drawing.Point(786, 366);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(30, 30);
            this.buttonUp.TabIndex = 3;
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.Image = ((System.Drawing.Image)(resources.GetObject("buttonLeft.Image")));
            this.buttonLeft.Location = new System.Drawing.Point(750, 402);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(30, 30);
            this.buttonLeft.TabIndex = 4;
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.Image = ((System.Drawing.Image)(resources.GetObject("buttonDown.Image")));
            this.buttonDown.Location = new System.Drawing.Point(786, 402);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(30, 30);
            this.buttonDown.TabIndex = 5;
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonCreateTank
            // 
            this.buttonCreateTank.Location = new System.Drawing.Point(730, 75);
            this.buttonCreateTank.Name = "buttonCreateTank";
            this.buttonCreateTank.Size = new System.Drawing.Size(140, 30);
            this.buttonCreateTank.TabIndex = 6;
            this.buttonCreateTank.Text = "Создать танк";
            this.buttonCreateTank.UseVisualStyleBackColor = true;
            this.buttonCreateTank.Click += new System.EventHandler(this.buttonCreateTank_Click);
            // 
            // FormTank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 453);
            this.Controls.Add(this.buttonCreateTank);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonCreateCar);
            this.Controls.Add(this.pictureBoxTank);
            this.Name = "FormTank";
            this.Text = "Tank";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTank)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxTank;
        private System.Windows.Forms.Button buttonCreateCar;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonCreateTank;
    }
}

