using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System;

// Serializable permite que el objeto sea serializable y se pueda guardar en un archivo y se pueda ver en el inspector
// Para eventos con 1 o mas argumentos hay que definir una clase 
// Serializa transforma de fuente de datos a objeto en memoria
// Se realiza si se necesita que el evento reciba argumentos
[Serializable] public class EventoArgumento : UnityEvent<int>{}
[Serializable] public class EventoDosArgumentos : UnityEvent<string, float>{}
[Serializable] public class EventroTresArgumentos : UnityEvent<string, char, bool>{}

public class PruebaEventos : MonoBehaviour
{
    // privada para procesos internos
    // publica para que otros objetos puedan acceder a ella
    [Serializable] private class Alumno{
        public string _nombre;
        public int _edad;
        public float _altura;
    }

    // UNITY EVENTS
    // - mecanismo basado en el patron de diseño Observer (patron de diseño de software) observador
    // el cual permite que un objeto notifique a otros objetos cuando un evento sucede
    // - informamos de un cambio en alguna situacion

    // VENTAJA
    // - permite que un objeto notifique a otros objetos cuando un evento sucede
    // - desacopla logica; remueve dependencias duras

    // USO
    // - Se usa cuando queramos poner un objeto de el tipo de otro Script evalua
    // si un event no resuelve el problema

    // Se agregan subscriptores al objeto para que se notifiquen cuando un evento sucede
    // Se pueden agregar varios subscriptores a un evento
    // Se pueden agregar varios eventos a un objeto
    [SerializeField] private Alumnto[] _alumno;

    [SerializeField] private UnityEvent _eventoSinParametros;
    [SerializeField] private EventoArgumento _eventoConArgumentos;
    [SerializeField] private EventoDosArgumentos _eventoDosArgumentos;
    [SerializeField] private EventroTresArgumentos _eventoTresArgumentos;

    void Start(){
        
    }

    // Update is called once per frame
    void Update(){
        if (Input.GetKeyDown(KeyCode.A)){
            _eventoSinParametros.Invoke();
        }

        if (Input.GetKeyDown(KeyCode.S)){
            _eventoConArgumentos.Invoke(13);
        }

        if (Input.GetKeyDown(KeyCode.D)){
            _eventoDosArgumentos.Invoke("Alooo", 64);
        }

        if (Input.GetKeyDown(KeyCode.F)){
            _eventoTresArgumentos.Invoke("assssss", 'a', true);
        }
        
    }
}
