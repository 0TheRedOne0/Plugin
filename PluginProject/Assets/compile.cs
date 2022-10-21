using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class compile : MonoBehaviour
{
    public Button MyButton;
    // Start is called before the first frame update
    void Start()
    {
        
        Button btn = MyButton.GetComponent<Button>();

        btn.onClick.AddListener(Compilar);
    }

   
    void Compilar()
    {
        Canvas.GetComponent<GameObject.Find<Inputs>>().tag;
    }
   

        // Update is called once per frame
        void Update()
    {
        
    }
}
