using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    private int currentHealth;

    private void Start()
    {
        // Oyuncunun can�n� ba�lang��ta maksimum sa�l�k de�eriyle ba�lat
        currentHealth = maxHealth;
    }

    // Hasar al�nd���nda bu fonksiyon �a�r�l�r
    public void TakeDamage(int damage)
    {
        // Hasar� oyuncunun can�ndan ��kar
        currentHealth -= damage;

        // Oyuncunun can�n�n negatif olmamas�n� sa�la
        if (currentHealth < 0)
        {
            currentHealth = 0;
        }

        // Burada isterseniz can azald���nda ek bir i�lem yapabilirsiniz,
        // �rne�in, oyuncunun �ld���n� kontrol edebilirsiniz.
    }

    // �stenirse di�er bile�enlerin oyuncunun can�n� okumas�n� sa�lamak i�in bir getter fonksiyonu eklenebilir
    public int GetCurrentHealth()
    {
        return currentHealth;
    }
}
