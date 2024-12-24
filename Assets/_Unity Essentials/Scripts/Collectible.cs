using UnityEngine;

public class Collectible : MonoBehaviour
{
    public float rotationSpeed; // Kecepatan rotasi collectible
    public GameObject onCollectEffect; // Efek partikel saat collectible diambil
    public GameObject birthdayEffect; // Efek ulang tahun

    void Update()
    {
        // Rotasi collectible
        transform.Rotate(0, rotationSpeed, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        // Terjadi hanya jika terkena oleh gameObject dengan tag "Player"
        if (other.CompareTag("Player"))
        {
            // Jika sudah mengenai target maka Destroy/Delete target dan berikan efek
            Destroy(gameObject);

            // Melakukan instantiate particle effect / memberikan efek partikel
                Instantiate(onCollectEffect, transform.position, transform.rotation);

            // Jika semua collectible sudah habis
            if (UpdateCollectibleCount.TotalCollectibles - 1 <= 0)
            {
                    Instantiate(birthdayEffect, transform.position, transform.rotation);
            }
        }
    }
}
