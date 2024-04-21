using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    private int currentHealth;

    private void Start()
    {
        // Oyuncunun canýný baþlangýçta maksimum saðlýk deðeriyle baþlat
        currentHealth = maxHealth;
    }

    // Hasar alýndýðýnda bu fonksiyon çaðrýlýr
    public void TakeDamage(int damage)
    {
        // Hasarý oyuncunun canýndan çýkar
        currentHealth -= damage;

        // Oyuncunun canýnýn negatif olmamasýný saðla
        if (currentHealth < 0)
        {
            currentHealth = 0;
        }

        // Burada isterseniz can azaldýðýnda ek bir iþlem yapabilirsiniz,
        // örneðin, oyuncunun öldüðünü kontrol edebilirsiniz.
    }

    // Ýstenirse diðer bileþenlerin oyuncunun canýný okumasýný saðlamak için bir getter fonksiyonu eklenebilir
    public int GetCurrentHealth()
    {
        return currentHealth;
    }
}
