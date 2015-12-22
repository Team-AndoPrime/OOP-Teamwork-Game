namespace BadSanta
{
    public static class Constants
    {
        //Max Screen Dimensions
        public const int MaxWidth = 1920;
        public const int MaxHeight = 1080;

        //Arrow Constants
        public const string ArrowProjectileTexturePath = "";
        public const int ArrowProjectileVelocity = 4;
        
        //Pistol bullet Constants
        public const string PistolProjectileTexturePath = "Images/Projectiles/rsz_pistolbullet";
        public const int PistolProjectileVelocity = 10;

        //Rifle bullet Constants
        public const string RifleProjectileTexturePath = "Images/Projectiles/rsz_pistolbullet";
        public const int RifleProjectileVelocity = 25;

        //Weapon Ranges
        public const int RangedWeaponRange = 500;

        //Machine Gun
        public const int MachineGunBonusDamage = 5;
        public const string MachineGunWeaponTexture = "Images/Weapons/pistolBullet";

        //Pistol
        public const int PistolbonusDamage = 5;
        public const string PistolWeaponTexture = "Images/Weapons/pistol";

        //Sniper
        public const int SniperBonusDamage = 3;
        public const string SniperWeaponTexture = "Images/Weapons/sniper";

        //Crossbow
        public const int CrossbowBonusDamage = 10;
        public const string CrossbowWeaponTexture = "Images/Weapons/crossbow";

        //Horns Attack
        public const int HornsAtackBonusDamage = 7;
        public const string HornsAttackTexturePath = "Images/Weapons/Melees/simpleMelee";

        //Simple Melee
        public const int SimpleMeleeBonusDamage = 3;
        public const string SimpleMeleeTexturePath = "Images/Weapons/Melees/simpleMelee";

        //Triple Melee
        public const int TripleMeleeBonusDamage = 5;
        public const string TripleMeleeTexturePath = "Images/Weapons/Melees/simpleMelee";

        //Gifts Textures
        public const string CarIconPath = "Images/GiftImages/Car";
        public const string PlaneIconPath = "Images/GiftImages/Plane";
        public const string DroneIconPath = "Images/GiftImages/Drone";
        public const string DollIconPath = "Images/GiftImages/Doll";
        public const string RobotIconPath = "Images/GiftImages/Robot";

        //Tiles
        public const int TileSize = 36;

        //Level Constants
        public const int MaxEnemies = 70;
        public const int MaxGifts = 30;
        public const int PlayerSpawnPoint = 36;
        public const int MaxLevel = 2;
    }
}
