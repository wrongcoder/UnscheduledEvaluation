using StardewValley;
using StardewValley.Extensions;

namespace UnscheduledEvaluation;

// ReSharper disable InconsistentNaming
public class AddEvaluationMailPatch
{
    public const string Evaluation1Mail = "UnscheduledEvaluation-SawEvaluation1";
    public const string Evaluation2Mail = "UnscheduledEvaluation-SawEvaluation2";

    public static void Postfix(Event __instance)
    {
        switch (__instance.id)
        {
            case "558291":
                Game1.player.eventsSeen.Toggle<string>("321777", false);
                Game1.addMailForTomorrow(Evaluation1Mail, true);
                Game1.addMail(Evaluation2Mail, true);
                break;
            case "558292":
                Game1.addMail(Evaluation2Mail, true);
                break;
        }
    }
}