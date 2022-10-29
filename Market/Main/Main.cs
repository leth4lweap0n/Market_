using System;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.Mvvm.Native;
using Market.Entity;

namespace Market.Main
{
    public partial class Main : XtraForm
    {
        private readonly ExampleDBContext _db = new();
        public Main()
        {
            InitializeComponent();
            SaleGridControl.DataSource = _db.Sale.ToList();
            var total = _db.Sale
                .Where(r => true)
                .Sum(r => r.Price);
            TextboxTotal.Text = total.ToString();
        }

        void AddSale(Sale nSale)
        {
            var SaleProduct = _db.Sale.FirstOrDefault(x => x.Barkod == nSale.Barkod);
            if (SaleProduct != null)
            {
                SaleProduct.Price += nSale.Price;
                SaleProduct.Count += nSale.Count;
                _db.Sale.Update(SaleProduct);
            }
            else
            {
                _db.Sale.Add(nSale);
            }
            _db.SaveChanges();
            SaleGridControl.DataSource = _db.Sale.ToList();
            var total = _db.Sale
                .Where(r => true)
                .Sum(r => r.Price);
            TextboxTotal.Text = total.ToString();
        }

        private void QuickAdd_Click(object sender, EventArgs e)
        {
            var Btn = (SimpleButton)sender;
            var ButttonInfo = _db.QuickSaleCommonProducts.Find(int.Parse(Btn.Tag.ToString()));
            if (ButttonInfo == null || ButttonInfo.ProductBarkod == 0)
            {
                MessageBox.Show("Bu butona ürün atanmadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var Product = _db.Products.Find(ButttonInfo.ProductBarkod);
            if (Product != null)
            {
                if (Product.Stock > 0)
                {
                    AddSale(new Sale
                    {
                        Barkod = Product.Barkod,
                        Name = Product.Name,
                        Price = Product.Price,
                        Count = 1
                    });
                    Product.Stock -= 1;
                    _db.SaveChanges();
                    return;
                }
                MessageBox.Show($"Stokta '{Product.Name}' kalmadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            MessageBox.Show("Stokta böyle bir ürün yok.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void Numpad_Click(object sender, EventArgs e)
        {
            var btn = (SimpleButton)sender;
            switch (btn.Text)
            {
                case "Temizle":
                    if (TextBoxBarkod.Text.Length > 0)
                        TextBoxBarkod.Text = "";
                    return;
                case "<----":
                    if (TextBoxBarkod.Text.Length > 0)
                        TextBoxBarkod.Text = TextBoxBarkod.Text.Remove(TextBoxBarkod.Text.Length - 1);
                    return;
                default:
                    TextBoxBarkod.Text += btn.Text;
                    TextBoxBarkod.Focus();
                    break;
            }
        }

        void ManualAddSale()
        {
            if (string.IsNullOrEmpty(TextBoxBarkod.Text) ||
                string.IsNullOrWhiteSpace(TextBoxBarkod.Text) ||
                TextBoxBarkod.Text.Length > 10)
            {
                MessageBox.Show("Geçerli barkod numarası girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextBoxBarkod.Text = "";
                return;
            }

            if (!int.TryParse(TextBoxBarkod.Text, out var Barkod))
            {
                MessageBox.Show("Geçerli barkod numarası girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextBoxBarkod.Text = "";
                return;
            }

            var Product = _db.Products.Find(Barkod);
            if (Product != null)
            {
                if (Product.Stock > 0)
                {
                    AddSale(new Sale
                    {
                        Barkod = Product.Barkod,
                        Name = Product.Name,
                        Price = Product.Price,
                        Count = 1
                    });
                    Product.Stock -= 1;
                    _db.SaveChanges();
                    TextBoxBarkod.Text = "";
                    return;
                }
                MessageBox.Show($"Stokta '{Product.Name}' kalmadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TextBoxBarkod.Text = "";
                return;
            }
            MessageBox.Show("Stokta böyle bir ürün yok.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            TextBoxBarkod.Text = "";
        }
        private void ManuelAddSale_Click(object sender, EventArgs e)
        {
            ManualAddSale();
        }
        private void TextBoxBarkod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Enter)
            {
                ManualAddSale();
            }
        }
        void ConfirmSale(PaymentMethod pm)
        {
            if (!_db.Sale.Any())
            {
                MessageBox.Show("Ürün eklemediniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _db.ConfirmedSalesInfo.Add(new ConfirmedSalesInfo
            {
                Details = string.Join(" | ", _db.Sale.ToList().Select(sale => $"Barkod:{sale.Barkod}-Adı:{sale.Name}-Adet:{sale.Count}-Tutar:{sale.Price}")),
                PaymentMethod = pm.ToString(),
                MoneyEarned = int.Parse(TextboxTotal.Text),
                Date = DateTime.Now
            });
            _db.Sale.RemoveRange(_db.Sale);
            _db.SaveChanges();
            SaleGridControl.DataSource = _db.Sale.ToList();
            TextboxTotal.Text = "0";
            MessageBox.Show("Satış tamamlandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void ButtonConfirmCreditCard_Click(object sender, EventArgs e)
        {
            ConfirmSale(PaymentMethod.CreditCard);
        }


        private void ButtonConfirmCash_Click(object sender, EventArgs e)
        {
            ConfirmSale(PaymentMethod.Cash);
        }


        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            if (!_db.Sale.Any())
            {
                MessageBox.Show("Ürün eklemediniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _db.Sale.ToList().ForEach(sale =>
            {
                var Product = _db.Products.Find(sale.Barkod);
                if (Product != null)
                {
                    Product.Stock += sale.Count;
                }
            });
            
            _db.CancelledSalesInfo.Add(new CancelledSalesInfo
            {
                Details = string.Join(" | ", _db.Sale.ToList().Select(sale => $"Barkod:{sale.Barkod}-Adı:{sale.Name}-Adet:{sale.Count}-Tutar:{sale.Price}")),
                UnearnedMoney = int.Parse(TextboxTotal.Text),
                Date = DateTime.Now
            });
            _db.Sale.RemoveRange(_db.Sale);
            _db.SaveChanges();
            SaleGridControl.DataSource = _db.Sale.ToList();
            TextboxTotal.Text = "0";
            MessageBox.Show("Satış iptal edildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private QuickSaleCommonProducts tmp;
        private void QuickCommonEditButtonsFunc(object sender, EventArgs e)
        {
            var Btn = (SimpleButton)sender;
            tmp = _db.QuickSaleCommonProducts.Find(int.Parse(Btn.Tag.ToString()));
            if (tmp != null)
            {
                TextBoxQuickSaleEdit.Text = tmp.ProductBarkod.ToString();
            }

        }
        private void QuickSaleEditSave_Click(object sender, EventArgs e)
        {
            var Product = _db.Products.Find(int.Parse(TextBoxQuickSaleEdit.Text));
            if (Product != null)
            {
                tmp.ProductBarkod = int.Parse(TextBoxQuickSaleEdit.Text);
                _db.QuickSaleCommonProducts.Update(tmp);
                _db.SaveChanges();
                MessageBox.Show("Değişiklikler kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TextBoxQuickSaleEdit.Text = "";
                return;

            }
            MessageBox.Show("Böyle bir barkod numarası yok.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}