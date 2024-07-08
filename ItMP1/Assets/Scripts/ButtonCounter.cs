using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ButtonCounter : MonoBehaviour
{
    int click = 0;
    [SerializeField] TextMeshProUGUI tmp;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tmp.text = click.ToString();
    }

    public void Counter()
    {
        click++;
    }
}
