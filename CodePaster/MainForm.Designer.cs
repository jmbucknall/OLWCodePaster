namespace CodePaster {
  partial class MainForm {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.CodeTypes = new System.Windows.Forms.ComboBox();
      this.label1 = new System.Windows.Forms.Label();
      this.OKBtn = new System.Windows.Forms.Button();
      this.CancelBtn = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // CodeTypes
      // 
      this.CodeTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.CodeTypes.FormattingEnabled = true;
      this.CodeTypes.Location = new System.Drawing.Point(24, 50);
      this.CodeTypes.Name = "CodeTypes";
      this.CodeTypes.Size = new System.Drawing.Size(335, 21);
      this.CodeTypes.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(21, 30);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(186, 13);
      this.label1.TabIndex = 1;
      this.label1.Text = "Select the type of code being inserted";
      // 
      // OKBtn
      // 
      this.OKBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.OKBtn.Location = new System.Drawing.Point(203, 125);
      this.OKBtn.Name = "OKBtn";
      this.OKBtn.Size = new System.Drawing.Size(75, 23);
      this.OKBtn.TabIndex = 2;
      this.OKBtn.Text = "OK";
      this.OKBtn.UseVisualStyleBackColor = true;
      // 
      // CancelBtn
      // 
      this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.CancelBtn.Location = new System.Drawing.Point(284, 125);
      this.CancelBtn.Name = "CancelBtn";
      this.CancelBtn.Size = new System.Drawing.Size(75, 23);
      this.CancelBtn.TabIndex = 3;
      this.CancelBtn.Text = "Cancel";
      this.CancelBtn.UseVisualStyleBackColor = true;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(386, 167);
      this.Controls.Add(this.CancelBtn);
      this.Controls.Add(this.OKBtn);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.CodeTypes);
      this.Name = "MainForm";
      this.Text = "MainForm";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ComboBox CodeTypes;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button OKBtn;
    private System.Windows.Forms.Button CancelBtn;
  }
}