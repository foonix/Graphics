namespace UnityEngine.Rendering.HighDefinition
{
    public abstract class HDRenderPipelineResources : RenderPipelineResources
    {
        protected override string packagePath => HDUtils.GetHDRenderPipelinePath();
    }
}
