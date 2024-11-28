using UnityEngine;

public class Scorer : MonoBehaviour
{
    public int hits = 0;
    private void OnCollisionEnter(Collision other)
    {

        if (other.gameObject.tag != "Hit")
        {
            hits++;
            Debug.Log("You have bumped into a thing this many times: " + hits);
        }
       
    }
    public int GetHits()
    {
        return hits;
    }

}

