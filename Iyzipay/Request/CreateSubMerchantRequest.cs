﻿using System;

namespace Iyzipay.Request
{
    public class CreateSubMerchantRequest : BaseRequestV2
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string GsmNumber { get; set; }
        public string Address { get; set; }
        public string Iban { get; set; }
        public string TaxOffice { get; set; }
        public string ContactName { get; set; }
        public string ContactSurname { get; set; }
        public string LegalCompanyTitle { get; set; }
        public string SubMerchantExternalId { get; set; }
        public string IdentityNumber { get; set; }
        public string TaxNumber { get; set; }
        public string SubMerchantType { get; set; }
        public string Currency { get; set; }
        public string SettlementDescriptionTemplate { get; set; }
        public string SwiftCode { get; set; }

        public override string ToPKIRequestString()
        {
            return ToStringRequestBuilder.NewInstance()
                .AppendSuper(base.ToPKIRequestString())
                .Append("name", Name)
                .Append("email", Email)
                .Append("gsmNumber", GsmNumber)
                .Append("address", Address)
                .Append("iban", Iban)
                .Append("taxOffice", TaxOffice)
                .Append("contactName", ContactName)
                .Append("contactSurname", ContactSurname)
                .Append("legalCompanyTitle", LegalCompanyTitle)
                .Append("swiftCode", SwiftCode)
                .Append("currency", Currency)
                .Append("settlementDescriptionTemplate", SettlementDescriptionTemplate)
                .Append("subMerchantExternalId", SubMerchantExternalId)
                .Append("identityNumber", IdentityNumber)
                .Append("taxNumber", TaxNumber)
                .Append("subMerchantType", SubMerchantType)
                .GetRequestString();
        }

    }
}
