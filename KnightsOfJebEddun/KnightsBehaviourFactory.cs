using ContractConfigurator;

namespace KnightsOfJebEddun
{
    public class KnightsBehaviourFactory : BehaviourFactory
    {
        public override ContractBehaviour Generate(ConfiguredContract contract)
        {
            return new KnightsBehaviour();
        }
    }
}