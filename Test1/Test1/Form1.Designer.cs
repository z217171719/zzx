namespace Test1
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
      this.buttonAdd = new System.Windows.Forms.Button();
      this.textBoxOp1 = new System.Windows.Forms.TextBox();
      this.textBoxOp2 = new System.Windows.Forms.TextBox();
      this.labelResult = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // buttonAdd
      // 
      this.buttonAdd.BackColor = System.Drawing.Color.DarkRed;
      this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.buttonAdd.ForeColor = System.Drawing.Color.Yellow;
      this.buttonAdd.Location = new System.Drawing.Point(240, 113);
      this.buttonAdd.Name = "buttonAdd";
      this.buttonAdd.Size = new System.Drawing.Size(100, 86);
      this.buttonAdd.TabIndex = 0;
      this.buttonAdd.Text = "+";
      this.buttonAdd.UseVisualStyleBackColor = false;
      this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
      // 
      // textBoxOp1
      // 
      this.textBoxOp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textBoxOp1.Location = new System.Drawing.Point(40, 113);
      this.textBoxOp1.Name = "textBoxOp1";
      this.textBoxOp1.Size = new System.Drawing.Size(150, 31);
      this.textBoxOp1.TabIndex = 1;
      // 
      // textBoxOp2
      // 
      this.textBoxOp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textBoxOp2.Location = new System.Drawing.Point(40, 168);
      this.textBoxOp2.Name = "textBoxOp2";
      this.textBoxOp2.Size = new System.Drawing.Size(150, 31);
      this.textBoxOp2.TabIndex = 2;
      // 
      // labelResult
      // 
      this.labelResult.AutoSize = true;
      this.labelResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.labelResult.Location = new System.Drawing.Point(37, 43);
      this.labelResult.Name = "labelResult";
      this.labelResult.Size = new System.Drawing.Size(106, 37);
      this.labelResult.TabIndex = 3;
      this.labelResult.Text = "Result";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(391, 263);
      this.Controls.Add(this.labelResult);
      this.Controls.Add(this.textBoxOp2);
      this.Controls.Add(this.textBoxOp1);
      this.Controls.Add(this.buttonAdd);
      this.Name = "Form1";
      this.Text = "My Calc";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button buttonAdd;
    private System.Windows.Forms.TextBox textBoxOp1;
    private System.Windows.Forms.TextBox textBoxOp2;
    private System.Windows.Forms.Label labelResult;
  }
}

