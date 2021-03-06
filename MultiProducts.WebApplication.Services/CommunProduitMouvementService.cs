using MultiProducts.WebApplication.Services.Interfaces;
using System.Diagnostics;

namespace MultiProducts.WebApplication.Services
{
    public abstract class CommunProduitMouvementService : ICommunProduitMouvementService
    {
        public virtual string Move1()
        {
            return "CommunProduitMouvementService.Move1";
        }

        public virtual string Move2()
        {
            return "CommunProduitMouvementService.Move2";
        }

        public virtual string Move3()
        {
            return "CommunProduitMouvementService.Move3";
        }
    }
}
