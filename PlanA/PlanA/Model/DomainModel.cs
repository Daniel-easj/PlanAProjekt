using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlanA.CatalogClasses.CombinedCatalogs;
using PlanA.CatalogClasses.CustomerCatalogs;
using PlanA.CatalogClasses.ProductCatalogs;

namespace PlanA.Model
{
    public class DomainModel
    {
        // CustomerCatalogs
        private CompanyCustomerCatalog _companyCustomerCatalog;
        private HousingAssociationCustomerCatalog _housingAssociationCustomerCatalog;
        private PrivateCustomerCatalog _privateCustomerCatalog;

        // Combined CustomerCatalog
        private CustomersCatalog _customersCatalog;

        // ToolCatalogs
        private PuttyCatalog _puttyCatalog;
        private ToolCatalog _toolCatalog;
        private CoverCatalog _coverCatalog;
        private WallCoverCatalog _wallCoverCatalog;
        private PaintCatalog _paintCatalog;

        // Combined ProductCatalog
        private ProductsCatalog _productsCatalog;

        private static DomainModel _instance;

        public static DomainModel Instance
        {
            get
            {
                _instance = _instance ?? (_instance = new DomainModel());
                return _instance;
            }
        }
        public static DomainModel Catalogs { get { return Instance; } }

        private DomainModel()
        {
            _companyCustomerCatalog = new CompanyCustomerCatalog();
            _housingAssociationCustomerCatalog = new HousingAssociationCustomerCatalog();
            _privateCustomerCatalog = new PrivateCustomerCatalog();

            _customersCatalog = new CustomersCatalog();

            _puttyCatalog = new PuttyCatalog();
            _toolCatalog = new ToolCatalog();
            _coverCatalog = new CoverCatalog();
            _wallCoverCatalog = new WallCoverCatalog();
            _paintCatalog = new PaintCatalog();

            _productsCatalog = new ProductsCatalog();
        }

        public async Task LoadAsync()
        {
            await _companyCustomerCatalog.LoadAsync();
            await _privateCustomerCatalog.LoadAsync();

        }

        public async Task SaveAsync()
        {
            await _companyCustomerCatalog.SaveAsync();
        }

        public CompanyCustomerCatalog CompanyCustomersCatalog => _companyCustomerCatalog;
        public HousingAssociationCustomerCatalog HousingAssociationCustomerCatalog => _housingAssociationCustomerCatalog;
        public PrivateCustomerCatalog PrivateCustomerCatalog => _privateCustomerCatalog;
        public CustomersCatalog CustomersCatalog => _customersCatalog;


        public PuttyCatalog PuttyCatalog => _puttyCatalog;
        public ToolCatalog ToolCatalog => _toolCatalog;
        public CoverCatalog CoverCatalog => _coverCatalog;
        public WallCoverCatalog WallCoverCatalog => _wallCoverCatalog;
        public PaintCatalog PaintCatalog => _paintCatalog;
        public ProductsCatalog ProductsCatalog => _productsCatalog;

    }
}
