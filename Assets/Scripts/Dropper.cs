using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float TimeToWait = 2f;
    MeshRenderer MR ;
    Rigidbody RB ;
    void Start()
    {
        MR = GetComponent<MeshRenderer>();
        RB = GetComponent<Rigidbody>();

        MR.enabled = false;
        RB.useGravity = false;
    }
    void Update()
    {
        if (Time.time > TimeToWait)
        {
            MR.enabled = true;
            RB.useGravity = true;
        }
    }
}
