using Verse;

namespace MitosisComp;

public class CompProperties_Mitosis : CompProperties
{
    public readonly float coldMultiplier = 0f;

    public readonly int countLimit = 40;

    public readonly float heatMultiplier = 0f;

    public readonly PawnKindDef pawnKind = null;

    public readonly int splittingTimer = 60000;

    public readonly float temperatureOffset = 0f;

    public CompProperties_Mitosis()
    {
        compClass = typeof(Comp_Mitosis);
    }
}