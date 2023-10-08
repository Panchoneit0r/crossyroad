using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Must;

public class Player : MonoBehaviour
{
    public int carril;
    public int lateral;
    public Vector3 posObjetivo;
    public float velocidad;
    public Mundo mundo;
    public Transform rotacion;
    public bool pasar = true;
    public Player self;
    private Vector2 touchStartPos;
    private Vector2 touchEndPos;

    public GameObject panelmuerte;
    public GameObject Botones;

    public Scoore puntaje;
    
    public int posicionZ;


    private void Start()
    {
        panelmuerte.SetActive(false);
        puntaje = FindObjectOfType<Scoore>();
    }

    // Update is called once per frame
    void Update()
    {
        ActualizarPosicion();
    
    }

    public void ActualizarPosicion()
    {
        posObjetivo = new Vector3(lateral, 0.5f, posicionZ);
        transform.position = Vector3.Lerp(transform.position,posObjetivo, velocidad*Time.deltaTime);
    }
    public void Avanzar()
    {
        puntaje.AumentarPuntaje(10);
        StartCoroutine(Salto());
        rotacion.eulerAngles = Vector3.zero;

        posicionZ++;
        if (posicionZ > carril)
        {
            carril = posicionZ;
            mundo.CrearPiso();
        }
        
    }
    public void Retroceder()
    {
        StartCoroutine(Salto());
        rotacion.eulerAngles = new Vector3(0,180,0);
         
      
        if (posicionZ > carril- 3) { posicionZ--; }
        
    }
    
    public void MoverLaterales(int cuanto)
    {
        StartCoroutine(Salto());
        rotacion.eulerAngles = new Vector3(0,90 * cuanto,0);
       
        lateral += cuanto;
        lateral = Mathf.Clamp(lateral, -5, 5);
        
    }
    IEnumerator Salto()
    {
        transform.position = new Vector3(lateral, 0.75f,posicionZ);
        yield return new WaitForSeconds(0.05f); // Espera durante 2 segundos
        transform.position = new Vector3(lateral, 0.5f,posicionZ);
    }
    
    public IEnumerator Ahogarse()
    {
        self.enabled = false;
        transform.position = new Vector3(lateral, 0.5f,posicionZ);
        yield return new WaitForSeconds(0.01f); // Espera durante 2 segundos
        transform.position = new Vector3(lateral, 0.4f,posicionZ);
        yield return new WaitForSeconds(0.01f); // Espera durante 2 segundos
        transform.position = new Vector3(lateral, 0.3f,posicionZ);
        yield return new WaitForSeconds(0.01f); // Espera durante 2 segundos
        transform.position = new Vector3(lateral, 0.2f,posicionZ);
        yield return new WaitForSeconds(0.01f); // Espera durante 2 segundos
        transform.position = new Vector3(lateral, 0.1f,posicionZ);
        yield return new WaitForSeconds(0.01f); // Espera durante 2 segundos
        transform.position = new Vector3(lateral, 0.0f,posicionZ);
        yield return new WaitForSeconds(0.01f); // Espera durante 2 segundos
        transform.position = new Vector3(lateral, -0.1f,posicionZ);
        yield return new WaitForSeconds(0.01f); // Espera durante 2 segundos
        transform.position = new Vector3(lateral, -0.2f,posicionZ);
        yield return new WaitForSeconds(0.01f); // Espera durante 2 segundos
        transform.position = new Vector3(lateral, -0.3f,posicionZ);
        yield return new WaitForSeconds(0.01f); // Espera durante 2 segundos
        transform.position = new Vector3(lateral, -0.4f,posicionZ);
        yield return new WaitForSeconds(0.01f); // Espera durante 2 segundos
        transform.position = new Vector3(lateral, -0.5f,posicionZ);
        Muerte();
    }

    public void Muerte()
    {
      
        Time.timeScale = 0; // Detener el tiempo
        panelmuerte.SetActive(true);
        Botones.SetActive(false);
        self.enabled = false;
    }
    
    

}
