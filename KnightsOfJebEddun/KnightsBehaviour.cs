using System;
using ContractConfigurator;
using UnityEngine;

namespace KnightsOfJebEddun
{
    public class KnightsBehaviour : ContractBehaviour
    {
            protected override void OnAccepted()
            {
                float currentLvl = ScenarioUpgradeableFacilities.GetFacilityLevel(SpaceCenterFacility.MissionControl);
                if (currentLvl < 2)
                {
                    foreach (String k in ScenarioUpgradeableFacilities.protoUpgradeables.Keys)
                    {
                        Debug.Log($"k = {k}");
                    }
                    ScenarioUpgradeableFacilities.protoUpgradeables[
                        SpaceCenterFacility.MissionControl.ToString()].facilityRefs[0].SetLevel(2);
                }
                
                currentLvl = ScenarioUpgradeableFacilities.GetFacilityLevel(SpaceCenterFacility.ResearchAndDevelopment);
                if (currentLvl < 2)
                {
                    ScenarioUpgradeableFacilities.protoUpgradeables[
                        SpaceCenterFacility.ResearchAndDevelopment.ToString()].facilityRefs[0].SetLevel(2);
                }
            }
    }
}
