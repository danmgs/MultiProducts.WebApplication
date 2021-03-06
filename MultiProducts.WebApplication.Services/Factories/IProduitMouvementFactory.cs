using MultiProducts.WebApplication.Model;
using MultiProducts.WebApplication.Services.Interfaces;
using MultiProducts.WebApplication.Services.Produits;
using System;

namespace MultiProducts.WebApplication.Services.Factories
{
    public interface IProduitMouvementFactory
    {
        ICommunProduitMouvementService BuildService(string productCode);

        IMRAProduitMouvementService BuildService_MRA();
    }
}
