using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.ARFoundation;

public class Image : MonoBehaviour
{
    private ARTrackedImageManager arTrackedImageManager;
    private void Awake()
    {
        arTrackedImageManager = FindObjectOfType<ARTrackedImageManager>();
    }
    private void OnEnable()
    {
        arTrackedImageManager.trackedImagesChanged += OnImageChanged;
    }
    private void OnDisable()
    {
        arTrackedImageManager.trackedImagesChanged -= OnImageChanged;
    }
    public void OnImageChanged(ARTrackedImagesChangedEventArgs args)
    {
        foreach(var trackedImage in args.added)
        {
            Debug.Log(trackedImage.name);
        }
    }
}
