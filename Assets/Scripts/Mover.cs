using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;
   
    void Start()
    {
        PrintInstruction();
    }

 
    void Update()
    {
        MovePlayer();
    }
    void PrintInstruction()
    {
        Debug.Log("Welcom to the game!");
        Debug.Log("Move using arrow keys or wasd");
        Debug.Log("Don't bump into objects");
    }
    void MovePlayer()
    {
        float xvalue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float yvalue = 0f;
        float zvalue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xvalue, yvalue, zvalue);
    }


}
