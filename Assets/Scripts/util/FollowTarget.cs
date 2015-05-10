using UnityEngine;
using System.Collections;

public class FollowTarget : MonoBehaviour
{
    public GameObject Target;
    public float FollwSpeed = 0.1F;
    
    // Update is called once per frame
    void Update()
    {
        if (null == Target)
        {
            Destroy(this);
            return;
        }

        transform.position += (Target.transform.position - transform.position) * FollwSpeed;
    }
}
