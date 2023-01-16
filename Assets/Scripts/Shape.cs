using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Shape : MonoBehaviour
{
    [SerializeField]
    protected TextMeshProUGUI infoText;

    private string m_Name = "";
    public string Name {
        get {

            return m_Name;
        
        }
        set {

            if (m_Name.Length > 25)
            {

                Debug.Log("Name is too long!");

            }
            else {
            
                m_Name = value;

            }
        } 
    }

    protected Material Material {
        get {

            return GetComponent<Renderer>().sharedMaterial;    
        
        } 
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public virtual void DisplayText() {

        if (!infoText.IsActive()) {

            infoText.gameObject.SetActive(true);
        
        }

        infoText.text = "Hello! I am: " + Material.color.ToString() + " shape! My name is " + m_Name.ToString();  
       
    } 
}
