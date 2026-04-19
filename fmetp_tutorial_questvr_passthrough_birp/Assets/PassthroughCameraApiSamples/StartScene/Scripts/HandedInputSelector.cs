// Copyright (c) Meta Platforms, Inc. and affiliates.
// Original Source code from Oculus Starter Samples (https://github.com/oculus-samples/Unity-StarterSamples)

using Meta.XR.Samples;
using UnityEngine;
using UnityEngine.EventSystems;

namespace PassthroughCameraSamples.StartScene
{
    [MetaCodeSample("PassthroughCameraApiSamples-StartScene")]
    public class HandedInputSelector : MonoBehaviour
    {

        private void Start()
        {
            var cameraRig = FindFirstObjectByType<OVRCameraRig>();
            var inputModule = FindFirstObjectByType<OVRInputModule>();
            inputModule.rayTransform = cameraRig.rightHandAnchor;
        }
    }
}
