using System.Linq;
using RimWorld;
using Verse;

namespace MitosisComp
{
    public class Comp_Mitosis : ThingComp
    {
        private int ticksSinceLastSplit;

        private CompProperties_Mitosis Props => (CompProperties_Mitosis) props;

        public override void PostExposeData()
        {
            base.PostExposeData();
            Scribe_Values.Look(ref ticksSinceLastSplit, "ticksSinceLastSplit");
        }

        public override string CompInspectStringExtra()
        {
            if (!Prefs.DevMode)
            {
                return string.Empty;
            }

            var text = "Last Mitosis Split: " + ticksSinceLastSplit + " ticks";
            text = text + "\nWill split at: " + (Props.splittingTimer * GetTemperatureMultiplier()) + " ticks";
            text = text + "\nCan Split:" + CanSplit();

            return text;
        }

        public override void CompTick()
        {
            base.CompTick();
            if (parent.Map == null)
            {
                return;
            }

            if (ticksSinceLastSplit >= Props.splittingTimer * GetTemperatureMultiplier() && CanSplit())
            {
                SpawnPawn();
                ticksSinceLastSplit = 0;
            }
            else
            {
                ticksSinceLastSplit++;
            }
        }

        private bool CanSplit()
        {
            var pawns = from p in parent.Map.mapPawns?.AllPawns
                where p != null && p.def == Props.pawnKind.race
                select p;
            var num = pawns.Count();
            return Props.countLimit > num;
        }

        private float GetTemperatureMultiplier()
        {
            float result;
            if (parent.AmbientTemperature >= 0f)
            {
                result = 1f - (Props.heatMultiplier * (parent.AmbientTemperature - Props.temperatureOffset));
            }
            else
            {
                result = 1f - (Props.coldMultiplier * (parent.AmbientTemperature - Props.temperatureOffset));
            }

            return result;
        }

        private void SpawnPawn()
        {
            var request = new PawnGenerationRequest(Props.pawnKind, parent.Faction, PawnGenerationContext.NonPlayer, -1,
                true, true, false, false, true, false, 1f, false, true, true, false);
            var newThing = PawnGenerator.GeneratePawn(request);
            GenSpawn.Spawn(newThing, parent.Position, parent.Map);
        }
    }
}