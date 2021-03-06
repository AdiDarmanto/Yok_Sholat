#if UNITY_EDITOR
using UnityEditor;
#endif

using UnityEngine;

namespace Wikitude
{
    /// <summary>
    /// Class used by the Wikitude SDK for platform and version dependent compilation. For internal use only.
    /// </summary>
    public class Platform : PlatformBase {

    #if UNITY_EDITOR
        [InitializeOnLoadMethod]
    #endif
        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
        public static void Initialize() {
            if (_instance == null) {
                _instance = new Platform();
            }
        }

        public override void LoadImage(Texture2D texture, byte[] data) {
            texture.LoadImage(data);
        }

        public override byte[] EncodeToPNG(Texture2D texture) {
            return texture.EncodeToPNG();
        }

        public override UnityVersion GetUnityVersion() {
#if UNITY_2018_1_OR_NEWER
            return UnityVersion.Unity_2018_1;
#elif UNITY_2017_3_OR_NEWER
            return UnityVersion.Unity_2017_3;
#elif UNITY_2017_2_OR_NEWER
            return UnityVersion.Unity_2017_2;
#elif UNITY_2017_1_OR_NEWER
            return UnityVersion.Unity_2017_1;
#elif UNITY_5_6_OR_NEWER
            return UnityVersion.Unity_5_6;
#elif UNITY_5_5_OR_NEWER
            return UnityVersion.Unity_5_5;
#elif UNITY_5_4_OR_NEWER
            return UnityVersion.Unsupported;
#elif UNITY_5
            return UnityVersion.Unsupported;
#elif UNITY_4
            return UnityVersion.Unsupported;
#else
            return UnityVersion.Unknown;
#endif
        }
    }
}
