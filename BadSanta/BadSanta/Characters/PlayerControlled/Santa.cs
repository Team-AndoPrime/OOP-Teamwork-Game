using System.Collections.Generic;
using BadSanta.Core;
using BadSanta.Entities;
using BadSanta.Objects.Items.Weapons;
using BadSanta.Objects.Items.Weapons.RangedWeapons;
using BadSanta.Objects.Projectiles;
using Microsoft.Xna.Framework.Graphics;

namespace BadSanta.Characters.PlayerControlled
{
    public class Santa : Player
    {
        private Texture2D santaImg;
        private RangedWeapon currentWeapon;
        private int currentWeaponAmmo;
        private List<RangedWeapon> weaponList;
        private List<int> ammoList;


        public Santa(int health, float damage, string name) 
            : base(health, damage, name)
        {
            this.ammoList = new List<int>();
            this.WeaponList = new List<RangedWeapon>();
            Initialize();
        }

        public Texture2D Image => this.santaImg;

        public IEnumerable<RangedWeapon> WeaponList
        {
            get { return this.weaponList; }
            private set { this.weaponList = value as List<RangedWeapon>; }
        }

        public bool IsAttacking { get; set; }

        private void Initialize()
        {
            this.weaponList.Add(new Pistol());
            this.ammoList.Add(50);
            currentWeapon = this.weaponList[0];
            currentWeaponAmmo = this.ammoList[0];

            this.santaImg = GameEngine.ContentLoader.Content.Load<Texture2D>("Images/Characters/rsz_santa");
        }
        
        public override void Attack(Character enemy)
        {
            if (IsAttacking)
            {
                
            }
        }

    }

}
