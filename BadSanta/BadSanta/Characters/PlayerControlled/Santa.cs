using System.Collections.Generic;
using BadSanta.Core;
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

        private void Initialize()
        {
            this.currentWeapon = new Pistol();
            this.bulletFactory = new BulletFactory();
        }

        public override void Attack()
        {
            this.bulletFactory.Produce(this);
        }

        public override void Update(GameTime gameTime)
        {
            foreach (var generatedBullet in this.bulletFactory.GeneratedBullets)
            {
                generatedBullet.Update(gameTime);
            }

            if (this.IsAttacking)
            {
                Attack();
                this.IsAttacking = false;
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

        public BulletFactory BulletFactory
        {
            get { return this.bulletFactory; }
        }

        public override void Collision(Rectangle newRectangle)
        {
            base.Collision(newRectangle);

            Rectangle bulletCollisionBox;

            for(int i = 0; i < this.bulletFactory.GeneratedBullets.Count; i++)
            {
                bulletCollisionBox = new Rectangle(this.bulletFactory.GeneratedBullets[i].PositionX,
                    this.bulletFactory.GeneratedBullets[i].PositionY,
                    this.bulletFactory.GeneratedBullets[i].ProjectileTexture.Width,
                    this.bulletFactory.GeneratedBullets[i].ProjectileTexture.Height);

                if (bulletCollisionBox.TouchAnywhere(newRectangle))
                {
                    this.bulletFactory.GeneratedBullets.Remove(this.bulletFactory.GeneratedBullets[i]);
                }

            }
        }
    }

}
