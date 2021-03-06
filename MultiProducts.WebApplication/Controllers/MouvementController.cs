using Microsoft.AspNetCore.Mvc;
using MultiProducts.WebApplication.Model;
using MultiProducts.WebApplication.Services.Factories;

namespace MultiProducts.WebApplication.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MouvementController : ControllerBase
    {
        readonly IProduitMouvementFactory _produitMouvementFactory;

        public MouvementController(IProduitMouvementFactory produitMouvementFactory)
        {
            this._produitMouvementFactory = produitMouvementFactory;
        }

        [HttpGet("{productCode}")] // api/Mouvement/Move1/{productCode}
        public string Move1(string productCode)
        {
            return _produitMouvementFactory.BuildService(productCode).Move1();
        }

        [HttpGet("{productCode}")] // api/Mouvement/Move2/{productCode}
        public string Move2(string productCode)
        {
            return _produitMouvementFactory.BuildService(productCode).Move2();
        }

        [HttpGet("{productCode}")] // api/Mouvement/Move3/{productCode}
        public string Move3(string productCode)
        {
            return _produitMouvementFactory.BuildService(productCode).Move3();
        }

        [HttpGet] // api/Mouvement/MRA_MoveMRA1
        public string MRA_MoveMRA1() 
        {
            return _produitMouvementFactory.BuildService_MRA().MoveMRA1();
        }
    }
}
