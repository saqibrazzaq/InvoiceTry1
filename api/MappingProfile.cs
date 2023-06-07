using api.Dtos;
using api.Entities;
using AutoMapper;

namespace api
{
    public class MappingProfile : AutoMapper.Profile
    {
        public MappingProfile()
        {
            // Address
            CreateMap<Address, AddressRes>();
            CreateMap<AddressReqEdit, Address>();

            // Bill
            CreateMap<Bill, BillRes>();
            CreateMap<BillReqEdit, Bill>();

            // BillItem
            CreateMap<BillItem, BillItemRes>();
            CreateMap<BillItemReqEdit, BillItem>();

            // BillItemSalesTax
            CreateMap<BillItemSalesTax, BillItemSalesTaxRes>();
            CreateMap<BillItemSalesTaxReqEdit, BillItemSalesTax>();

            // Business
            CreateMap<Business, BusinessRes>();
            CreateMap<BusinessReqEdit, Business>();

            // Country
            CreateMap<Country, CountryRes>();
            CreateMap<CountryReqEdit, Country>();

            // Currency
            CreateMap<Currency, CurrencyRes>();
            CreateMap<CurrencyReqEdit, Currency>();

            // Customer
            CreateMap<Customer, CustomerRes>();
            CreateMap<CustomerReqEdit, Customer>();

            // CustomerBillingAddress
            CreateMap<CustomerBillingAddress, CustomerBillingAddressRes>();
            CreateMap<CustomerBillingAddressReqEdit, CustomerBillingAddress>();

            // CustomerContact
            CreateMap<CustomerContact, CustomerContactRes>();
            CreateMap<CustomerContactReqEdit, CustomerContact>();

            // CustomerShippingAddress
            CreateMap<CustomerShippingAddress, CustomerShippingAddressRes>();
            CreateMap<CustomerShippingAddressReqEdit, CustomerShippingAddress>();

            // Department
            CreateMap<Department, DepartmentRes>();
            CreateMap<DepartmentReqEdit, Department>();

            // Designation
            CreateMap<Designation, DesignationRes>();
            CreateMap<DesignationReqEdit, Designation>();

            // Employee
            CreateMap<Employee, EmployeeRes>();
            CreateMap<EmployeeReqEdit, Employee>();

            // Invoice
            CreateMap<Invoice, InvoiceRes>();
            CreateMap<InvoiceReqEdit, Invoice>();

            // InvoiceItem
            CreateMap<InvoiceItem, InvoiceItemRes>();
            CreateMap<InvoiceItemReqEdit, InvoiceItem>();

            // InvoiceItemSalesTax
            CreateMap<InvoiceItemSalesTax, InvoiceItemSalesTaxRes>();
            CreateMap<InvoiceItemSalesTaxReqEdit, InvoiceItemSalesTax>();

            // Profile
            CreateMap<Entities.Profile, ProfileRes>();
            CreateMap<ProfileReqEdit, Entities.Profile>();

            // SalesTax
            CreateMap<SalesTax, SalesTaxRes>();
            CreateMap<SalesTaxReqEdit, SalesTax>();

            // SalesTaxRate
            CreateMap<SalesTaxRate,  SalesTaxRateRes>();
            CreateMap<SalesTaxRateReqEdit,  SalesTaxRate>();

            // Service
            CreateMap<Service, ServiceRes>();
            CreateMap<ServiceReqEdit, Service>();

            // ServiceSalesTax
            CreateMap<ServiceSalesTax, ServiceSalesTaxRes>();
            CreateMap<ServiceSalesTaxReqEdit, ServiceSalesTax>();

            // State
            CreateMap<State, StateRes>();
            CreateMap<StateReqEdit, State>();

            // Vendor
            CreateMap<Vendor, VendorRes>();
            CreateMap<VendorReqEdit, Vendor>();
        }
    }
}
