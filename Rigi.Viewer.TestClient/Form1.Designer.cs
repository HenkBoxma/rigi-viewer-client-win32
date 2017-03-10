namespace Rigi.Viewer.TestClient
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
      this.button2 = new System.Windows.Forms.Button();
      this.output = new System.Windows.Forms.TextBox();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.txtSignature = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.statusStrip1 = new System.Windows.Forms.StatusStrip();
      this.status = new System.Windows.Forms.ToolStripStatusLabel();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.txtTranslation = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.txtSigTranslate = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.button3 = new System.Windows.Forms.Button();
      this.groupBox3 = new System.Windows.Forms.GroupBox();
      this.txtProjectUrl = new System.Windows.Forms.TextBox();
      this.label4 = new System.Windows.Forms.Label();
      this.button4 = new System.Windows.Forms.Button();
      this.button1 = new System.Windows.Forms.Button();
      this.groupBox1.SuspendLayout();
      this.statusStrip1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.groupBox3.SuspendLayout();
      this.SuspendLayout();
      // 
      // button2
      // 
      this.button2.Location = new System.Drawing.Point(248, 54);
      this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(111, 28);
      this.button2.TabIndex = 1;
      this.button2.Text = "Select";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // output
      // 
      this.output.Location = new System.Drawing.Point(16, 118);
      this.output.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.output.Multiline = true;
      this.output.Name = "output";
      this.output.ReadOnly = true;
      this.output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.output.Size = new System.Drawing.Size(1137, 427);
      this.output.TabIndex = 2;
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.txtSignature);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Controls.Add(this.button2);
      this.groupBox1.Location = new System.Drawing.Point(413, 15);
      this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.groupBox1.Size = new System.Drawing.Size(375, 96);
      this.groupBox1.TabIndex = 3;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Select";
      // 
      // txtSignature
      // 
      this.txtSignature.Location = new System.Drawing.Point(89, 20);
      this.txtSignature.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.txtSignature.Name = "txtSignature";
      this.txtSignature.Size = new System.Drawing.Size(268, 22);
      this.txtSignature.TabIndex = 3;
      this.txtSignature.Text = "2629757992855423862";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(8, 23);
      this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(73, 17);
      this.label1.TabIndex = 2;
      this.label1.Text = "Signature:";
      // 
      // statusStrip1
      // 
      this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
      this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.status});
      this.statusStrip1.Location = new System.Drawing.Point(0, 552);
      this.statusStrip1.Name = "statusStrip1";
      this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
      this.statusStrip1.Size = new System.Drawing.Size(1293, 25);
      this.statusStrip1.TabIndex = 4;
      this.statusStrip1.Text = "statusStrip1";
      // 
      // status
      // 
      this.status.Name = "status";
      this.status.Size = new System.Drawing.Size(53, 20);
      this.status.Text = "Ready.";
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.txtTranslation);
      this.groupBox2.Controls.Add(this.label3);
      this.groupBox2.Controls.Add(this.txtSigTranslate);
      this.groupBox2.Controls.Add(this.label2);
      this.groupBox2.Controls.Add(this.button3);
      this.groupBox2.Location = new System.Drawing.Point(796, 15);
      this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.groupBox2.Size = new System.Drawing.Size(487, 96);
      this.groupBox2.TabIndex = 5;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Translate";
      // 
      // txtTranslation
      // 
      this.txtTranslation.Location = new System.Drawing.Point(89, 57);
      this.txtTranslation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.txtTranslation.Name = "txtTranslation";
      this.txtTranslation.Size = new System.Drawing.Size(268, 22);
      this.txtTranslation.TabIndex = 5;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(8, 60);
      this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(39, 17);
      this.label3.TabIndex = 4;
      this.label3.Text = "Text:";
      // 
      // txtSigTranslate
      // 
      this.txtSigTranslate.Location = new System.Drawing.Point(89, 20);
      this.txtSigTranslate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.txtSigTranslate.Name = "txtSigTranslate";
      this.txtSigTranslate.Size = new System.Drawing.Size(268, 22);
      this.txtSigTranslate.TabIndex = 3;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(8, 23);
      this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(73, 17);
      this.label2.TabIndex = 2;
      this.label2.Text = "Signature:";
      // 
      // button3
      // 
      this.button3.Location = new System.Drawing.Point(367, 20);
      this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(104, 28);
      this.button3.TabIndex = 1;
      this.button3.Text = "Translate";
      this.button3.UseVisualStyleBackColor = true;
      this.button3.Click += new System.EventHandler(this.button3_Click);
      // 
      // groupBox3
      // 
      this.groupBox3.Controls.Add(this.txtProjectUrl);
      this.groupBox3.Controls.Add(this.label4);
      this.groupBox3.Controls.Add(this.button4);
      this.groupBox3.Location = new System.Drawing.Point(16, 15);
      this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.groupBox3.Size = new System.Drawing.Size(389, 96);
      this.groupBox3.TabIndex = 6;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "Start";
      // 
      // txtProjectUrl
      // 
      this.txtProjectUrl.Location = new System.Drawing.Point(107, 20);
      this.txtProjectUrl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.txtProjectUrl.Name = "txtProjectUrl";
      this.txtProjectUrl.Size = new System.Drawing.Size(268, 22);
      this.txtProjectUrl.TabIndex = 3;
      this.txtProjectUrl.Text = "https://rigidev.rigi.io/projects/585c0abaea4ee56708ab2bc4";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(8, 23);
      this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(88, 17);
      this.label4.TabIndex = 2;
      this.label4.Text = "Project URL:";
      // 
      // button4
      // 
      this.button4.Location = new System.Drawing.Point(296, 52);
      this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.button4.Name = "button4";
      this.button4.Size = new System.Drawing.Size(80, 28);
      this.button4.TabIndex = 1;
      this.button4.Text = "Start";
      this.button4.UseVisualStyleBackColor = true;
      this.button4.Click += new System.EventHandler(this.button4_Click);
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(1163, 118);
      this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(104, 28);
      this.button1.TabIndex = 7;
      this.button1.Text = "Clear";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1293, 577);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.groupBox3);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.statusStrip1);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.output);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
      this.MaximizeBox = false;
      this.Name = "Form1";
      this.Text = "RIGI Viewer Test Client";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.statusStrip1.ResumeLayout(false);
      this.statusStrip1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.groupBox3.ResumeLayout(false);
      this.groupBox3.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.TextBox output;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.TextBox txtSignature;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.StatusStrip statusStrip1;
    private System.Windows.Forms.ToolStripStatusLabel status;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.TextBox txtTranslation;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtSigTranslate;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.TextBox txtProjectUrl;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Button button4;
    private System.Windows.Forms.Button button1;
  }
}

