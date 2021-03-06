﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlanA.BaseClasses;
using PlanA.CatalogClasses.CustomerCatalogs;
using PlanA.CatalogClasses.ProductCatalogs;
using PlanA.CatalogClasses.ZipCatalog;

namespace PlanA.Model
{
    public class DomainModel
    {
        // CustomerCatalogs
        private CompanyCustomerCatalog _companyCustomerCatalog;
        private HousingAssociationCustomerCatalog _housingAssociationCustomerCatalog;
        private PrivateCustomerCatalog _privateCustomerCatalog;

        // Combined CustomerCatalog
        private ObservableCollection<CustomerBase> _customers;

        // ZipCatalog
        private ZipCatalog _zipCatalog;

        // ProductCatalogs
        private PuttyCatalog _puttyCatalog;
        private ToolCatalog _toolCatalog;
        private CoverCatalog _coverCatalog;
        private WallCoverCatalog _wallCoverCatalog;
        private PaintCatalog _paintCatalog;

        // Combined ProductCatalog
        private ObservableCollection<ProductBase> _products;

        private static DomainModel _instance;

        public static DomainModel Instance
        {
            get
            {
                _instance = _instance ?? (_instance = new DomainModel());
                return _instance;
            }
        }
        public static DomainModel Catalogs => Instance;

        public DomainModel()
        {
            _companyCustomerCatalog = new CompanyCustomerCatalog();
            _housingAssociationCustomerCatalog = new HousingAssociationCustomerCatalog();
            _privateCustomerCatalog = new PrivateCustomerCatalog();

            _customers = new ObservableCollection<CustomerBase>();

            _zipCatalog = new ZipCatalog();


            _puttyCatalog = new PuttyCatalog();
            _toolCatalog = new ToolCatalog();
            _coverCatalog = new CoverCatalog();
            _wallCoverCatalog = new WallCoverCatalog();
            _paintCatalog = new PaintCatalog();

            _products = new ObservableCollection<ProductBase>();
        }

        public async System.Threading.Tasks.Task LoadAsync()
        {
            await _companyCustomerCatalog.LoadAsync();
            await _privateCustomerCatalog.LoadAsync();
            await _housingAssociationCustomerCatalog.LoadAsync();

            await _toolCatalog.LoadAsync();
            await _paintCatalog.LoadAsync();

            await _zipCatalog.LoadAsync();
        }

        public async System.Threading.Tasks.Task SaveAsync()
        {
            await _companyCustomerCatalog.SaveAsync();
            await _privateCustomerCatalog.SaveAsync();
            await _housingAssociationCustomerCatalog.SaveAsync();
            await _zipCatalog.LoadAsync();
        }

        public bool IDExists(CustomerBase cb)
        {
            foreach (var item in _customers)
            {   
                if (item.CustomerType.ToLower() == cb.CustomerType.ToLower() && cb.Key == item.Key)
                {
                    return true;
                }
            }

            return false;
        }

        public bool IDExistsProduct(ProductBase pb)
        {
            foreach (var item in _customers)
            {
                if (item.CustomerType.ToLower() == pb.ProductType.ToLower() && pb.Key == item.Key)
                {
                    return true;
                }
            }

            return false;
        }

        public CompanyCustomerCatalog CompanyCustomersCatalog => _companyCustomerCatalog;
        public HousingAssociationCustomerCatalog HousingAssociationCustomerCatalog => _housingAssociationCustomerCatalog;
        public PrivateCustomerCatalog PrivateCustomerCatalog => _privateCustomerCatalog;
        public ObservableCollection<CustomerBase> Customers => _customers;

        public ZipCatalog ZipCodes => _zipCatalog;


        public PuttyCatalog PuttyCatalog => _puttyCatalog;
        public ToolCatalog ToolCatalog => _toolCatalog;
        public CoverCatalog CoverCatalog => _coverCatalog;
        public WallCoverCatalog WallCoverCatalog => _wallCoverCatalog;
        public PaintCatalog PaintCatalog => _paintCatalog;

        public ObservableCollection<ProductBase> Products => _products;

    }
}