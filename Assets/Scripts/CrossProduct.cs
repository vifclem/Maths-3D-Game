
using TMPro;
using UnityEngine;

public class CrossProduct : MonoBehaviour
{

    public Transform player, enemy;
    public TextMeshProUGUI debugText;

    private void Start()
    {
      
    }
    private void Update()
    {
        //float dot = Vector3.Dot(player.transform.forward, -enemy.transform.forward);
       // debugText.text += $"Dot : {dot}\n";
        //Vector3 cross = Vector3.Cross(player.transform.forward, -enemy.transform.forward);
        //debugText.text += $"Cross : {cross}\n";
        //Vector3 direction = enemy.transform.position - player.transform.position;
        //debugText.text += $"Direction : {direction}\n";

    }


    Vector3 Crossproduct(Vector3 a, Vector3 b)
    {
        return new Vector3(
            (a.y * b.z - a.z * b.y),
            (a.z * b.x - a.x * b.z),
            (a.x * b.y - a.y * b.x));
    }

    float Dotproduct(Vector3 a, Vector3 b)
    {
        return (
            a.x * b.x +
            a.y * b.y +
            a.z * b.z);
    }
}
