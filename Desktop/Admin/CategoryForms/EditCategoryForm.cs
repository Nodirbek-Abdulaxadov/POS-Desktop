using Desktop.Extended;
using POS.Application.Common.DataTransferObjects.CategoryDtos;
using POS.Application.Common.Exceptions;
using POS.Application.Interfaces;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop.Admin.CategoryForms
{
    public partial class EditCategoryForm : Form
    {
        private readonly IBusinessUnit _businessUnit;
        private readonly int id = 0;

        public EditCategoryForm(int id, IBusinessUnit businessUnit)
        {
            InitializeComponent();
            _businessUnit = businessUnit;
            this.id = id;
            this.AcceptButton = guna2Button1;
        }

        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }
        /// <summary>
        /// Edit formasini yuklanishi 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void EditCategoryForm_Load(object sender, EventArgs e)
        {
            await LoadCategoryData();
        }

        private async Task LoadCategoryData()
        {
            try
            {
                var categoryDto = await _businessUnit.CategoryService.GetByIdAsync(id);
                name_textbox.Text = categoryDto.Name;
            }
            catch (MarketException ex)
            {
                new Toastr().ShowError(ex.ErrorMessage);
            }
            catch (Exception)
            {
                new Toastr().ShowError();
            }
        }

        /// <summary>
        /// Edit formasini ma'limotlarini saqlash
        /// </summary>
        /// <returns></returns>
        private async Task SaveCategory()
        {
            try
            {
                await _businessUnit.CategoryService.UpdateAsync(new UpdateCategoryDto()
                {
                    Id = id,
                    Name = name_textbox.Text
                });

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (MarketException ex)
            {
                new Toastr().ShowError(ex.ErrorMessage);
            }
            catch (Exception)
            {
                new Toastr().ShowError();
            }
        }

        private async void guna2Button1_Click(object sender, EventArgs e)
        {
            await SaveCategory();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CanselBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
        /// <summary>
        /// Enter tugmasi orqali boshqarish 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void guna2Button1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                await SaveCategory();
            }
        }
    }
}
