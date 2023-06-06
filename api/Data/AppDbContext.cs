using api.Entities;
using Microsoft.EntityFrameworkCore;

namespace api.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            :base(options)
        {
            
        }

        // Tables
        public DbSet<Address>? Addresses { get; set; }
        public DbSet<Bill>? Bills { get; set; }
        public DbSet<BillItem>? BillItems { get; set; }
        public DbSet<BillItemSalesTax>? BillItemSalesTaxes { get; set; }
        public DbSet<Business>? Businesses { get; set; }
        public DbSet<Country>? Countries { get; set; }
        public DbSet<Currency>? Currencies { get; set; }
        public DbSet<Customer>? Customers { get; set; }
        public DbSet<CustomerBillingAddress>? CustomerBillingAddresses { get; set; }
        public DbSet<CustomerContact>? CustomerContacts { get; set; }
        public DbSet<CustomerShippingAddress>? CustomerShippingAddresses { get; set; }
        public DbSet<Department>? Departments { get; set; }
        public DbSet<Designation>? Designations { get; set; }
        public DbSet<Employee>? Employees { get; set; }
        public DbSet<Invoice>? Invoices { get; set; }
        public DbSet<InvoiceItem>? InvoiceItems { get; set; }
        public DbSet<InvoiceItemSalesTax>? InvoiceItemSalesTaxes { get; set; }
        public DbSet<Profile>? Profiles { get; set; }
        public DbSet<SalesTax>? SalesTaxes { get; set; }
        public DbSet<SalesTaxRate>? SalesTaxRates { get; set; }
        public DbSet<Service>? Services { get; set; }
        public DbSet<ServiceSalesTax>? ServiceSalesTaxes { get; set; }
        public DbSet<State>? States { get; set; }
        public DbSet<Vendor>? Vendors { get; set; }
    }
}
