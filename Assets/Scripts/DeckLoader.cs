using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeckLoader : MonoBehaviour
{
    [SerializeField] private CartaLoader _cartaPrefab;
    [SerializeField] private CartaSO[] _cartas;
    [SerializeField] private GameObject _carta;

    float x = -10.5f;

    void Start() {
        _cartaPrefab.GetComponent<CartaLoader>();
        Randomize();
    }

    public void Randomize() {
        for (int i = 0; i < 5 ; i++) {
            x = x + 3.5f;
            Vector3 pos = new Vector3(x, 0, 0);
            int ran = Random.Range(0, _cartas.Length);
            _cartaPrefab.SetData(_cartas[ran]);
            Instantiate(_cartaPrefab,  pos, Quaternion.identity, _carta.transform);
        }
    }

    public void  Clear () {
        x = -10.5f;
        for (int i = 0; i < 5 ; i++) {
            Destroy(_carta.transform.GetChild(i).gameObject);
        }
        Randomize();
    }

    // Fisher Yates Shuffle method to randomize the array without repeating elements 
    
    // Resources.Load to load the data from the resources folder in real time; its versatile and easy to use 
    // but is not the best option for performance

}
