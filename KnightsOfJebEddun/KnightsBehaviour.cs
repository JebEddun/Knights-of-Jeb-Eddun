using System;
using ContractConfigurator;
using UnityEngine;

namespace KnightsOfJebEddun
{
    public class KnightsBehaviour : ContractBehaviour
    {
        private string MissionControl;
        private string RnD;

        public KnightsBehaviour()
        {
            MissionControl = "SpaceCenter/" + SpaceCenterFacility.MissionControl;
            RnD = "SpaceCenter/" + SpaceCenterFacility.ResearchAndDevelopment;
            
            Debug.Log($"Knights: MissionControl = {ScenarioUpgradeableFacilities.GetFacilityName(SpaceCenterFacility.MissionControl)}");

        }

        protected override void OnAccepted()
            {
                float currentLvl = ScenarioUpgradeableFacilities.GetFacilityLevel(SpaceCenterFacility.MissionControl);
                if (currentLvl < 2)
                {
                    ScenarioUpgradeableFacilities.protoUpgradeables[MissionControl].facilityRefs[0].SetLevel(2);
                }
                
                currentLvl = ScenarioUpgradeableFacilities.GetFacilityLevel(SpaceCenterFacility.ResearchAndDevelopment);
                if (currentLvl < 2)
                {
                    ScenarioUpgradeableFacilities.protoUpgradeables[RnD].facilityRefs[0].SetLevel(2);
                }
            }
    }
}
