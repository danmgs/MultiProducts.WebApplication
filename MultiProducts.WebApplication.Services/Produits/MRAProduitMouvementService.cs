using MultiProducts.WebApplication.Services.Interfaces;

namespace MultiProducts.WebApplication.Services.Produits
{
    public class MRAProduitMouvementService : CommunProduitMouvementService, IMRAProduitMouvementService
    {
        public override string Move1()
        {
            return "MRAProduitMouvementService.Move1";
        }

        public override string Move2()
        {
            string baseMoveStr = base.Move2();

            return $"{baseMoveStr} + MRAProduitMouvementService.Move2";
        }

        public string MoveMRA1()
        {
            return $"Special Combo Move : {Move1()} + {Move2()}";
        }
    }
}
