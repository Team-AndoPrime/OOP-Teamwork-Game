using BadSanta.Entities;
using BadSanta.Entities.Factories;
using BadSanta.Objects.Items.Weapons;
using BadSanta.Objects.Items.Weapons.RangedWeapons;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace BadSanta.Characters.PlayerControlled
{
    public class Santa : Player
    {
        private BulletFactory bulletFactory;
        private RangedWeapon currentWeapon;

        public Santa(int health, float damage, string name)
            : base(health, damage, name)
        {
            this.Image = Content.Load<Texture2D>("Images/Characters/rsz_santa");
            Initialize();
        }

        public bool IsAttacking { get; set; }

        private void Initialize()
        {
            this.currentWeapon = new Pistol();
            this.bulletFactory = new BulletFactory();
        }

        public override void Attack(Character enemy)
        {
            if (this.IsAttacking)
            {
                this.bulletFactory.Produce(this);
            }
        }

        public override void Update(GameTime gameTime)
        {
            foreach (var generatedBullet in this.bulletFactory.GeneratedBullets)
            {
                generatedBullet.Update(gameTime);
            }

            base.Update(gameTime);
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            base.Draw(spriteBatch);
            foreach (var generatedBullet in this.bulletFactory.GeneratedBullets)
            {
                generatedBullet.Draw(spriteBatch);
            }
        }
    }

}
