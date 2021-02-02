
namespace GUID_O_MATIC
{
    partial class GuidForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuidForm));
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.rbNakedGuid = new System.Windows.Forms.RadioButton();
            this.rbCsharpGuid = new System.Windows.Forms.RadioButton();
            this.btnNewGuid = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rbCurlyBrackets = new System.Windows.Forms.RadioButton();
            this.rbQuotes = new System.Windows.Forms.RadioButton();
            this.cbUppercaseGuid = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnCopy
            // 
            this.btnCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopy.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCopy.Location = new System.Drawing.Point(291, 182);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(127, 23);
            this.btnCopy.TabIndex = 0;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(158, 182);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(127, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // rbNakedGuid
            // 
            this.rbNakedGuid.AutoSize = true;
            this.rbNakedGuid.Location = new System.Drawing.Point(33, 41);
            this.rbNakedGuid.Name = "rbNakedGuid";
            this.rbNakedGuid.Size = new System.Drawing.Size(59, 19);
            this.rbNakedGuid.TabIndex = 3;
            this.rbNakedGuid.Text = "Naked";
            this.rbNakedGuid.UseVisualStyleBackColor = true;
            // 
            // rbCsharpGuid
            // 
            this.rbCsharpGuid.AutoSize = true;
            this.rbCsharpGuid.Checked = true;
            this.rbCsharpGuid.Location = new System.Drawing.Point(33, 116);
            this.rbCsharpGuid.Name = "rbCsharpGuid";
            this.rbCsharpGuid.Size = new System.Drawing.Size(104, 19);
            this.rbCsharpGuid.TabIndex = 4;
            this.rbCsharpGuid.TabStop = true;
            this.rbCsharpGuid.Text = "CSharp Format";
            this.rbCsharpGuid.UseVisualStyleBackColor = true;
            // 
            // btnNewGuid
            // 
            this.btnNewGuid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnNewGuid.Location = new System.Drawing.Point(13, 182);
            this.btnNewGuid.Name = "btnNewGuid";
            this.btnNewGuid.Size = new System.Drawing.Size(137, 23);
            this.btnNewGuid.TabIndex = 5;
            this.btnNewGuid.Text = "New GUID";
            this.btnNewGuid.UseVisualStyleBackColor = true;
            this.btnNewGuid.Click += new System.EventHandler(this.btnNewGuid_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Copy Format:";
            // 
            // rbCurlyBrackets
            // 
            this.rbCurlyBrackets.AutoSize = true;
            this.rbCurlyBrackets.Location = new System.Drawing.Point(33, 91);
            this.rbCurlyBrackets.Name = "rbCurlyBrackets";
            this.rbCurlyBrackets.Size = new System.Drawing.Size(100, 19);
            this.rbCurlyBrackets.TabIndex = 7;
            this.rbCurlyBrackets.TabStop = true;
            this.rbCurlyBrackets.Text = "Curly Brackets";
            this.rbCurlyBrackets.UseVisualStyleBackColor = true;
            // 
            // rbQuotes
            // 
            this.rbQuotes.AutoSize = true;
            this.rbQuotes.Location = new System.Drawing.Point(33, 66);
            this.rbQuotes.Name = "rbQuotes";
            this.rbQuotes.Size = new System.Drawing.Size(63, 19);
            this.rbQuotes.TabIndex = 8;
            this.rbQuotes.TabStop = true;
            this.rbQuotes.Text = "Quotes";
            this.rbQuotes.UseVisualStyleBackColor = true;
            // 
            // cbUppercaseGuid
            // 
            this.cbUppercaseGuid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbUppercaseGuid.AutoSize = true;
            this.cbUppercaseGuid.Location = new System.Drawing.Point(15, 148);
            this.cbUppercaseGuid.Name = "cbUppercaseGuid";
            this.cbUppercaseGuid.Size = new System.Drawing.Size(111, 19);
            this.cbUppercaseGuid.TabIndex = 9;
            this.cbUppercaseGuid.Text = "Uppercase GUID";
            this.cbUppercaseGuid.UseVisualStyleBackColor = true;
            // 
            // GuidForm
            // 
            this.AcceptButton = this.btnCopy;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 217);
            this.Controls.Add(this.cbUppercaseGuid);
            this.Controls.Add(this.rbQuotes);
            this.Controls.Add(this.rbCurlyBrackets);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNewGuid);
            this.Controls.Add(this.rbCsharpGuid);
            this.Controls.Add(this.rbNakedGuid);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCopy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(446, 39);
            this.Name = "GuidForm";
            this.Text = "GUID-O-MATIC";
            this.Load += new System.EventHandler(this.GuidForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.RadioButton rbNakedGuid;
        private System.Windows.Forms.RadioButton rbCsharpGuid;
        private System.Windows.Forms.Button btnNewGuid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbCurlyBrackets;
        private System.Windows.Forms.RadioButton rbQuotes;
        private System.Windows.Forms.CheckBox cbUppercaseGuid;
    }
}

