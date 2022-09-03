using System;
using UnityEditor;
using UnityEngine;

namespace Editor
{
    public class TestBuild
    {
        public static void PerformBuild()
        {
            var argvs = Environment.GetCommandLineArgs();
            foreach (var argv in argvs)
            {
                Debug.Log($"para: {argv}");
            }


            // BuildPlayerOptions buildPlayerOptions = new BuildPlayerOptions();
            // buildPlayerOptions.scenes = new[] { "Assets/Scenes/SampleScene.unity" };
            // BuildPipeline.BuildPlayer(buildPlayerOptions);
        }
    }
}