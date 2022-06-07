namespace Tester
{
    partial class frmTester
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
            this.srcHexViewer1 = new HexViewer.SRCHexViewer();
            this.SuspendLayout();
            // 
            // srcHexViewer1
            // 
            this.srcHexViewer1.AlternateBackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.srcHexViewer1.AlternateBackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.srcHexViewer1.AlternateTextColor1 = System.Drawing.Color.White;
            this.srcHexViewer1.AlternateTextColor2 = System.Drawing.Color.White;
            this.srcHexViewer1.AutoSelectCharacter = true;
            this.srcHexViewer1.AutoSize = true;
            this.srcHexViewer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.srcHexViewer1.BytesPerLine = 18;
            this.srcHexViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.srcHexViewer1.HexCenterSeparator = '-';
            this.srcHexViewer1.HexDataSeparator = ' ';
            this.srcHexViewer1.HexViewBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.srcHexViewer1.HexViewFont = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.srcHexViewer1.HexViewForeColor = System.Drawing.Color.White;
            this.srcHexViewer1.IsAlternateLineColor = true;
            this.srcHexViewer1.LineNumberBackColor = System.Drawing.Color.Empty;
            this.srcHexViewer1.LineNumberForeColor = System.Drawing.Color.Empty;
            this.srcHexViewer1.LoadingDelay = 0;
            this.srcHexViewer1.Location = new System.Drawing.Point(0, 0);
            this.srcHexViewer1.Name = "srcHexViewer1";
            this.srcHexViewer1.Padding = new System.Windows.Forms.Padding(2);
            this.srcHexViewer1.ShowHorizontalScrollbars = false;
            this.srcHexViewer1.ShowLineNumber = false;
            this.srcHexViewer1.ShowProgressBar = true;
            this.srcHexViewer1.Size = new System.Drawing.Size(658, 472);
            this.srcHexViewer1.SynchronizeScrolling = false;
            this.srcHexViewer1.TabIndex = 0;
            this.srcHexViewer1.TextViewBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.srcHexViewer1.TextViewFont = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.srcHexViewer1.TextViewForeColor = System.Drawing.Color.White;
            this.srcHexViewer1.ProgressChanged += new HexViewer.ProgressChangedEventHandler(this.srcHexViewer1_ProgressChanged);
            this.srcHexViewer1.LoadCompleted += new HexViewer.LoadCompletedEventHandler(this.srcHexViewer1_LoadCompleted);
            this.srcHexViewer1.SelectedByteIndexChanged += new HexViewer.SelectedByteIndexChangedEventHandler(this.srcHexViewer1_SelectedByteIndexChanged);
            this.srcHexViewer1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.srcHexViewer1_KeyDown);
            // 
            // frmTester
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 472);
            this.Controls.Add(this.srcHexViewer1);
            this.KeyPreview = true;
            this.Name = "frmTester";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tester";
            this.Load += new System.EventHandler(this.frmTester_Load);
            this.Shown += new System.EventHandler(this.frmTester_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmTester_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HexViewer.SRCHexViewer srcHexViewer1;

    }
}

