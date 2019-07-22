using ContractingApp.Models;
using ContractingApp.Data;
using System;
using System.Linq;

namespace ContosoUniversity.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ContractContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Contracts.Any())
            {
                return;   // DB has been seeded
            }

            var contracts = new Contract[]
            {
            new Contract{ContractName="Contract 1",EffectiveDate=DateTime.Parse("2019-01-01"),TerminationDate=DateTime.Parse("2020-01-01")},
            new Contract{ContractName="Contract 2",EffectiveDate=DateTime.Parse("2019-02-01"),TerminationDate=DateTime.Parse("2020-02-01")},
            new Contract{ContractName="Contract 3",EffectiveDate=DateTime.Parse("2019-03-01"),TerminationDate=DateTime.Parse("2020-03-01")}};
            foreach (Contract c in contracts)
            {
                context.Contracts.Add(c);
            }
            context.SaveChanges();

            var providers = new Provider[]
            {
            new Provider{ProviderName="ProviderOne",State="NY", Location="Albany", Type="Business"},
            new Provider{ProviderName="ProviderTwo",State="NY", Location="New York", Type="Business"},
            new Provider{ProviderName="ProviderThree",State="NY", Location="Rochester", Type="Business"}};
            foreach (Provider p in providers)
            {
                context.Providers.Add(p);
            }
            context.SaveChanges();
        }
    }
}