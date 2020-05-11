namespace OFClient
{
    partial class frmSign
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSign));
            this.axUnipenFingerprint1 = new AxUnipenFingerprintLib.AxUnipenFingerprint();
            ((System.ComponentModel.ISupportInitialize)(this.axUnipenFingerprint1)).BeginInit();
            this.SuspendLayout();
            // 
            // axUnipenFingerprint1
            // 
            this.axUnipenFingerprint1.Enabled = true;
            this.axUnipenFingerprint1.Location = new System.Drawing.Point(57, 38);
            this.axUnipenFingerprint1.Name = "axUnipenFingerprint1";
            this.axUnipenFingerprint1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axUnipenFingerprint1.OcxState")));
            this.axUnipenFingerprint1.Size = new System.Drawing.Size(283, 188);
            this.axUnipenFingerprint1.TabIndex = 0;
            // 
            // frmSign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 413);
            this.Controls.Add(this.axUnipenFingerprint1);
            this.Name = "frmSign";
            this.Text = "frmSign";
            ((System.ComponentModel.ISupportInitialize)(this.axUnipenFingerprint1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxUnipenFingerprintLib.AxUnipenFingerprint axUnipenFingerprint1;
    }
}