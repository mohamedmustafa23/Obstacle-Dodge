using UnityEngine;

public class TriggerProjectill : MonoBehaviour
{
    [SerializeField] GameObject Hiter1;
    [SerializeField] GameObject Hiter2;
    [SerializeField] GameObject Hiter3;
    [SerializeField] GameObject Hiter4;
    [SerializeField] GameObject Hiter5;


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Hiter1.SetActive(true);
            Hiter2.SetActive(true);
            Hiter3.SetActive(true);
            Hiter4.SetActive(true);
            Hiter5.SetActive(true);
            Destroy(gameObject);
        }
    }

}
