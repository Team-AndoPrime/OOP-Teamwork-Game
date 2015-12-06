using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BadSanta.Objects.Projectiles
{
    class SniperBullet : Bullet
    {
        private const string projectileTexturePath = "";
        private const float projectileVelocity = 10f;

        public SniperBullet() 
            : base(projectileTexturePath, projectileVelocity)
        {
        }
    }
}
