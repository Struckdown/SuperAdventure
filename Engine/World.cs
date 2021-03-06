﻿using System.Collections.Generic;
using System.Linq;

namespace Engine
{
    public static class World
    {
        private static readonly List<Item> _items = new List<Item>();
        private static readonly List<Monster> _monsters = new List<Monster>();
        private static readonly List<Quest> _quests = new List<Quest>();
        private static readonly List<Location> _locations = new List<Location>();

        public const int UNSELLABLE_ITEM_PRICE = -1;

        public const int ITEM_ID_BROKEN_SWORD = 1;
        public const int ITEM_ID_RAT_TAIL = 2;
        public const int ITEM_ID_PIECE_OF_FUR = 3;
        public const int ITEM_ID_SNAKE_FANG = 4;
        public const int ITEM_ID_SNAKESKIN = 5;
        public const int ITEM_ID_CLUB = 6;  
        public const int ITEM_ID_HEALING_POTION = 7;
        public const int ITEM_ID_SPIDER_FANG = 8;
        public const int ITEM_ID_SPIDER_SILK = 9;
        public const int ITEM_ID_ADVENTURER_PASS = 10;
        public const int ITEM_ID_GREATER_HEALING_POTION = 11;
        public const int ITEM_ID_SCROLL_MINOR_FIREBALL = 12;
        public const int ITEM_ID_TROLL_BLOOD = 13;
        public const int ITEM_ID_GREEN_JELLY = 14;
        public const int ITEM_ID_HUMAN_BONES = 15;
        public const int ITEM_ID_ROTTING_SKULL = 16;
        public const int ITEM_ID_BROKEN_HELMET = 17;
        public const int ITEM_ID_DAMAGED_AXE = 18;
        public const int ITEM_ID_WISP_FRAGMENT = 19;
        public const int ITEM_ID_LARGE_BRANCH = 20;
        public const int ITEM_ID_SPIKED_COLLAR = 21;
        public const int ITEM_ID_SHARP_SWORD = 22;
        public const int ITEM_ID_DRAGONHIDE = 23;
        public const int ITEM_ID_WOLF_FANG = 24;
        public const int ITEM_ID_VORPAL_SWORD = 25;
        public const int ITEM_ID_CURSED_RING = 26;
        public const int ITEM_ID_LONG_BOW = 27;
        public const int ITEM_ID_COIN_PURSE = 28;
        public const int ITEM_ID_PAN_PIPES = 29;
        public const int ITEM_ID_KOBOLD_TAIL = 30;
        public const int ITEM_ID_SPIKED_CLUB = 31;
        public const int ITEM_ID_BUNDLE_OF_STRAW = 32;
        public const int ITEM_ID_GIANT_MOTH_WINGS = 33;
        public const int ITEM_ID_DAMAGED_BOOK = 34;
        public const int ITEM_ID_BANDAGES = 35;
        public const int ITEM_ID_SCARAB_LEGS = 36;
        public const int ITEM_ID_WORM_TOOTH = 37;
        public const int ITEM_ID_ELVEN_BROOCH = 38;
        public const int ITEM_ID_MANA_POTION = 39;
        public const int ITEM_ID_BLACK_GAUNTLET = 40;
        public const int ITEM_ID_CENTAUR_HOOF = 41;
        public const int ITEM_ID_WYVERN_WINGS = 42;
        public const int ITEM_ID_WYVERN_TAIL = 43;
        public const int ITEM_ID_GIANT_FEATHER = 44;
        public const int ITEM_ID_STONE_OF_TRUTH = 45; // mimic loot
        public const int ITEM_ID_BURNT_HAIR = 46;
        public const int ITEM_ID_SILVER_LONGSWORD = 47;
        public const int ITEM_ID_TOME_OF_POWER = 48;
        public const int ITEM_ID_EYE_OF_NEWT = 49;
        public const int ITEM_ID_LIFEDRINKER_SKULL = 50;
        public const int ITEM_ID_CURSED_STAFF = 51;
        public const int ITEM_ID_LIZARD_TAIL = 52;
        public const int ITEM_ID_ASHES = 53;
        public const int ITEM_ID_RUBY = 54;
        public const int ITEM_ID_CRACKED_OBSIDIAN = 55;
        public const int ITEM_ID_RED_HAT = 56;
        public const int ITEM_ID_FAERIE_DUST = 57;
        public const int ITEM_ID_ORANGE_MUSHROOM = 58;
        public const int ITEM_ID_HARPY_FEATHER = 59;
        public const int ITEM_ID_TRIDANT = 60;
        public const int ITEM_ID_EMERALD_RING = 61;
        public const int ITEM_ID_GOLDEN_RING = 62;
        public const int ITEM_ID_BEAR_PELT = 63;

        public const int MONSTER_ID_RAT = 1;
        public const int MONSTER_ID_SNAKE = 2;
        public const int MONSTER_ID_GIANT_SPIDER = 3;
        public const int MONSTER_ID_TROLL = 4;
        public const int MONSTER_ID_GREEN_SLIME = 5;
        public const int MONSTER_ID_SKELETON = 6;
        public const int MONSTER_ID_WIZARD = 7;
        public const int MONSTER_ID_ZOMBIE = 8;
        public const int MONSTER_ID_GRUE = 9;
        public const int MONSTER_ID_SHADOW = 10;
        public const int MONSTER_ID_ANIMATED_ARMOR = 11;
        public const int MONSTER_ID_FLYING_AXE = 12;
        public const int MONSTER_ID_WISP = 13;
        public const int MONSTER_ID_ENT = 14;
        public const int MONSTER_ID_RABID_DOG = 15;
        public const int MONSTER_ID_OGRE = 16;
        public const int MONSTER_ID_GOBLIN = 17;
        public const int MONSTER_ID_GREEN_DRAGON = 18;
        public const int MONSTER_ID_DIRE_WOLF = 19;
        public const int MONSTER_ID_DEATHKNIGHT = 20;
        public const int MONSTER_ID_WRAITH = 21;
        public const int MONSTER_ID_ORC = 22;
        public const int MONSTER_ID_THIEF = 23;
        public const int MONSTER_ID_SATYR = 24;
        public const int MONSTER_ID_KOBOLD = 25;
        public const int MONSTER_ID_BUGBEAR = 26;
        public const int MONSTER_ID_SCARECROW = 27;
        public const int MONSTER_ID_GIANT_MOTH = 28;
        public const int MONSTER_ID_ANIMATED_BOOK = 29;
        public const int MONSTER_ID_MUMMY = 30;
        public const int MONSTER_ID_SCARAB = 31;
        public const int MONSTER_ID_GIANT_WORM = 32;
        public const int MONSTER_ID_DARK_ELF = 33;
        public const int MONSTER_ID_IMP = 34;
        public const int MONSTER_ID_HEADLESS_HORSEMAN = 35;
        public const int MONSTER_ID_CENTAUR = 36;
        public const int MONSTER_ID_WYVERN = 37;
        public const int MONSTER_ID_ROC = 38;
        public const int MONSTER_ID_MIMIC = 39;
        public const int MONSTER_ID_NIGHTMARE = 40;
        public const int MONSTER_ID_DJINN = 41;
        public const int MONSTER_ID_LICH = 42;
        public const int MONSTER_ID_WITCH = 43;
        public const int MONSTER_ID_NECROMANCER = 44;
        public const int MONSTER_ID_LIZARDMAN = 45;
        public const int MONSTER_ID_FIRE_ELEMENTAL = 46;
        public const int MONSTER_ID_GOLEM = 47; //more golems?
        public const int MONSTER_ID_GNOME = 48;
        public const int MONSTER_ID_PIXIE = 49;
        public const int MONSTER_ID_DRYAD = 50;
        public const int MONSTER_ID_HARPY = 51;
        public const int MONSTER_ID_NAGA = 52;
        public const int MONSTER_ID_NYMPH = 53;
        public const int MONSTER_ID_NAIAD = 54; //double check spelling
        public const int MONSTER_ID_DIRE_BEAR = 55;

        public const int QUEST_ID_CLEAR_ALCHEMIST_GARDEN = 1;
        public const int QUEST_ID_CLEAR_FARMERS_FIELD = 2;

        public const int LOCATION_ID_HOME = 1;
        public const int LOCATION_ID_TOWN_SQUARE = 2;
        public const int LOCATION_ID_WEST_GUARD_POST = 3;
        public const int LOCATION_ID_ALCHEMIST_HUT = 4;
        public const int LOCATION_ID_ALCHEMISTS_GARDEN = 5;
        public const int LOCATION_ID_FARMHOUSE = 6;
        public const int LOCATION_ID_FARM_FIELD = 7;
        public const int LOCATION_ID_BRIDGE = 8;
        public const int LOCATION_ID_SPIDER_FIELD = 9;
        public const int LOCATION_ID_BACK_ALLEY = 10;
        public const int LOCATION_ID_WEST_SUBURBS = 11;
        public const int LOCATION_ID_NORTHERN_ROAD = 12;
        public const int LOCATION_ID_MARKET_DISTRICT = 13;
        public const int LOCATION_ID_SIDE_ROAD = 14;
        public const int LOCATION_ID_GENERAL_STORE = 15;
        public const int LOCATION_ID_DEAD_END = 16;
        public const int LOCATION_ID_ARCHERY_RANGE = 17;
        public const int LOCATION_ID_EASTERN_TRAIL = 18;
        public const int LOCATION_ID_BROKEN_PASS = 19;
        public const int LOCATION_ID_DESERT_ENTRANCE = 20;
        public const int LOCATION_ID_LARGE_HILL = 21;
        public const int LOCATION_ID_CLIFF = 22;
        public const int LOCATION_ID_ROLLING_HILLS = 23;
        public const int LOCATION_ID_PEACEFUL_POND = 24;
        public const int LOCATION_ID_COLLISAL_CAVE_ENTRANCE = 25;
        public const int LOCATION_ID_MUDFIELD = 26;
        public const int LOCATION_ID_LESS_TRAVELED_ROAD = 27;
        public const int LOCATION_ID_THE_FORGOTTEN_TOWER = 28;
        public const int LOCATION_ID_STAIRS_TO_THE_SPIRE = 29;
        public const int LOCATION_ID_THE_SPIRE = 30;
        public const int LOCATION_ID_TRIFOX_TRAIL = 31;
        public const int LOCATION_ID_ENTRANCE_TO_YOGNAR_WOODS = 32;
        public const int LOCATION_ID_IN_THE_WOODS = 33;
        public const int LOCATION_ID_RIVER_CROSSING = 34;
        public const int LOCATION_ID_RIVER_UPTRAIL = 35;
        public const int LOCATION_ID_RIVER_UPTRAIL_DEAD_END = 36;
        public const int LOCATION_ID_RIVER_DOWNTRAIL = 37;
        public const int LOCATION_ID_WESTBROOK_DOCK = 38;
        public const int LOCATION_ID_WESTBROOK_TOWN_CENTER = 39;
        public const int LOCATION_ID_WESTBROOK_GENERAL_STORE = 40;
        public const int LOCATION_ID_WESTBROOK_CHAPEL = 41;
        public const int LOCATION_ID_WESTBROOK_CEMETARY = 42;
        public const int LOCATION_ID_KINGS_ROAD = 43;
        public const int LOCATION_ID_VALLEY_NEAR_CASTLE = 44;
        public const int LOCATION_ID_CASTLE_GATES = 45;
        public const int LOCATION_ID_WEST_COURTYARD = 46;
        public const int LOCATION_ID_GARDNERS_HOME = 47;
        public const int LOCATION_ID_EAST_COUTYARD = 48;
        public const int LOCATION_ID_CASTLE_GARDENS = 49;
        public const int LOCATION_ID_CASTLE_SHRINE = 50;
        public const int LOCATION_ID_CASTLE_GRAND_HALL = 51;
        public const int LOCATION_ID_CASTLE_DINING_HALL = 52;
        public const int LOCATION_ID_CASTLE_UPPER_FLOOR = 53;
        public const int LOCATION_ID_CASTLE_BEDROOM = 54;
        public const int LOCATION_ID_CASTLE_THRONE_ROOM = 55;
        public const int LOCATION_ID_CASTLE_VAULT = 56;
        public const int LOCATION_ID_LOST_ROAD = 57;
        public const int LOCATION_ID_EASTERN_LOST_RUINS = 58;
        public const int LOCATION_ID_SOUTHERN_BROKEN_BUILDING = 59;
        public const int LOCATION_ID_WESTERN_LOST_RUINS = 60;
        public const int LOCATION_ID_NORTHERN_BROKEN_BUILDING = 61;
        public const int LOCATION_ID_FINAL_LOST_RUINS = 62;
        public const int LOCATION_ID_ALTAR_DRAGON = 63;
        public const int LOCATION_ID_PEDESTAL = 64;
        public const int LOCATION_ID_DARK_PORTAL = 65;
        public const int LOCATION_ID_EAST_GUARD_POST = 66;

        static World()
        {
            PopulateItems();
            PopulateMonsters();
            PopulateQuests();
            PopulateLocations();
        }

        private static void PopulateItems()
        {
            _items.Add(new Weapon(ITEM_ID_BROKEN_SWORD, "Broken sword", "Broken swords", 1, 0, 5, 5));
            _items.Add(new Item(ITEM_ID_RAT_TAIL, "Rat tail", "Rat tails", 1));
            _items.Add(new Item(ITEM_ID_PIECE_OF_FUR, "Piece of fur", "Pieces of fur", 1));
            _items.Add(new Item(ITEM_ID_SNAKE_FANG, "Snake fang", "Snake fangs", 1));
            _items.Add(new Item(ITEM_ID_SNAKESKIN, "Snakeskin", "Snakeskins", 2));
            _items.Add(new Weapon(ITEM_ID_CLUB, "Club", "Clubs", 2, 3, 10, 8));
            _items.Add(new HealingPotion(ITEM_ID_HEALING_POTION, "Healing potion", "Healing potions", 5, 2, 8));
            _items.Add(new Item(ITEM_ID_SPIDER_FANG, "Spider fang", "Spider fangs", 1));
            _items.Add(new Item(ITEM_ID_SPIDER_SILK, "Spider silk", "Spider silks", 1));
            _items.Add(new Item(ITEM_ID_ADVENTURER_PASS, "Adventurer pass", "Adventurer passes", UNSELLABLE_ITEM_PRICE));
            _items.Add(new HealingPotion(ITEM_ID_GREATER_HEALING_POTION, "Greater Healing potion", "Greater Healing potions", 15, 3, 25));
            _items.Add(new DamageMagicScroll(ITEM_ID_SCROLL_MINOR_FIREBALL, "Scroll of Minor Fireball", "Scrolls of Minor Fireball", 2, 3, 5, 10));
            _items.Add(new Item(ITEM_ID_TROLL_BLOOD, "Flask of troll blood", "Flasks of troll blood", 38));
            _items.Add(new Item(ITEM_ID_GREEN_JELLY, "Green jelly", "Green jelly", 3));
            _items.Add(new Item(ITEM_ID_HUMAN_BONES, "Human bones", "Human bones", 22));
            _items.Add(new Item(ITEM_ID_ROTTING_SKULL, "Rotting skull", "Rotting skulls", 41));
            _items.Add(new Item(ITEM_ID_BROKEN_HELMET, "Broken helmet", "Broken helmets", 17));
            _items.Add(new Weapon(ITEM_ID_DAMAGED_AXE, "Damaged axe", "Damaged axes", 1, 0, 12, 50));
            _items.Add(new Item(ITEM_ID_WISP_FRAGMENT, "Wisp fragment", "Wisp fragments", 7));
            _items.Add(new Item(ITEM_ID_LARGE_BRANCH, "Large branch", "Large branches", 4));
            _items.Add(new Item(ITEM_ID_SPIKED_COLLAR, "Spiked collar", "Spiked collar", 7));
            _items.Add(new Weapon(ITEM_ID_SHARP_SWORD, "Sharp sword", "Sharp swords", 4, 10, 15, 250));
            _items.Add(new Item(ITEM_ID_DRAGONHIDE, "Dragonhide", "Dragonhides", 120));
            _items.Add(new Item(ITEM_ID_WOLF_FANG, "Wolf fang", "Wolf fangs", 25));
            _items.Add(new Weapon(ITEM_ID_VORPAL_SWORD, "Vorpal sword", "Vorpal swords", 8, 35, 50, 3000));
            _items.Add(new Item(ITEM_ID_CURSED_RING, "Cursed ring", "Cursed rings", 99));
            _items.Add(new Weapon(ITEM_ID_LONG_BOW, "Long bow", "Long bows", 4, 10, 25, 400));
            _items.Add(new Item(ITEM_ID_COIN_PURSE, "Coin purse", "Coin purses", 80));
            _items.Add(new Item(ITEM_ID_PAN_PIPES, "Pan pipes", "Pan pipes", 33));
            _items.Add(new Item(ITEM_ID_KOBOLD_TAIL, "Kobold tail", "Kobold tails", 6));
            _items.Add(new Weapon(ITEM_ID_SPIKED_CLUB, "Spiked club", "Spiked clubs", 3, 7, 12, 50));
            _items.Add(new Item(ITEM_ID_BUNDLE_OF_STRAW, "Bundle of straw", "Bundles of straw", 15));
            _items.Add(new Item(ITEM_ID_GIANT_MOTH_WINGS, "Giant moth wing", "Giant moth wings", 320));
            _items.Add(new Item(ITEM_ID_DAMAGED_BOOK, "Damage book", "Damaged books", 19));
            _items.Add(new Item(ITEM_ID_BANDAGES, "Bandage", "Bandages", 16));
            _items.Add(new Item(ITEM_ID_SCARAB_LEGS, "Scarab leg", "Scarab legs", 22));
            _items.Add(new Item(ITEM_ID_WORM_TOOTH, "Worm tooth", "Worm teeth", 99));
            _items.Add(new Item(ITEM_ID_ELVEN_BROOCH, "Elven brooch", "Elven brooches", 220));
            _items.Add(new Item(ITEM_ID_MANA_POTION, "Mana potion", "Mana potions", 75));
            _items.Add(new Item(ITEM_ID_BLACK_GAUNTLET, "Black gauntlet", "Black gaunlets", 80));
            _items.Add(new Item(ITEM_ID_CENTAUR_HOOF, "Centaur hoof", "Centaur hooves", 46));
            _items.Add(new Item(ITEM_ID_WYVERN_WINGS, "Wyvern wing", "Wyvern wings", 170));
            _items.Add(new Item(ITEM_ID_WYVERN_TAIL, "Wyvern tail", "Wyvern tails", 340));
            _items.Add(new Item(ITEM_ID_GIANT_FEATHER, "Giant feather", "Giant feathers", 620));
            _items.Add(new Item(ITEM_ID_STONE_OF_TRUTH, "Stone of Truth", "Stones of Truth", 500)); //mimic loot
            _items.Add(new Item(ITEM_ID_BURNT_HAIR, "Burnt hair", "Burnt hair", 35));
            _items.Add(new Weapon(ITEM_ID_SILVER_LONGSWORD, "Silver longsword", "Silver longswords", 5, 20, 30, 750));
            _items.Add(new Item(ITEM_ID_TOME_OF_POWER, "Tome of Power", "Tomes of Powers", 1000));
            _items.Add(new Item(ITEM_ID_EYE_OF_NEWT, "Eye of newt", "Eyes of newt", 62));
            _items.Add(new Item(ITEM_ID_LIFEDRINKER_SKULL, "Lifedrinker skull", "Lifedrinker skulls", 460));
            _items.Add(new Weapon(ITEM_ID_CURSED_STAFF, "Cursed staff", "Cursed staves", 4, 6, 24, 320));
            _items.Add(new Item(ITEM_ID_LIZARD_TAIL, "Lizard tail", "Lizard tails", 80));
            _items.Add(new Item(ITEM_ID_ASHES, "Ashes", "Ashes", 3));
            _items.Add(new Item(ITEM_ID_RUBY, "Cracked ruby", "Cracked rubies", 1500));
            _items.Add(new Item(ITEM_ID_CRACKED_OBSIDIAN, "Cracked obsidian", "Cracked obsidians", 275));
            _items.Add(new Item(ITEM_ID_RED_HAT, "Red gnome hat", "Red gnome hats", 25));
            _items.Add(new Item(ITEM_ID_FAERIE_DUST, "Faerie dust", "Faerie dust", 22));
            _items.Add(new Item(ITEM_ID_ORANGE_MUSHROOM, "Orange mushroom", "Orange mushrooms", 41));
            _items.Add(new Item(ITEM_ID_HARPY_FEATHER, "Harpy feather", "Harpy feathers", 35));
            _items.Add(new Weapon(ITEM_ID_TRIDANT, "Tridant", "Tridants", 6, 22, 28, 450));
            _items.Add(new Item(ITEM_ID_EMERALD_RING, "Emerald ring", "Emerald rings", 280));
            _items.Add(new Item(ITEM_ID_GOLDEN_RING, "Gold ring", "Gold rings", 160));
            _items.Add(new Item(ITEM_ID_BEAR_PELT, "Bear pelt", "Bear pelts", 95));
        }

        private static void PopulateMonsters()
        {
            Monster rat = new Monster(MONSTER_ID_RAT, "Rat", 5, 3, 10, 3, 3);
            rat.LootTable.Add(new LootItem(ItemByID(ITEM_ID_RAT_TAIL), 75, false));
            rat.LootTable.Add(new LootItem(ItemByID(ITEM_ID_PIECE_OF_FUR), 75, true));

            Monster snake = new Monster(MONSTER_ID_SNAKE, "Snake", 5, 3, 10, 3, 3);
            snake.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SNAKE_FANG), 75, false));
            snake.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SNAKESKIN), 75, true));

            Monster giantSpider = new Monster(MONSTER_ID_GIANT_SPIDER, "Giant spider", 20, 5, 40, 10, 10);
            giantSpider.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SPIDER_FANG), 75, true));
            giantSpider.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SPIDER_SILK), 25, false));

            Monster troll = new Monster(MONSTER_ID_TROLL, "Troll", 30, 50, 40, 120, 120);
            troll.LootTable.Add(new LootItem(ItemByID(ITEM_ID_TROLL_BLOOD), 40, true));
            troll.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SPIKED_CLUB), 10, false));

            Monster greenSlime = new Monster(MONSTER_ID_GREEN_SLIME, "Green Slime", 2, 4, 2, 2, 2);
            troll.LootTable.Add(new LootItem(ItemByID(ITEM_ID_GREEN_JELLY), 100, true));

            Monster skeleton = new Monster(MONSTER_ID_SKELETON, "Skeleton", 8, 12, 1, 14, 14);
            skeleton.LootTable.Add(new LootItem(ItemByID(ITEM_ID_HUMAN_BONES), 60, true));
            skeleton.LootTable.Add(new LootItem(ItemByID(ITEM_ID_ROTTING_SKULL), 20, false));

            Monster wizard = new Monster(MONSTER_ID_WIZARD, "Wizard", 40, 200, 50, 65, 65);
            wizard.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SCROLL_MINOR_FIREBALL), 80, true));
            wizard.LootTable.Add(new LootItem(ItemByID(ITEM_ID_STONE_OF_TRUTH), 20, false));
            wizard.LootTable.Add(new LootItem(ItemByID(ITEM_ID_CURSED_RING), 30, false));
            wizard.LootTable.Add(new LootItem(ItemByID(ITEM_ID_MANA_POTION), 50, true));

            Monster zombie = new Monster(MONSTER_ID_ZOMBIE, "Zombie", 4, 6, 3, 18, 18);
            zombie.LootTable.Add(new LootItem(ItemByID(ITEM_ID_ROTTING_SKULL), 100, true));

            Monster grue = new Monster(MONSTER_ID_GRUE, "The Grue", 30, 500, 200, 150, 150);
            grue.LootTable.Add(new LootItem(ItemByID(ITEM_ID_HUMAN_BONES), 80, true));
            grue.LootTable.Add(new LootItem(ItemByID(ITEM_ID_PIECE_OF_FUR), 80, true));
            grue.LootTable.Add(new LootItem(ItemByID(ITEM_ID_EMERALD_RING), 20, false));

            Monster shadow = new Monster(MONSTER_ID_SHADOW, "Shadow", 15, 10, 0, 4, 4);

            Monster animatedArmor = new Monster(MONSTER_ID_ANIMATED_ARMOR, "Animated Armor", 7, 24, 18, 32, 32);
            animatedArmor.LootTable.Add(new LootItem(ItemByID(ITEM_ID_BROKEN_HELMET), 60, true));
            animatedArmor.LootTable.Add(new LootItem(ItemByID(ITEM_ID_BROKEN_SWORD), 40, false));

            Monster flyingAxe = new Monster(MONSTER_ID_FLYING_AXE, "Flying Axe", 10, 12, 3, 3, 3);
            flyingAxe.LootTable.Add(new LootItem(ItemByID(ITEM_ID_DAMAGED_AXE), 75, false));

            Monster wisp = new Monster(MONSTER_ID_WISP, "Wisp", 4, 4, 5, 7, 7);
            wisp.LootTable.Add(new LootItem(ItemByID(ITEM_ID_WISP_FRAGMENT), 100, true));

            Monster ent = new Monster(MONSTER_ID_ENT, "Ent", 16, 65, 34, 48, 48);
            ent.LootTable.Add(new LootItem(ItemByID(ITEM_ID_LARGE_BRANCH), 50, false));

            Monster rabidDog = new Monster(MONSTER_ID_RABID_DOG, "Rabid Dog", 3, 6, 2, 4, 4);
            rabidDog.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SPIKED_COLLAR), 60, false));

            Monster ogre = new Monster(MONSTER_ID_OGRE, "Ogre", 24, 20, 35, 38, 38);
            ogre.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SPIKED_CLUB), 10, false));

            Monster goblin = new Monster(MONSTER_ID_GOBLIN, "Goblin", 6, 5, 7, 6, 6);
            goblin.LootTable.Add(new LootItem(ItemByID(ITEM_ID_BROKEN_SWORD), 50, false));
            goblin.LootTable.Add(new LootItem(ItemByID(ITEM_ID_GOLDEN_RING), 10, false));

            Monster greenDragon = new Monster(MONSTER_ID_GREEN_DRAGON, "Green Dragon", 80, 500, 1000, 350, 350);
            greenDragon.LootTable.Add(new LootItem(ItemByID(ITEM_ID_DRAGONHIDE), 80, true));
            greenDragon.LootTable.Add(new LootItem(ItemByID(ITEM_ID_RUBY), 20, false));
            greenDragon.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SILVER_LONGSWORD), 75, false));

            Monster direWolf = new Monster(MONSTER_ID_DIRE_WOLF, "Dire Wolf", 16, 27, 15, 25, 25);
            direWolf.LootTable.Add(new LootItem(ItemByID(ITEM_ID_WOLF_FANG), 75, true));

            Monster deathKnight = new Monster(MONSTER_ID_DEATHKNIGHT, "Death Knight", 50, 250, 200, 200, 200);
            deathKnight.LootTable.Add(new LootItem(ItemByID(ITEM_ID_VORPAL_SWORD), 20, false));
            deathKnight.LootTable.Add(new LootItem(ItemByID(ITEM_ID_EMERALD_RING), 30, false));
            deathKnight.LootTable.Add(new LootItem(ItemByID(ITEM_ID_BLACK_GAUNTLET), 70, true));

            Monster wraith = new Monster(MONSTER_ID_WRAITH, "Wraith", 13, 33, 19, 21, 21);

            Monster orc = new Monster(MONSTER_ID_ORC, "Orc", 10, 20, 20, 16, 16);
            orc.LootTable.Add(new LootItem(ItemByID(ITEM_ID_LONG_BOW), 30, false));

            Monster thief = new Monster(MONSTER_ID_THIEF, "Thief", 6, 11, 23, 11, 11);
            thief.LootTable.Add(new LootItem(ItemByID(ITEM_ID_COIN_PURSE), 30, false));
            thief.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SHARP_SWORD), 10, false));

            Monster satyr = new Monster(MONSTER_ID_SATYR, "Satyr", 24, 28, 18, 33, 33);
            satyr.LootTable.Add(new LootItem(ItemByID(ITEM_ID_PAN_PIPES), 60, false));

            Monster kobold = new Monster(MONSTER_ID_KOBOLD, "Kobold", 5, 4, 4, 7, 7);
            kobold.LootTable.Add(new LootItem(ItemByID(ITEM_ID_KOBOLD_TAIL), 80, true));

            Monster bugBear = new Monster(MONSTER_ID_BUGBEAR, "Bugbear", 12, 22, 16, 19, 19);
            bugBear.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SPIKED_CLUB), 25, false));

            Monster scarecrow = new Monster(MONSTER_ID_SCARECROW, "Scarecrow", 9, 15, 8, 14, 14);
            scarecrow.LootTable.Add(new LootItem(ItemByID(ITEM_ID_BUNDLE_OF_STRAW), 40, false));

            Monster giantMoth = new Monster(MONSTER_ID_GIANT_MOTH, "Giant Moth", 24, 38, 15, 57, 57);
            giantMoth.LootTable.Add(new LootItem(ItemByID(ITEM_ID_GIANT_MOTH_WINGS), 30, false));

            Monster animatedBook = new Monster(MONSTER_ID_ANIMATED_BOOK, "Animated Book", 2, 1, 3, 3, 3);
            animatedBook.LootTable.Add(new LootItem(ItemByID(ITEM_ID_DAMAGED_BOOK), 50, false));

            Monster mummy = new Monster(MONSTER_ID_MUMMY, "Mummy", 14, 18, 4, 23, 23);
            mummy.LootTable.Add(new LootItem(ItemByID(ITEM_ID_BANDAGES), 40, false));

            Monster scarab = new Monster(MONSTER_ID_SCARAB, "Scarab", 9, 6, 6, 14, 14);
            scarab.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SCARAB_LEGS), 75, false));

            Monster giantWorm = new Monster(MONSTER_ID_GIANT_WORM, "Giant Worm", 35, 70, 45, 78, 78);
            giantWorm.LootTable.Add(new LootItem(ItemByID(ITEM_ID_WORM_TOOTH), 20, false));

            Monster darkElf = new Monster(MONSTER_ID_DARK_ELF, "Dark Elf", 24, 40, 34, 29, 29);
            darkElf.LootTable.Add(new LootItem(ItemByID(ITEM_ID_ELVEN_BROOCH), 20, false));
            darkElf.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SILVER_LONGSWORD), 20, false));

            Monster imp = new Monster(MONSTER_ID_IMP, "Imp", 8, 10, 13, 14, 14);
            imp.LootTable.Add(new LootItem(ItemByID(ITEM_ID_MANA_POTION), 30, false));

            Monster headlessHorseman = new Monster(MONSTER_ID_HEADLESS_HORSEMAN, "Headless Horseman", 40, 200, 320, 160, 160);
            headlessHorseman.LootTable.Add(new LootItem(ItemByID(ITEM_ID_SILVER_LONGSWORD), 70, false));

            Monster centaur = new Monster(MONSTER_ID_CENTAUR, "Centaur", 22, 45, 28, 35, 35);
            centaur.LootTable.Add(new LootItem(ItemByID(ITEM_ID_CENTAUR_HOOF), 80, true));
            centaur.LootTable.Add(new LootItem(ItemByID(ITEM_ID_LONG_BOW), 30, false));

            Monster wyvern = new Monster(MONSTER_ID_WYVERN, "Wyvern", 45, 200, 180, 150, 150);
            wyvern.LootTable.Add(new LootItem(ItemByID(ITEM_ID_WYVERN_TAIL), 10, false));
            wyvern.LootTable.Add(new LootItem(ItemByID(ITEM_ID_WYVERN_WINGS), 10, false));

            Monster roc = new Monster(MONSTER_ID_ROC, "Roc", 48, 175, 198, 178, 178);
            roc.LootTable.Add(new LootItem(ItemByID(ITEM_ID_GIANT_FEATHER), 30, false));

            Monster mimic = new Monster(MONSTER_ID_MIMIC, "Mimic", 22, 10, 130, 35, 35);
            mimic.LootTable.Add(new LootItem(ItemByID(ITEM_ID_STONE_OF_TRUTH), 30, false));

            Monster nightmare = new Monster(MONSTER_ID_NIGHTMARE, "Nightmare", 25, 80, 60, 75, 75);
            nightmare.LootTable.Add(new LootItem(ItemByID(ITEM_ID_ASHES), 100, true));

            Monster djinn = new Monster(MONSTER_ID_DJINN, "Djinn", 33, 130, 88, 72, 72);
            djinn.LootTable.Add(new LootItem(ItemByID(ITEM_ID_CURSED_RING), 20, false));

            Monster lich = new Monster(MONSTER_ID_LICH, "Lich", 125, 1000, 750, 180, 180);
            lich.LootTable.Add(new LootItem(ItemByID(ITEM_ID_ROTTING_SKULL), 80, true));
            lich.LootTable.Add(new LootItem(ItemByID(ITEM_ID_LIFEDRINKER_SKULL), 10, false));
            lich.LootTable.Add(new LootItem(ItemByID(ITEM_ID_RUBY), 10, false));

            Monster witch = new Monster(MONSTER_ID_WITCH, "Witch", 22, 40, 35, 37, 37);
            witch.LootTable.Add(new LootItem(ItemByID(ITEM_ID_EYE_OF_NEWT), 100, true));

            Monster necromancer = new Monster(MONSTER_ID_NECROMANCER, "Necromancer", 25, 35, 60, 34, 34);
            necromancer.LootTable.Add(new LootItem(ItemByID(ITEM_ID_CURSED_STAFF), 30, false));

            Monster lizardman = new Monster(MONSTER_ID_LIZARDMAN, "Lizardman", 20, 35, 57, 16, 16);
            lizardman.LootTable.Add(new LootItem(ItemByID(ITEM_ID_LIZARD_TAIL), 60, false));

            Monster fireElemental = new Monster(MONSTER_ID_FIRE_ELEMENTAL, "Fire Elemental", 38, 70, 25, 65, 65);

            Monster golem = new Monster(MONSTER_ID_GOLEM, "Golem", 50, 100, 79, 86, 86);

            Monster gnome = new Monster(MONSTER_ID_GNOME, "Gnome", 7, 12, 9, 8, 8);
            gnome.LootTable.Add(new LootItem(ItemByID(ITEM_ID_RED_HAT), 30, false));

            Monster pixie = new Monster(MONSTER_ID_PIXIE, "Pixie", 4, 2, 4, 3, 3);
            pixie.LootTable.Add(new LootItem(ItemByID(ITEM_ID_FAERIE_DUST), 50, false));

            Monster dryad = new Monster(MONSTER_ID_DRYAD, "Dryad", 12, 18, 16, 23, 23);
            dryad.LootTable.Add(new LootItem(ItemByID(ITEM_ID_GOLDEN_RING), 10, false));

            Monster harpy = new Monster(MONSTER_ID_HARPY, "Harpy", 15, 34, 22, 19, 19);
            harpy.LootTable.Add(new LootItem(ItemByID(ITEM_ID_HARPY_FEATHER), 40, false));

            Monster naga = new Monster(MONSTER_ID_NAGA, "Naga", 14, 28, 23, 20, 20);
            naga.LootTable.Add(new LootItem(ItemByID(ITEM_ID_TRIDANT), 30, false));

            Monster nymph = new Monster(MONSTER_ID_NYMPH, "Nymph", 9, 20, 17, 22, 22);
            nymph.LootTable.Add(new LootItem(ItemByID(ITEM_ID_FAERIE_DUST), 80, false));

            Monster naiad = new Monster(MONSTER_ID_NAIAD, "Naiad", 12, 25, 16, 26, 26);

            Monster direbear = new Monster(MONSTER_ID_DIRE_BEAR, "Direbear", 25, 48, 61, 72, 72);
            direbear.LootTable.Add(new LootItem(ItemByID(ITEM_ID_BEAR_PELT), 20, false));

            _monsters.Add(rat);
            _monsters.Add(snake);
            _monsters.Add(giantSpider);
            _monsters.Add(greenSlime);
            _monsters.Add(troll);
            _monsters.Add(skeleton);
            _monsters.Add(wizard);
            _monsters.Add(zombie);
            _monsters.Add(grue);
            _monsters.Add(shadow);
            _monsters.Add(animatedArmor);
            _monsters.Add(flyingAxe);
            _monsters.Add(wisp);
            _monsters.Add(ent);
            _monsters.Add(rabidDog);
            _monsters.Add(ogre);
            _monsters.Add(goblin);
            _monsters.Add(greenDragon); 
            _monsters.Add(direWolf);
            _monsters.Add(deathKnight);
            _monsters.Add(wraith);
            _monsters.Add(orc);
            _monsters.Add(thief);
            _monsters.Add(satyr);
            _monsters.Add(kobold);
            _monsters.Add(bugBear);
            _monsters.Add(scarecrow);
            _monsters.Add(giantMoth);
            _monsters.Add(animatedBook);
            _monsters.Add(mummy);
            _monsters.Add(scarab);
            _monsters.Add(giantWorm);
            _monsters.Add(darkElf);
            _monsters.Add(imp);
            _monsters.Add(headlessHorseman);
            _monsters.Add(centaur);
            _monsters.Add(wyvern);
            _monsters.Add(roc);
            _monsters.Add(mimic);
            _monsters.Add(nightmare);
            _monsters.Add(djinn);
            _monsters.Add(lich);
            _monsters.Add(witch);
            _monsters.Add(necromancer);
            _monsters.Add(lizardman);
            _monsters.Add(fireElemental);
            _monsters.Add(golem);
            _monsters.Add(gnome);
            _monsters.Add(pixie);
            _monsters.Add(dryad);
            _monsters.Add(harpy);
            _monsters.Add(naga);
            _monsters.Add(nymph);
            _monsters.Add(naiad);
            _monsters.Add(direbear);
        }

        private static void PopulateQuests()
        {
            Quest clearAlchemistGarden =
                new Quest(
                    QUEST_ID_CLEAR_ALCHEMIST_GARDEN,
                    "Clear the alchemist's garden (repeatable)",
                    "Kill rats in the alchemist's garden and bring back 3 rat tails. You will receive a healing potion and 10 gold pieces.", 20, 10);

            clearAlchemistGarden.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(ITEM_ID_RAT_TAIL), 3));

            clearAlchemistGarden.RewardItem = ItemByID(ITEM_ID_HEALING_POTION);
            clearAlchemistGarden.IsRepeatable = true;

            Quest clearFarmersField =
                new Quest(
                    QUEST_ID_CLEAR_FARMERS_FIELD,
                    "Clear the farmer's field",
                    "Kill snakes in the farmer's field and bring back 3 snake fangs. You will receive an adventurer's pass and 20 gold pieces.", 20, 20);

            clearFarmersField.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(ITEM_ID_SNAKE_FANG), 3));

            clearFarmersField.RewardItem = ItemByID(ITEM_ID_ADVENTURER_PASS);

            _quests.Add(clearAlchemistGarden);
            _quests.Add(clearFarmersField);
        }

        private static void PopulateLocations()
        {
            // Create each location
            Location home = new Location(LOCATION_ID_HOME, "Home", "Your house. You really need to clean up the place.");

            Location backAlley = new Location(LOCATION_ID_BACK_ALLEY, "Back Alley", "A Back alley. This place stinks as always." +
                " Bob the Rat-Catcher is around");

            Vendor bobTheRatCatcher = new Vendor("Bob the Rat-Catcher");
            bobTheRatCatcher.AddItemToInventory(ItemByID(ITEM_ID_PIECE_OF_FUR), 5);
            bobTheRatCatcher.AddItemToInventory(ItemByID(ITEM_ID_RAT_TAIL), 3);
            bobTheRatCatcher.AddItemToInventory(ItemByID(ITEM_ID_CLUB), 1);

            backAlley.VendorWorkingHere = bobTheRatCatcher;

            Location sideRoad = new Location(LOCATION_ID_SIDE_ROAD, "Side Road", "A small side road that leads to the market district" +
                "to the north.");
            sideRoad.AddMonster(MONSTER_ID_GREEN_SLIME, 30);
            sideRoad.AddMonster(MONSTER_ID_RABID_DOG, 70);

            Location marketDistrict = new Location(LOCATION_ID_MARKET_DISTRICT, "Market District", "The place is bustling with activity." +
                "People are running around everywhere carrying various goods. You can see the General Store to the north.");

            Location deadEnd = new Location(LOCATION_ID_DEAD_END, "Dead End", "The road ends here.");
            deadEnd.AddMonster(MONSTER_ID_KOBOLD, 100);

            Location generalStore = new Location(LOCATION_ID_GENERAL_STORE, "General Store", "The General Store has many goods but most" +
                "of them do not pertain to adventuring unfortunately.");

            Location archeryRange = new Location(LOCATION_ID_ARCHERY_RANGE, "Archery Range", "Three targets sit in the distance," +
                "with a man by the name of Jacob shooting at them.");

            Location townSquare = new Location(LOCATION_ID_TOWN_SQUARE, "Town square", "You see a large fountain.");

            Location northRoad = new Location(LOCATION_ID_NORTHERN_ROAD, "The Northern Road", "The road continues northwards. The " +
                "town can be seen behind you.");

            Location westSuburbs = new Location(LOCATION_ID_WEST_SUBURBS, "West Suburbs", "Small cottages dot the landscape.");

            Location largeHill = new Location(LOCATION_ID_LARGE_HILL, "Large Hill", "Atop the hill, you can see the town to the " +
                "south of you, as well as a large tower to the west. To the north is a large cliff and to the north east you can " +
                "see a massive mountain. A small pond can be seen to the east.");
            largeHill.AddMonster(MONSTER_ID_OGRE, 50);
            largeHill.AddMonster(MONSTER_ID_GNOME, 20);
            largeHill.AddMonster(MONSTER_ID_KOBOLD, 30);

            Location cliff = new Location(LOCATION_ID_CLIFF, "Cliff", "You can see a small field of dirt and mud beneath you. You " +
                "might be able to climb down safetly but you won't be able to get back up this way.");
            cliff.AddMonster(MONSTER_ID_HARPY, 90);
            cliff.AddMonster(MONSTER_ID_WYVERN, 10);

            Location rollingHills = new Location(LOCATION_ID_ROLLING_HILLS, "Rolling Hills", "The hills are numerous as you go up " +
                "and down constantly.");
            rollingHills.AddMonster(MONSTER_ID_THIEF, 40);
            rollingHills.AddMonster(MONSTER_ID_CENTAUR, 30);
            rollingHills.AddMonster(MONSTER_ID_GOBLIN, 30);

            Location peacefulPond = new Location(LOCATION_ID_PEACEFUL_POND, "Peaceful Pond", "There is a calm pond. The waters are " +
                "particularly still.");

            Location collosalCaveEntrance= new Location(LOCATION_ID_COLLISAL_CAVE_ENTRANCE, "Collisal Cave Entrance", "You see the " +
                "entrance to a collisal cave.");
            collosalCaveEntrance.AddMonster(MONSTER_ID_DIRE_BEAR, 40);
            collosalCaveEntrance.AddMonster(MONSTER_ID_DIRE_WOLF, 40);
            collosalCaveEntrance.AddMonster(MONSTER_ID_GRUE, 10);
            collosalCaveEntrance.AddMonster(MONSTER_ID_BUGBEAR, 20);

            Location trifoxTrail = new Location(LOCATION_ID_TRIFOX_TRAIL, "Trifox Trail", "The path splits in three directions. " +
                "To the north, you can see a forest. To the west is a river. And to the east is the town.");
            trifoxTrail.AddMonster(MONSTER_ID_GOBLIN, 30);
            trifoxTrail.AddMonster(MONSTER_ID_ORC, 40);
            trifoxTrail.AddMonster(MONSTER_ID_BUGBEAR, 30);

            Location easternTrail = new Location(LOCATION_ID_EASTERN_TRAIL, "Eastern Trail", "The path continues to the east with " +
                "a small branch to the south.");
            easternTrail.AddMonster(MONSTER_ID_ORC, 30);
            easternTrail.AddMonster(MONSTER_ID_THIEF, 70);

            Location brokenPass = new Location(LOCATION_ID_BROKEN_PASS, "Broken Pass", "The pass is sandwiched between two large " +
                "mountains. The sun is barely visible and it is quite dark.");
            brokenPass.AddMonster(MONSTER_ID_SHADOW, 20);
            brokenPass.AddMonster(MONSTER_ID_LIZARDMAN, 30);
            brokenPass.AddMonster(MONSTER_ID_FIRE_ELEMENTAL, 20);
            brokenPass.AddMonster(MONSTER_ID_DARK_ELF, 30);

            Location desertEntrance = new Location(LOCATION_ID_DESERT_ENTRANCE, "Desert Entrance", "The vast expanse of the desert" +
                " can be seen in front of you. The sweltering sun beats on your back.");
            desertEntrance.AddMonster(MONSTER_ID_GIANT_WORM, 20);
            desertEntrance.AddMonster(MONSTER_ID_GOLEM, 20);
            desertEntrance.AddMonster(MONSTER_ID_SCARAB, 30);
            desertEntrance.AddMonster(MONSTER_ID_SKELETON, 10);
            desertEntrance.AddMonster(MONSTER_ID_MUMMY, 20);

            Location alchemistHut = new Location(LOCATION_ID_ALCHEMIST_HUT, "Alchemist's hut", "There are many strange plants on the shelves. " +
                "Venessa smiles at you and offers you to browse her goods.");
            alchemistHut.QuestAvailableHere = QuestByID(QUEST_ID_CLEAR_ALCHEMIST_GARDEN);

            Vendor venessaTheAlchemist = new Vendor("Venessa the Alchemist");
            venessaTheAlchemist.AddItemToInventory(ItemByID(ITEM_ID_HEALING_POTION), 5);
            venessaTheAlchemist.AddItemToInventory(ItemByID(ITEM_ID_GREATER_HEALING_POTION), 1);
            venessaTheAlchemist.AddItemToInventory(ItemByID(ITEM_ID_SNAKESKIN), 3);
            venessaTheAlchemist.AddItemToInventory(ItemByID(ITEM_ID_SCROLL_MINOR_FIREBALL), 1);

            alchemistHut.VendorWorkingHere = venessaTheAlchemist;

            Location alchemistsGarden = new Location(LOCATION_ID_ALCHEMISTS_GARDEN, "Alchemist's garden", "Many plants are growing here.");
            alchemistsGarden.AddMonster(MONSTER_ID_RAT, 100);

            Location farmhouse = new Location(LOCATION_ID_FARMHOUSE, "Farmhouse", "There is a small farmhouse, with a farmer in front.");
            farmhouse.QuestAvailableHere = QuestByID(QUEST_ID_CLEAR_FARMERS_FIELD);

            Location farmersField = new Location(LOCATION_ID_FARM_FIELD, "Farmer's field", "You see rows of vegetables growing here.", null, 3);
            farmersField.AddMonster(MONSTER_ID_SNAKE, 60);
            farmersField.AddMonster(MONSTER_ID_RAT, 20);
            farmersField.AddMonster(MONSTER_ID_SCARECROW, 20);

            Location eastGuardPost = new Location(LOCATION_ID_WEST_GUARD_POST, "Guard Post", "There is a large, tough-looking guard here."
                , ItemByID(ITEM_ID_BROKEN_SWORD));

            Location westGuardPost = new Location(LOCATION_ID_EAST_GUARD_POST, "Guard Post", "A large guard greets you and lets you pass.");

            Location mudfield = new Location(LOCATION_ID_MUDFIELD, "Mudfield", "There is a large open space filled with dirt.");
            mudfield.AddMonster(MONSTER_ID_PIXIE, 60);
            mudfield.AddMonster(MONSTER_ID_NYMPH, 20);
            mudfield.AddMonster(MONSTER_ID_WISP, 20);

            Location forgottenTower = new Location(LOCATION_ID_THE_FORGOTTEN_TOWER, "The Forgotten Tower", "A massive tower stands " +
                "before you, reaching towards the heavens. The tower is composed entirely of some dark coloured stone and looks " +
                "rather imposing.");
            forgottenTower.AddMonster(MONSTER_ID_GOLEM, 50);
            forgottenTower.AddMonster(MONSTER_ID_IMP, 20);
            forgottenTower.AddMonster(MONSTER_ID_FIRE_ELEMENTAL, 20);
            forgottenTower.AddMonster(MONSTER_ID_DEATHKNIGHT, 10);

            Location lessTraveledRoad = new Location(LOCATION_ID_LESS_TRAVELED_ROAD, "Less Traveled Road", "The road looks like no" +
                " one has been here for a while. You can see a large tower in the distance.");
            lessTraveledRoad.AddMonster(MONSTER_ID_OGRE, 70);
            lessTraveledRoad.AddMonster(MONSTER_ID_WISP, 30);

            Location stairsToTheSpire = new Location(LOCATION_ID_STAIRS_TO_THE_SPIRE, "Spiral Stairs", "The stairs spiral up the tower, " +
                "seeming to drag on forever.");
            stairsToTheSpire.AddMonster(MONSTER_ID_ANIMATED_ARMOR, 30);
            stairsToTheSpire.AddMonster(MONSTER_ID_ANIMATED_BOOK, 30);
            stairsToTheSpire.AddMonster(MONSTER_ID_FLYING_AXE, 20);
            stairsToTheSpire.AddMonster(MONSTER_ID_WITCH, 10);
            stairsToTheSpire.AddMonster(MONSTER_ID_MIMIC, 10);

            Location forgottenTowerSpire = new Location(LOCATION_ID_THE_SPIRE, "Spire", "Lightning crackles around you at the top of " +
                "the spire. The noise is deafening. You cannot see the ground as the dark clouds block your line of sight.");
            forgottenTowerSpire.AddMonster(MONSTER_ID_WIZARD, 100);

            Location bridge = new Location(LOCATION_ID_BRIDGE, "Bridge", "A stone bridge crosses a wide river.");
            bridge.AddMonster(MONSTER_ID_TROLL, 100);

            Location entranceYognarWoods = new Location(LOCATION_ID_ENTRANCE_TO_YOGNAR_WOODS, "Entrance to Yognar Woods", "The entrance to Yognar Woods. " +
                "The trees stare at you menancingly.");
            entranceYognarWoods.AddMonster(MONSTER_ID_DRYAD, 70);
            entranceYognarWoods.AddMonster(MONSTER_ID_ENT, 30);

            Location inTheWoods = new Location(LOCATION_ID_IN_THE_WOODS, "In the Woods", "Trees can be seen everywhere. Trees. " +
                "So many trees. All you can see are trees.");
            inTheWoods.AddMonster(MONSTER_ID_CENTAUR, 10);
            inTheWoods.AddMonster(MONSTER_ID_DIRE_BEAR, 10);
            inTheWoods.AddMonster(MONSTER_ID_DIRE_WOLF, 10);
            inTheWoods.AddMonster(MONSTER_ID_GREEN_SLIME, 10);
            inTheWoods.AddMonster(MONSTER_ID_GREEN_DRAGON, 10);
            inTheWoods.AddMonster(MONSTER_ID_NYMPH, 10);
            inTheWoods.AddMonster(MONSTER_ID_SATYR, 10);
            inTheWoods.AddMonster(MONSTER_ID_PIXIE, 10);
            inTheWoods.AddMonster(MONSTER_ID_WISP, 10);
            inTheWoods.AddMonster(MONSTER_ID_GIANT_SPIDER, 10);

            Location river = new Location(LOCATION_ID_RIVER_CROSSING, "River Crossing", "You can see a small town to the west.");
            river.AddMonster(MONSTER_ID_TROLL, 70);
            river.AddMonster(MONSTER_ID_NAGA, 30);

            Location riverUptrail = new Location(LOCATION_ID_RIVER_UPTRAIL, "Following River North", "The river continues.");
            riverUptrail.AddMonster(MONSTER_ID_NAGA, 50);
            riverUptrail.AddMonster(MONSTER_ID_NAIAD, 50);

            Location riverUptrailEnd= new Location(LOCATION_ID_RIVER_UPTRAIL_DEAD_END, "River End", "The river merges into a massive " +
                "body of water in the distant.");
            riverUptrailEnd.AddMonster(MONSTER_ID_NAIAD, 100);

            Location riverDowntrail = new Location(LOCATION_ID_RIVER_DOWNTRAIL, "Following River South", "You can see massive mountains " +
                "to the south from where the river emerges.");
            riverDowntrail.AddMonster(MONSTER_ID_NAGA, 100);

            //Location mountainEntrance = new Location(LOCATION_ID_MOUNTAIN_ENTRANCE, "Mountain Pass", "There is a large open space filled with dirt.");


            Location westBrookDock = new Location(LOCATION_ID_WESTBROOK_DOCK, "Westbrook Dock", "Your raft is tied to the dock. " +
                "Fishermen can be seen moving around, carrying fish.");

            Location westBrookTownCenter= new Location(LOCATION_ID_WESTBROOK_TOWN_CENTER, "Westbrook Town Center", "You find yourself " +
                "in the center of the small town.");

            Location westBrookGeneralStore = new Location(LOCATION_ID_WESTBROOK_GENERAL_STORE, "Westbrook General Store", "The general " +
                "store is filled with various goods. Some goods are surprisingly exotic.");

            Location cemetary = new Location(LOCATION_ID_WESTBROOK_CEMETARY, "Westbrook Cemetary", "Stone graves rise out of the " +
                "ground. A chill air fills the air.");
            cemetary.AddMonster(MONSTER_ID_SKELETON, 35);
            cemetary.AddMonster(MONSTER_ID_ZOMBIE, 30);
            cemetary.AddMonster(MONSTER_ID_NECROMANCER, 10);
            cemetary.AddMonster(MONSTER_ID_WRAITH, 10);
            cemetary.AddMonster(MONSTER_ID_SHADOW, 10);
            cemetary.AddMonster(MONSTER_ID_LICH, 5);

            Location chapel = new Location(LOCATION_ID_MUDFIELD, "Chapel", "You find yourself in a humble chapel. Art to various " +
                "deities can be seen here.");

            Location kingsRoad = new Location(LOCATION_ID_KINGS_ROAD, "King's Road", "The road leads towards Lorthar Castle.");
            kingsRoad.AddMonster(MONSTER_ID_THIEF, 30);
            kingsRoad.AddMonster(MONSTER_ID_DARK_ELF, 30);
            kingsRoad.AddMonster(MONSTER_ID_RABID_DOG, 40);

            Location valleyNearCastle = new Location(LOCATION_ID_VALLEY_NEAR_CASTLE, "Valley Near Lorthar Castle", "The road passes " +
                "through the valley. Lorthar castle can be seen to the north. Westbrook is to the south.");
            valleyNearCastle.AddMonster(MONSTER_ID_DIRE_BEAR, 30);
            valleyNearCastle.AddMonster(MONSTER_ID_GOBLIN, 30);
            valleyNearCastle.AddMonster(MONSTER_ID_BUGBEAR, 40);

            Location castleGates = new Location(LOCATION_ID_CASTLE_GATES, "Castle Gates", "Two massive gates bar the way into the " +
                "castle. You can see the courtyards to the sides.");

            Location westCourtyard = new Location(LOCATION_ID_WEST_COURTYARD, "West Courtyard", "Large flowers are blooming " +
                "all around in the courtyard. Many beautiful shrubs are growing here.");

            Location gardnersHouse = new Location(LOCATION_ID_GARDNERS_HOME, "Gardner's Home", "The gardner resides in here. He " +
                "welcomes you to his home and provides hospitality to you.");

            Location eastCourtyard = new Location(LOCATION_ID_EAST_COUTYARD, "East Courtyard", "The courtyard is decorated with " +
                "many various trees.");

            Location castleGardens = new Location(LOCATION_ID_CASTLE_GARDENS, "Castle Gardens", "The gardens are filled with " +
                "an uncountable amount of flowers. It looks like the gardner has been here recently.");

            Location castleShrine = new Location(LOCATION_ID_CASTLE_SHRINE, "Shrine", "A large statue is decorated with many " +
                "candles and flowers. The statue depicts a woman holding a massive sword and shield in a heroic pose.");

            Location grandHall = new Location(LOCATION_ID_CASTLE_GRAND_HALL, "Grand Hall", "The massive hall dwarfs you. You " +
                "can see many works of art around the room and on the ceiling.");

            Location diningHall = new Location(LOCATION_ID_CASTLE_DINING_HALL, "Dining Hall", "A massive dining hall opens up " +
                "before you. The table can seat more people than you can count.");

            Location upperHall = new Location(LOCATION_ID_CASTLE_UPPER_FLOOR, "Upper Floor", "The upper floor of the castle " +
                "is filled with various doors but almost all of them are closed. A massive door opens up to the north.");

            Location castleBedroom = new Location(LOCATION_ID_CASTLE_BEDROOM, "Castle Bedroom", "You can see a large bedroom " +
                "with a large kingsize bed. Makes sense to you.");

            Location throneRoom = new Location(LOCATION_ID_CASTLE_BEDROOM, "Throne Room", "The King sits on his throne and welcomes " +
                "you.");

            Location castleVault = new Location(LOCATION_ID_CASTLE_VAULT, "Vault", "A massive treasure vault filled with treasure.");

            Location lostRoad = new Location(LOCATION_ID_LOST_ROAD, "Lost Road", "The path is incredibly worn. It looks like " +
                "no one has been here in ages.");
            lostRoad.AddMonster(MONSTER_ID_HEADLESS_HORSEMAN, 20);
            lostRoad.AddMonster(MONSTER_ID_NIGHTMARE, 50);
            lostRoad.AddMonster(MONSTER_ID_DARK_ELF, 30);

            Location eastLostRuins = new Location(LOCATION_ID_EASTERN_LOST_RUINS, "Lost Ruins", "Large ruins are scattered around. " +
                "There are many collapsed buildings around.");
            eastLostRuins.AddMonster(MONSTER_ID_GIANT_SPIDER, 70);
            eastLostRuins.AddMonster(MONSTER_ID_THIEF, 20);
            eastLostRuins.AddMonster(MONSTER_ID_BUGBEAR, 10);

            Location southernBrokenStructure = new Location(LOCATION_ID_SOUTHERN_BROKEN_BUILDING, "Broken Building", "The collapsed " +
                "building is filled with cracks in the walls and vines growing out of the ground.");
            southernBrokenStructure.AddMonster(MONSTER_ID_GOBLIN, 100);

            Location westernLostRuins = new Location(LOCATION_ID_WESTERN_LOST_RUINS, "Lost Ruins", "More broken down ruins are" +
                " scattered around the area.");
            westernLostRuins.AddMonster(MONSTER_ID_ZOMBIE, 30);
            westernLostRuins.AddMonster(MONSTER_ID_WRAITH, 30);
            westernLostRuins.AddMonster(MONSTER_ID_GREEN_SLIME, 40);

            Location northernBrokenStructure = new Location(LOCATION_ID_NORTHERN_BROKEN_BUILDING, "Broken Building", "A small chest " +
                "sits in the corner of this collapsed building.");
            northernBrokenStructure.AddMonster(MONSTER_ID_MIMIC, 100);

            Location finalLostRuins = new Location(LOCATION_ID_FINAL_LOST_RUINS, "Lost Ruins", "The buildings here are damaged " +
                "beyond repair and many beyond even recognition.");
            finalLostRuins.AddMonster(MONSTER_ID_WYVERN, 100);

            Location dragonAltar = new Location(LOCATION_ID_ALTAR_DRAGON, "Dragon Altar", "A titan of a dragon carved out of stone " +
                "sits here in prestine condition. Its size fills you with awe.");

            Location pedestal= new Location(LOCATION_ID_PEDESTAL, "Pedestal", "A large pedestal sits with a might sword sticking " +
                "out of it.");

            Location darkPortal = new Location(LOCATION_ID_DARK_PORTAL, "Dark Portal", "A purple void sits before you in a stone" +
                " wall, seemingly drawing you in.");
            darkPortal.AddMonster(MONSTER_ID_DEATHKNIGHT, 100);


            //Location spiderField = new Location(LOCATION_ID_SPIDER_FIELD, "Forest", "You see spider webs covering covering the trees in this forest.");
            //spiderField.AddMonster(MONSTER_ID_GIANT_SPIDER, 100);

            // Link the locations together
            home.LocationToNorth = townSquare;
            home.NorthTravelText = "You leave your home and make your way towards the town center.";
            home.LocationToEast = sideRoad;
            home.EastTravelText = "You make your way towards the side road that heads the long way to the market district.";
            home.LocationToSouth = farmersField;
            home.SouthTravelText = "You head towards the farmer's field to the south of your home.";
            home.LocationToWest = backAlley;
            home.WestTravelText = "You make your way into the backalley behind your home.";

            townSquare.LocationToNorth = northRoad;
            townSquare.NorthTravelText = "You leave town, heading out towards the big primary road to the north.";
            townSquare.LocationToSouth = home;
            townSquare.SouthTravelText = "You return to your home.";
            townSquare.LocationToEast = marketDistrict;
            townSquare.EastTravelText = "You make your way to the Market District.";
            townSquare.LocationToWest = westSuburbs;
            townSquare.WestTravelText = "You head towards the primary living space of the town.";

            sideRoad.LocationToEast = deadEnd;
            sideRoad.EastTravelText = "You head off the road towards a small set of raised ledges with no exit.";
            sideRoad.LocationToNorth = marketDistrict;
            sideRoad.NorthTravelText = "You head towards the market district.";
            sideRoad.LocationToWest = home;
            sideRoad.WestTravelText = "You head towards your home";

            backAlley.LocationToEast = home;
            backAlley.EastTravelText = "You head back to your home.";
            backAlley.LocationToNorth = westSuburbs;
            backAlley.NorthTravelText = "You leave the back alley and head for the main suburbs.";

            deadEnd.LocationToWest = sideRoad;
            deadEnd.WestTravelText = "You return the way you came.";

            marketDistrict.LocationToNorth = generalStore;
            marketDistrict.NorthTravelText = "You enter a small store named Ravens Goods.";
            marketDistrict.LocationToEast = eastGuardPost;
            marketDistrict.EastTravelText = "You head towards the guardpost that oversees the eastern wall.";
            marketDistrict.LocationToSouth = sideRoad;
            marketDistrict.SouthTravelText = "You head down the long winding path in the direction of your home.";
            marketDistrict.LocationToWest = townSquare;
            marketDistrict.WestTravelText = "You head towards the large fountain where the town center is located.";

            generalStore.LocationToSouth = marketDistrict;
            generalStore.SouthTravelText = "You exit the store.";

            eastGuardPost.LocationToWest = marketDistrict;
            eastGuardPost.WestTravelText = "You make your way into the Market District.";
            eastGuardPost.LocationToNorth = archeryRange;
            eastGuardPost.NorthTravelText = "You head towards the Archery Range.";
            eastGuardPost.LocationToEast = easternTrail;
            eastGuardPost.EastTravelText = "The guard lets you pass, warning you of the dangers of the Desert.";

            easternTrail.LocationToSouth = alchemistHut;
            easternTrail.SouthTravelText = "You follow a small winding path through the rugged sands towards a hut in the distance.";
            easternTrail.LocationToWest = eastGuardPost;
            easternTrail.WestTravelText = "You head down the primary road towards city.";
            easternTrail.LocationToEast = brokenPass;
            easternTrail.EastTravelText = "You make your way towards the broken cliffs in the distance.";

            archeryRange.LocationToSouth = eastGuardPost;
            archeryRange.SouthTravelText = "You leave the archer alone, seeing him score several direct hits, and you head south past the haybales.";

            brokenPass.LocationToWest = easternTrail;
            brokenPass.WestTravelText = "You head towards the worn out road in the distance.";
            brokenPass.LocationToEast = desertEntrance;
            brokenPass.EastTravelText = "You head towards the dull orange sands in the distance, the sun beating on your back.";

            desertEntrance.LocationToWest = brokenPass;
            desertEntrance.WestTravelText = "You leave the desert, thanksful to be free from the blistering sun.";

            northRoad.LocationToSouth = townSquare;
            northRoad.SouthTravelText = "You return to town.";
            northRoad.LocationToNorth = largeHill;
            northRoad.NorthTravelText = "You make your way towards the large hill in the distance.";

            largeHill.LocationToSouth = northRoad;
            largeHill.SouthTravelText = "You descend down the hill and head towards the main road.";
            largeHill.LocationToWest = cliff;
            largeHill.WestTravelText = "You head for a large cliff in the distance.";
            largeHill.LocationToEast = rollingHills;
            largeHill.EastTravelText = "You walk towards the collection of hills.";

            rollingHills.LocationToWest = largeHill;
            rollingHills.WestTravelText = "You travel towards the biggest hill in the area.";
            rollingHills.LocationToEast = peacefulPond;
            rollingHills.EastTravelText = "You continue past the hills and make your way towards a small pond you can see.";
            rollingHills.LocationToNorth = collosalCaveEntrance;
            rollingHills.NorthTravelText = "You head towards a massive cave you can see in the distance.";

            peacefulPond.LocationToWest = rollingHills;
            peacefulPond.WestTravelText = "You leave the pond and head back towards the many hills.";

            collosalCaveEntrance.LocationToSouth = rollingHills;
            collosalCaveEntrance.SouthTravelText = "You leave the cave entrance and head back to the hills to get a better vantage point.";

            cliff.LocationToSouth = mudfield;
            cliff.SouthTravelText = "You carefully climb down the cliff face. You're certainly not going to be climbing up that.";
            cliff.LocationToEast = largeHill;
            cliff.EastTravelText = "You leave the cliff and head towards the massive hill.";

            mudfield.LocationToEast = forgottenTower;
            mudfield.EastTravelText = "Leaving the mudfield, you make your way towards the tower you can see nearby.";

            forgottenTower.LocationToWest = mudfield;
            forgottenTower.WestTravelText = "You make your way through the forest and find yourself quickly in a field of dirt and mud.";
            forgottenTower.LocationToSouth = lessTraveledRoad;
            forgottenTower.SouthTravelText = "You head down a faint, overgrown path, one that no one has probably been down in months.";
            forgottenTower.LocationToNorth = stairsToTheSpire;
            forgottenTower.NorthTravelText = "You enter the tower and begin ascending the stairs, hearing the sound of lightning in the distance.";

            stairsToTheSpire.LocationToNorth = forgottenTowerSpire;
            stairsToTheSpire.NorthTravelText = "You finish ascending the tower and arrive at the great spire, lightning flashing all around suddenly.";
            stairsToTheSpire.LocationToSouth = forgottenTower;
            stairsToTheSpire.SouthTravelText = "You descend down the stairs, the sound of lightning disappearing.";

            forgottenTowerSpire.LocationToSouth = stairsToTheSpire;
            forgottenTowerSpire.SouthTravelText = "You leave the spire, lightning flashing all around you.";

            lessTraveledRoad.LocationToSouth = westSuburbs;
            lessTraveledRoad.SouthTravelText = "You head towards the western section of the town where the commonfolk live.";
            lessTraveledRoad.LocationToNorth = forgottenTower;
            lessTraveledRoad.NorthTravelText = "You make your way towards the distance tower, rumored to be where a powerful wizard lives.";
            //farmhouse.LocationToEast = townSquare;
            //farmhouse.LocationToWest = farmersField;

            farmersField.LocationToNorth = home;
            farmersField.NorthTravelText = "You return to your home, climbing over the nearby fence.";
            farmersField.LocationToWest = lostRoad;
            farmersField.WestTravelText = "You stumble across a path of unusually short and unhealthy grass and follow it.";

            alchemistHut.LocationToNorth = easternTrail;
            alchemistHut.NorthTravelText = "You return to the main path, bidding farewell to the alchemist.";
            alchemistHut.LocationToSouth = alchemistsGarden;
            alchemistHut.SouthTravelText = "You step into the garden and admire the various plants growing here.";

            alchemistsGarden.LocationToNorth = alchemistHut;
            alchemistsGarden.NorthTravelText = "You exit the garden and return to the alchemist's home.";

            westGuardPost.LocationToEast = westSuburbs;
            westGuardPost.EastTravelText = "You leave the guard post and return back to town.";
            westGuardPost.LocationToWest = bridge;
            westGuardPost.WestTravelText = "You pass by the guard and make way towards the bridge, fearful of what might be under or around it.";

            westSuburbs.LocationToNorth = lessTraveledRoad;
            westSuburbs.NorthTravelText = "You leave town, heading down a barely distinguishable road.";
            westSuburbs.LocationToSouth = backAlley;
            westSuburbs.SouthTravelText = "You head into the backalleys of town.";
            westSuburbs.LocationToEast = townSquare;
            westSuburbs.EastTravelText = "You head to the town fountain.";
            westSuburbs.LocationToWest = westGuardPost;
            westSuburbs.WestTravelText = "You make leave for the local guard post.";

            bridge.LocationToEast = westGuardPost;
            bridge.WestTravelText = "You cross over the bridge and head for the local town.";
            bridge.LocationToWest = trifoxTrail;
            bridge.WestTravelText = "You cautiously cross the bridge, watching for additional trolls.";

            trifoxTrail.LocationToEast = bridge;
            trifoxTrail.EastTravelText = "You head down the Trifox Trail in the direction of town.";
            trifoxTrail.LocationToNorth = entranceYognarWoods;
            trifoxTrail.NorthTravelText = "Heading north, you leave the primary trail and make way for Yognar Woods.";
            trifoxTrail.LocationToWest = river;
            trifoxTrail.WestTravelText = "You continue towards the surging river in the distance.";

            entranceYognarWoods.LocationToNorth = inTheWoods;
            entranceYognarWoods.NorthTravelText = "Deeper and deeper you go into the woods. You feel quite lost...";
            entranceYognarWoods.LocationToSouth = trifoxTrail;
            entranceYognarWoods.SouthTravelText = "You find an exit from the woods and leave as quickly as you can.";

            inTheWoods.LocationToSouth = entranceYognarWoods;
            inTheWoods.SouthTravelText = "You stumble around and think you find yourself near what you think is the entrance to the woods.";

            river.LocationToEast = trifoxTrail;
            river.EastTravelText = "You leave the river and head towards the Trifox Trail.";
            river.LocationToNorth = riverUptrail;
            river.NorthTravelText = "You follow the river north.";
            river.LocationToSouth = riverDowntrail;
            river.SouthTravelText = "You follow the river south.";
            river.LocationToWest = westBrookDock;
            river.WestTravelText = "Using a raft, you cross the river carefully. You make your way into the town.";

            riverUptrail.LocationToNorth = riverUptrailEnd;
            riverUptrail.NorthTravelText = "You continue following the river, following its bends and curves.";
            riverUptrail.LocationToSouth = river;
            riverUptrail.SouthTravelText = "You follow the river, returning near the Trifox Trail.";

            riverUptrailEnd.LocationToSouth = riverUptrail;
            riverUptrailEnd.SouthTravelText = "You gaze at the ocean before you turn around to head back upstream.";

            riverDowntrail.LocationToNorth = river;
            riverDowntrail.NorthTravelText = "You follow the river downstream.";
            //riverDowntrail.LocationToSouth = mountainEntrance;

            westBrookDock.LocationToEast = river;
            westBrookDock.EastTravelText = "Passing by the fishermen, you climb onto a raft and cross the stream.";
            westBrookDock.LocationToNorth = kingsRoad;
            westBrookDock.NorthTravelText = "You leave Westbrook and head down King's Road.";
            westBrookDock.LocationToWest = westBrookTownCenter;
            westBrookDock.WestTravelText = "You head to Westbrook's Town Center.";

            westBrookTownCenter.LocationToNorth = cemetary;
            westBrookTownCenter.NorthTravelText = "You stumble into the cemetary. No one has been here for a long time.";
            westBrookTownCenter.LocationToWest = chapel;
            westBrookTownCenter.WestTravelText = "You make your way towards the pristine looking structure in the distance.";
            westBrookTownCenter.LocationToSouth = westBrookGeneralStore;
            westBrookTownCenter.SouthTravelText = "A general store catches your eye and you head towards it.";
            westBrookTownCenter.LocationToEast = westBrookDock;
            westBrookTownCenter.EastTravelText = "You make your way to the docks.";

            chapel.LocationToEast = westBrookTownCenter;
            chapel.EastTravelText = "You leave the chapel and head back to the town center.";

            westBrookGeneralStore.LocationToNorth = westBrookTownCenter;
            westBrookGeneralStore.NorthTravelText = "You leave the store and return to the town center.";

            cemetary.LocationToSouth = westBrookTownCenter;
            cemetary.SouthTravelText = "You quickly leave the cemetary.";

            kingsRoad.LocationToSouth = westBrookDock;
            kingsRoad.SouthTravelText = "You head south on the King's Road and return to the docks of West Brook.";
            kingsRoad.LocationToNorth = valleyNearCastle;
            kingsRoad.NorthTravelText = "You continue north on the King's Road towards the castle you see in the distance.";

            valleyNearCastle.LocationToSouth = kingsRoad;
            valleyNearCastle.SouthTravelText = "You leave the valley, following the road.";
            valleyNearCastle.LocationToNorth = castleGates;
            valleyNearCastle.NorthTravelText = "You approach the castle in the distance.";

            castleGates.LocationToSouth = valleyNearCastle;
            castleGates.SouthTravelText = "You leave the gates and head for the valley.";
            castleGates.LocationToWest = westCourtyard;
            castleGates.WestTravelText = "You pass by the gates and head to the western coutyard.";
            castleGates.LocationToEast = eastCourtyard;
            castleGates.EastTravelText = "You pass by the gates and head to the eastern courtyard.";
            castleGates.LocationToNorth = grandHall;
            castleGates.NorthTravelText = "The guards let you pass through the gates and into the Grand Hall.";

            westCourtyard.LocationToNorth = gardnersHouse;
            westCourtyard.NorthTravelText = "You wander into a small cottage with a sign that reads 'The Gardner'.";
            westCourtyard.LocationToEast = castleGates;
            westCourtyard.EastTravelText = "You return to the castle gates.";

            gardnersHouse.LocationToSouth = westCourtyard;
            gardnersHouse.SouthTravelText = "You thank the gardner and leave his abode.";

            eastCourtyard.LocationToWest = castleGates;
            eastCourtyard.WestTravelText = "You return to the castle gates.";
            eastCourtyard.LocationToNorth = castleGardens;
            eastCourtyard.NorthTravelText = "You head towards the gardens.";

            castleGardens.LocationToSouth = eastCourtyard;
            castleGardens.SouthTravelText = "You head towards the courtyards.";
            castleGardens.LocationToNorth = castleShrine;
            castleGardens.NorthTravelText = "You head towards a large statue nearby.";

            castleShrine.LocationToSouth = castleGardens;
            castleShrine.SouthTravelText = "You leave the large shrine and head towards the gardens.";

            grandHall.LocationToSouth = castleGates;
            grandHall.SouthTravelText = "You leave the Grand Hall and make your way to the castle gates.";
            grandHall.LocationToEast = diningHall;
            grandHall.EastTravelText = "Seeing a large room, you stumble into it and find yourself in the dining hall.";
            grandHall.LocationToNorth = upperHall;
            grandHall.NorthTravelText = "You ascend a massive set of stairs.";

            diningHall.LocationToWest = grandHall;
            diningHall.WestTravelText = "You leave the dining hall and return to the Grand Hall.";

            upperHall.LocationToSouth = grandHall;
            upperHall.SouthTravelText = "You descend down the massive stairs.";
            upperHall.LocationToWest = castleBedroom;
            upperHall.WestTravelText = "Stumbling about, you eventually find yourself inside a set of bedrooms.";
            upperHall.LocationToNorth = throneRoom;
            upperHall.NorthTravelText = "You go past a giant set of doors and find yourself in the throne room.";

            castleBedroom.LocationToEast = upperHall;
            castleBedroom.EastTravelText = "You return to the second floor.";

            throneRoom.LocationToSouth = upperHall;
            throneRoom.SouthTravelText = "You leave the throne room and head back out the grand doors.";
            throneRoom.LocationToNorth = castleVault;
            throneRoom.NorthTravelText = "You go behind the throne and find yourself inside a massive secret vault.";

            castleVault.LocationToSouth = throneRoom;
            castleVault.SouthTravelText = "You leave the vault, returning to the throne room.";

            lostRoad.LocationToEast = farmersField;
            lostRoad.EastTravelText = "Following the winding road, you soon return to the farmer's field.";
            lostRoad.LocationToWest = eastLostRuins;
            lostRoad.WestTravelText = "You head towards the ruins you can see in the distance.";

            eastLostRuins.LocationToEast = lostRoad;
            eastLostRuins.EastTravelText = "You return to the winding road in the direction of the field.";
            eastLostRuins.LocationToSouth = southernBrokenStructure;
            eastLostRuins.SouthTravelText = "You investigate one of the broken buildings nearby.";
            eastLostRuins.LocationToWest = westernLostRuins;
            eastLostRuins.WestTravelText = "You head over to the other half of the broken ruins.";

            southernBrokenStructure.LocationToNorth = eastLostRuins;
            southernBrokenStructure.NorthTravelText = "You leave the collapsed building.";

            westernLostRuins.LocationToEast = eastLostRuins;
            westernLostRuins.EastTravelText = "You return to the eastern lost ruins.";
            westernLostRuins.LocationToNorth = northernBrokenStructure;
            westernLostRuins.NorthTravelText = "You dart into another broken down building before more creatures swarm onto you.";
            westernLostRuins.LocationToSouth = finalLostRuins;
            westernLostRuins.SouthTravelText = "You follow the road through the ruins and arrive at a small set of very large destroyed buildings.";

            northernBrokenStructure.LocationToSouth = westernLostRuins;
            northernBrokenStructure.SouthTravelText = "You leave the building and return to exploring the ruins.";

            finalLostRuins.LocationToNorth = westernLostRuins;
            finalLostRuins.NorthTravelText = "You return to the primary cluster of buildings.";
            finalLostRuins.LocationToWest = dragonAltar;
            finalLostRuins.WestTravelText = "In the distance, you can see a giant altar of a dragon. You make way towards it.";

            dragonAltar.LocationToEast = finalLostRuins;
            dragonAltar.EastTravelText = "You return to the ruins.";
            dragonAltar.LocationToWest = pedestal;
            dragonAltar.WestTravelText = "Circling around the altar, you find a pedestal.";

            pedestal.LocationToEast = dragonAltar;
            pedestal.EastTravelText = "You return to the front of the altar.";
            pedestal.LocationToSouth = darkPortal;
            pedestal.SouthTravelText = "You feel the air shift, as a dark pulsating void can be seen to your south. You are drawn towards it.";

            darkPortal.LocationToNorth = pedestal;
            darkPortal.NorthTravelText = "You break away from the draw of the portal and return to the pedestal by the dragon statue.";



            //spiderField.LocationToWest = bridge;

            // Add the locations to the static list
            _locations.Add(home);
            _locations.Add(townSquare);
            _locations.Add(eastGuardPost);
            _locations.Add(alchemistHut);
            _locations.Add(alchemistsGarden);
            _locations.Add(farmhouse);
            _locations.Add(farmersField);
            _locations.Add(bridge);
            _locations.Add(sideRoad);
            _locations.Add(deadEnd);
            _locations.Add(marketDistrict);
            _locations.Add(backAlley);
            _locations.Add(westSuburbs);
            _locations.Add(northRoad);
            _locations.Add(largeHill);
            _locations.Add(rollingHills);
            _locations.Add(peacefulPond);
            _locations.Add(collosalCaveEntrance);
            _locations.Add(cliff);
            _locations.Add(mudfield);
            _locations.Add(generalStore);
            _locations.Add(archeryRange);
            _locations.Add(westGuardPost);
            _locations.Add(lessTraveledRoad);
            _locations.Add(forgottenTower);
            _locations.Add(stairsToTheSpire);
            _locations.Add(forgottenTowerSpire);
            _locations.Add(easternTrail);
            _locations.Add(brokenPass);
            _locations.Add(desertEntrance);
            _locations.Add(trifoxTrail);
            _locations.Add(entranceYognarWoods);
            _locations.Add(inTheWoods);
            _locations.Add(river);
            _locations.Add(riverUptrail);
            _locations.Add(riverUptrailEnd);
            _locations.Add(riverDowntrail);
            _locations.Add(westBrookDock);
            _locations.Add(westBrookTownCenter);
            _locations.Add(chapel);
            _locations.Add(westBrookGeneralStore);
            _locations.Add(cemetary);
            _locations.Add(kingsRoad);
            _locations.Add(valleyNearCastle);
            _locations.Add(castleGates);
            _locations.Add(eastCourtyard);
            _locations.Add(westCourtyard);
            _locations.Add(gardnersHouse);
            _locations.Add(castleGardens);
            _locations.Add(castleShrine);
            _locations.Add(grandHall);
            _locations.Add(diningHall);
            _locations.Add(upperHall);
            _locations.Add(castleBedroom);
            _locations.Add(throneRoom);
            _locations.Add(castleVault);
            _locations.Add(lostRoad);
            _locations.Add(eastLostRuins);
            _locations.Add(westernLostRuins);
            _locations.Add(northernBrokenStructure);
            _locations.Add(southernBrokenStructure);
            _locations.Add(finalLostRuins);
            _locations.Add(dragonAltar);
            _locations.Add(pedestal);
            _locations.Add(darkPortal);

            //_locations.Add(spiderField);
        }

        public static Item ItemByID(int id)
        {
            return _items.SingleOrDefault(x => x.ID == id);
        }

        public static Monster MonsterByID(int id)
        {
            return _monsters.SingleOrDefault(x => x.ID == id);
        }

        public static Quest QuestByID(int id)
        {
            return _quests.SingleOrDefault(x => x.ID == id);
        }

        public static Location LocationByID(int id)
        {
            return _locations.SingleOrDefault(x => x.ID == id);
        }
    }
}