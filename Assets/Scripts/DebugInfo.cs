using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class DebugInfo : MonoBehaviour
{
    public Transform player, enemy, direction;
    public TextMeshProUGUI debugText;

    // Update is called once per frame
    void Update()
    {
        
        Vector3 cross = Vector3.Cross(player.transform.forward, -enemy.transform.forward);
        debugText.text = $"Cross : {cross}\n";
        Vector3 direction = enemy.transform.position - player.transform.position;
        direction.Normalize();
        debugText.text += $"Direction : {direction}\n";
        float dotSight = Vector3.Dot(direction, player.transform.forward);
        debugText.text = $"Dot2 : {dotSight}\n";
        float dot = Vector3.Dot(enemy.forward, direction);
        debugText.text = $"Dot : {dot}\n";



        debugText.text += $"Player {player.transform.forward}\n" +
            $"Enemy {enemy.transform.forward}" +
            $"Direction {direction}\n" +
            $"Dot {dot}\n" +
            $"cross {cross}\n" +
            $"dotSight {dotSight}\n";

       

        if(dot > 0.2f && Vector3.Distance(player.position, enemy.position) < 3 && dotSight > 0.7f)
        {
            
            debugText.text = "On est deriere , tu peut tapper";
        }
       
        Debug.DrawRay(player.position, direction * 1000, Color.red);
        Debug.DrawRay(player.position, player.forward * 1000, Color.green);
        Debug.DrawRay(enemy.position, enemy.forward * 1000, Color.blue);






    }
}
