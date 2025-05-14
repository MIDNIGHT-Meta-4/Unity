using System;
using UnityEngine;

public enum SceneDataType
{
    Start,
    Loading,
    Catagory,
    Game,
    GameResult,
}
namespace Single
{
    [Serializable]
    public class SceneData
    {
        public SceneDataType SceneDataType;
        public GameObject SceneObject;
    }
}