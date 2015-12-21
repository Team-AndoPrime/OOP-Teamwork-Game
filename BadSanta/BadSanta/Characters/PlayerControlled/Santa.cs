using BadSanta.Entities;
using BadSanta.Objects.Items.Weapons;
using BadSanta.Objects.Items.Weapons.RangedWeapons;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace BadSanta.Characters.PlayerControlled
{
    public class Santa : Player
    {
     
        private RangedWeapon currentWeapon;
        private int currentWeaponAmmo;

        public Santa(int health, float damage, string name, ContentManager content) 
            : base(health, damage, name)
        {
            this.Image = content.Load<Texture2D>("Images/Characters/rsz_santa");
            Initialize();
        }

        public bool IsAttacking { get; set; }

        private void Initialize()
        {
            this.currentWeapon = new Pistol();
            this.currentWeaponAmmo = 50;
        }
        
        public override void Attack(Character enemy)
        {
            if (this.IsAttacking)
            {
                
            }
        }

    }

}
