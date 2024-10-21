using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    new
        // Start is called before the first frame update
        Rigidbody rigidbody;
        AudioSource audioSource;
     

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Time.deltaTime + " seg. "+(1.0f/Time.deltaTime)+" FPS");
        ProcesarInput();
    }

    private void ProcesarInput(){
        if (Input.GetKey(KeyCode.Space)){
            rigidbody.AddRelativeForce(Vector3.up);
            if(!audioSource.isPlaying){
                audioSource.Play();
            }
        }
        else{
            audioSource.Stop();
        }

        if (Input.GetKey(KeyCode.D)){
            //transform.Rotate(Vector3.back);
            var rotarDerecha = transform.rotation;
            rotarDerecha.z -= Time.deltaTime * 0.5f;
            transform.rotation = rotarDerecha;

        }
        else if (Input.GetKey(KeyCode.A)){
            //transform.Rotate(Vector3.forward);
            var rotarIzquierda = transform.rotation;
            rotarIzquierda.z += Time.deltaTime * 0.5f;
            transform.rotation = rotarIzquierda;

        }
    }
}
