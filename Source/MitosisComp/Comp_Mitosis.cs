using System.Linq;
using RimWorld;
using Verse;

namespace MitosisComp;

public class Comp_Mitosis : ThingComp
{
    private int ticksSinceLastSplit;

    private CompProperties_Mitosis Props => (CompProperties_Mitosis)props;

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

        var text = $"Last Mitosis Split: {ticksSinceLastSplit} ticks";
        text = $"{text}\nWill split at: {Props.splittingTimer * getTemperatureMultiplier()} ticks";
        text = $"{text}\nCan Split:{canSplit()}";

        return text;
    }

    public override void CompTick()
    {
        base.CompTick();
        if (parent.Map == null)
        {
            return;
        }

        if (ticksSinceLastSplit >= Props.splittingTimer * getTemperatureMultiplier() && canSplit())
        {
            spawnPawn();
            ticksSinceLastSplit = 0;
        }
        else
        {
            ticksSinceLastSplit++;
        }
    }

    private bool canSplit()
    {
        var pawns = from p in parent.Map.mapPawns?.AllPawns
            where p != null && p.def == Props.pawnKind.race
            select p;
        var num = pawns.Count();
        return Props.countLimit > num;
    }

    private float getTemperatureMultiplier()
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

    private void spawnPawn()
    {
        var request = new PawnGenerationRequest(Props.pawnKind, parent.Faction, PawnGenerationContext.NonPlayer, -1,
            true, true, false, false, true, 1f, false, true, true, false);
        var newThing = PawnGenerator.GeneratePawn(request);
        GenSpawn.Spawn(newThing, parent.Position, parent.Map);
    }
}