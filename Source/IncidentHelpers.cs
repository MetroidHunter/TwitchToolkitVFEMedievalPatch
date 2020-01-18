using RimWorld;
using ToolkitPatchLib;
using Verse;
using VFECore;
using VFEMedieval;

namespace ToolkitVFEMedievalPatch
{
    public class IncidentHelper_VFEM_PursuitParty : NormalIncidentHelper<IncidentWorker_RaidEnemySpecial>
    {
        public IncidentHelper_VFEM_PursuitParty() : base(IncidentCategoryDefOf.ThreatBig, IncidentDef.Named("VFEM_PursuitParty")) { }
    }

    public class VoteHelper_VFEM_PursuitParty : BasicVotingHelper<IncidentWorker_RaidEnemySpecial>
    {
        public VoteHelper_VFEM_PursuitParty() : base(IncidentCategoryDefOf.ThreatBig, IncidentDef.Named("VFEM_PursuitParty")) { }
    }

    public class IncidentHelper_VFEM_Quest_MedievalTournament : NormalIncidentHelper<IncidentWorker_QuestMedievalTournament>
    {
        public IncidentHelper_VFEM_Quest_MedievalTournament() : base(IncidentCategoryDefOf.WorldQuest, IncidentDef.Named("VFEM_Quest_MedievalTournament"), Find.World) { }
    }

    public class VoteHelper_VFEM_Quest_MedievalTournament : BasicVotingHelper<IncidentWorker_QuestMedievalTournament>
    {
        public VoteHelper_VFEM_Quest_MedievalTournament() : base(IncidentCategoryDefOf.WorldQuest, IncidentDef.Named("VFEM_Quest_MedievalTournament")) { }
    }

    public class IncidentHelper_VFEM_Quest_CastleRuins : NormalIncidentHelper<IncidentWorker_QuestCastleRuins>
    {
        public IncidentHelper_VFEM_Quest_CastleRuins() : base(IncidentCategoryDefOf.WorldQuest, IncidentDef.Named("VFEM_Quest_CastleRuins"), Find.World) { }
    }

    public class VoteHelper_VFEM_Quest_CastleRuins : BasicVotingHelper<IncidentWorker_QuestCastleRuins>
    {
        public VoteHelper_VFEM_Quest_CastleRuins() : base(IncidentCategoryDefOf.WorldQuest, IncidentDef.Named("VFEM_Quest_CastleRuins")) { }
    }
}
