using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 3;
    private int currentHealth;

    private void Start()
    {
        // Oyuncunun canýný baþlangýçta maksimum saðlýk deðeriyle baþlat
        currentHealth = maxHealth;
    }

    // Hasar alýndýðýnda bu fonksiyon çaðrýlýr
    public void TakeDamage()
    {
        // Hasarý oyuncunun canýndan çýkar
        currentHealth -= 1;

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
