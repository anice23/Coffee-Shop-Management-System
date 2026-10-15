using CoffeSystem_DataAccess.DBContext;
using CoffeSystem_DataAccess.Repositories;
using CoffeSystem_Business;
using CoffeSystem_DataAccess.Entities;

namespace CoffeSystem_1UI.Screens
{
    public partial class frmPOS : Form
    {
        private readonly ProductService _productService;
        private readonly List<OrderItem> _cart = new List<OrderItem>();
        private List<Product> _allProducts = new List<Product>();
        private readonly OrderService _orderService;
        private CategoryService _categoryService;
        private readonly int _loggedInUserId;

        // Constructor
        public frmPOS(int loggedInUserId)
        {
            InitializeComponent();
            dgvCart.CellClick += dgvCart_CellClick;
            cmbPaymentMethod.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbPaymentMethod.Items.Add("Cash");
            cmbPaymentMethod.Items.Add("Card");

            cmbPaymentMethod.SelectedIndex = 0;
            AppDbContext context = new AppDbContext();
            ProductRepository repository = new ProductRepository(context);
            _productService = new ProductService(repository);

            OrderRepository orderRepository = new OrderRepository(context);
             _orderService = new OrderService(orderRepository);
            _loggedInUserId = loggedInUserId;
            txtSearchProduct.TextChanged +=txtSearchProduct_TextChanged;
            _categoryService = CreateCategoryService();

            cmbCategoryFilter.SelectedIndexChanged += cmbCategoryFilter_SelectedIndexChanged;
            Shown += frmPOS_Shown;


        }

        // Create Categorie Service
        private CategoryService CreateCategoryService()
        {
            AppDbContext context = new AppDbContext();

            CategoryRepository repository =
                new CategoryRepository(context);

            return new CategoryService(repository);
        }

        // 
        private async void frmPOS_Shown(object sender, EventArgs e)
        {
            try
            {
                await LoadCategoriesAsync();
                await LoadProductsAsync();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());

                MessageBox.Show(
                    "تعذّر تحميل المنتجات. حاول مجددًا.",
                    "Products Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        // Load Categories

        private async Task LoadCategoriesAsync()
        {
            var categories =
                await _categoryService.GetAllCategoriesAsync();

            categories.Insert(0, new Category
            {
                CategoryId = 0,
                Name = "All Categories"
            });

            cmbCategoryFilter.DisplayMember = "Name";
            cmbCategoryFilter.ValueMember = "CategoryId";
            cmbCategoryFilter.DataSource = categories;
            cmbCategoryFilter.SelectedIndex = 0;
        }

        // 
        private void cmbCategoryFilter_SelectedIndexChanged( object sender, EventArgs e)
        {
            ApplyProductFilters();
        }

        // Methode N°1 
        private async Task LoadProductsAsync()
        {
            _allProducts = await _productService
                .GettAllProductsAsync();

                 ApplyProductFilters();
        }
        // Methode N°2 
        private void ApplyProductFilters()
        {
            string searchText = txtSearchProduct.Text.Trim();

            int? selectedCategoryId = null;

            if (cmbCategoryFilter.SelectedValue is int categoryId &&
                categoryId > 0)
            {
                selectedCategoryId = categoryId;
            }

            var filteredProducts = _allProducts
                .Where(p =>
                    (
                        string.IsNullOrWhiteSpace(searchText) ||
                        p.Name.Contains(
                            searchText,
                            StringComparison.OrdinalIgnoreCase
                        )
                    )
                    &&
                    (
                        !selectedCategoryId.HasValue ||
                        p.CategoryId == selectedCategoryId.Value
                    )
                )
                .ToList();

            dgvProducts.Rows.Clear();

            foreach (var product in filteredProducts)
            {
                dgvProducts.Rows.Add(
                    product.ProductId,
                    product.Name,
                    $"{product.Price:0.000} DT",
                    product.StockQuantity
                );
            }
        }

        // Methode N°3
        private void RefreshCart()

        {
            dgvCart.Rows.Clear();
            decimal grandTotal = 0;
            foreach (var item in _cart)
            {
                var product =_allProducts.FirstOrDefault(p => p.ProductId == item.ProductId);
                if (product == null)
                {
                    continue;
                }
                int rowIndex = dgvCart.Rows.Add(product.Name,item.Quantity,$"{item.UnitPrice:0.000} DT",$"{item.TotalPrice:0.000} DT","X");

                // Store the product ID in the row
                dgvCart.Rows[rowIndex].Tag = item.ProductId;
                grandTotal += item.TotalPrice;

            }
            lblGrandTotal.Text = $"{grandTotal:0.000} DT";
        }

        // Methode N°4
        private void dgvCart_CellClick( object sender, DataGridViewCellEventArgs e)
        { // Ignore headers and clicks outside the Remove column
            if (e.RowIndex < 0 || e.ColumnIndex != 4)
            {
                return;
            }

            // Get the product ID associated with this row
            if (dgvCart.Rows[e.RowIndex].Tag is not int productId)
            {
                return;
            }

            // Find the item in the cart
            var item = _cart.FirstOrDefault(
                i => i.ProductId == productId
            );

            if (item == null)
            {
                return;
            }

            if (item.Quantity > 1)
            {
                // Remove one unit only
                item.Quantity--;

                // Recalculate this item's total
                item.TotalPrice = item.Quantity * item.UnitPrice;
            }
            else
            {
                // Remove the product when quantity reaches zero
                _cart.Remove(item);
            }

            // Refresh cart and grand total
            RefreshCart();
        }
        

        // Methode N°4
        private void txtSearchProduct_TextChanged( object sender,EventArgs e)
        {
            ApplyProductFilters();
        }

        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmPOS_Load(object sender, EventArgs e)
        {

        }

        private void dgvProducts_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // lahna bech nzido les products fl cart mte3 l orderitem
            // cases matloubl na9ra 7sebi fiha

            // Case (1) : ken index mte3i bl null => fammech product => maysir chey
            if (e.RowIndex < 0)
            {
                return;
            }

            // => if t3adit lahna : n7adhrou productid met3na
            int productId = Convert.ToInt32(dgvProducts.Rows[e.RowIndex].Cells["colProductId"].Value);

            // case (2) : bech nlawjou 3la awel product bl id hedha
            var product = _allProducts.FirstOrDefault(p => p.ProductId == productId);
            // nchoufou if null => n7abes
            if (product == null)
            {
                return;
            }
            // => sinon nchoufouh : deja exist fl cart meta3 l item or no => if yes : lahna manzidouch just nzidou ll quantity + totalPrice
            var existingItem = _cart.FirstOrDefault(i => i.ProductId == product.ProductId);

            //

            if (product.StockQuantity <= 0)
            {
                MessageBox.Show(
                    "This product is out of stock.",
                    "Stock Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }

            if (existingItem != null &&
                existingItem.Quantity >= product.StockQuantity)
            {
                MessageBox.Show(
                    $"Available stock for {product.Name}: {product.StockQuantity}",
                    "Insufficient Stock",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );

                return;
            }
            if (existingItem != null)
            {
                existingItem.Quantity++;
                existingItem.TotalPrice = existingItem.Quantity * existingItem.UnitPrice;

            }
            else
            {
                _cart.Add(new OrderItem
                {
                    ProductId = product.ProductId,
                    Quantity = 1,
                    UnitPrice = product.Price,
                    TotalPrice = product.Price
                });
            }

            RefreshCart();



        }


        // btnClear
        private void btnClearCart_Click(object sender, EventArgs e)
        {
            _cart.Clear();
            RefreshCart();

        }

        // btnCheckout
        private async  void btnCheckout_Click(object sender, EventArgs e)
        {
            if (_cart.Count == 0)
            {
                MessageBox.Show("Cart is empty", "warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string paymentMethod = cmbPaymentMethod.SelectedItem.ToString();
            // Calculate the total before confirmation
            decimal total = _cart.Sum(item => item.TotalPrice);

            DialogResult confirmation = MessageBox.Show(
                $"هل أنت متأكد من إتمام عملية البيع؟\n\n" +
                $"إجمالي الكمية: {_cart.Sum(item => item.Quantity)}\n" +
                $"المجموع: {total:0.000} DT\n" +
                $"طريقة الدفع: {paymentMethod}",
                "تأكيد عملية البيع",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2
            );

            // Stop if the cashier selects No
            if (confirmation != DialogResult.Yes)
            {
                return;
            }


            Order order = new Order
            {
                OrderDate = DateTime.Now,
                PaymentMethod = cmbPaymentMethod.SelectedItem.ToString(),
                UserId = _loggedInUserId,
                OrderItems=_cart

            };
           int orderId=  await _orderService.CreateOrderAsync(order);

            using (frmReceipt receiptForm = new frmReceipt(order))
            {
                receiptForm.ShowDialog();
            }
            _cart.Clear();
            RefreshCart();
            await LoadProductsAsync();
            MessageBox.Show(
                    $"Order #{orderId} completed successfully!\n" +
                    $"Total: {order.TotalAmount:0.000} DT\n" +
                    $"Payment: {order.PaymentMethod}",
                    "Checkout",
                      MessageBoxButtons.OK,
                       MessageBoxIcon.Information
                   );




        }
    }
}