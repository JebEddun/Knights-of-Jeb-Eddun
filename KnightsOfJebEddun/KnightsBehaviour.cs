using ContractConfigurator;

namespace KnightsOfJebEddun
{
    public class KnightsBehaviour : ContractBehaviour
    {
            protected override void OnAccepted()
            {
                float currentLvl = ScenarioUpgradeableFacilities.GetFacilityLevel(SpaceCenterFacility.MissionControl);
                if (currentLvl < 2)
                {
                    ScenarioUpgradeableFacilities.protoUpgradeables[
                        SpaceCenterFacility.MissionControl.ToString()].facilityRefs[0].SetLevel(2);
                }
            }
    }
}
