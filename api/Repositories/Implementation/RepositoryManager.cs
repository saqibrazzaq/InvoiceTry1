using api.Data;
using api.Repositories.Interfaces;

namespace api.Repositories.Implementation
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly AppDbContext _context;
        private readonly Lazy<IAddressRepository> _addressRepository;
        private readonly Lazy<IBillRepository> _billRepository;
        private readonly Lazy<IBillItemRepository> _billItemRepository;
        private readonly Lazy<IBillItemSalesTaxRepository> _billItemSalesTaxRepository;
        private readonly Lazy<IBusinessRepository> _businessRepository;
        private readonly Lazy<ICountryRepository> _countryRepository;
        private readonly Lazy<ICurrencyRepository> _currencyRepository;
        private readonly Lazy<ICustomerRepository> _customersRepository;
        private readonly Lazy<ICustomerBillingAddressRepository> _customersBillingAddressRepository;
        private readonly Lazy<ICustomerContactRepository> _customersContactRepository;
        private readonly Lazy<ICustomerShippingAddressRepository> _customerShippingAddressRepository;
        private readonly Lazy<IDepartmentRepository> _departmentRepository;
        private readonly Lazy<IDesignationRepository> _designationRepository;
        private readonly Lazy<IEmployeeRepository> _employeeRepository;
        private readonly Lazy<IInvoiceRepository> _invoiceRepository;
        private readonly Lazy<IInvoiceItemRepository> _invoiceItemRepository;
        private readonly Lazy<IInvoiceItemSalesTaxRepository > _invoiceItemSalesTaxRepository;
        private readonly Lazy<IProfileRepository> _profileRepository;
        private readonly Lazy<ISalesTaxRepository> _salesTaxRepository;
        private readonly Lazy<ISalesTaxRateRepository> _salesTaxRateRepository;
        private readonly Lazy<IProductRepository> _productRepository;
        private readonly Lazy<IProductSalesTaxRepository> _productSalesTaxRepository;
        private readonly Lazy<IStateRepository> _stateRepository;
        private readonly Lazy<IVendorRepository> _vendorRepository;

        public RepositoryManager(AppDbContext context)
        {
            _context = context;

            // Initialize all repositories
            _addressRepository = new Lazy<IAddressRepository> (() =>
                new AddressRepository(context));
            _billRepository = new Lazy<IBillRepository>(() =>
                new BillRepository(context));
            _billItemRepository = new Lazy<IBillItemRepository>(() =>
                new BillItemRepository(context));
            _billItemSalesTaxRepository = new Lazy<IBillItemSalesTaxRepository>(() =>
                new BillItemSalesTaxRepository(context));
            _businessRepository = new Lazy<IBusinessRepository>(() =>
                new BusinessRepository(context));
            _countryRepository = new Lazy<ICountryRepository>(() =>
                new CountryRepository(context));
            _currencyRepository = new Lazy<ICurrencyRepository>(() =>
                new CurrencyRepository(context));
            _customersRepository = new Lazy<ICustomerRepository>(() =>
                new CustomerRepository(context));
            _customersBillingAddressRepository = new Lazy<ICustomerBillingAddressRepository>(() =>
                new CustomerBillingAddressRepository(context));
            _customersContactRepository = new Lazy<ICustomerContactRepository>(() =>
                new CustomerContactRepository(context));
            _customerShippingAddressRepository = new Lazy<ICustomerShippingAddressRepository>(() =>
                new CustomerShippingAddressRepository(context));
            _departmentRepository = new Lazy<IDepartmentRepository>(() =>
                new DepartmentRepository(context));
            _designationRepository = new Lazy<IDesignationRepository>(() =>
                new DesignationRepository(context));
            _employeeRepository = new Lazy<IEmployeeRepository>(() =>
                new EmployeeRepository(context));
            _invoiceRepository = new Lazy<IInvoiceRepository>(() =>
                new InvoiceRepository(context));
            _invoiceItemRepository = new Lazy<IInvoiceItemRepository>(() =>
                new InvoiceItemRepository(context));
            _invoiceItemSalesTaxRepository = new Lazy<IInvoiceItemSalesTaxRepository>(() =>
                new InvoiceItemSalesTaxRepository(context));
            _profileRepository = new Lazy<IProfileRepository>(() =>
                new ProfileRepository(context));
            _salesTaxRepository = new Lazy<ISalesTaxRepository>(() =>
                new SalesTaxRepository(context));
            _salesTaxRateRepository = new Lazy<ISalesTaxRateRepository>(() =>
                new SalesTaxRateRepository(context));
            _productRepository = new Lazy<IProductRepository>(() =>
                new ProductRepository(context));
            _productSalesTaxRepository = new Lazy<IProductSalesTaxRepository>(() =>
                new ProductSalesTaxRepository(context));
            _stateRepository = new Lazy<IStateRepository>(() =>
                new StateRepository(context));
            _vendorRepository = new Lazy<IVendorRepository>(() =>
                new VendorRepository(context));
        }

        public IAddressRepository AddressRepository => _addressRepository.Value;
        public IBillRepository BillRepository => _billRepository.Value;
        public IBillItemRepository BillItemRepository => _billItemRepository.Value;
        public IBillItemSalesTaxRepository BillItemSalesTaxRepository => _billItemSalesTaxRepository.Value;
        public IBusinessRepository BusinessRepository => _businessRepository.Value;
        public ICountryRepository CountryRepository => _countryRepository.Value;
        public ICurrencyRepository CurrencyRepository => _currencyRepository.Value;
        public ICustomerRepository CustomerRepository => _customersRepository.Value;
        public ICustomerBillingAddressRepository CustomerBillingAddressRepository => _customersBillingAddressRepository.Value;
        public ICustomerContactRepository CustomerContactRepository => _customersContactRepository.Value;
        public ICustomerShippingAddressRepository CustomerShippingAddressRepository => _customerShippingAddressRepository.Value;
        public IDepartmentRepository DepartmentRepository => _departmentRepository.Value;
        public IDesignationRepository DesignationRepository => _designationRepository.Value;
        public IEmployeeRepository EmployeeRepository => _employeeRepository.Value;
        public IInvoiceRepository InvoiceRepository => _invoiceRepository.Value;
        public IInvoiceItemRepository InvoiceItemRepository => _invoiceItemRepository.Value;
        public IInvoiceItemSalesTaxRepository InvoiceItemSalesTaxRepository => _invoiceItemSalesTaxRepository.Value;
        public IProfileRepository ProfileRepository => _profileRepository.Value;
        public ISalesTaxRepository SalesTaxRepository => _salesTaxRepository.Value;
        public ISalesTaxRateRepository SalesTaxRateRepository => _salesTaxRateRepository.Value;
        public IProductRepository ProductRepository => _productRepository.Value;
        public IProductSalesTaxRepository ProductSalesTaxRepository => _productSalesTaxRepository.Value;
        public IStateRepository StateRepository => _stateRepository.Value;
        public IVendorRepository VendorRepository => _vendorRepository.Value;
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
