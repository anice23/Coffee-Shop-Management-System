using CoffeSystem_Business;
using CoffeSystem_DataAccess.DBContext;
using CoffeSystem_DataAccess.Entities;
using CoffeSystem_DataAccess.Repositories;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace CoffeSystem_1UI.Screens.Settings
{
    public partial class frmSettings : Form
    {
        private readonly AppDbContext _context;
        private readonly CafeSettingsService _settingsService;
        private CafeSetting? _currentSettings;
        public frmSettings()
        {
            InitializeComponent();

            _context = CreateDbContext();
            _settingsService = CreateSettingsService();
        }

        // Methode N°1
        private AppDbContext CreateDbContext()
        {
            return new AppDbContext();
        }
        // Methode N°2
        private CafeSettingsService CreateSettingsService()
        {
            CafeSettingsRepository repository =
                new CafeSettingsRepository(_context);

            return new CafeSettingsService(repository);
        }
        // Methode N°3

        private async Task LoadSettingsAsync()
        {
            try
            {
                _currentSettings =
                    await _settingsService.GetSettingsAsync();

                if (_currentSettings == null)
                {
                    MessageBox.Show(
                        "No cafe settings were found in the database.",
                        "Settings",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                txtCafeName.Text = _currentSettings.CafeName;
                txtAddress.Text = _currentSettings.Address;
                txtPhoneNumber.Text = _currentSettings.PhoneNumber;
                txtReceiptFooter.Text = _currentSettings.ReceiptFooter;

                numLowStockThreshold.Value = Math.Max(
                    numLowStockThreshold.Minimum,
                    Math.Min(
                        numLowStockThreshold.Maximum,
                        _currentSettings.LowStockThreshold));
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Failed to load settings.\n{ex.Message}",
                    "Settings Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {

        }

        private async void frmSettings_Shown(object sender, EventArgs e)
        {
            await LoadSettingsAsync();

        }

        private async void btnSaveCafeInfo_Click(object sender, EventArgs e)
        {
            if (_currentSettings == null)
            {
                MessageBox.Show(
                    "Please wait until settings are loaded.",
                    "Settings",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            try
            {
                btnSaveCafeInfo.Enabled = false;

                await _settingsService.UpdateSettingsAsync(
                    _currentSettings.CafeSettingId,
                    txtCafeName.Text,
                    txtAddress.Text,
                    txtPhoneNumber.Text,
                    txtReceiptFooter.Text,
                    decimal.ToInt32(numLowStockThreshold.Value));

                MessageBox.Show(
                    "Cafe settings saved successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Failed to save settings.\n{ex.Message}",
                    "Save Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                btnSaveCafeInfo.Enabled = true;
            }
        }
    }
}
