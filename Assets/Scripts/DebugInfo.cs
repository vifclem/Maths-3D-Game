using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DebugInfo : MonoBehaviour
{
    public Transform player, enemy;
    public TextMeshProUGUI debugText;

    // Update is called once per frame
    void Update()
    {
        debugText.text = $"Player {player.transform.forward}\n" +
            $"Enemy {enemy.transform.forward}";
    }
}
