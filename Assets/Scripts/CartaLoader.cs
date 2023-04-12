using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Assertions;

public class CartaLoader : MonoBehaviour
{
    [SerializeField] private CartaSO _datos;

    [SerializeField] private TMP_Text _topText;
    
    [SerializeField] private TMP_Text _bottomText; 

    [SerializeField] private SpriteRenderer _spriteRenderer;
    void Start()
    {
        Assert.IsNotNull(_datos, "NO HAY DATOS DEL PREFAB CARTA NO PUEDEN SER NULOS");
        _topText.text = _datos._nombre;
        _bottomText.text = _datos._ataque;
        _spriteRenderer.sprite = _datos._sprite;
    }

    public void Randomize()
    {

        _topText.text = _datos._nombre;
        _bottomText.text = _datos._ataque;
        _spriteRenderer.sprite = _datos._sprite;
    }

    public void SetData(CartaSO datos)
    {
        _datos = datos;
    }
    
}
