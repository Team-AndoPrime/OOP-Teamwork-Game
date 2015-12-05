﻿using System;
using BadSanta.Core;
using BadSanta.Exceptions;
using BadSanta.Interfaces;
using Microsoft.Xna.Framework.Graphics;

namespace BadSanta.Objects.Items.Weapons
{
    public abstract class Firearm : Weapon, IProjectile
    {

        private float velocity;
        private Texture2D projectileTexture;
        private int fireRate;

        protected Firearm(int fireRate, int reloadRate, float bonusDamage, int range, float velocity, string projectileTexturePath, string weaponTexture) 
            : base(reloadRate, bonusDamage, range, weaponTexture)
        {
            this.ProjectileTexture = this.Content.Load<Texture2D>(projectileTexturePath);
            this.Velocity = velocity;
            this.FireRate = fireRate;
        }

        public float Velocity
        {
            get { return this.velocity; }
            private set
            {
                if (value <= 0)
                {
                    throw new InvalidProjectileVelocityException("Projectile Velocity cannot be zero or negative");
                }
                this.velocity = value;
            }
        }

        public Texture2D ProjectileTexture
        {
            get { return this.projectileTexture; }
            private set { this.projectileTexture = value; }
        }

        public int FireRate
        {
            get { return this.fireRate; }
            private set
            {
                if (value <= 0)
                {
                    throw new InvalidWeaponStatException("Fire Rate cannot be zero or negative");
                }
                this.fireRate = value;
            }
        }
    }
}