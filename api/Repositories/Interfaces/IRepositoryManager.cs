namespace api.Repositories.Interfaces
{
    public interface IRepositoryManager
    {
        IAddressRepository AddressRepository { get; }
        IBillRepository BillRepository { get; }
        IBillItemRepository BillItemRepository { get; }
        IBillItemSalesTaxRepository BillItemSalesTaxRepository { get; }
        IBusinessRepository BusinessRepository { get; }
        ICountryRepository CountryRepository { get; }
        ICurrencyRepository CurrencyRepository { get; }
        ICustomerRepository CustomerRepository { get; }
        ICustomerBillingAddressRepository CustomerBillingAddressRepository { get; }
        ICustomerContactRepository CustomerContactRepository { get; }
        ICustomerShippingAddressRepository CustomerShippingAddressRepository { get; }
        IDepartmentRepository DepartmentRepository { get; }
        IDesignationRepository DesignationRepository { get; }
        IEmployeeRepository EmployeeRepository { get; }
        IInvoiceRepository InvoiceRepository { get; }
        IInvoiceItemRepository InvoiceItemRepository { get; }
        IInvoiceItemSalesTaxRepository InvoiceItemSalesTaxRepository { get; }
        IProfileRepository ProfileRepository { get; }   
        ISalesTaxRepository SalesTaxRepository { get; }
        ISalesTaxRateRepository SalesTaxRateRepository { get; }
        IProductRepository ProductRepository { get; }
        IProductSalesTaxRepository ProductSalesTaxRepository { get; }
        IStateRepository StateRepository { get; }
        IVendorRepository VendorRepository { get; }
        void Save();
    }
}
