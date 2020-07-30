namespace TelerikDataGridIBindingListExample
{
    partial class Form1
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn9 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn10 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn11 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn12 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition3 = new Telerik.WinControls.UI.TableViewDefinition();
            this.radGridView1 = new Telerik.WinControls.UI.RadGridView();
            this.btnWorkingBind = new System.Windows.Forms.Button();
            this.btnBrokenBind = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // radGridView1
            // 
            this.radGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radGridView1.BackColor = System.Drawing.SystemColors.Control;
            this.radGridView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.radGridView1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.radGridView1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radGridView1.Location = new System.Drawing.Point(13, 42);
            this.radGridView1.Margin = new System.Windows.Forms.Padding(4);
            // 
            // 
            // 
            gridViewTextBoxColumn9.EnableExpressionEditor = false;
            gridViewTextBoxColumn9.FieldName = "FirstName";
            gridViewTextBoxColumn9.HeaderText = "First Name";
            gridViewTextBoxColumn9.MinWidth = 6;
            gridViewTextBoxColumn9.Name = "FirstName";
            gridViewTextBoxColumn9.Width = 62;
            gridViewTextBoxColumn10.EnableExpressionEditor = false;
            gridViewTextBoxColumn10.FieldName = "LastName";
            gridViewTextBoxColumn10.HeaderText = "Last Name";
            gridViewTextBoxColumn10.MinWidth = 6;
            gridViewTextBoxColumn10.Name = "LastName";
            gridViewTextBoxColumn10.Width = 62;
            gridViewTextBoxColumn11.EnableExpressionEditor = false;
            gridViewTextBoxColumn11.FieldName = "Height";
            gridViewTextBoxColumn11.HeaderText = "Height";
            gridViewTextBoxColumn11.MinWidth = 6;
            gridViewTextBoxColumn11.Name = "Height";
            gridViewTextBoxColumn11.Width = 62;
            gridViewTextBoxColumn12.EnableExpressionEditor = false;
            gridViewTextBoxColumn12.FieldName = "Weight";
            gridViewTextBoxColumn12.HeaderText = "Weight";
            gridViewTextBoxColumn12.MinWidth = 6;
            gridViewTextBoxColumn12.Name = "Weight";
            gridViewTextBoxColumn12.Width = 62;
            this.radGridView1.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn9,
            gridViewTextBoxColumn10,
            gridViewTextBoxColumn11,
            gridViewTextBoxColumn12});
            this.radGridView1.MasterTemplate.ViewDefinition = tableViewDefinition3;
            this.radGridView1.Name = "radGridView1";
            this.radGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radGridView1.Size = new System.Drawing.Size(775, 396);
            this.radGridView1.TabIndex = 0;
            // 
            // btnWorkingBind
            // 
            this.btnWorkingBind.Location = new System.Drawing.Point(13, 13);
            this.btnWorkingBind.Name = "btnWorkingBind";
            this.btnWorkingBind.Size = new System.Drawing.Size(98, 23);
            this.btnWorkingBind.TabIndex = 1;
            this.btnWorkingBind.Text = "Working Bind";
            this.btnWorkingBind.UseVisualStyleBackColor = true;
            this.btnWorkingBind.Click += new System.EventHandler(this.btnWorkingBind_Click);
            // 
            // btnBrokenBind
            // 
            this.btnBrokenBind.Location = new System.Drawing.Point(117, 12);
            this.btnBrokenBind.Name = "btnBrokenBind";
            this.btnBrokenBind.Size = new System.Drawing.Size(98, 23);
            this.btnBrokenBind.TabIndex = 2;
            this.btnBrokenBind.Text = "Broken Bind";
            this.btnBrokenBind.UseVisualStyleBackColor = true;
            this.btnBrokenBind.Click += new System.EventHandler(this.btnBrokenBind_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBrokenBind);
            this.Controls.Add(this.btnWorkingBind);
            this.Controls.Add(this.radGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView radGridView1;
        private System.Windows.Forms.Button btnWorkingBind;
        private System.Windows.Forms.Button btnBrokenBind;
    }
}

