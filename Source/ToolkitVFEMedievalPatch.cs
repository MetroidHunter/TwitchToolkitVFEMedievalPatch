using Verse;
using ToolkitPatchLib;

namespace ToolkitVFEMedievalPatch
{
    public class ToolkitVFEMedievalPatch : Mod
    {
        public ToolkitVFEMedievalPatch(ModContentPack content) : base(content)
        {
            Logger.LOGGERNAME = "TVFEM";
        }

        public override string SettingsCategory() => "Toolkit VFE Medieval Patch";
    }
}
