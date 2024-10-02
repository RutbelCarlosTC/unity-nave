using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ProcesarInput();
    }

    private void ProcesarInput(){
        if (Input.GetKey(KeyCode.Space)){
            print("Propulsor");
        }
        if (Input.GetKey(KeyCode.D)){
            print("Rot Derecha");
        }
        else if (Input.GetKey(KeyCode.A)){
            print("Rot Izquierda");
        }
    }
}
