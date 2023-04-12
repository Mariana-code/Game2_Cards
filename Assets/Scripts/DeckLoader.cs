using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeckLoader : MonoBehaviour
{
    [SerializeField] private GameObject[] _cartas;

    public void Randomize()
    {
        foreach (var carta in _cartas)
        {
            carta.GetComponent<CartaLoader>().Randomize();
        }
    }
    
}
