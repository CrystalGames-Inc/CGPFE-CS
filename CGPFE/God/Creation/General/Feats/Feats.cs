using CGPFE.Data.Constants;
using CGPFE.Management;

namespace CGPFE.God.Creation.General.Feats;

public class Feats
{
    public class Acrobatics : Feat
    {
        public string Name() {
            return "Acrobatics";
        }

        public FeatType Type() {
            return FeatType.General;
        }

        public bool CanAcquire() {
            return true;
        }
    }

    public class AcrobaticSteps : Feat
    {
        public string Name() {
            return "Acrobatic Steps";
        }

        public FeatType Type() {
            return FeatType.General;
        }

        public bool CanAcquire() {
            return PlayerDataManager.Instance.Player.Attributes.Dexterity >= 15 /*TODO add nimble moves requirements*/;
        }
    }
}