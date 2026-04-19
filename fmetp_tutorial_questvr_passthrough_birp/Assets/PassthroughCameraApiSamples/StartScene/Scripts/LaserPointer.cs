// Copyright (c) Meta Platforms, Inc. and affiliates.
// Original Source code from Oculus Starter Samples (https://github.com/oculus-samples/Unity-StarterSamples)

using Meta.XR.Samples;
using UnityEngine;

namespace PassthroughCameraSamples.StartScene
{
    [MetaCodeSample("PassthroughCameraApiSamples-StartScene")]
    public class LaserPointer : OVRCursor
    {
        public GameObject CursorVisual;
        private LineRenderer m_lineRenderer;

        private void Awake() => m_lineRenderer = GetComponent<LineRenderer>();

        public override void SetCursorRay(Transform t)
        {
            UpdatePointer(t.position, t.position + t.forward * 5f);
        }

        public override void SetCursorStartDest(Vector3 start, Vector3 dest, Vector3 normal)
        {
            UpdatePointer(start, dest);
        }

        private void UpdatePointer(Vector3 start, Vector3 end)
        {
            m_lineRenderer.SetPosition(0, start);
            m_lineRenderer.SetPosition(1, end);
            CursorVisual.transform.position = end;
        }

        private void LateUpdate()
        {
            bool hasActiveController = OVRInput.GetActiveController() != OVRInput.Controller.None;
            m_lineRenderer.enabled = hasActiveController;
            CursorVisual.SetActive(hasActiveController);
        }
    }
}
