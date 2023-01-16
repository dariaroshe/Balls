using UnityEngine;

namespace SelectLevel
{
    public abstract class SelectLevelComponent : MonoBehaviour
    {
        public abstract void Initialize(SelectLevelModel selectLevelModel, SelectLevelScene selectLevelScene);
    }
}