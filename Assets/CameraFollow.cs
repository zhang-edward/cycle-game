using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // C# attribute which allows private variable to be exposed in the inspector (this attribute does other things too,
    // but they're not important for now)
    [SerializeField]
    public Transform transformToFollow;

    // Update is called once per frame
    void Update()
    {
        // Maintain z position of -10 so that the camera stays "in front" of objects 
		// (setting camera z to 0 makes it so camera doesn't see anything)
        Vector3 targetPosition = new Vector3(transformToFollow.position.x, transformToFollow.position.y, -10);
        // Note: we could just set transform.position = targetPosition, but using Lerp makes it smoother
        //transform.position = Vector3.Lerp(transform.position, targetPosition, 20f * Time.deltaTime);
        transform.position = targetPosition;
    }
}
