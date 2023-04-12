using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PruebaOyente : MonoBehaviour
{
    public void EventoSinParametros() {
        print("Evento sin parametros");
    }
    
    public void EventoArgumento(int p) {
        print(string.Format("parametros: {0}", p));
    }
        public void EventoDosArgumentos(string p1, float p2) {
        print(string.Format("parametros: {0} {1}", p1, p2));

    }
        public void EventroTresArgumentos(string p1, char p2, bool p3) {
        print(string.Format("parametros: {0} {1} {2}", p1, p2, p3));

    }

}
