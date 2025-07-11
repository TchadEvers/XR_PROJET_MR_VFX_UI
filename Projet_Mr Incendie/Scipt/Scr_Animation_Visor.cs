
using UnityEngine;

public class Scr_Animation_Visor : MonoBehaviour
{
    public Material Visor;

    public void Eyes_Animation(float Next_Animation)
    {
        Visor.SetFloat("_Animation", Next_Animation);
    }

    void Start()
    {
        StartCoroutine(BlinkingEyes());
    }

    System.Collections.IEnumerator BlinkingEyes()
    {
        while (true)
        {
            float wait = Random.Range(0.025f, 0.0375f);

            Eyes_Animation(0.519f);
            yield return new WaitForSeconds(wait);

            Eyes_Animation(0.301f);
            yield return new WaitForSeconds(wait);

            Eyes_Animation(0);
            yield return new WaitForSeconds(wait);

            Eyes_Animation(0.301f);
            yield return new WaitForSeconds(wait);

            Eyes_Animation(0.519f);

            float blinkingRepeat = Random.Range(2f, 5f);
            yield return new WaitForSeconds(blinkingRepeat);
        }
    }
}
