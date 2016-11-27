namespace MP3TagEditor
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
            this._btnBrowse = new System.Windows.Forms.Button();
            this._txtArtists = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this._txtAlbumArtists = new System.Windows.Forms.TextBox();
            this._txtAlbum = new System.Windows.Forms.TextBox();
            this._txtTitle = new System.Windows.Forms.TextBox();
            this._btnSave = new System.Windows.Forms.Button();
            this._btnAuto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _btnBrowse
            // 
            this._btnBrowse.Location = new System.Drawing.Point(13, 13);
            this._btnBrowse.Name = "_btnBrowse";
            this._btnBrowse.Size = new System.Drawing.Size(75, 23);
            this._btnBrowse.TabIndex = 0;
            this._btnBrowse.Text = "Browse...";
            this._btnBrowse.UseVisualStyleBackColor = true;
            this._btnBrowse.Click += new System.EventHandler(this._btnBrowse_Click);
            // 
            // _txtArtists
            // 
            this._txtArtists.Location = new System.Drawing.Point(117, 70);
            this._txtArtists.Name = "_txtArtists";
            this._txtArtists.Size = new System.Drawing.Size(100, 20);
            this._txtArtists.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Artists";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Album Artists";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Album";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Title";
            // 
            // _txtAlbumArtists
            // 
            this._txtAlbumArtists.Location = new System.Drawing.Point(117, 97);
            this._txtAlbumArtists.Name = "_txtAlbumArtists";
            this._txtAlbumArtists.Size = new System.Drawing.Size(100, 20);
            this._txtAlbumArtists.TabIndex = 6;
            // 
            // _txtAlbum
            // 
            this._txtAlbum.Location = new System.Drawing.Point(117, 124);
            this._txtAlbum.Name = "_txtAlbum";
            this._txtAlbum.Size = new System.Drawing.Size(100, 20);
            this._txtAlbum.TabIndex = 7;
            // 
            // _txtTitle
            // 
            this._txtTitle.Location = new System.Drawing.Point(117, 151);
            this._txtTitle.Name = "_txtTitle";
            this._txtTitle.Size = new System.Drawing.Size(100, 20);
            this._txtTitle.TabIndex = 8;
            // 
            // _btnSave
            // 
            this._btnSave.Location = new System.Drawing.Point(13, 193);
            this._btnSave.Name = "_btnSave";
            this._btnSave.Size = new System.Drawing.Size(75, 23);
            this._btnSave.TabIndex = 9;
            this._btnSave.Text = "Save";
            this._btnSave.UseVisualStyleBackColor = true;
            this._btnSave.Click += new System.EventHandler(this._btnSave_Click);
            // 
            // _btnAuto
            // 
            this._btnAuto.Location = new System.Drawing.Point(186, 192);
            this._btnAuto.Name = "_btnAuto";
            this._btnAuto.Size = new System.Drawing.Size(75, 23);
            this._btnAuto.TabIndex = 10;
            this._btnAuto.Text = "Auto-Fill";
            this._btnAuto.UseVisualStyleBackColor = true;
            this._btnAuto.Click += new System.EventHandler(this._btnAuto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 263);
            this.Controls.Add(this._btnAuto);
            this.Controls.Add(this._btnSave);
            this.Controls.Add(this._txtTitle);
            this.Controls.Add(this._txtAlbum);
            this.Controls.Add(this._txtAlbumArtists);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._txtArtists);
            this.Controls.Add(this._btnBrowse);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _btnBrowse;
        private System.Windows.Forms.TextBox _txtArtists;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox _txtAlbumArtists;
        private System.Windows.Forms.TextBox _txtAlbum;
        private System.Windows.Forms.TextBox _txtTitle;
        private System.Windows.Forms.Button _btnSave;
        private System.Windows.Forms.Button _btnAuto;
    }
}

