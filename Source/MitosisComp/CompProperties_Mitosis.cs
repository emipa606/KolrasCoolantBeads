using Verse;

namespace MitosisComp
{
    // Token: 0x02000002 RID: 2
    public class CompProperties_Mitosis : CompProperties
    {
        // Token: 0x04000005 RID: 5
        public readonly float coldMultiplier = 0f;

        // Token: 0x04000006 RID: 6
        public readonly int countLimit = 40;

        // Token: 0x04000004 RID: 4
        public readonly float heatMultiplier = 0f;

        // Token: 0x04000001 RID: 1
        public readonly PawnKindDef pawnKind = null;

        // Token: 0x04000002 RID: 2
        public readonly int splittingTimer = 60000;

        // Token: 0x04000003 RID: 3
        public readonly float temperatureOffset = 0f;

        // Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
        public CompProperties_Mitosis()
        {
            compClass = typeof(Comp_Mitosis);
        }
    }
}