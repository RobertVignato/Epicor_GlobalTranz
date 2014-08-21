namespace SampleClientForRateQuoteWebService
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
			this.btnRateMyShipment = new System.Windows.Forms.Button();
			this.dgvRateMyShipment = new System.Windows.Forms.DataGridView();
			this.textBoxBolNo = new System.Windows.Forms.TextBox();
			this.btnConfirmShipment = new System.Windows.Forms.Button();
			this.txtIndex = new System.Windows.Forms.TextBox();
			this.label32 = new System.Windows.Forms.Label();
			this.btnMyShipmentTrack = new System.Windows.Forms.Button();
			this.dgvShipmentTrack = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dgvRateMyShipment)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvShipmentTrack)).BeginInit();
			this.SuspendLayout();
			// 
			// btnRateMyShipment
			// 
			this.btnRateMyShipment.Location = new System.Drawing.Point(13, 13);
			this.btnRateMyShipment.Name = "btnRateMyShipment";
			this.btnRateMyShipment.Size = new System.Drawing.Size(144, 23);
			this.btnRateMyShipment.TabIndex = 0;
			this.btnRateMyShipment.Text = "1. Rate My Shipment";
			this.btnRateMyShipment.UseVisualStyleBackColor = true;
			this.btnRateMyShipment.Click += new System.EventHandler(this.btnRateMyShipment_Click);
			// 
			// dgvRateMyShipment
			// 
			this.dgvRateMyShipment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvRateMyShipment.Location = new System.Drawing.Point(13, 42);
			this.dgvRateMyShipment.Name = "dgvRateMyShipment";
			this.dgvRateMyShipment.Size = new System.Drawing.Size(913, 133);
			this.dgvRateMyShipment.TabIndex = 1;
			// 
			// textBoxBolNo
			// 
			this.textBoxBolNo.Location = new System.Drawing.Point(162, 208);
			this.textBoxBolNo.Name = "textBoxBolNo";
			this.textBoxBolNo.ReadOnly = true;
			this.textBoxBolNo.Size = new System.Drawing.Size(80, 20);
			this.textBoxBolNo.TabIndex = 36;
			// 
			// btnConfirmShipment
			// 
			this.btnConfirmShipment.Location = new System.Drawing.Point(12, 207);
			this.btnConfirmShipment.Name = "btnConfirmShipment";
			this.btnConfirmShipment.Size = new System.Drawing.Size(144, 20);
			this.btnConfirmShipment.TabIndex = 35;
			this.btnConfirmShipment.Text = "2. Confirm Shipment";
			this.btnConfirmShipment.UseVisualStyleBackColor = true;
			this.btnConfirmShipment.Click += new System.EventHandler(this.btnConfirmShipment_Click);
			// 
			// txtIndex
			// 
			this.txtIndex.Location = new System.Drawing.Point(367, 181);
			this.txtIndex.Name = "txtIndex";
			this.txtIndex.Size = new System.Drawing.Size(61, 20);
			this.txtIndex.TabIndex = 38;
			// 
			// label32
			// 
			this.label32.AutoSize = true;
			this.label32.Location = new System.Drawing.Point(10, 184);
			this.label32.Name = "label32";
			this.label32.Size = new System.Drawing.Size(351, 13);
			this.label32.TabIndex = 37;
			this.label32.Text = "Please select a carrier index from the grid below after Rate My Shipment :";
			// 
			// btnMyShipmentTrack
			// 
			this.btnMyShipmentTrack.Location = new System.Drawing.Point(12, 233);
			this.btnMyShipmentTrack.Name = "btnMyShipmentTrack";
			this.btnMyShipmentTrack.Size = new System.Drawing.Size(144, 20);
			this.btnMyShipmentTrack.TabIndex = 39;
			this.btnMyShipmentTrack.Text = "3. My Shipment Track";
			this.btnMyShipmentTrack.UseVisualStyleBackColor = true;
			this.btnMyShipmentTrack.Click += new System.EventHandler(this.btnMyShipmentTrack_Click);
			// 
			// dgvShipmentTrack
			// 
			this.dgvShipmentTrack.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvShipmentTrack.Location = new System.Drawing.Point(12, 259);
			this.dgvShipmentTrack.Name = "dgvShipmentTrack";
			this.dgvShipmentTrack.Size = new System.Drawing.Size(913, 95);
			this.dgvShipmentTrack.TabIndex = 40;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(938, 368);
			this.Controls.Add(this.dgvShipmentTrack);
			this.Controls.Add(this.btnMyShipmentTrack);
			this.Controls.Add(this.txtIndex);
			this.Controls.Add(this.label32);
			this.Controls.Add(this.textBoxBolNo);
			this.Controls.Add(this.btnConfirmShipment);
			this.Controls.Add(this.dgvRateMyShipment);
			this.Controls.Add(this.btnRateMyShipment);
			this.Name = "Form1";
			this.Text = "Sample Client for Rate Quote Web Service";
			((System.ComponentModel.ISupportInitialize)(this.dgvRateMyShipment)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvShipmentTrack)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnRateMyShipment;
		private System.Windows.Forms.DataGridView dgvRateMyShipment;
		private System.Windows.Forms.TextBox textBoxBolNo;
		private System.Windows.Forms.Button btnConfirmShipment;
		private System.Windows.Forms.TextBox txtIndex;
		private System.Windows.Forms.Label label32;
		private System.Windows.Forms.Button btnMyShipmentTrack;
		private System.Windows.Forms.DataGridView dgvShipmentTrack;
	}
}

