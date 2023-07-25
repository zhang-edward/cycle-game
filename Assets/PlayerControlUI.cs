using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerControlUI : MonoBehaviour
{
    public Player player;
    private TMP_Text text;

    // Awake is called before the first frame update
    void Awake()
    {
        text = GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = player.pedalMode ? "A" : "D";
        transform.position = player.transform.position + (2 * Vector3.up);
    }
}
