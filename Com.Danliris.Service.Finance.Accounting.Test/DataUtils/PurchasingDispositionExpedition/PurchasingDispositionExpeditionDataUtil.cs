﻿using Com.Danliris.Service.Finance.Accounting.Lib.BusinessLogic.Services.PurchasingDispositionExpedition;
using Com.Danliris.Service.Finance.Accounting.Lib.Models.PurchasingDispositionExpedition;
using Com.Danliris.Service.Finance.Accounting.Lib.ViewModels.IntegrationViewModel;
using Com.Danliris.Service.Finance.Accounting.Lib.ViewModels.PurchasingDispositionExpedition;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Com.Danliris.Service.Finance.Accounting.Test.DataUtils.PurchasingDispositionExpedition
{
    public class PurchasingDispositionExpeditionDataUtil
    {
        private readonly PurchasingDispositionExpeditionService Service;

        public PurchasingDispositionExpeditionDataUtil(PurchasingDispositionExpeditionService service)
        {
            Service = service;
        }

        public PurchasingDispositionExpeditionModel GetNewData()
        {
            long nowTicks = DateTimeOffset.Now.Ticks;
            string nowTicksA = $"{nowTicks}a";
            string nowTicksB = $"{nowTicks}b";
            return new PurchasingDispositionExpeditionModel()
            {
                BankExpenditureNoteNo = nowTicksA,
                CashierDivisionBy = nowTicksA,
                CashierDivisionDate = DateTimeOffset.Now,
                CurrencyId = nowTicksA,
                CurrencyCode = nowTicksA,
                PaymentDueDate = DateTimeOffset.Now,
                InvoiceNo = nowTicksA,
                NotVerifiedReason = nowTicksA,
                Position = (int)nowTicks,
                SendToCashierDivisionBy = nowTicksA,
                SendToCashierDivisionDate = DateTimeOffset.Now,
                SendToPurchasingDivisionBy = nowTicksA,
                SendToPurchasingDivisionDate = DateTimeOffset.Now,
                SupplierCode = nowTicksA,
                SupplierName = nowTicksA,
                TotalPaid = nowTicks,
                DispositionId = nowTicksA,
                DispositionDate = DateTimeOffset.Now,
                DispositionNo = nowTicksA,
                VerificationDivisionBy = nowTicksA,
                VerificationDivisionDate = DateTimeOffset.Now,
                VerifyDate = DateTimeOffset.Now,
                UseIncomeTax = false,
                IncomeTax = nowTicks,
                IncomeTaxId = nowTicksA,
                IncomeTaxName = nowTicksA,
                IncomeTaxRate = nowTicks,
                IsPaid = false,
                IsPaidPPH = false,
                UseVat = false,
                Vat = nowTicks,
                BankExpenditureNoteDate = DateTimeOffset.Now,
                BankExpenditureNotePPHDate = DateTimeOffset.Now,
                BankExpenditureNotePPHNo = nowTicksA,
                PaymentMethod = nowTicksA,
                CategoryCode = nowTicksA,
                CategoryName = nowTicksA,

                Items = new List<PurchasingDispositionExpeditionItemModel>
                {
                    new PurchasingDispositionExpeditionItemModel
                    {
                        Price = nowTicks,
                        ProductId = nowTicksA,
                        ProductCode = nowTicksA,
                        ProductName = nowTicksA,
                        Quantity = nowTicks,
                        UnitId = nowTicksA,
                        UnitCode = nowTicksA,
                        UnitName = nowTicksA,
                        Uom = nowTicksA,
                        PurchasingDispositionDetailId = (int)nowTicks
                    }
                }
            };
        }

        public PurchasingDispositionExpeditionViewModel GetNewViewModel()
        {
            long nowTicks = DateTimeOffset.Now.Ticks;
            string nowTicksA = $"{nowTicks}a";
            string nowTicksB = $"{nowTicks}b";
            return new PurchasingDispositionExpeditionViewModel()
            {
                bankExpenditureNoteNo = nowTicksA,
                cashierDivisionBy = nowTicksA,
                cashierDivisionDate = DateTimeOffset.Now,
                currency = new CurrencyViewModel
                {
                    _id = nowTicksA,
                    code = nowTicksA,
                },
                paymentDueDate = DateTimeOffset.Now,
                invoiceNo = nowTicksA,
                notVerifiedReason = nowTicksA,
                position = (int)nowTicks,
                sendToCashierDivisionBy = nowTicksA,
                sendToCashierDivisionDate = DateTimeOffset.Now,
                sendToPurchasingDivisionBy = nowTicksA,
                sendToPurchasingDivisionDate = DateTimeOffset.Now,
                supplier = new SupplierViewModel
                {
                    code = nowTicksA,
                    name = nowTicksA,
                },
                totalPaid = nowTicks,
                dispositionId = nowTicksA,
                dispositionDate = DateTimeOffset.Now,
                dispositionNo = nowTicksA,
                verificationDivisionBy = nowTicksA,
                verificationDivisionDate = DateTimeOffset.Now,
                verifyDate = DateTimeOffset.Now,
                useIncomeTax = false,
                incomeTax = nowTicks,
                incomeTaxVm = new IncomeTaxViewModel
                {
                    _id = nowTicksA,
                    name = nowTicksA,
                    rate = nowTicks
                },
                isPaid = false,
                isPaidPPH = false,
                useVat = false,
                vat = nowTicks,
                bankExpenditureNoteDate = DateTimeOffset.Now,
                bankExpenditureNotePPHDate = DateTimeOffset.Now,
                bankExpenditureNotePPHNo = nowTicksA,
                paymentMethod = nowTicksA,
                category = new CategoryViewModel
                {
                    name = nowTicksA,
                    code = nowTicksA,
                },
                items = new List<PurchasingDispositionExpeditionItemViewModel>
                {
                    new PurchasingDispositionExpeditionItemViewModel
                    {
                        price = nowTicks,
                        product = new ProductViewModel
                        {
                            _id = nowTicksA,
                            code = nowTicksA,
                            name = nowTicksA,
                        },
                        quantity = nowTicks,
                        unit = new UnitViewModel
                        {
                            _id = nowTicksA,
                            code = nowTicksA,
                            name = nowTicksA,
                        },
                        uom = nowTicksA,
                        purchasingDispositionDetailId =(int) nowTicks,
                    }
                }
            };
        }


        public async Task<PurchasingDispositionExpeditionModel> GetTestData()
        {
            PurchasingDispositionExpeditionModel model = GetNewData();
            await Service.CreateAsync(model);
            return await Service.ReadByIdAsync(model.Id);
        }
    }
}
