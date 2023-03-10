namespace PicturesViewer
{
    partial class Main
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
            this.btnAddPicture = new System.Windows.Forms.Button();
            this.btnDeletePicture = new System.Windows.Forms.Button();
            this.pbox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddPicture
            // 
            this.btnAddPicture.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddPicture.Location = new System.Drawing.Point(228, 415);
            this.btnAddPicture.Name = "btnAddPicture";
            this.btnAddPicture.Size = new System.Drawing.Size(128, 23);
            this.btnAddPicture.TabIndex = 0;
            this.btnAddPicture.Text = "Dodaj zdjęcie";
            this.btnAddPicture.UseVisualStyleBackColor = true;
            this.btnAddPicture.Click += new System.EventHandler(this.btnAddPicture_Click);
            // 
            // btnDeletePicture
            // 
            this.btnDeletePicture.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeletePicture.Location = new System.Drawing.Point(464, 415);
            this.btnDeletePicture.Name = "btnDeletePicture";
            this.btnDeletePicture.Size = new System.Drawing.Size(128, 23);
            this.btnDeletePicture.TabIndex = 1;
            this.btnDeletePicture.Text = "Usuń zdjęcie";
            this.btnDeletePicture.UseVisualStyleBackColor = true;
            this.btnDeletePicture.Visible = false;
            this.btnDeletePicture.Click += new System.EventHandler(this.btnDeletePicture_Click);
            // 
            // pbox
            // 
            this.pbox.Location = new System.Drawing.Point(12, 12);
            this.pbox.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.pbox.Name = "pbox";
            this.pbox.Size = new System.Drawing.Size(760, 388);
            this.pbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox.TabIndex = 2;
            this.pbox.TabStop = false;
            this.pbox.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.pbox_LoadCompleted);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.pbox);
            this.Controls.Add(this.btnDeletePicture);
            this.Controls.Add(this.btnAddPicture);
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Main";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddPicture;
        private System.Windows.Forms.Button btnDeletePicture;
        private System.Windows.Forms.PictureBox pbox;
    }
}

