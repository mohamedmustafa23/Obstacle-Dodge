using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Congratulation : MonoBehaviour
{
    [SerializeField] GameObject TextCongratulation;
    [SerializeField] GameObject TextGameOver;
    Scorer sc ;

    [System.Obsolete]
    private void Start() 
    {
        sc = FindObjectOfType<Scorer>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (sc.GetHits() == 0)
        {
            TextCongratulation.SetActive(true);
        }
        else
        {
            TextGameOver.SetActive(true);
        }
    }

}
