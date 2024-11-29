using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace laba1
{
    public partial class Form1 : Form
    {
        private List<Computer_Equipment> equipmentList = new List<Computer_Equipment>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Считывание данных с формы
                string brand = txtBrand.Text.Trim();
                string cpuBrand = txtCpuBrand.Text.Trim();
                int ram = int.Parse(txtRam.Text);
                int price = int.Parse(txtPrice.Text);

                Computer_Equipment newDevice = null;

                if (cmbDeviceType.SelectedIndex == 0) // Компьютерная техника
                {
                    newDevice = new Computer_Equipment(brand, cpuBrand, ram, price);
                }
                else if (cmbDeviceType.SelectedIndex == 1) // Персональный компьютер
                {
                    string color = txtColor.Text.Trim();
                    int size = int.Parse(txtSize.Text);
                    newDevice = new Personal_Computer(brand, cpuBrand, ram, price, color, size);
                }
                else if (cmbDeviceType.SelectedIndex == 2) // Ноутбук
                {
                    int weight = int.Parse(txtWeight.Text);
                    int power = int.Parse(txtPower.Text);
                    newDevice = new Laptop(brand, cpuBrand, ram, price, weight, power);
                }

                if (newDevice != null)
                {
                    equipmentList.Add(newDevice);
                    UpdateEquipmentList();
                    MessageBox.Show("Устройство добавлено успешно!", "Информация");
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("Ошибка при добавлении устройства. Выберите корректный тип устройства.", "Ошибка");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Некорректный ввод данных. Проверьте введённые значения.", "Ошибка");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            equipmentList.Clear();
            UpdateEquipmentList();
        }

        private void UpdateEquipmentList()
        {
            lstEquipment.Items.Clear();
            foreach (var device in equipmentList)
            {
                lstEquipment.Items.Add(device.Print_Info());
            }
        }

        private void ClearFields()
        {
            txtBrand.Clear();
            txtCpuBrand.Clear();
            txtRam.Clear();
            txtPrice.Clear();
            txtColor.Clear();
            txtSize.Clear();
            txtWeight.Clear();
            txtPower.Clear();
        }

        private void cmbDeviceType_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Включение/отключение полей в зависимости от типа устройства
            grpPC.Enabled = cmbDeviceType.SelectedIndex == 1;
            grpLaptop.Enabled = cmbDeviceType.SelectedIndex == 2;
        }
    }
    public class Personal_Computer : Computer_Equipment
    {
        public string Color { get; set; }
        public int Size { get; set; }

        public Personal_Computer(string brand, string cpuBrand, int ram, int price, string color, int size)
            : base(brand, cpuBrand, ram, price)
        {
            Color = color;
            Size = size;
        }

        public override string Print_Info()
        {
            return base.Print_Info() + $", Color: {Color}, Size: {Size} inches";
        }
    }

    public class Laptop : Computer_Equipment
    {
        public int Weight { get; set; }
        public int Power { get; set; }

        public Laptop(string brand, string cpuBrand, int ram, int price, int weight, int power)
            : base(brand, cpuBrand, ram, price)
        {
            Weight = weight;
            Power = power;
        }

        public override string Print_Info()
        {
            return base.Print_Info() + $", Weight: {Weight} kg, Power: {Power} W";
        }
    }
    public class Computer_Equipment
    {
        public string Brand { get; set; }
        public string CpuBrand { get; set; }
        public int Ram { get; set; }
        public int Price { get; set; }

        public Computer_Equipment(string brand, string cpuBrand, int ram, int price)
        {
            Brand = brand;
            CpuBrand = cpuBrand;
            Ram = ram;
            Price = price;
        }

        public virtual string Print_Info()
        {
            return $"Brand: {Brand}, CPU: {CpuBrand}, RAM: {Ram} GB, Price: {Price} USD";
        }
    }
}
