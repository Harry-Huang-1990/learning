namespace WinFormsApp1
{
    partial class FormModbus
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
            btn_Connect = new Button();
            btn_ReedReg = new Button();
            list_ReedReg_mes = new ListBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btn_Connect
            // 
            btn_Connect.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Connect.Location = new Point(98, 78);
            btn_Connect.Name = "btn_Connect";
            btn_Connect.Size = new Size(142, 80);
            btn_Connect.TabIndex = 0;
            btn_Connect.Text = "连接串口";
            btn_Connect.UseVisualStyleBackColor = true;
            btn_Connect.Click += btn_Connect_Click;
            // 
            // btn_ReedReg
            // 
            btn_ReedReg.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btn_ReedReg.Location = new Point(411, 78);
            btn_ReedReg.Name = "btn_ReedReg";
            btn_ReedReg.Size = new Size(177, 80);
            btn_ReedReg.TabIndex = 0;
            btn_ReedReg.Text = "读取寄存器";
            btn_ReedReg.UseVisualStyleBackColor = true;
            btn_ReedReg.Click += button2_Click;
            // 
            // list_ReedReg_mes
            // 
            list_ReedReg_mes.FormattingEnabled = true;
            list_ReedReg_mes.ItemHeight = 20;
            list_ReedReg_mes.Location = new Point(98, 227);
            list_ReedReg_mes.Name = "list_ReedReg_mes";
            list_ReedReg_mes.Size = new Size(370, 364);
            list_ReedReg_mes.TabIndex = 1;
            list_ReedReg_mes.SelectedIndexChanged += list_ReedReg_mes_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Location = new Point(248, 108);
            label1.Name = "label1";
            label1.Size = new Size(50, 50);
            label1.TabIndex = 2;
            // 
            // FormModbus
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1262, 673);
            Controls.Add(label1);
            Controls.Add(list_ReedReg_mes);
            Controls.Add(btn_ReedReg);
            Controls.Add(btn_Connect);
            Name = "FormModbus";
            Text = "modbus仿真";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Connect;
        private Button btn_ReedReg;
        private ListBox list_ReedReg_mes;
        private Label label1;
    }
}