using UnityEngine;
using UnityEngine.Rendering;

namespace pfc.Fulldome
{
    [ExecuteAlways]
    public class SwitchPipeline : MonoBehaviour
    {
        public RenderPipelineAsset asset;

        // Start is called before the first frame update
        void OnEnable()
        {
            GraphicsSettings.renderPipelineAsset = asset;
        }
    }
}