using System.Collections.Generic;
using UnityEngine;

namespace Single
{
    public class SceneManager : MonoBehaviour
    {
        [SerializeField] private List<SceneData> _scenes;

        public void LoadScene(SceneDataType sceneDataType)
        {
            foreach (SceneData sceneData in _scenes)
            {
                if (sceneData.SceneDataType == sceneDataType)
                {
                    sceneData.SceneObject.SetActive(true);
                }
                else
                    sceneData.SceneObject.SetActive(false);
            }
        }
    }
}