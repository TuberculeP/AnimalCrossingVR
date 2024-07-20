using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoiteAPieceController : MonoBehaviour
{
    public Transform spawnerLocation;
    public GameObject piecePrefab;
    // sound to play when coin appears
    private void OnTriggerEnter(Collider other)
    {
        GameObject theGameObject = other.gameObject;
        if (theGameObject.CompareTag("Orange"))
        {
            Destroy(theGameObject);
            GameObject newPiece = Instantiate(piecePrefab, spawnerLocation.position, Quaternion.identity);
            newPiece.GetComponent<Rigidbody>().AddForce(Vector3.up, ForceMode.Impulse);
            // find the second audio source in current object and play the sound
            AudioSource audioSource = gameObject.GetComponents<AudioSource>()[1];
            audioSource.Play();
        }
    }
}
