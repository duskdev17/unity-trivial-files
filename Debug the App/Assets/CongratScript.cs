using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CongratScript : MonoBehaviour
{
    public TextMesh Text;
    public ParticleSystem SparksParticles;

    [SerializeField] float RotatingSpeed;

    public List<string> textToDisplay;

    // Start is called before the first frame update
    void Start()
    {
        textToDisplay.Add("Congratulation");
        textToDisplay.Add("All Errors Fixed");
        StartCoroutine(UpdateTitle());
        RotatingSpeed = 1.0f;
        SparksParticles.Play();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.right, RotatingSpeed);
    }

    IEnumerator UpdateTitle()
    {
        Text.text = textToDisplay[0];
        yield return new WaitForSeconds(1f);
        Text.text = textToDisplay[1];
        yield return new WaitForSeconds(1f);
        yield return UpdateTitle();
    }
}