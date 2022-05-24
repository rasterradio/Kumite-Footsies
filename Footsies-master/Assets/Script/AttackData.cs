namespace Footsies
{
    [System.Serializable]
    public class AttackData
    {
        public int attackID;
        public string attackName;

        public int damageActionID;
        public int guardActionID;

        public int numberOfHit;

        public bool dealVitalHealthDamage;
        public int guardHealthDamage;

        public int hitStunFrame;
        public int guardStunFrame;
        public int guardBreakStunFrame;
        public StanceType stanceType;

        public bool isPowerAttack;
    }

    [System.Serializable]
    public enum StanceType
    {
        Mid = 0,
        High = 1,
        Low = 2,
    }
}