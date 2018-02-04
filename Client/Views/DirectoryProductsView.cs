using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Client.IViews;
using Client.Models;
using Client.Presenters;
using Core.Domain;

namespace Client.Views
{
    /// <summary>
    /// Класс представления "Справочник товаров".
    /// </summary>
    public partial class DirectoryProductsView : Form, IDirectoryProductsView
    {
        #region Private Fields and Consts

        private const string IdColumn = "Id";
        private const string NameColumn = "Name";
        private static readonly Dictionary<string, string> PColumnHeaders;
        private static readonly Dictionary<string, int> PColumnWidths;

        //Список хранит группы товаров.
        private List<GroupProduct> _groupProducts;

        //Биндинг для comboBoxGroupProducts.
        private BindingList<GroupProduct> _bListGroupProduct;

        //Биндинг для comboBoxProducts.
        private BindingList<ProductDTO> _bListProduct;

        //Хранит ранее загруженные товары.
        private Dictionary<int, List<ProductDTO>> _cacheProducts = new Dictionary<int, List<ProductDTO>>();

        //Список хранит товары.
        private List<ProductDTO> _products;

        #endregion

        #region Constructors

        static DirectoryProductsView()
        {
            PColumnHeaders = new Dictionary<string, string>();
            PColumnWidths = new Dictionary<string, int>();

            PColumnHeaders[IdColumn] = "Ид";
            PColumnHeaders[NameColumn] = "Наименование";

            PColumnWidths[IdColumn] = 60;
        }

        public DirectoryProductsView()
        {
            InitializeComponent();
        }

        public DirectoryProductsView(DirectoryProductsPresenter presenter, DirectoryProductsModel model)
            : this()
        {
            presenter.Init(this, model);

            if (GetGroupProducts != null)
                GetGroupProducts();
        }

        #endregion

        #region IDirectoryProductsView

        public event Action GetGroupProducts;
        public event Action<int> GetProducts;
        public event Action ViewClosed;

        /// <summary>
        /// Список групп товаров.
        /// </summary>
        public List<GroupProduct> GroupProducts
        {
            set
            {
                _groupProducts = value;

            }
        }

        /// <summary>
        /// Список товаров.
        /// </summary>
        public List<ProductDTO> Products
        {
            set
            {
                _products = value;
            }
        }

        #endregion

        #region EventHandlers

        private void comboBoxGroupProducts_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            try
            {
                var groupProduct = (GroupProduct)comboBoxGroupProducts.SelectedItem;

                //Заполнение списка товаров, если в словаре не хранятся товары для группы, то делаем запрос к бд, иначе берем из словаря.
                if (!_cacheProducts.ContainsKey(groupProduct.Id))
                {
                    GetProducts?.Invoke(groupProduct.Id);

                    _cacheProducts.Add(groupProduct.Id, _products);
                }
                else
                {
                    _products = _cacheProducts[groupProduct.Id];
                }

                //Заполнение таблицы.
                _bListProduct = new BindingList<ProductDTO>(_products);
                dataGridViewProducts.DataSource = _bListProduct;
                _bListProduct.ResetBindings();

                dataGridViewProducts.Columns[IdColumn].HeaderText = PColumnHeaders[IdColumn];
                dataGridViewProducts.Columns[NameColumn].HeaderText = PColumnHeaders[NameColumn];

                dataGridViewProducts.Columns[IdColumn].Width = PColumnWidths[IdColumn];
                dataGridViewProducts.Columns[NameColumn].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch
            {
                MessageBox.Show("Данные о товарах отсутствуют", "Справочник товаров", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBoxGroupProducts_Click(object sender, System.EventArgs e)
        {
            //Загрузка групп товаров в comboBox.
            if (_bListGroupProduct == null)
            {
                try
                {
                    _bListGroupProduct = new BindingList<GroupProduct>(_groupProducts);
                    comboBoxGroupProducts.DataSource = _bListGroupProduct;
                    _bListGroupProduct.ResetBindings();
                }
                catch
                {
                    MessageBox.Show("Данные о группах товаров отсутствуют", "Справочник товаров", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        } 

        private void DirectoryProductsView_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (ViewClosed != null)
                ViewClosed();
        }

        #endregion
    }
}
