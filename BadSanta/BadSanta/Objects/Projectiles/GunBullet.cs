using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BadSanta.Objects.Projectiles
{
    class GunBullet : Bullet
    {
        private const string projectileTexturePath = "";
        private const float projectileVelocity = 25f;

        public GunBullet() 
            : base(projectileTexturePath, projectileVelocity)
        {
        }
    }
}
