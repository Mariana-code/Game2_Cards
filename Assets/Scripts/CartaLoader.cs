using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Assertions;

public class CartaLoader : MonoBehaviour
{
    [SerializeField]
    private CartaSO _datos;

    [SerializeField]
    private TMP_Text _nombre;
    
    [SerializeField]
    private TMP_Text _ataque; 

    [SerializeField]
    private SpriteRenderer _spriteRenderer;
    void Start()
    {
        Assert.IsNotNull(_datos, "NO HAY DATOS DEL PREFAB CARTA NO PUEDEN SER NULOS");
        _nombre.text = _datos._nombre;
        _fuerza.text = _datos._fuerza;
        _spriteRenderer.sprite = _datos._sprite;
    }
}
