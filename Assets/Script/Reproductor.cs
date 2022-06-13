using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reproductor : MonoBehaviour
{
    [SerializeField]
    AudioSource audioS;
    public AudioClip[] ListaAudio;
    public int indice = 0;
    // Start is called before the first frame update
    void Start()
    {
        audioS = GetComponent<AudioSource>();
        // ListaAudio = new AudioClip[3];

        audioS.clip = ListaAudio[indice];//asina desdee la vista de valor 

        audioS.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            AumentarIndice();
        }



        if (Input.GetKeyDown(KeyCode.B))//asigno una tecla
        {
            DisminuirIndice();
        }

        audioS.clip = ListaAudio[indice];//Actualiza el valor del clip asignado al audiosource
        audioS.Play();
    }// fin Update

//Aqui inician metodos o funciones
     public void AumentarIndice(){
         indice++;
      if (indice >= ListaAudio.Length)
      {
          Debug.Log("Ya llegaste a la meta");
          indice = ListaAudio.Length-1;
      }


     }

     public void DisminuirIndice(){
         indice--; // aumento el indice
            if (indice <= 0) //comparo el valor indice con la cantidad de elementos
            {
                Debug.Log("Ya regresaste");
                indice= 0;//asigno a indice al ultimo valor conocido en la lista
            }



     }



}// fin de clase
