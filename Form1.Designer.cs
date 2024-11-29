using System.Windows.Forms;
using System;

namespace laba1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private ComboBox cmbDeviceType;
        private Label lblDeviceType;
        private TextBox txtBrand;
        private Label lblBrand;
        private TextBox txtCpuBrand;
        private Label lblCpuBrand;
        private Label lblRam;
        private TextBox txtRam;
        private Label lblPrice;
        private TextBox txtPrice;
        private Label lblColor;
        private TextBox txtColor;
        private TextBox txtSize;
        private Label lblSize;
        private TextBox txtWeight;
        private Label lblWeight;
        private TextBox txtPower;
        private Label lblPower;
        private Button btnAdd;
        private Button btnClear;
        private ListBox lstEquipment;
        private GroupBox grpPC;
        private GroupBox grpLaptop;

        private void InitializeComponent()
        {
            this.cmbDeviceType = new ComboBox();
            this.lblDeviceType = new Label();
            this.txtBrand = new TextBox();
            this.lblBrand = new Label();
            this.txtCpuBrand = new TextBox();
            this.lblCpuBrand = new Label();
            this.lblRam = new Label();
            this.txtRam = new TextBox();
            this.txtPrice = new TextBox();
            this.lblPrice = new Label();
            this.txtColor = new TextBox();
            this.lblColor = new Label();
            this.txtSize = new TextBox();
            this.lblSize = new Label();
            this.txtWeight = new TextBox();
            this.lblWeight = new Label();
            this.txtPower = new TextBox();
            this.lblPower = new Label();
            this.btnAdd = new Button();
            this.btnClear = new Button();
            this.lstEquipment = new ListBox();
            this.grpPC = new GroupBox();
            this.grpLaptop = new GroupBox();

            // 
            // cmbDeviceType
            // 
            this.lblDeviceType.Text = "Тип устройства:";
            this.lblDeviceType.Location = new System.Drawing.Point(20, 30); 
            this.cmbDeviceType.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbDeviceType.Items.AddRange(new object[] {
                "Компьютерная техника",
                "Персональный компьютер",
                "Ноутбук"});
            this.cmbDeviceType.Location = new System.Drawing.Point(20, 10);
            this.cmbDeviceType.SelectedIndexChanged += new EventHandler(this.cmbDeviceType_SelectedIndexChanged);

            // 
            // txtBrand
            // 
            this.lblBrand.Text = "Бренд:";
            this.lblBrand.Location = new System.Drawing.Point(20, 70);
            this.txtBrand.Location = new System.Drawing.Point(20, 50);
            this.txtBrand.Text = "";

            // 
            // txtCpuBrand
            // 
            this.lblCpuBrand.Text = "Процессор:";
            this.lblCpuBrand.Location = new System.Drawing.Point(20, 110);
            this.txtCpuBrand.Location = new System.Drawing.Point(20, 90);
            this.txtCpuBrand.Text = "";

            // 
            // txtRam
            // 
            this.lblRam.Text = "Опреративная память:";
            this.lblRam.Location = new System.Drawing.Point(20, 150);
            this.txtRam.Location = new System.Drawing.Point(20, 130);
            this.txtRam.Text = "";

            // 
            // txtPrice
            // 
            this.lblPrice.Text = "Цена:";
            this.lblPrice.Location = new System.Drawing.Point(20, 190);
            this.txtPrice.Location = new System.Drawing.Point(20, 170);
            this.txtPrice.Text = "";

            // 
            // grpPC
            // 
            this.grpPC.Controls.Add(this.txtColor);
            this.grpPC.Controls.Add(this.txtSize);
            this.grpPC.Controls.Add(this.lblColor);
            this.grpPC.Controls.Add(this.lblSize);
            this.grpPC.Enabled = false;
            this.grpPC.Location = new System.Drawing.Point(300, 60);
            this.grpPC.Size = new System.Drawing.Size(180, 120);
            this.grpPC.Text = "Персональный компьютер";

            // 
            // txtColor
            // 
            this.lblColor.Text = "Цвет:";
            this.lblColor.Location = new System.Drawing.Point(10, 20);
            this.txtColor.Location = new System.Drawing.Point(10, 40);
            //this.txtColor.Size = new System.Drawing.Size(150, 20);
            this.txtColor.Text = "";
            this.grpPC.Controls.Add(this.lblColor);
            this.grpPC.Controls.Add(this.txtColor);

            // 
            // txtSize
            // 
            this.lblSize.Text = "Размер:";
            this.lblSize.Location = new System.Drawing.Point(10, 60);
            this.txtSize.Location = new System.Drawing.Point(10, 80);
            this.txtSize.Text = "";
            this.grpPC.Controls.Add(this.lblSize);
            this.grpPC.Controls.Add(this.txtSize);

            // 
            // grpLaptop
            // 
            this.grpLaptop.Controls.Add(this.txtWeight);
            this.grpLaptop.Controls.Add(this.txtPower);
            this.grpLaptop.Controls.Add(this.lblWeight);
            this.grpLaptop.Controls.Add(this.lblPower);
            this.grpLaptop.Enabled = false;
            this.grpLaptop.Location = new System.Drawing.Point(500, 60);
            this.grpLaptop.Size = new System.Drawing.Size(180, 120);
            this.grpLaptop.Text = "Ноутбук";

            // 
            // txtWeight
            // 
            this.lblWeight.Text = "Вес:";
            this.lblWeight.Location = new System.Drawing.Point(10, 20);
            this.txtWeight.Location = new System.Drawing.Point(10, 40);
            this.txtWeight.Text = "";
            this.grpLaptop.Controls.Add(this.lblWeight);
            this.grpLaptop.Controls.Add(this.txtWeight);

            // 
            // txtPower
            // 
            this.lblPower.Text = "Мощность:";
            this.lblPower.Location = new System.Drawing.Point(10, 60);
            this.txtPower.Location = new System.Drawing.Point(10, 80);
            this.txtPower.Text = "";
            this.grpLaptop.Controls.Add(this.lblPower);
            this.grpLaptop.Controls.Add(this.txtPower);

            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(20, 220);
            this.btnAdd.Text = "Добавить";
            this.btnAdd.Click += new EventHandler(this.btnAdd_Click);

            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(120, 220);
            this.btnClear.Text = "Очистить";
            this.btnClear.Click += new EventHandler(this.btnClear_Click);

            // 
            // lstEquipment
            // 
            this.lstEquipment.Location = new System.Drawing.Point(20, 260);
            this.lstEquipment.Size = new System.Drawing.Size(600, 150);

            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(700, 550);
            
            this.Controls.Add(this.lblDeviceType);
            this.Controls.Add(this.cmbDeviceType);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.lblCpuBrand);
            this.Controls.Add(this.txtCpuBrand);
            this.Controls.Add(this.lblRam);
            this.Controls.Add(this.txtRam);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.grpPC);
            this.Controls.Add(this.grpLaptop);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lstEquipment);
            this.Text = "Управление устройствами";
            this.ClientSize = new System.Drawing.Size(700, 450);
        }
    }
}
