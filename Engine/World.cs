using System.Collections.Generic;
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

        public const int ITEM_ID_RUSTY_SWORD = 1;
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

        public const int MONSTER_ID_RAT = 1;
        public const int MONSTER_ID_SNAKE = 2;
        public const int MONSTER_ID_GIANT_SPIDER = 3;

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
            _items.Add(new Weapon(ITEM_ID_RUSTY_SWORD, "Rusty sword", "Rusty swords", 1, 0, 5, 5));
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

            _monsters.Add(rat);
            _monsters.Add(snake);
            _monsters.Add(giantSpider);
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

            Location marketDistrict = new Location(LOCATION_ID_MARKET_DISTRICT, "Market District", "The place is bustling with activity." +
                "People are running around everywhere carrying various goods. You can see the General Store to the north.");

            Location deadEnd = new Location(LOCATION_ID_DEAD_END, "Dead End", "The road ends here.");

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

            Location cliff = new Location(LOCATION_ID_CLIFF, "Cliff", "You can see a small field of dirt and mud beneath you. You " +
                "might be able to climb down safetly but you won't be able to get back up this way.");

            Location rollingHills = new Location(LOCATION_ID_ROLLING_HILLS, "Rolling Hills", "The hills are numerous as you go up " +
                "and down constantly.");

            Location peacefulPond = new Location(LOCATION_ID_PEACEFUL_POND, "Peaceful Pond", "There is a calm pond. The waters are " +
                "particularly still.");

            Location collosalCaveEntrance= new Location(LOCATION_ID_COLLISAL_CAVE_ENTRANCE, "Collisal Cave Entrance", "You see the " +
                "entrance to a collisal cave.");

            Location trifoxTrail = new Location(LOCATION_ID_TRIFOX_TRAIL, "Trifox Trail", "The path splits in three directions. " +
                "To the north, you can see a forest. To the west is a river. And to the east is the town.");

            Location easternTrail = new Location(LOCATION_ID_EASTERN_TRAIL, "Eastern Trail", "The path continues to the east with " +
                "a small branch to the south.");

            Location brokenPass = new Location(LOCATION_ID_BROKEN_PASS, "Broken Pass", "The pass is sandwiched between two large " +
                "mountains. The sun is barely visible and it is quite dark.");

            Location desertEntrance = new Location(LOCATION_ID_DESERT_ENTRANCE, "Desert Entrance", "The vast expanse of the desert" +
                " can be seen in front of you. The sweltering sun beats on your back.");

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
            farmersField.AddMonster(MONSTER_ID_SNAKE, 75);
            farmersField.AddMonster(MONSTER_ID_RAT, 25);

            Location eastGuardPost = new Location(LOCATION_ID_WEST_GUARD_POST, "Guard Post", "There is a large, tough-looking guard here."
                , ItemByID(ITEM_ID_RUSTY_SWORD));

            Location westGuardPost = new Location(LOCATION_ID_EAST_GUARD_POST, "Guard Post", "A large guard greets you and lets you pass.");

            Location mudfield = new Location(LOCATION_ID_MUDFIELD, "Mudfield", "There is a large open space filled with dirt.");

            Location forgottenTower = new Location(LOCATION_ID_THE_FORGOTTEN_TOWER, "The Forgotten Tower", "A massive tower stands " +
                "before you, reaching towards the heavens. The tower is composed entirely of some dark coloured stone and looks " +
                "rather imposing.");

            Location lessTraveledRoad = new Location(LOCATION_ID_LESS_TRAVELED_ROAD, "Less Traveled Road", "The road looks like no" +
                " one has been here for a while. You can see a large tower in the distance.");

            Location stairsToTheSpire = new Location(LOCATION_ID_STAIRS_TO_THE_SPIRE, "Spiral Stairs", "The stairs spiral up the tower, " +
                "seeming to drag on forever.");

            Location forgottenTowerSpire = new Location(LOCATION_ID_THE_SPIRE, "Spire", "Lightning crackles around you at the top of " +
                "the spire. The noise is deafening. You cannot see the ground as the dark clouds block your line of sight.");

            Location bridge = new Location(LOCATION_ID_BRIDGE, "Bridge", "A stone bridge crosses a wide river.");

            Location entranceYognarWoods = new Location(LOCATION_ID_ENTRANCE_TO_YOGNAR_WOODS, "Entrance to Yognar Woods", "The entrance to Yognar Woods. " +
                "The trees stare at you menancingly.");

            Location inTheWoods = new Location(LOCATION_ID_IN_THE_WOODS, "In the Woods", "Trees can be seen everywhere. Trees. " +
                "So many trees. All you can see are trees.");

            Location river = new Location(LOCATION_ID_RIVER_CROSSING, "River Crossing", "You can see a small town to the west.");

            Location riverUptrail = new Location(LOCATION_ID_RIVER_UPTRAIL, "Following River North", "The river continues.");

            Location riverUptrailEnd= new Location(LOCATION_ID_RIVER_UPTRAIL_DEAD_END, "River End", "The river merges into a massive " +
                "body of water in the distant.");

            Location riverDowntrail = new Location(LOCATION_ID_RIVER_DOWNTRAIL, "Following River South", "You can see massive mountains " +
                "to the south from where the river emerges.");

            //Location mountainEntrance = new Location(LOCATION_ID_MOUNTAIN_ENTRANCE, "Mountain Pass", "There is a large open space filled with dirt.");


            Location westBrookDock = new Location(LOCATION_ID_WESTBROOK_DOCK, "Westbrook Dock", "Your raft is tied to the dock. " +
                "Fishermen can be seen moving around, carrying fish.");

            Location westBrookTownCenter= new Location(LOCATION_ID_WESTBROOK_TOWN_CENTER, "Westbrook Town Center", "You find yourself " +
                "in the center of the small town.");

            Location westBrookGeneralStore = new Location(LOCATION_ID_WESTBROOK_GENERAL_STORE, "Westbrook General Store", "The general " +
                "store is filled with various goods. Some goods are surprisingly exotic.");

            Location cemetary = new Location(LOCATION_ID_WESTBROOK_CEMETARY, "Westbrook Cemetary", "Stone graves rise out of the " +
                "ground. A chill air fills the air.");

            Location chapel = new Location(LOCATION_ID_MUDFIELD, "Chapel", "You find yourself in a humble chapel. Art to various " +
                "deities can be seen here.");

            Location kingsRoad = new Location(LOCATION_ID_KINGS_ROAD, "King's Road", "The road leads towards Lorthar Castle.");

            Location valleyNearCastle = new Location(LOCATION_ID_VALLEY_NEAR_CASTLE, "Valley Near Lorthar Castle", "The road passes " +
                "through the valley. Lorthar castle can be seen to the north. Westbrook is to the south.");

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

            Location eastLostRuins = new Location(LOCATION_ID_EASTERN_LOST_RUINS, "Lost Ruins", "Large ruins are scattered around. " +
                "There are many collapsed buildings around.");

            Location southernBrokenStructure = new Location(LOCATION_ID_SOUTHERN_BROKEN_BUILDING, "Broken Building", "The collapsed " +
                "building is filled with cracks in the walls and vines growing out of the ground.");

            Location westernLostRuins = new Location(LOCATION_ID_WESTERN_LOST_RUINS, "Lost Ruins", "More broken down ruins are" +
                " scattered around the area.");

            Location northernBrokenStructure = new Location(LOCATION_ID_NORTHERN_BROKEN_BUILDING, "Broken Building", "A small chest " +
                "sits in the corner of this collapsed building.");

            Location finalLostRuins = new Location(LOCATION_ID_FINAL_LOST_RUINS, "Lost Ruins", "The buildings here are damaged " +
                "beyond repair and many beyond even recognition.");

            Location dragonAltar = new Location(LOCATION_ID_ALTAR_DRAGON, "Dragon Altar", "A titan of a dragon carved out of stone " +
                "sits here in prestine condition. Its size fills you with awe.");

            Location pedestal= new Location(LOCATION_ID_PEDESTAL, "Pedestal", "A large pedestal sits with a might sword sticking " +
                "out of it.");

            Location darkPortal = new Location(LOCATION_ID_DARK_PORTAL, "Dark Portal", "A purple void sits before you in a stone" +
                " wall, seemingly drawing you in.");


            Location spiderField = new Location(LOCATION_ID_SPIDER_FIELD, "Forest", "You see spider webs covering covering the trees in this forest.");
            spiderField.AddMonster(MONSTER_ID_GIANT_SPIDER, 100);

            // Link the locations together
            home.LocationToNorth = townSquare;
            home.LocationToEast = sideRoad;
            home.LocationToSouth = farmersField;
            home.LocationToWest = backAlley;

            townSquare.LocationToNorth = northRoad;
            townSquare.LocationToSouth = home;
            townSquare.LocationToEast = marketDistrict;
            townSquare.LocationToWest = westSuburbs;

            sideRoad.LocationToEast = deadEnd;
            sideRoad.LocationToNorth = marketDistrict;
            sideRoad.LocationToWest = home;

            backAlley.LocationToEast = home;
            backAlley.LocationToNorth = westSuburbs;

            deadEnd.LocationToWest = sideRoad;

            marketDistrict.LocationToNorth = generalStore;
            marketDistrict.LocationToEast = eastGuardPost;
            marketDistrict.LocationToSouth = sideRoad;
            marketDistrict.LocationToWest = townSquare;

            generalStore.LocationToSouth = marketDistrict;

            eastGuardPost.LocationToWest = marketDistrict;
            eastGuardPost.LocationToNorth = archeryRange;
            eastGuardPost.LocationToEast = easternTrail;

            easternTrail.LocationToSouth = alchemistHut;
            easternTrail.LocationToWest = eastGuardPost;
            easternTrail.LocationToEast = brokenPass;

            archeryRange.LocationToSouth = eastGuardPost;

            brokenPass.LocationToWest = easternTrail;
            brokenPass.LocationToEast = desertEntrance;

            desertEntrance.LocationToWest = brokenPass;

            northRoad.LocationToSouth = townSquare;
            northRoad.LocationToNorth = largeHill;

            largeHill.LocationToSouth = northRoad;
            largeHill.LocationToNorth = cliff;
            largeHill.LocationToEast = rollingHills;

            rollingHills.LocationToWest = largeHill;
            rollingHills.LocationToEast = peacefulPond;
            rollingHills.LocationToNorth = collosalCaveEntrance;

            peacefulPond.LocationToWest = rollingHills;

            collosalCaveEntrance.LocationToSouth = rollingHills;

            cliff.LocationToWest = mudfield;
            cliff.LocationToSouth = largeHill;

            mudfield.LocationToEast = forgottenTower;

            forgottenTower.LocationToWest = mudfield;
            forgottenTower.LocationToSouth = lessTraveledRoad;
            forgottenTower.LocationToNorth = stairsToTheSpire;

            stairsToTheSpire.LocationToNorth = forgottenTowerSpire;
            stairsToTheSpire.LocationToSouth = forgottenTower;

            forgottenTowerSpire.LocationToSouth = stairsToTheSpire;

            lessTraveledRoad.LocationToSouth = westSuburbs;
            lessTraveledRoad.LocationToNorth = forgottenTower;
            //farmhouse.LocationToEast = townSquare;
            //farmhouse.LocationToWest = farmersField;

            farmersField.LocationToNorth = home;
            farmersField.LocationToWest = lostRoad;

            alchemistHut.LocationToNorth = easternTrail;
            alchemistHut.LocationToSouth = alchemistsGarden;

            alchemistsGarden.LocationToNorth = alchemistHut;

            westGuardPost.LocationToEast = westSuburbs;
            westGuardPost.LocationToWest = bridge;

            westSuburbs.LocationToNorth = lessTraveledRoad;
            westSuburbs.LocationToSouth = backAlley;
            westSuburbs.LocationToEast = townSquare;
            westSuburbs.LocationToWest = westGuardPost;

            bridge.LocationToEast = westGuardPost;
            bridge.LocationToWest = trifoxTrail;

            trifoxTrail.LocationToEast = bridge;
            trifoxTrail.LocationToNorth = entranceYognarWoods;
            trifoxTrail.LocationToWest = river;

            entranceYognarWoods.LocationToNorth = inTheWoods;
            entranceYognarWoods.LocationToSouth = trifoxTrail;

            inTheWoods.LocationToSouth = entranceYognarWoods;

            river.LocationToEast = trifoxTrail;
            river.LocationToNorth = riverUptrail;
            river.LocationToSouth = riverDowntrail;
            river.LocationToWest = westBrookDock;

            riverUptrail.LocationToNorth = riverUptrailEnd;
            riverUptrail.LocationToSouth = river;

            riverUptrailEnd.LocationToSouth = riverUptrail;

            riverDowntrail.LocationToNorth = river;
            //riverDowntrail.LocationToSouth = mountainEntrance;

            westBrookDock.LocationToEast = river;
            westBrookDock.LocationToNorth = kingsRoad;
            westBrookDock.LocationToWest = westBrookTownCenter;

            westBrookTownCenter.LocationToNorth = cemetary;
            westBrookTownCenter.LocationToWest = chapel;
            westBrookTownCenter.LocationToSouth = westBrookGeneralStore;
            westBrookTownCenter.LocationToEast = westBrookDock;

            chapel.LocationToEast = westBrookTownCenter;

            westBrookGeneralStore.LocationToNorth = westBrookTownCenter;

            cemetary.LocationToSouth = westBrookTownCenter;

            kingsRoad.LocationToSouth = westBrookDock;
            kingsRoad.LocationToNorth = valleyNearCastle;

            valleyNearCastle.LocationToSouth = kingsRoad;
            valleyNearCastle.LocationToNorth = castleGates;

            castleGates.LocationToSouth = valleyNearCastle;
            castleGates.LocationToWest = westCourtyard;
            castleGates.LocationToEast = eastCourtyard;
            castleGates.LocationToNorth = grandHall;

            westCourtyard.LocationToNorth = gardnersHouse;
            westCourtyard.LocationToEast = castleGates;

            gardnersHouse.LocationToSouth = westCourtyard;

            eastCourtyard.LocationToWest = castleGates;
            eastCourtyard.LocationToNorth = castleGardens;

            castleGardens.LocationToSouth = eastCourtyard;
            castleGardens.LocationToNorth = castleShrine;

            castleShrine.LocationToSouth = castleGardens;

            grandHall.LocationToSouth = castleGates;
            grandHall.LocationToEast = diningHall;
            grandHall.LocationToNorth = upperHall;

            diningHall.LocationToWest = grandHall;

            upperHall.LocationToSouth = grandHall;
            upperHall.LocationToWest = castleBedroom;
            upperHall.LocationToNorth = throneRoom;

            castleBedroom.LocationToEast = upperHall;

            throneRoom.LocationToSouth = upperHall;
            throneRoom.LocationToNorth = castleVault;

            castleVault.LocationToSouth = throneRoom;

            lostRoad.LocationToEast = farmersField;
            lostRoad.LocationToWest = eastLostRuins;

            eastLostRuins.LocationToEast = lostRoad;
            eastLostRuins.LocationToSouth = southernBrokenStructure;
            eastLostRuins.LocationToWest = westernLostRuins;

            southernBrokenStructure.LocationToNorth = eastLostRuins;

            westernLostRuins.LocationToEast = eastLostRuins;
            westernLostRuins.LocationToNorth = northernBrokenStructure;
            westernLostRuins.LocationToSouth = finalLostRuins;

            northernBrokenStructure.LocationToSouth = westernLostRuins;

            finalLostRuins.LocationToNorth = westernLostRuins;
            finalLostRuins.LocationToWest = dragonAltar;

            dragonAltar.LocationToEast = finalLostRuins;
            dragonAltar.LocationToWest = pedestal;

            pedestal.LocationToEast = dragonAltar;
            pedestal.LocationToSouth = darkPortal;

            darkPortal.LocationToNorth = pedestal;



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