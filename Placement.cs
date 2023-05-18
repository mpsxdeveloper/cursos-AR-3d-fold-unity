using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class Placement : MonoBehaviour
{


    ARRaycastManager rayManager;
    public GameObject target;
    public GameObject robot;

    // Start is called before the first frame update
    void Start()
    {
        rayManager = FindObjectOfType<ARRaycastManager>();
        target.SetActive(false);
        robot.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        List<ARRaycastHit> hits = new List<ARRaycastHit>();
        Vector2 screenCenter = new Vector2(Screen.width/2, Screen.height/2);
        rayManager.Raycast(screenCenter, hits, TrackableType.Planes);
        if(hits.Count > 0) {
            transform.position = hits[0].pose.position;
            target.SetActive(true);
        }
        if(Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began) {
            robot.transform.position = transform.position;
            robot.SetActive(true);
        }
    }

}