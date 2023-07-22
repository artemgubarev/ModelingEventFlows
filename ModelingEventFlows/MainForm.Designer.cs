namespace ModelingEventFlows
{
    partial class MainForm
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
            this.simulationTimeTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.flowIntensityTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.runButton = new DevExpress.XtraEditors.SimpleButton();
            this.flowIntensityErrorLabel = new DevExpress.XtraEditors.LabelControl();
            this.simulationTimeErrorLabel = new DevExpress.XtraEditors.LabelControl();
            this.chartControl = new DevExpress.XtraCharts.ChartControl();
            this.eventsCountLabel = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.simulationTimeTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flowIntensityTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl)).BeginInit();
            this.SuspendLayout();
            // 
            // simulationTimeTextEdit
            // 
            this.simulationTimeTextEdit.Location = new System.Drawing.Point(13, 59);
            this.simulationTimeTextEdit.Name = "simulationTimeTextEdit";
            this.simulationTimeTextEdit.Size = new System.Drawing.Size(113, 20);
            this.simulationTimeTextEdit.TabIndex = 0;
            // 
            // flowIntensityTextEdit
            // 
            this.flowIntensityTextEdit.Location = new System.Drawing.Point(12, 128);
            this.flowIntensityTextEdit.Name = "flowIntensityTextEdit";
            this.flowIntensityTextEdit.Size = new System.Drawing.Size(113, 20);
            this.flowIntensityTextEdit.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 40);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(112, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Время моделирования";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 109);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(162, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Интенсивность потока событий";
            // 
            // runButton
            // 
            this.runButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.runButton.Location = new System.Drawing.Point(12, 415);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(205, 23);
            this.runButton.TabIndex = 4;
            this.runButton.Text = "Запустить моделирование процесса";
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // flowIntensityErrorLabel
            // 
            this.flowIntensityErrorLabel.Appearance.ForeColor = System.Drawing.Color.Red;
            this.flowIntensityErrorLabel.Appearance.Options.UseForeColor = true;
            this.flowIntensityErrorLabel.Location = new System.Drawing.Point(13, 90);
            this.flowIntensityErrorLabel.Name = "flowIntensityErrorLabel";
            this.flowIntensityErrorLabel.Size = new System.Drawing.Size(246, 13);
            this.flowIntensityErrorLabel.TabIndex = 5;
            this.flowIntensityErrorLabel.Text = "Неверно задана интенсивность потока событий";
            this.flowIntensityErrorLabel.Visible = false;
            // 
            // simulationTimeErrorLabel
            // 
            this.simulationTimeErrorLabel.Appearance.ForeColor = System.Drawing.Color.Red;
            this.simulationTimeErrorLabel.Appearance.Options.UseForeColor = true;
            this.simulationTimeErrorLabel.Location = new System.Drawing.Point(13, 21);
            this.simulationTimeErrorLabel.Name = "simulationTimeErrorLabel";
            this.simulationTimeErrorLabel.Size = new System.Drawing.Size(197, 13);
            this.simulationTimeErrorLabel.TabIndex = 6;
            this.simulationTimeErrorLabel.Text = "Неверно задано время моделирования";
            this.simulationTimeErrorLabel.Visible = false;
            // 
            // chartControl
            // 
            this.chartControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chartControl.Location = new System.Drawing.Point(265, 12);
            this.chartControl.Name = "chartControl";
            this.chartControl.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartControl.Size = new System.Drawing.Size(523, 426);
            this.chartControl.TabIndex = 7;
            // 
            // eventsCountLabel
            // 
            this.eventsCountLabel.Location = new System.Drawing.Point(14, 361);
            this.eventsCountLabel.Name = "eventsCountLabel";
            this.eventsCountLabel.Size = new System.Drawing.Size(90, 13);
            this.eventsCountLabel.TabIndex = 8;
            this.eventsCountLabel.Text = "Число событий = ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.eventsCountLabel);
            this.Controls.Add(this.chartControl);
            this.Controls.Add(this.simulationTimeErrorLabel);
            this.Controls.Add(this.flowIntensityErrorLabel);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.flowIntensityTextEdit);
            this.Controls.Add(this.simulationTimeTextEdit);
            this.Name = "MainForm";
            this.Text = "Моделирование Пуасоновского потока событий";
            ((System.ComponentModel.ISupportInitialize)(this.simulationTimeTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flowIntensityTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit simulationTimeTextEdit;
        private DevExpress.XtraEditors.TextEdit flowIntensityTextEdit;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton runButton;
        private DevExpress.XtraEditors.LabelControl flowIntensityErrorLabel;
        private DevExpress.XtraEditors.LabelControl simulationTimeErrorLabel;
        private DevExpress.XtraCharts.ChartControl chartControl;
        private DevExpress.XtraEditors.LabelControl eventsCountLabel;
    }
}

