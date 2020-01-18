using Verse;
using ToolkitPatchLib;

namespace ToolkitVFEMedievalPatch
{
    public class ToolkitVFEMedievalPatch : Mod
    {
        public ToolkitVFEMedievalPatch(ModContentPack content) : base(content)
        {
            ToolkitPatchLogger.LOGGERNAME = "TVFEM";
        }

        public override string SettingsCategory() => "Toolkit VFE Medieval Patch";
    }
}
