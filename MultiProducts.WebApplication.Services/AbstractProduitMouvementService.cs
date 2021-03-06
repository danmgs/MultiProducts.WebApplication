using System;
using System.Diagnostics;

namespace MultiProducts.WebApplication.Services
{
    public abstract class AbstractProduitMouvementService
    {
        protected virtual void BeginLaunchProcessFlowMove()
        {
            Debug.Print("BeginLaunchProcessFlowMove");
        }

        protected virtual void EndLaunchProcessFlowMove()
        {
            Debug.Print("EndLaunchProcessFlowMove");
        }

        public void LaunchProcessFlowMove()
        {
            BeginLaunchProcessFlowMove();
            Debug.Print("BeginLaunchProcessFlowMove");
            EndLaunchProcessFlowMove();
        }
    }
}
