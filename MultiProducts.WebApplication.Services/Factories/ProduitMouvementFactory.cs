using MultiProducts.WebApplication.Model;
using MultiProducts.WebApplication.Services.Interfaces;
using MultiProducts.WebApplication.Services.Produits;
using System;

namespace MultiProducts.WebApplication.Services.Factories
{
    public class ProduitMouvementFactory : IProduitMouvementFactory
    {
        public ICommunProduitMouvementService BuildService(string productCode)
        {
            ICommunProduitMouvementService communService = new CommunProduitMouvementService();

            if (productCode.Equals(EnumProduct.Auto.ToString(), StringComparison.OrdinalIgnoreCase))
            {
                communService = new AutoProduitMouvementService();
            }
            else if (productCode.Equals(EnumProduct.MRA.ToString(), StringComparison.OrdinalIgnoreCase))
            {
                communService = new MRAProduitMouvementService();
            }
            else if (productCode.Equals(EnumProduct.MRH.ToString(), StringComparison.OrdinalIgnoreCase))
            {
                communService = new MRHProduitMouvementService();
            }

            return communService;
        }

        public IMRAProduitMouvementService BuildService_MRA()
        {
            return new MRAProduitMouvementService();
        }
    }
}
