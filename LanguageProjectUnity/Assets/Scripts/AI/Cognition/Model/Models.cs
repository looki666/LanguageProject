public class Models {
    public static IModel BobTrueModel() {
        IModel m = new SimpleModel();

        // things Bob takes to be true of Bob
        m.Add(new Phrase(Expression.KING, Expression.BOB));
        m.Add(new Phrase(Expression.ACTIVE, Expression.BOB));
        m.Add(new Phrase(Expression.NEAR_YOU, Expression.BOB)); // should this be trivially true, or false?
        m.Add(new Phrase(Expression.IN_RED_AREA, Expression.BOB));

        // things Bob takes to be true of Evan
        m.Add(new Phrase(Expression.ACTIVE, Expression.EVAN));
        m.Add(new Phrase(Expression.IN_GREEN_AREA, Expression.EVAN));

        // things Bob takes to be true of the fountain
        m.Add(new Phrase(Expression.FOUNTAIN, new Phrase(Expression.THE, Expression.FOUNTAIN)));
        m.Add(new Phrase(Expression.ACTIVE, new Phrase(Expression.THE, Expression.FOUNTAIN)));
        m.Add(new Phrase(Expression.NEAR_YOU, new Phrase(Expression.THE, Expression.FOUNTAIN)));
        m.Add(new Phrase(Expression.IN_RED_AREA, new Phrase(Expression.THE, Expression.FOUNTAIN)));

        // things Bob takes to be true of a fountain
        m.Add(new Phrase(Expression.FOUNTAIN, new Phrase(Expression.A, Expression.FOUNTAIN)));
        m.Add(new Phrase(Expression.ACTIVE, new Phrase(Expression.A, Expression.FOUNTAIN)));
        m.Add(new Phrase(Expression.INACTIVE, new Phrase(Expression.A, Expression.FOUNTAIN)));
        m.Add(new Phrase(Expression.NEAR_YOU, new Phrase(Expression.A, Expression.FOUNTAIN)));
        m.Add(new Phrase(Expression.IN_BLUE_AREA, new Phrase(Expression.A, Expression.FOUNTAIN)));
        m.Add(new Phrase(Expression.IN_RED_AREA, new Phrase(Expression.A, Expression.FOUNTAIN)));

        // things Bob takes to be true of two fountains
        m.Add(new Phrase(Expression.FOUNTAIN, new Phrase(Expression.TWO, Expression.FOUNTAIN)));
        m.Add(new Phrase(Expression.ACTIVE, new Phrase(Expression.TWO, Expression.FOUNTAIN)));
        m.Add(new Phrase(Expression.IN_BLUE_AREA, new Phrase(Expression.TWO, Expression.FOUNTAIN)));

        // things Bob takes to be true of three fountains
        m.Add(new Phrase(Expression.FOUNTAIN, new Phrase(Expression.THREE, Expression.FOUNTAIN)));

        // things Bob takes to be true of every fountain
        m.Add(new Phrase(Expression.FOUNTAIN, new Phrase(Expression.EVERY, Expression.FOUNTAIN)));

        // things Bob takes to be true of the lamp
        m.Add(new Phrase(Expression.LAMP, new Phrase(Expression.THE, Expression.LAMP)));
        m.Add(new Phrase(Expression.ACTIVE, new Phrase(Expression.THE, Expression.LAMP)));

        // things Bob takes to be true of a lamp
        m.Add(new Phrase(Expression.LAMP, new Phrase(Expression.A, Expression.LAMP)));
        m.Add(new Phrase(Expression.ACTIVE, new Phrase(Expression.A, Expression.LAMP)));
        m.Add(new Phrase(Expression.INACTIVE, new Phrase(Expression.A, Expression.LAMP)));

        // things Bob takes to be true of two lamps
        m.Add(new Phrase(Expression.LAMP, new Phrase(Expression.TWO, Expression.LAMP)));

        // things Bob takes to be true of three lamps

        // things Bob takes to be true of every lamp
        m.Add(new Phrase(Expression.LAMP, new Phrase(Expression.EVERY, Expression.LAMP)));

        // things Bob takes to be true of the active thing
        m.Add(new Phrase(Expression.ACTIVE, new Phrase(Expression.THE, Expression.ACTIVE)));
        m.Add(new Phrase(Expression.IN_RED_AREA, new Phrase(Expression.THE, Expression.ACTIVE)));

        // things Bob takes to be true of an active thing
        m.Add(new Phrase(Expression.FOUNTAIN, new Phrase(Expression.A, Expression.ACTIVE)));
        m.Add(new Phrase(Expression.LAMP, new Phrase(Expression.A, Expression.ACTIVE)));
        m.Add(new Phrase(Expression.ACTIVE, new Phrase(Expression.A, Expression.ACTIVE)));
        m.Add(new Phrase(Expression.KING, new Phrase(Expression.A, Expression.ACTIVE)));
        m.Add(new Phrase(Expression.NEAR_YOU, new Phrase(Expression.A, Expression.ACTIVE)));
        m.Add(new Phrase(Expression.IN_BLUE_AREA, new Phrase(Expression.A, Expression.ACTIVE)));
        m.Add(new Phrase(Expression.IN_RED_AREA, new Phrase(Expression.A, Expression.ACTIVE)));

        // things Bob takes to be true of two active things
        m.Add(new Phrase(Expression.FOUNTAIN, new Phrase(Expression.TWO, Expression.ACTIVE)));
        m.Add(new Phrase(Expression.ACTIVE, new Phrase(Expression.TWO, Expression.ACTIVE)));
        m.Add(new Phrase(Expression.IN_RED_AREA, new Phrase(Expression.TWO, Expression.ACTIVE)));

        // things Bob takes to be true of three active things
        m.Add(new Phrase(Expression.ACTIVE, new Phrase(Expression.THREE, Expression.ACTIVE)));

        // things Bob takes to be true of every active thing
        m.Add(new Phrase(Expression.ACTIVE, new Phrase(Expression.EVERY, Expression.ACTIVE)));

        // things Bob takes to be true of the inactive thing
        m.Add(new Phrase(Expression.INACTIVE, new Phrase(Expression.THE, Expression.INACTIVE)));
        m.Add(new Phrase(Expression.IN_BLUE_AREA, new Phrase(Expression.THE, Expression.INACTIVE)));

        // things Bob takes to be true of an inactive thing
        m.Add(new Phrase(Expression.FOUNTAIN, new Phrase(Expression.A, Expression.INACTIVE)));
        m.Add(new Phrase(Expression.LAMP, new Phrase(Expression.A, Expression.INACTIVE)));
        m.Add(new Phrase(Expression.INACTIVE, new Phrase(Expression.A, Expression.INACTIVE)));
        m.Add(new Phrase(Expression.IN_BLUE_AREA, new Phrase(Expression.A, Expression.INACTIVE)));

        // things Bob takes to be true of two inactive things
        m.Add(new Phrase(Expression.INACTIVE, new Phrase(Expression.TWO, Expression.INACTIVE)));
        m.Add(new Phrase(Expression.IN_BLUE_AREA, new Phrase(Expression.TWO, Expression.INACTIVE)));

        // things Bob takes to be true of three inactive things

        // things Bob takes to be true of every inactive thing
        m.Add(new Phrase(Expression.INACTIVE, new Phrase(Expression.EVERY, Expression.INACTIVE)));
        m.Add(new Phrase(Expression.IN_BLUE_AREA, new Phrase(Expression.EVERY, Expression.INACTIVE)));

        // things Bob takes to be true of the king
        m.Add(new Phrase(Expression.ACTIVE, new Phrase(Expression.THE, Expression.KING)));
        m.Add(new Phrase(Expression.KING, new Phrase(Expression.THE, Expression.KING)));
        m.Add(new Phrase(Expression.NEAR_YOU, new Phrase(Expression.THE, Expression.KING)));
        m.Add(new Phrase(Expression.IN_RED_AREA, new Phrase(Expression.THE, Expression.KING)));

        // things Bob takes to be true of a king
        m.Add(new Phrase(Expression.ACTIVE, new Phrase(Expression.A, Expression.KING)));
        m.Add(new Phrase(Expression.KING, new Phrase(Expression.A, Expression.KING)));
        m.Add(new Phrase(Expression.NEAR_YOU, new Phrase(Expression.A, Expression.KING)));
        m.Add(new Phrase(Expression.IN_RED_AREA, new Phrase(Expression.A, Expression.KING)));

        // things Bob takes to be true of two kings
        
        // things Bob takes to be true of three kings
        
        // things Bob takes to be true of every king
        m.Add(new Phrase(Expression.ACTIVE, new Phrase(Expression.EVERY, Expression.KING)));
        m.Add(new Phrase(Expression.KING, new Phrase(Expression.EVERY, Expression.KING)));
        m.Add(new Phrase(Expression.NEAR_YOU, new Phrase(Expression.EVERY, Expression.KING)));
        m.Add(new Phrase(Expression.IN_RED_AREA, new Phrase(Expression.EVERY, Expression.KING)));

        // things Bob takes to be true of the yellow thing

        // things Bob takes to be true of a yellow thing
        
        // things Bob takes to be true of two yellow things
        
        // things Bob takes to be true of three yellow things
        
        // things Bob takes to be true of every yellow thing
        m.Add(new Phrase(Expression.YELLOW, new Phrase(Expression.EVERY, Expression.YELLOW)));

        // things Bob takes to be true of the green thing

        // things Bob takes to be true of a green thing
        
        // things Bob takes to be true of two green things
        
        // things Bob takes to be true of three green things
        
        // things Bob takes to be true of every green thing
        m.Add(new Phrase(Expression.GREEN, new Phrase(Expression.EVERY, Expression.GREEN)));

        // things Bob takes to be true of the blue thing

        // things Bob takes to be true of a blue thing
        
        // things Bob takes to be true of two blue things
        
        // things Bob takes to be true of three blue things
        
        // things Bob takes to be true of every blue thing
        m.Add(new Phrase(Expression.BLUE, new Phrase(Expression.EVERY, Expression.BLUE)));

        // things Bob takes to be true of the red thing

        // things Bob takes to be true of a red thing
        
        // things Bob takes to be true of two red things
        
        // things Bob takes to be true of three red things
        
        // things Bob takes to be true of every red thing
        m.Add(new Phrase(Expression.RED, new Phrase(Expression.EVERY, Expression.RED)));

        // things Bob takes to be true of the near-Bob thing
        m.Add(new Phrase(Expression.FOUNTAIN, new Phrase(Expression.THE, Expression.NEAR_YOU)));
        m.Add(new Phrase(Expression.ACTIVE, new Phrase(Expression.THE, Expression.NEAR_YOU)));
        m.Add(new Phrase(Expression.NEAR_YOU, new Phrase(Expression.THE, Expression.NEAR_YOU)));
        m.Add(new Phrase(Expression.IN_RED_AREA, new Phrase(Expression.THE, Expression.NEAR_YOU)));

        // things Bob takes to be true of a near-Bob thing
        m.Add(new Phrase(Expression.FOUNTAIN, new Phrase(Expression.A, Expression.NEAR_YOU)));
        m.Add(new Phrase(Expression.ACTIVE, new Phrase(Expression.A, Expression.NEAR_YOU)));
        m.Add(new Phrase(Expression.KING, new Phrase(Expression.A, Expression.NEAR_YOU)));
        m.Add(new Phrase(Expression.NEAR_YOU, new Phrase(Expression.A, Expression.NEAR_YOU)));
        m.Add(new Phrase(Expression.IN_RED_AREA, new Phrase(Expression.A, Expression.NEAR_YOU)));

        // things Bob takes to be true of two near-Bob things
        m.Add(new Phrase(Expression.ACTIVE, new Phrase(Expression.TWO, Expression.NEAR_YOU)));
        m.Add(new Phrase(Expression.NEAR_YOU, new Phrase(Expression.TWO, Expression.NEAR_YOU)));
        m.Add(new Phrase(Expression.IN_RED_AREA, new Phrase(Expression.TWO, Expression.NEAR_YOU)));

        // things Bob takes to be true of three near-Bob things

        // things Bob takes to be true of every near-Bob thing
        m.Add(new Phrase(Expression.ACTIVE, new Phrase(Expression.EVERY, Expression.NEAR_YOU)));
        m.Add(new Phrase(Expression.NEAR_YOU, new Phrase(Expression.EVERY, Expression.NEAR_YOU)));
        m.Add(new Phrase(Expression.IN_RED_AREA, new Phrase(Expression.EVERY, Expression.NEAR_YOU)));

        // things Bob takes to be true of the in-yellow-area thing

        // things Bob takes to be true of an in-yellow-area thing

        // things Bob takes to be true of two in-yellow-area things

        // things Bob takes to be true of three in-yellow-area things

        // things Bob takes to be true of every in-yellow-area thing
        m.Add(new Phrase(Expression.IN_YELLOW_AREA, new Phrase(Expression.EVERY, Expression.IN_YELLOW_AREA)));

        // things Bob takes to be true of the in-green-area thing
        m.Add(new Phrase(Expression.ACTIVE, new Phrase(Expression.THE, Expression.IN_GREEN_AREA)));
        m.Add(new Phrase(Expression.IN_GREEN_AREA, new Phrase(Expression.THE, Expression.IN_GREEN_AREA)));

        // things Bob takes to be true of an in-green-area thing
        m.Add(new Phrase(Expression.ACTIVE, new Phrase(Expression.A, Expression.IN_GREEN_AREA)));
        m.Add(new Phrase(Expression.IN_GREEN_AREA, new Phrase(Expression.A, Expression.IN_GREEN_AREA)));

        // things Bob takes to be true of two in-green-area things

        // things Bob takes to be true of three in-green-area things

        // things Bob takes to be true of every in-green-area thing
        m.Add(new Phrase(Expression.ACTIVE, new Phrase(Expression.EVERY, Expression.IN_GREEN_AREA)));
        m.Add(new Phrase(Expression.IN_GREEN_AREA, new Phrase(Expression.EVERY, Expression.IN_GREEN_AREA)));

        // things Bob takes to be true of the in-blue-area thing

        // things Bob takes to be true of an in-blue-area thing
        m.Add(new Phrase(Expression.FOUNTAIN, new Phrase(Expression.A, Expression.IN_BLUE_AREA)));
        m.Add(new Phrase(Expression.LAMP, new Phrase(Expression.A, Expression.IN_BLUE_AREA)));
        m.Add(new Phrase(Expression.ACTIVE, new Phrase(Expression.A, Expression.IN_BLUE_AREA)));
        m.Add(new Phrase(Expression.INACTIVE, new Phrase(Expression.A, Expression.IN_BLUE_AREA)));
        m.Add(new Phrase(Expression.IN_BLUE_AREA, new Phrase(Expression.A, Expression.IN_BLUE_AREA)));

        // things Bob takes to be true of two in-blue-area things
        m.Add(new Phrase(Expression.FOUNTAIN, new Phrase(Expression.TWO, Expression.IN_BLUE_AREA)));
        m.Add(new Phrase(Expression.INACTIVE, new Phrase(Expression.TWO, Expression.IN_BLUE_AREA)));
        m.Add(new Phrase(Expression.IN_BLUE_AREA, new Phrase(Expression.TWO, Expression.IN_BLUE_AREA)));

        // things Bob takes to be true of three in-blue-area things
        m.Add(new Phrase(Expression.IN_BLUE_AREA, new Phrase(Expression.THREE, Expression.IN_BLUE_AREA)));

        // things Bob takes to be true of every in-blue-area thing
        m.Add(new Phrase(Expression.IN_BLUE_AREA, new Phrase(Expression.EVERY, Expression.IN_BLUE_AREA)));

        // things Bob takes to be true of the in-red-area thing

        // things Bob takes to be true of an in-red-area thing
        m.Add(new Phrase(Expression.FOUNTAIN, new Phrase(Expression.A, Expression.IN_RED_AREA)));
        m.Add(new Phrase(Expression.LAMP, new Phrase(Expression.A, Expression.IN_RED_AREA)));
        m.Add(new Phrase(Expression.ACTIVE, new Phrase(Expression.A, Expression.IN_RED_AREA)));
        m.Add(new Phrase(Expression.KING, new Phrase(Expression.A, Expression.IN_RED_AREA)));
        m.Add(new Phrase(Expression.NEAR_YOU, new Phrase(Expression.A, Expression.IN_RED_AREA)));
        m.Add(new Phrase(Expression.IN_RED_AREA, new Phrase(Expression.A, Expression.IN_RED_AREA)));

        // things Bob takes to be true of two in-red-area things
        m.Add(new Phrase(Expression.ACTIVE, new Phrase(Expression.TWO, Expression.IN_RED_AREA)));
        m.Add(new Phrase(Expression.NEAR_YOU, new Phrase(Expression.TWO, Expression.IN_RED_AREA)));
        m.Add(new Phrase(Expression.IN_RED_AREA, new Phrase(Expression.TWO, Expression.IN_RED_AREA)));

        // things Bob takes to be true of three in-red-area things
        m.Add(new Phrase(Expression.ACTIVE, new Phrase(Expression.THREE, Expression.IN_RED_AREA)));
        m.Add(new Phrase(Expression.IN_RED_AREA, new Phrase(Expression.THREE, Expression.IN_RED_AREA)));
        
        // things Bob takes to be true of every in-red-area thing
        m.Add(new Phrase(Expression.ACTIVE, new Phrase(Expression.EVERY, Expression.IN_RED_AREA)));
        m.Add(new Phrase(Expression.IN_RED_AREA, new Phrase(Expression.EVERY, Expression.IN_RED_AREA)));

        return m;
    }

    public static IModel BobFalseModel() {
        IModel m = new SimpleModel();
        // things Bob doesn't take to be true of Bob
        m.Add(new Phrase(Expression.FOUNTAIN, Expression.BOB));
        m.Add(new Phrase(Expression.LAMP, Expression.BOB));
        m.Add(new Phrase(Expression.INACTIVE, Expression.BOB));
        m.Add(new Phrase(Expression.YELLOW, Expression.BOB));
        m.Add(new Phrase(Expression.GREEN, Expression.BOB));
        m.Add(new Phrase(Expression.BLUE, Expression.BOB));
        m.Add(new Phrase(Expression.RED, Expression.BOB));
        m.Add(new Phrase(Expression.IN_YELLOW_AREA, Expression.BOB));
        m.Add(new Phrase(Expression.IN_GREEN_AREA, Expression.BOB));
        m.Add(new Phrase(Expression.IN_BLUE_AREA, Expression.BOB));

        // things Bob doesn't take to be true of Evan
        m.Add(new Phrase(Expression.KING, Expression.EVAN));
        m.Add(new Phrase(Expression.FOUNTAIN, Expression.EVAN));
        m.Add(new Phrase(Expression.LAMP, Expression.EVAN));
        m.Add(new Phrase(Expression.INACTIVE, Expression.EVAN));
        m.Add(new Phrase(Expression.YELLOW, Expression.EVAN));
        m.Add(new Phrase(Expression.GREEN, Expression.EVAN));
        m.Add(new Phrase(Expression.BLUE, Expression.EVAN));
        m.Add(new Phrase(Expression.RED, Expression.EVAN));
        m.Add(new Phrase(Expression.NEAR_YOU, Expression.EVAN));
        m.Add(new Phrase(Expression.IN_YELLOW_AREA, Expression.EVAN));
        m.Add(new Phrase(Expression.IN_BLUE_AREA, Expression.EVAN));
        m.Add(new Phrase(Expression.IN_RED_AREA, Expression.EVAN));

        // things Bob doesn't take to be true of the fountain
        m.Add(new Phrase(Expression.LAMP, new Phrase(Expression.THE, Expression.FOUNTAIN)));
        m.Add(new Phrase(Expression.INACTIVE, new Phrase(Expression.THE, Expression.FOUNTAIN)));
        m.Add(new Phrase(Expression.KING, new Phrase(Expression.THE, Expression.FOUNTAIN)));
        m.Add(new Phrase(Expression.YELLOW, new Phrase(Expression.THE, Expression.FOUNTAIN)));
        m.Add(new Phrase(Expression.GREEN, new Phrase(Expression.THE, Expression.FOUNTAIN)));
        m.Add(new Phrase(Expression.BLUE, new Phrase(Expression.THE, Expression.FOUNTAIN)));
        m.Add(new Phrase(Expression.RED, new Phrase(Expression.THE, Expression.FOUNTAIN)));
        m.Add(new Phrase(Expression.IN_YELLOW_AREA, new Phrase(Expression.THE, Expression.FOUNTAIN)));
        m.Add(new Phrase(Expression.IN_GREEN_AREA, new Phrase(Expression.THE, Expression.FOUNTAIN)));
        m.Add(new Phrase(Expression.IN_BLUE_AREA, new Phrase(Expression.THE, Expression.FOUNTAIN)));

        // things Bob doesn't take to be true of a fountain
        m.Add(new Phrase(Expression.LAMP, new Phrase(Expression.A, Expression.FOUNTAIN)));
        m.Add(new Phrase(Expression.KING, new Phrase(Expression.A, Expression.FOUNTAIN)));
        m.Add(new Phrase(Expression.YELLOW, new Phrase(Expression.A, Expression.FOUNTAIN)));
        m.Add(new Phrase(Expression.GREEN, new Phrase(Expression.A, Expression.FOUNTAIN)));
        m.Add(new Phrase(Expression.BLUE, new Phrase(Expression.A, Expression.FOUNTAIN)));
        m.Add(new Phrase(Expression.RED, new Phrase(Expression.A, Expression.FOUNTAIN)));
        m.Add(new Phrase(Expression.IN_YELLOW_AREA, new Phrase(Expression.A, Expression.FOUNTAIN)));
        m.Add(new Phrase(Expression.IN_GREEN_AREA, new Phrase(Expression.A, Expression.FOUNTAIN)));

        // things Bob doesn't take to be true of two fountains
        m.Add(new Phrase(Expression.LAMP, new Phrase(Expression.TWO, Expression.FOUNTAIN)));
        m.Add(new Phrase(Expression.INACTIVE, new Phrase(Expression.TWO, Expression.FOUNTAIN)));
        m.Add(new Phrase(Expression.KING, new Phrase(Expression.TWO, Expression.FOUNTAIN)));
        m.Add(new Phrase(Expression.YELLOW, new Phrase(Expression.TWO, Expression.FOUNTAIN)));
        m.Add(new Phrase(Expression.GREEN, new Phrase(Expression.TWO, Expression.FOUNTAIN)));
        m.Add(new Phrase(Expression.BLUE, new Phrase(Expression.TWO, Expression.FOUNTAIN)));
        m.Add(new Phrase(Expression.RED, new Phrase(Expression.TWO, Expression.FOUNTAIN)));
        m.Add(new Phrase(Expression.NEAR_YOU, new Phrase(Expression.TWO, Expression.FOUNTAIN)));
        m.Add(new Phrase(Expression.IN_YELLOW_AREA, new Phrase(Expression.TWO, Expression.FOUNTAIN)));
        m.Add(new Phrase(Expression.IN_GREEN_AREA, new Phrase(Expression.TWO, Expression.FOUNTAIN)));
        m.Add(new Phrase(Expression.IN_RED_AREA, new Phrase(Expression.TWO, Expression.FOUNTAIN)));

        // things Bob doesn't take to be true of three fountains
        m.Add(new Phrase(Expression.LAMP, new Phrase(Expression.THREE, Expression.FOUNTAIN)));
        m.Add(new Phrase(Expression.ACTIVE, new Phrase(Expression.THREE, Expression.FOUNTAIN)));
        m.Add(new Phrase(Expression.INACTIVE, new Phrase(Expression.THREE, Expression.FOUNTAIN)));
        m.Add(new Phrase(Expression.KING, new Phrase(Expression.THREE, Expression.FOUNTAIN)));
        m.Add(new Phrase(Expression.YELLOW, new Phrase(Expression.THREE, Expression.FOUNTAIN)));
        m.Add(new Phrase(Expression.GREEN, new Phrase(Expression.THREE, Expression.FOUNTAIN)));
        m.Add(new Phrase(Expression.BLUE, new Phrase(Expression.THREE, Expression.FOUNTAIN)));
        m.Add(new Phrase(Expression.RED, new Phrase(Expression.THREE, Expression.FOUNTAIN)));
        m.Add(new Phrase(Expression.NEAR_YOU, new Phrase(Expression.THREE, Expression.FOUNTAIN)));
        m.Add(new Phrase(Expression.IN_YELLOW_AREA, new Phrase(Expression.THREE, Expression.FOUNTAIN)));
        m.Add(new Phrase(Expression.IN_GREEN_AREA, new Phrase(Expression.THREE, Expression.FOUNTAIN)));
        m.Add(new Phrase(Expression.IN_BLUE_AREA, new Phrase(Expression.THREE, Expression.FOUNTAIN)));
        m.Add(new Phrase(Expression.IN_RED_AREA, new Phrase(Expression.THREE, Expression.FOUNTAIN)));

        // things Bob doesn't take to be true of every fountain
        m.Add(new Phrase(Expression.LAMP, new Phrase(Expression.EVERY, Expression.FOUNTAIN)));
        m.Add(new Phrase(Expression.ACTIVE, new Phrase(Expression.EVERY, Expression.FOUNTAIN)));
        m.Add(new Phrase(Expression.INACTIVE, new Phrase(Expression.EVERY, Expression.FOUNTAIN)));
        m.Add(new Phrase(Expression.KING, new Phrase(Expression.EVERY, Expression.FOUNTAIN)));
        m.Add(new Phrase(Expression.YELLOW, new Phrase(Expression.EVERY, Expression.FOUNTAIN)));
        m.Add(new Phrase(Expression.GREEN, new Phrase(Expression.EVERY, Expression.FOUNTAIN)));
        m.Add(new Phrase(Expression.BLUE, new Phrase(Expression.EVERY, Expression.FOUNTAIN)));
        m.Add(new Phrase(Expression.RED, new Phrase(Expression.EVERY, Expression.FOUNTAIN)));
        m.Add(new Phrase(Expression.NEAR_YOU, new Phrase(Expression.EVERY, Expression.FOUNTAIN)));
        m.Add(new Phrase(Expression.IN_YELLOW_AREA, new Phrase(Expression.EVERY, Expression.FOUNTAIN)));
        m.Add(new Phrase(Expression.IN_GREEN_AREA, new Phrase(Expression.EVERY, Expression.FOUNTAIN)));
        m.Add(new Phrase(Expression.IN_BLUE_AREA, new Phrase(Expression.EVERY, Expression.FOUNTAIN)));
        m.Add(new Phrase(Expression.IN_RED_AREA, new Phrase(Expression.EVERY, Expression.FOUNTAIN)));

        // things Bob doesn't take to be true of the lamp
        m.Add(new Phrase(Expression.INACTIVE, new Phrase(Expression.THE, Expression.LAMP)));
        m.Add(new Phrase(Expression.KING, new Phrase(Expression.THE, Expression.LAMP)));
        m.Add(new Phrase(Expression.YELLOW, new Phrase(Expression.THE, Expression.LAMP)));
        m.Add(new Phrase(Expression.GREEN, new Phrase(Expression.THE, Expression.LAMP)));
        m.Add(new Phrase(Expression.BLUE, new Phrase(Expression.THE, Expression.LAMP)));
        m.Add(new Phrase(Expression.RED, new Phrase(Expression.THE, Expression.LAMP)));
        m.Add(new Phrase(Expression.NEAR_YOU, new Phrase(Expression.THE, Expression.LAMP)));
        m.Add(new Phrase(Expression.IN_YELLOW_AREA, new Phrase(Expression.THE, Expression.LAMP)));
        m.Add(new Phrase(Expression.IN_GREEN_AREA, new Phrase(Expression.THE, Expression.LAMP)));
        m.Add(new Phrase(Expression.IN_BLUE_AREA, new Phrase(Expression.THE, Expression.LAMP)));
        m.Add(new Phrase(Expression.IN_RED_AREA, new Phrase(Expression.THE, Expression.LAMP)));

        // things Bob doesn't take to be true of a lamp
        m.Add(new Phrase(Expression.FOUNTAIN, new Phrase(Expression.A, Expression.LAMP)));
        m.Add(new Phrase(Expression.KING, new Phrase(Expression.A, Expression.LAMP)));
        m.Add(new Phrase(Expression.YELLOW, new Phrase(Expression.A, Expression.LAMP)));
        m.Add(new Phrase(Expression.GREEN, new Phrase(Expression.A, Expression.LAMP)));
        m.Add(new Phrase(Expression.BLUE, new Phrase(Expression.A, Expression.LAMP)));
        m.Add(new Phrase(Expression.RED, new Phrase(Expression.A, Expression.LAMP)));
        m.Add(new Phrase(Expression.NEAR_YOU, new Phrase(Expression.A, Expression.LAMP)));
        m.Add(new Phrase(Expression.IN_YELLOW_AREA, new Phrase(Expression.A, Expression.LAMP)));
        m.Add(new Phrase(Expression.IN_GREEN_AREA, new Phrase(Expression.A, Expression.LAMP)));
        m.Add(new Phrase(Expression.IN_BLUE_AREA, new Phrase(Expression.A, Expression.LAMP)));
        m.Add(new Phrase(Expression.IN_RED_AREA, new Phrase(Expression.A, Expression.LAMP)));

        // things Bob doesn't take to be true of two lamps
        m.Add(new Phrase(Expression.FOUNTAIN, new Phrase(Expression.TWO, Expression.LAMP)));
        m.Add(new Phrase(Expression.ACTIVE, new Phrase(Expression.TWO, Expression.LAMP)));
        m.Add(new Phrase(Expression.INACTIVE, new Phrase(Expression.TWO, Expression.LAMP)));
        m.Add(new Phrase(Expression.KING, new Phrase(Expression.TWO, Expression.LAMP)));
        m.Add(new Phrase(Expression.YELLOW, new Phrase(Expression.TWO, Expression.LAMP)));
        m.Add(new Phrase(Expression.GREEN, new Phrase(Expression.TWO, Expression.LAMP)));
        m.Add(new Phrase(Expression.BLUE, new Phrase(Expression.TWO, Expression.LAMP)));
        m.Add(new Phrase(Expression.RED, new Phrase(Expression.TWO, Expression.LAMP)));
        m.Add(new Phrase(Expression.NEAR_YOU, new Phrase(Expression.TWO, Expression.LAMP)));
        m.Add(new Phrase(Expression.IN_YELLOW_AREA, new Phrase(Expression.TWO, Expression.LAMP)));
        m.Add(new Phrase(Expression.IN_GREEN_AREA, new Phrase(Expression.TWO, Expression.LAMP)));
        m.Add(new Phrase(Expression.IN_BLUE_AREA, new Phrase(Expression.TWO, Expression.LAMP)));
        m.Add(new Phrase(Expression.IN_RED_AREA, new Phrase(Expression.TWO, Expression.LAMP)));

        // things Bob doesn't take to be true of three lamps
        m.Add(new Phrase(Expression.FOUNTAIN, new Phrase(Expression.THREE, Expression.LAMP)));
        m.Add(new Phrase(Expression.LAMP, new Phrase(Expression.THREE, Expression.LAMP)));
        m.Add(new Phrase(Expression.ACTIVE, new Phrase(Expression.THREE, Expression.LAMP)));
        m.Add(new Phrase(Expression.INACTIVE, new Phrase(Expression.THREE, Expression.LAMP)));
        m.Add(new Phrase(Expression.KING, new Phrase(Expression.THREE, Expression.LAMP)));
        m.Add(new Phrase(Expression.YELLOW, new Phrase(Expression.THREE, Expression.LAMP)));
        m.Add(new Phrase(Expression.GREEN, new Phrase(Expression.THREE, Expression.LAMP)));
        m.Add(new Phrase(Expression.BLUE, new Phrase(Expression.THREE, Expression.LAMP)));
        m.Add(new Phrase(Expression.RED, new Phrase(Expression.THREE, Expression.LAMP)));
        m.Add(new Phrase(Expression.NEAR_YOU, new Phrase(Expression.THREE, Expression.LAMP)));
        m.Add(new Phrase(Expression.IN_YELLOW_AREA, new Phrase(Expression.THREE, Expression.LAMP)));
        m.Add(new Phrase(Expression.IN_GREEN_AREA, new Phrase(Expression.THREE, Expression.LAMP)));
        m.Add(new Phrase(Expression.IN_BLUE_AREA, new Phrase(Expression.THREE, Expression.LAMP)));
        m.Add(new Phrase(Expression.IN_RED_AREA, new Phrase(Expression.THREE, Expression.LAMP)));

        // things Bob doesn't take to be true of every lamp
        m.Add(new Phrase(Expression.FOUNTAIN, new Phrase(Expression.EVERY, Expression.LAMP)));
        m.Add(new Phrase(Expression.ACTIVE, new Phrase(Expression.EVERY, Expression.LAMP)));
        m.Add(new Phrase(Expression.INACTIVE, new Phrase(Expression.EVERY, Expression.LAMP)));
        m.Add(new Phrase(Expression.KING, new Phrase(Expression.EVERY, Expression.LAMP)));
        m.Add(new Phrase(Expression.YELLOW, new Phrase(Expression.EVERY, Expression.LAMP)));
        m.Add(new Phrase(Expression.GREEN, new Phrase(Expression.EVERY, Expression.LAMP)));
        m.Add(new Phrase(Expression.BLUE, new Phrase(Expression.EVERY, Expression.LAMP)));
        m.Add(new Phrase(Expression.RED, new Phrase(Expression.EVERY, Expression.LAMP)));
        m.Add(new Phrase(Expression.NEAR_YOU, new Phrase(Expression.EVERY, Expression.LAMP)));
        m.Add(new Phrase(Expression.IN_YELLOW_AREA, new Phrase(Expression.EVERY, Expression.LAMP)));
        m.Add(new Phrase(Expression.IN_GREEN_AREA, new Phrase(Expression.EVERY, Expression.LAMP)));
        m.Add(new Phrase(Expression.IN_BLUE_AREA, new Phrase(Expression.EVERY, Expression.LAMP)));
        m.Add(new Phrase(Expression.IN_RED_AREA, new Phrase(Expression.EVERY, Expression.LAMP)));

        // things Bob doesn't take to be true of the active thing
        // m.Add(new Phrase(Expression.FOUNTAIN, new Phrase(Expression.THE, Expression.ACTIVE)));
        // m.Add(new Phrase(Expression.LAMP, new Phrase(Expression.THE, Expression.ACTIVE)));
        m.Add(new Phrase(Expression.INACTIVE, new Phrase(Expression.THE, Expression.ACTIVE)));
        m.Add(new Phrase(Expression.KING, new Phrase(Expression.THE, Expression.ACTIVE)));
        m.Add(new Phrase(Expression.YELLOW, new Phrase(Expression.THE, Expression.ACTIVE)));
        m.Add(new Phrase(Expression.GREEN, new Phrase(Expression.THE, Expression.ACTIVE)));
        m.Add(new Phrase(Expression.BLUE, new Phrase(Expression.THE, Expression.ACTIVE)));
        m.Add(new Phrase(Expression.RED, new Phrase(Expression.THE, Expression.ACTIVE)));
        // m.Add(new Phrase(Expression.NEAR_YOU, new Phrase(Expression.THE, Expression.ACTIVE)));
        m.Add(new Phrase(Expression.IN_YELLOW_AREA, new Phrase(Expression.THE, Expression.ACTIVE)));
        m.Add(new Phrase(Expression.IN_GREEN_AREA, new Phrase(Expression.THE, Expression.ACTIVE)));
        m.Add(new Phrase(Expression.IN_BLUE_AREA, new Phrase(Expression.THE, Expression.ACTIVE)));

        // things Bob doesn't take to be true of an active thing
        m.Add(new Phrase(Expression.INACTIVE, new Phrase(Expression.A, Expression.ACTIVE)));
        m.Add(new Phrase(Expression.YELLOW, new Phrase(Expression.A, Expression.ACTIVE)));
        m.Add(new Phrase(Expression.GREEN, new Phrase(Expression.A, Expression.ACTIVE)));
        m.Add(new Phrase(Expression.BLUE, new Phrase(Expression.A, Expression.ACTIVE)));
        m.Add(new Phrase(Expression.RED, new Phrase(Expression.A, Expression.ACTIVE)));
        m.Add(new Phrase(Expression.IN_YELLOW_AREA, new Phrase(Expression.A, Expression.ACTIVE)));
        m.Add(new Phrase(Expression.IN_GREEN_AREA, new Phrase(Expression.A, Expression.ACTIVE)));

        // things Bob doesn't take to be true of two active things
        m.Add(new Phrase(Expression.LAMP, new Phrase(Expression.TWO, Expression.ACTIVE)));        
        m.Add(new Phrase(Expression.INACTIVE, new Phrase(Expression.TWO, Expression.ACTIVE)));
        m.Add(new Phrase(Expression.KING, new Phrase(Expression.TWO, Expression.ACTIVE)));
        m.Add(new Phrase(Expression.YELLOW, new Phrase(Expression.TWO, Expression.ACTIVE)));
        m.Add(new Phrase(Expression.GREEN, new Phrase(Expression.TWO, Expression.ACTIVE)));
        m.Add(new Phrase(Expression.BLUE, new Phrase(Expression.TWO, Expression.ACTIVE)));
        m.Add(new Phrase(Expression.RED, new Phrase(Expression.TWO, Expression.ACTIVE)));
        m.Add(new Phrase(Expression.NEAR_YOU, new Phrase(Expression.TWO, Expression.ACTIVE)));
        m.Add(new Phrase(Expression.IN_YELLOW_AREA, new Phrase(Expression.TWO, Expression.ACTIVE)));
        m.Add(new Phrase(Expression.IN_GREEN_AREA, new Phrase(Expression.TWO, Expression.ACTIVE)));
        m.Add(new Phrase(Expression.IN_BLUE_AREA, new Phrase(Expression.TWO, Expression.ACTIVE)));

        // things Bob doesn't take to be true of three active things
        m.Add(new Phrase(Expression.FOUNTAIN, new Phrase(Expression.THREE, Expression.ACTIVE)));
        m.Add(new Phrase(Expression.LAMP, new Phrase(Expression.THREE, Expression.ACTIVE)));
        m.Add(new Phrase(Expression.INACTIVE, new Phrase(Expression.THREE, Expression.ACTIVE)));
        m.Add(new Phrase(Expression.KING, new Phrase(Expression.THREE, Expression.ACTIVE)));
        m.Add(new Phrase(Expression.YELLOW, new Phrase(Expression.THREE, Expression.ACTIVE)));
        m.Add(new Phrase(Expression.GREEN, new Phrase(Expression.THREE, Expression.ACTIVE)));
        m.Add(new Phrase(Expression.BLUE, new Phrase(Expression.THREE, Expression.ACTIVE)));
        m.Add(new Phrase(Expression.RED, new Phrase(Expression.THREE, Expression.ACTIVE)));
        m.Add(new Phrase(Expression.NEAR_YOU, new Phrase(Expression.THREE, Expression.ACTIVE)));
        m.Add(new Phrase(Expression.IN_YELLOW_AREA, new Phrase(Expression.THREE, Expression.ACTIVE)));
        m.Add(new Phrase(Expression.IN_GREEN_AREA, new Phrase(Expression.THREE, Expression.ACTIVE)));
        m.Add(new Phrase(Expression.IN_BLUE_AREA, new Phrase(Expression.THREE, Expression.ACTIVE)));
        m.Add(new Phrase(Expression.IN_RED_AREA, new Phrase(Expression.THREE, Expression.ACTIVE)));
        
        // things Bob doesn't take to be true of every active thing
        m.Add(new Phrase(Expression.FOUNTAIN, new Phrase(Expression.EVERY, Expression.ACTIVE)));
        m.Add(new Phrase(Expression.LAMP, new Phrase(Expression.EVERY, Expression.ACTIVE)));
        m.Add(new Phrase(Expression.INACTIVE, new Phrase(Expression.EVERY, Expression.ACTIVE)));
        m.Add(new Phrase(Expression.KING, new Phrase(Expression.EVERY, Expression.ACTIVE)));
        m.Add(new Phrase(Expression.YELLOW, new Phrase(Expression.EVERY, Expression.ACTIVE)));
        m.Add(new Phrase(Expression.GREEN, new Phrase(Expression.EVERY, Expression.ACTIVE)));
        m.Add(new Phrase(Expression.BLUE, new Phrase(Expression.EVERY, Expression.ACTIVE)));
        m.Add(new Phrase(Expression.RED, new Phrase(Expression.EVERY, Expression.ACTIVE)));
        m.Add(new Phrase(Expression.NEAR_YOU, new Phrase(Expression.EVERY, Expression.ACTIVE)));
        m.Add(new Phrase(Expression.IN_YELLOW_AREA, new Phrase(Expression.EVERY, Expression.ACTIVE)));
        m.Add(new Phrase(Expression.IN_GREEN_AREA, new Phrase(Expression.EVERY, Expression.ACTIVE)));
        m.Add(new Phrase(Expression.IN_BLUE_AREA, new Phrase(Expression.EVERY, Expression.ACTIVE)));
        m.Add(new Phrase(Expression.IN_RED_AREA, new Phrase(Expression.EVERY, Expression.ACTIVE)));

        // things Bob doesn't take to be true of the inactive thing
        // m.Add(new Phrase(Expression.FOUNTAIN, new Phrase(Expression.THE, Expression.INACTIVE)));
        // m.Add(new Phrase(Expression.LAMP, new Phrase(Expression.THE, Expression.INACTIVE)));
        m.Add(new Phrase(Expression.ACTIVE, new Phrase(Expression.THE, Expression.INACTIVE)));
        m.Add(new Phrase(Expression.KING, new Phrase(Expression.THE, Expression.INACTIVE)));
        m.Add(new Phrase(Expression.YELLOW, new Phrase(Expression.THE, Expression.INACTIVE)));
        m.Add(new Phrase(Expression.GREEN, new Phrase(Expression.THE, Expression.INACTIVE)));
        m.Add(new Phrase(Expression.BLUE, new Phrase(Expression.THE, Expression.INACTIVE)));
        m.Add(new Phrase(Expression.RED, new Phrase(Expression.THE, Expression.INACTIVE)));
        m.Add(new Phrase(Expression.NEAR_YOU, new Phrase(Expression.THE, Expression.INACTIVE)));
        m.Add(new Phrase(Expression.IN_YELLOW_AREA, new Phrase(Expression.THE, Expression.INACTIVE)));
        m.Add(new Phrase(Expression.IN_GREEN_AREA, new Phrase(Expression.THE, Expression.INACTIVE)));
        m.Add(new Phrase(Expression.IN_RED_AREA, new Phrase(Expression.THE, Expression.INACTIVE)));

        // things Bob doesn't take to be true of an inactive thing
        m.Add(new Phrase(Expression.ACTIVE, new Phrase(Expression.A, Expression.INACTIVE)));
        m.Add(new Phrase(Expression.KING, new Phrase(Expression.A, Expression.INACTIVE)));
        m.Add(new Phrase(Expression.YELLOW, new Phrase(Expression.A, Expression.INACTIVE)));
        m.Add(new Phrase(Expression.GREEN, new Phrase(Expression.A, Expression.INACTIVE)));
        m.Add(new Phrase(Expression.BLUE, new Phrase(Expression.A, Expression.INACTIVE)));
        m.Add(new Phrase(Expression.RED, new Phrase(Expression.A, Expression.INACTIVE)));
        m.Add(new Phrase(Expression.NEAR_YOU, new Phrase(Expression.A, Expression.INACTIVE)));
        m.Add(new Phrase(Expression.IN_YELLOW_AREA, new Phrase(Expression.A, Expression.INACTIVE)));
        m.Add(new Phrase(Expression.IN_GREEN_AREA, new Phrase(Expression.A, Expression.INACTIVE)));
        m.Add(new Phrase(Expression.IN_RED_AREA, new Phrase(Expression.A, Expression.INACTIVE)));
        
        // things Bob doesn't take to be true of two inactive things
        m.Add(new Phrase(Expression.FOUNTAIN, new Phrase(Expression.TWO, Expression.INACTIVE)));
        m.Add(new Phrase(Expression.LAMP, new Phrase(Expression.TWO, Expression.INACTIVE)));
        m.Add(new Phrase(Expression.ACTIVE, new Phrase(Expression.TWO, Expression.INACTIVE)));
        m.Add(new Phrase(Expression.KING, new Phrase(Expression.TWO, Expression.INACTIVE)));
        m.Add(new Phrase(Expression.YELLOW, new Phrase(Expression.TWO, Expression.INACTIVE)));
        m.Add(new Phrase(Expression.GREEN, new Phrase(Expression.TWO, Expression.INACTIVE)));
        m.Add(new Phrase(Expression.BLUE, new Phrase(Expression.TWO, Expression.INACTIVE)));
        m.Add(new Phrase(Expression.RED, new Phrase(Expression.TWO, Expression.INACTIVE)));
        m.Add(new Phrase(Expression.NEAR_YOU, new Phrase(Expression.TWO, Expression.INACTIVE)));
        m.Add(new Phrase(Expression.IN_YELLOW_AREA, new Phrase(Expression.TWO, Expression.INACTIVE)));
        m.Add(new Phrase(Expression.IN_GREEN_AREA, new Phrase(Expression.TWO, Expression.INACTIVE)));
        m.Add(new Phrase(Expression.IN_RED_AREA, new Phrase(Expression.TWO, Expression.INACTIVE)));

        // things Bob doesn't take to be true of three inactive thing
        m.Add(new Phrase(Expression.FOUNTAIN, new Phrase(Expression.THREE, Expression.INACTIVE)));
        m.Add(new Phrase(Expression.LAMP, new Phrase(Expression.THREE, Expression.INACTIVE)));
        m.Add(new Phrase(Expression.ACTIVE, new Phrase(Expression.THREE, Expression.INACTIVE)));
        m.Add(new Phrase(Expression.INACTIVE, new Phrase(Expression.THREE, Expression.INACTIVE)));
        m.Add(new Phrase(Expression.KING, new Phrase(Expression.THREE, Expression.INACTIVE)));
        m.Add(new Phrase(Expression.YELLOW, new Phrase(Expression.THREE, Expression.INACTIVE)));
        m.Add(new Phrase(Expression.GREEN, new Phrase(Expression.THREE, Expression.INACTIVE)));
        m.Add(new Phrase(Expression.BLUE, new Phrase(Expression.THREE, Expression.INACTIVE)));
        m.Add(new Phrase(Expression.RED, new Phrase(Expression.THREE, Expression.INACTIVE)));
        m.Add(new Phrase(Expression.NEAR_YOU, new Phrase(Expression.THREE, Expression.INACTIVE)));
        m.Add(new Phrase(Expression.IN_YELLOW_AREA, new Phrase(Expression.THREE, Expression.INACTIVE)));
        m.Add(new Phrase(Expression.IN_GREEN_AREA, new Phrase(Expression.THREE, Expression.INACTIVE)));
        m.Add(new Phrase(Expression.IN_BLUE_AREA, new Phrase(Expression.THREE, Expression.INACTIVE)));
        m.Add(new Phrase(Expression.IN_RED_AREA, new Phrase(Expression.THREE, Expression.INACTIVE)));
        
        // things Bob doesn't take to be true of every inactive thing
        m.Add(new Phrase(Expression.FOUNTAIN, new Phrase(Expression.EVERY, Expression.INACTIVE)));
        m.Add(new Phrase(Expression.LAMP, new Phrase(Expression.EVERY, Expression.INACTIVE)));
        m.Add(new Phrase(Expression.ACTIVE, new Phrase(Expression.EVERY, Expression.INACTIVE)));
        m.Add(new Phrase(Expression.KING, new Phrase(Expression.EVERY, Expression.INACTIVE)));
        m.Add(new Phrase(Expression.YELLOW, new Phrase(Expression.EVERY, Expression.INACTIVE)));
        m.Add(new Phrase(Expression.GREEN, new Phrase(Expression.EVERY, Expression.INACTIVE)));
        m.Add(new Phrase(Expression.BLUE, new Phrase(Expression.EVERY, Expression.INACTIVE)));
        m.Add(new Phrase(Expression.RED, new Phrase(Expression.EVERY, Expression.INACTIVE)));
        m.Add(new Phrase(Expression.NEAR_YOU, new Phrase(Expression.EVERY, Expression.INACTIVE)));
        m.Add(new Phrase(Expression.IN_YELLOW_AREA, new Phrase(Expression.EVERY, Expression.INACTIVE)));
        m.Add(new Phrase(Expression.IN_GREEN_AREA, new Phrase(Expression.EVERY, Expression.INACTIVE)));
        m.Add(new Phrase(Expression.IN_RED_AREA, new Phrase(Expression.EVERY, Expression.INACTIVE)));

        // things Bob doesn't take to be true of the king
        m.Add(new Phrase(Expression.FOUNTAIN, new Phrase(Expression.THE, Expression.KING)));
        m.Add(new Phrase(Expression.LAMP, new Phrase(Expression.THE, Expression.KING)));
        m.Add(new Phrase(Expression.INACTIVE, new Phrase(Expression.THE, Expression.KING)));
        m.Add(new Phrase(Expression.YELLOW, new Phrase(Expression.THE, Expression.KING)));
        m.Add(new Phrase(Expression.GREEN, new Phrase(Expression.THE, Expression.KING)));
        m.Add(new Phrase(Expression.BLUE, new Phrase(Expression.THE, Expression.KING)));
        m.Add(new Phrase(Expression.RED, new Phrase(Expression.THE, Expression.KING)));
        m.Add(new Phrase(Expression.IN_YELLOW_AREA, new Phrase(Expression.THE, Expression.KING)));
        m.Add(new Phrase(Expression.IN_GREEN_AREA, new Phrase(Expression.THE, Expression.KING)));
        m.Add(new Phrase(Expression.IN_BLUE_AREA, new Phrase(Expression.THE, Expression.KING)));

        // things Bob doesn't take to be true of a king
        m.Add(new Phrase(Expression.FOUNTAIN, new Phrase(Expression.A, Expression.KING)));
        m.Add(new Phrase(Expression.LAMP, new Phrase(Expression.A, Expression.KING)));
        m.Add(new Phrase(Expression.INACTIVE, new Phrase(Expression.A, Expression.KING)));
        m.Add(new Phrase(Expression.YELLOW, new Phrase(Expression.A, Expression.KING)));
        m.Add(new Phrase(Expression.GREEN, new Phrase(Expression.A, Expression.KING)));
        m.Add(new Phrase(Expression.BLUE, new Phrase(Expression.A, Expression.KING)));
        m.Add(new Phrase(Expression.RED, new Phrase(Expression.A, Expression.KING)));
        m.Add(new Phrase(Expression.IN_YELLOW_AREA, new Phrase(Expression.A, Expression.KING)));
        m.Add(new Phrase(Expression.IN_GREEN_AREA, new Phrase(Expression.A, Expression.KING)));
        m.Add(new Phrase(Expression.IN_BLUE_AREA, new Phrase(Expression.A, Expression.KING)));

        // things Bob doesn't take to be true of two kings
        m.Add(new Phrase(Expression.FOUNTAIN, new Phrase(Expression.TWO, Expression.KING)));
        m.Add(new Phrase(Expression.LAMP, new Phrase(Expression.TWO, Expression.KING)));
        m.Add(new Phrase(Expression.ACTIVE, new Phrase(Expression.TWO, Expression.KING)));
        m.Add(new Phrase(Expression.INACTIVE, new Phrase(Expression.TWO, Expression.KING)));
        m.Add(new Phrase(Expression.KING, new Phrase(Expression.TWO, Expression.KING)));
        m.Add(new Phrase(Expression.YELLOW, new Phrase(Expression.TWO, Expression.KING)));
        m.Add(new Phrase(Expression.GREEN, new Phrase(Expression.TWO, Expression.KING)));
        m.Add(new Phrase(Expression.BLUE, new Phrase(Expression.TWO, Expression.KING)));
        m.Add(new Phrase(Expression.RED, new Phrase(Expression.TWO, Expression.KING)));
        m.Add(new Phrase(Expression.NEAR_YOU, new Phrase(Expression.TWO, Expression.KING)));
        m.Add(new Phrase(Expression.IN_YELLOW_AREA, new Phrase(Expression.TWO, Expression.KING)));
        m.Add(new Phrase(Expression.IN_GREEN_AREA, new Phrase(Expression.TWO, Expression.KING)));
        m.Add(new Phrase(Expression.IN_BLUE_AREA, new Phrase(Expression.TWO, Expression.KING)));
        m.Add(new Phrase(Expression.IN_RED_AREA, new Phrase(Expression.TWO, Expression.KING)));

        // things Bob doesn't take to be true of three kings
        m.Add(new Phrase(Expression.FOUNTAIN, new Phrase(Expression.THREE, Expression.KING)));
        m.Add(new Phrase(Expression.LAMP, new Phrase(Expression.THREE, Expression.KING)));
        m.Add(new Phrase(Expression.ACTIVE, new Phrase(Expression.THREE, Expression.KING)));
        m.Add(new Phrase(Expression.INACTIVE, new Phrase(Expression.THREE, Expression.KING)));
        m.Add(new Phrase(Expression.KING, new Phrase(Expression.THREE, Expression.KING)));
        m.Add(new Phrase(Expression.YELLOW, new Phrase(Expression.THREE, Expression.KING)));
        m.Add(new Phrase(Expression.GREEN, new Phrase(Expression.THREE, Expression.KING)));
        m.Add(new Phrase(Expression.BLUE, new Phrase(Expression.THREE, Expression.KING)));
        m.Add(new Phrase(Expression.RED, new Phrase(Expression.THREE, Expression.KING)));
        m.Add(new Phrase(Expression.NEAR_YOU, new Phrase(Expression.THREE, Expression.KING)));
        m.Add(new Phrase(Expression.IN_YELLOW_AREA, new Phrase(Expression.THREE, Expression.KING)));
        m.Add(new Phrase(Expression.IN_GREEN_AREA, new Phrase(Expression.THREE, Expression.KING)));
        m.Add(new Phrase(Expression.IN_BLUE_AREA, new Phrase(Expression.THREE, Expression.KING)));
        m.Add(new Phrase(Expression.IN_RED_AREA, new Phrase(Expression.THREE, Expression.KING)));

        // things Bob doesn't take to be true of every king
        m.Add(new Phrase(Expression.FOUNTAIN, new Phrase(Expression.EVERY, Expression.KING)));
        m.Add(new Phrase(Expression.LAMP, new Phrase(Expression.EVERY, Expression.KING)));
        m.Add(new Phrase(Expression.INACTIVE, new Phrase(Expression.EVERY, Expression.KING)));
        m.Add(new Phrase(Expression.YELLOW, new Phrase(Expression.EVERY, Expression.KING)));
        m.Add(new Phrase(Expression.GREEN, new Phrase(Expression.EVERY, Expression.KING)));
        m.Add(new Phrase(Expression.BLUE, new Phrase(Expression.EVERY, Expression.KING)));
        m.Add(new Phrase(Expression.RED, new Phrase(Expression.EVERY, Expression.KING)));
        m.Add(new Phrase(Expression.IN_YELLOW_AREA, new Phrase(Expression.EVERY, Expression.KING)));
        m.Add(new Phrase(Expression.IN_GREEN_AREA, new Phrase(Expression.EVERY, Expression.KING)));
        m.Add(new Phrase(Expression.IN_BLUE_AREA, new Phrase(Expression.EVERY, Expression.KING)));

        // things Bob doesn't take to be true of the yellow thing
        // m.Add(new Phrase(Expression.FOUNTAIN, new Phrase(Expression.THE, Expression.YELLOW)));
        // m.Add(new Phrase(Expression.LAMP, new Phrase(Expression.THE, Expression.YELLOW)));
        // m.Add(new Phrase(Expression.ACTIVE, new Phrase(Expression.THE, Expression.YELLOW)));
        // m.Add(new Phrase(Expression.INACTIVE, new Phrase(Expression.THE, Expression.YELLOW)));
        // m.Add(new Phrase(Expression.KING, new Phrase(Expression.THE, Expression.YELLOW)));
        // m.Add(new Phrase(Expression.YELLOW, new Phrase(Expression.THE, Expression.YELLOW)));
        // m.Add(new Phrase(Expression.GREEN, new Phrase(Expression.THE, Expression.YELLOW)));
        // m.Add(new Phrase(Expression.BLUE, new Phrase(Expression.THE, Expression.YELLOW)));
        // m.Add(new Phrase(Expression.RED, new Phrase(Expression.THE, Expression.YELLOW)));
        // m.Add(new Phrase(Expression.NEAR_YOU, new Phrase(Expression.THE, Expression.YELLOW)));
        // m.Add(new Phrase(Expression.IN_YELLOW_AREA, new Phrase(Expression.THE, Expression.YELLOW)));
        // m.Add(new Phrase(Expression.IN_GREEN_AREA, new Phrase(Expression.THE, Expression.YELLOW)));
        // m.Add(new Phrase(Expression.IN_BLUE_AREA, new Phrase(Expression.THE, Expression.YELLOW)));
        // m.Add(new Phrase(Expression.IN_RED_AREA, new Phrase(Expression.THE, Expression.YELLOW)));
        
        // things Bob doesn't take to be true of a yellow thing
        m.Add(new Phrase(Expression.FOUNTAIN, new Phrase(Expression.A, Expression.YELLOW)));
        m.Add(new Phrase(Expression.LAMP, new Phrase(Expression.A, Expression.YELLOW)));
        m.Add(new Phrase(Expression.ACTIVE, new Phrase(Expression.A, Expression.YELLOW)));
        m.Add(new Phrase(Expression.INACTIVE, new Phrase(Expression.A, Expression.YELLOW)));
        m.Add(new Phrase(Expression.KING, new Phrase(Expression.A, Expression.YELLOW)));
        m.Add(new Phrase(Expression.YELLOW, new Phrase(Expression.A, Expression.YELLOW)));
        m.Add(new Phrase(Expression.GREEN, new Phrase(Expression.A, Expression.YELLOW)));
        m.Add(new Phrase(Expression.BLUE, new Phrase(Expression.A, Expression.YELLOW)));
        m.Add(new Phrase(Expression.RED, new Phrase(Expression.A, Expression.YELLOW)));
        m.Add(new Phrase(Expression.NEAR_YOU, new Phrase(Expression.A, Expression.YELLOW)));
        m.Add(new Phrase(Expression.IN_YELLOW_AREA, new Phrase(Expression.A, Expression.YELLOW)));
        m.Add(new Phrase(Expression.IN_GREEN_AREA, new Phrase(Expression.A, Expression.YELLOW)));
        m.Add(new Phrase(Expression.IN_BLUE_AREA, new Phrase(Expression.A, Expression.YELLOW)));
        m.Add(new Phrase(Expression.IN_RED_AREA, new Phrase(Expression.A, Expression.YELLOW)));

        // things Bob doesn't take to be true of two yellow things
        m.Add(new Phrase(Expression.FOUNTAIN, new Phrase(Expression.TWO, Expression.YELLOW)));
        m.Add(new Phrase(Expression.LAMP, new Phrase(Expression.TWO, Expression.YELLOW)));
        m.Add(new Phrase(Expression.ACTIVE, new Phrase(Expression.TWO, Expression.YELLOW)));
        m.Add(new Phrase(Expression.INACTIVE, new Phrase(Expression.TWO, Expression.YELLOW)));
        m.Add(new Phrase(Expression.KING, new Phrase(Expression.TWO, Expression.YELLOW)));
        m.Add(new Phrase(Expression.YELLOW, new Phrase(Expression.TWO, Expression.YELLOW)));
        m.Add(new Phrase(Expression.GREEN, new Phrase(Expression.TWO, Expression.YELLOW)));
        m.Add(new Phrase(Expression.BLUE, new Phrase(Expression.TWO, Expression.YELLOW)));
        m.Add(new Phrase(Expression.RED, new Phrase(Expression.TWO, Expression.YELLOW)));
        m.Add(new Phrase(Expression.NEAR_YOU, new Phrase(Expression.TWO, Expression.YELLOW)));
        m.Add(new Phrase(Expression.IN_YELLOW_AREA, new Phrase(Expression.TWO, Expression.YELLOW)));
        m.Add(new Phrase(Expression.IN_GREEN_AREA, new Phrase(Expression.TWO, Expression.YELLOW)));
        m.Add(new Phrase(Expression.IN_BLUE_AREA, new Phrase(Expression.TWO, Expression.YELLOW)));
        m.Add(new Phrase(Expression.IN_RED_AREA, new Phrase(Expression.TWO, Expression.YELLOW)));

        // things Bob doesn't take to be true of three yellow things
        m.Add(new Phrase(Expression.FOUNTAIN, new Phrase(Expression.THREE, Expression.YELLOW)));
        m.Add(new Phrase(Expression.LAMP, new Phrase(Expression.THREE, Expression.YELLOW)));
        m.Add(new Phrase(Expression.ACTIVE, new Phrase(Expression.THREE, Expression.YELLOW)));
        m.Add(new Phrase(Expression.INACTIVE, new Phrase(Expression.THREE, Expression.YELLOW)));
        m.Add(new Phrase(Expression.KING, new Phrase(Expression.THREE, Expression.YELLOW)));
        m.Add(new Phrase(Expression.YELLOW, new Phrase(Expression.THREE, Expression.YELLOW)));
        m.Add(new Phrase(Expression.GREEN, new Phrase(Expression.THREE, Expression.YELLOW)));
        m.Add(new Phrase(Expression.BLUE, new Phrase(Expression.THREE, Expression.YELLOW)));
        m.Add(new Phrase(Expression.RED, new Phrase(Expression.THREE, Expression.YELLOW)));
        m.Add(new Phrase(Expression.NEAR_YOU, new Phrase(Expression.THREE, Expression.YELLOW)));
        m.Add(new Phrase(Expression.IN_YELLOW_AREA, new Phrase(Expression.THREE, Expression.YELLOW)));
        m.Add(new Phrase(Expression.IN_GREEN_AREA, new Phrase(Expression.THREE, Expression.YELLOW)));
        m.Add(new Phrase(Expression.IN_BLUE_AREA, new Phrase(Expression.THREE, Expression.YELLOW)));
        m.Add(new Phrase(Expression.IN_RED_AREA, new Phrase(Expression.THREE, Expression.YELLOW)));

        // things Bob doesn't take to be true of every yellow thing
        m.Add(new Phrase(Expression.FOUNTAIN, new Phrase(Expression.EVERY, Expression.YELLOW)));
        m.Add(new Phrase(Expression.LAMP, new Phrase(Expression.EVERY, Expression.YELLOW)));
        m.Add(new Phrase(Expression.ACTIVE, new Phrase(Expression.EVERY, Expression.YELLOW)));
        m.Add(new Phrase(Expression.INACTIVE, new Phrase(Expression.EVERY, Expression.YELLOW)));
        m.Add(new Phrase(Expression.KING, new Phrase(Expression.EVERY, Expression.YELLOW)));
        m.Add(new Phrase(Expression.GREEN, new Phrase(Expression.EVERY, Expression.YELLOW)));
        m.Add(new Phrase(Expression.BLUE, new Phrase(Expression.EVERY, Expression.YELLOW)));
        m.Add(new Phrase(Expression.RED, new Phrase(Expression.EVERY, Expression.YELLOW)));
        m.Add(new Phrase(Expression.NEAR_YOU, new Phrase(Expression.EVERY, Expression.YELLOW)));
        m.Add(new Phrase(Expression.IN_YELLOW_AREA, new Phrase(Expression.EVERY, Expression.YELLOW)));
        m.Add(new Phrase(Expression.IN_GREEN_AREA, new Phrase(Expression.EVERY, Expression.YELLOW)));
        m.Add(new Phrase(Expression.IN_BLUE_AREA, new Phrase(Expression.EVERY, Expression.YELLOW)));
        m.Add(new Phrase(Expression.IN_RED_AREA, new Phrase(Expression.EVERY, Expression.YELLOW)));

        // things Bob doesn't take to be true of the green thing
        // m.Add(new Phrase(Expression.FOUNTAIN, new Phrase(Expression.THE, Expression.GREEN)));
        // m.Add(new Phrase(Expression.LAMP, new Phrase(Expression.THE, Expression.GREEN)));
        // m.Add(new Phrase(Expression.ACTIVE, new Phrase(Expression.THE, Expression.GREEN)));
        // m.Add(new Phrase(Expression.INACTIVE, new Phrase(Expression.THE, Expression.GREEN)));
        // m.Add(new Phrase(Expression.KING, new Phrase(Expression.THE, Expression.GREEN)));
        // m.Add(new Phrase(Expression.YELLOW, new Phrase(Expression.THE, Expression.GREEN)));
        // m.Add(new Phrase(Expression.GREEN, new Phrase(Expression.THE, Expression.GREEN)));
        // m.Add(new Phrase(Expression.BLUE, new Phrase(Expression.THE, Expression.GREEN)));
        // m.Add(new Phrase(Expression.RED, new Phrase(Expression.THE, Expression.GREEN)));
        // m.Add(new Phrase(Expression.NEAR_YOU, new Phrase(Expression.THE, Expression.GREEN)));
        // m.Add(new Phrase(Expression.IN_YELLOW_AREA, new Phrase(Expression.THE, Expression.GREEN)));
        // m.Add(new Phrase(Expression.IN_GREEN_AREA, new Phrase(Expression.THE, Expression.GREEN)));
        // m.Add(new Phrase(Expression.IN_BLUE_AREA, new Phrase(Expression.THE, Expression.GREEN)));
        // m.Add(new Phrase(Expression.IN_RED_AREA, new Phrase(Expression.THE, Expression.GREEN)));
        
        // things Bob doesn't take to be true of a green thing
        m.Add(new Phrase(Expression.FOUNTAIN, new Phrase(Expression.A, Expression.GREEN)));
        m.Add(new Phrase(Expression.LAMP, new Phrase(Expression.A, Expression.GREEN)));
        m.Add(new Phrase(Expression.ACTIVE, new Phrase(Expression.A, Expression.GREEN)));
        m.Add(new Phrase(Expression.INACTIVE, new Phrase(Expression.A, Expression.GREEN)));
        m.Add(new Phrase(Expression.KING, new Phrase(Expression.A, Expression.GREEN)));
        m.Add(new Phrase(Expression.YELLOW, new Phrase(Expression.A, Expression.GREEN)));
        m.Add(new Phrase(Expression.GREEN, new Phrase(Expression.A, Expression.GREEN)));
        m.Add(new Phrase(Expression.BLUE, new Phrase(Expression.A, Expression.GREEN)));
        m.Add(new Phrase(Expression.RED, new Phrase(Expression.A, Expression.GREEN)));
        m.Add(new Phrase(Expression.NEAR_YOU, new Phrase(Expression.A, Expression.GREEN)));
        m.Add(new Phrase(Expression.IN_YELLOW_AREA, new Phrase(Expression.A, Expression.GREEN)));
        m.Add(new Phrase(Expression.IN_GREEN_AREA, new Phrase(Expression.A, Expression.GREEN)));
        m.Add(new Phrase(Expression.IN_BLUE_AREA, new Phrase(Expression.A, Expression.GREEN)));
        m.Add(new Phrase(Expression.IN_RED_AREA, new Phrase(Expression.A, Expression.GREEN)));

        // things Bob doesn't take to be true of two green things
        m.Add(new Phrase(Expression.FOUNTAIN, new Phrase(Expression.TWO, Expression.GREEN)));
        m.Add(new Phrase(Expression.LAMP, new Phrase(Expression.TWO, Expression.GREEN)));
        m.Add(new Phrase(Expression.ACTIVE, new Phrase(Expression.TWO, Expression.GREEN)));
        m.Add(new Phrase(Expression.INACTIVE, new Phrase(Expression.TWO, Expression.GREEN)));
        m.Add(new Phrase(Expression.KING, new Phrase(Expression.TWO, Expression.GREEN)));
        m.Add(new Phrase(Expression.YELLOW, new Phrase(Expression.TWO, Expression.GREEN)));
        m.Add(new Phrase(Expression.GREEN, new Phrase(Expression.TWO, Expression.GREEN)));
        m.Add(new Phrase(Expression.BLUE, new Phrase(Expression.TWO, Expression.GREEN)));
        m.Add(new Phrase(Expression.RED, new Phrase(Expression.TWO, Expression.GREEN)));
        m.Add(new Phrase(Expression.NEAR_YOU, new Phrase(Expression.TWO, Expression.GREEN)));
        m.Add(new Phrase(Expression.IN_YELLOW_AREA, new Phrase(Expression.TWO, Expression.GREEN)));
        m.Add(new Phrase(Expression.IN_GREEN_AREA, new Phrase(Expression.TWO, Expression.GREEN)));
        m.Add(new Phrase(Expression.IN_BLUE_AREA, new Phrase(Expression.TWO, Expression.GREEN)));
        m.Add(new Phrase(Expression.IN_RED_AREA, new Phrase(Expression.TWO, Expression.GREEN)));

        // things Bob doesn't take to be true of three green things
        m.Add(new Phrase(Expression.FOUNTAIN, new Phrase(Expression.THREE, Expression.GREEN)));
        m.Add(new Phrase(Expression.LAMP, new Phrase(Expression.THREE, Expression.GREEN)));
        m.Add(new Phrase(Expression.ACTIVE, new Phrase(Expression.THREE, Expression.GREEN)));
        m.Add(new Phrase(Expression.INACTIVE, new Phrase(Expression.THREE, Expression.GREEN)));
        m.Add(new Phrase(Expression.KING, new Phrase(Expression.THREE, Expression.GREEN)));
        m.Add(new Phrase(Expression.YELLOW, new Phrase(Expression.THREE, Expression.GREEN)));
        m.Add(new Phrase(Expression.GREEN, new Phrase(Expression.THREE, Expression.GREEN)));
        m.Add(new Phrase(Expression.BLUE, new Phrase(Expression.THREE, Expression.GREEN)));
        m.Add(new Phrase(Expression.RED, new Phrase(Expression.THREE, Expression.GREEN)));
        m.Add(new Phrase(Expression.NEAR_YOU, new Phrase(Expression.THREE, Expression.GREEN)));
        m.Add(new Phrase(Expression.IN_YELLOW_AREA, new Phrase(Expression.THREE, Expression.GREEN)));
        m.Add(new Phrase(Expression.IN_GREEN_AREA, new Phrase(Expression.THREE, Expression.GREEN)));
        m.Add(new Phrase(Expression.IN_BLUE_AREA, new Phrase(Expression.THREE, Expression.GREEN)));
        m.Add(new Phrase(Expression.IN_RED_AREA, new Phrase(Expression.THREE, Expression.GREEN)));

        // things Bob doesn't take to be true of every green thing
        m.Add(new Phrase(Expression.FOUNTAIN, new Phrase(Expression.EVERY, Expression.GREEN)));
        m.Add(new Phrase(Expression.LAMP, new Phrase(Expression.EVERY, Expression.GREEN)));
        m.Add(new Phrase(Expression.ACTIVE, new Phrase(Expression.EVERY, Expression.GREEN)));
        m.Add(new Phrase(Expression.INACTIVE, new Phrase(Expression.EVERY, Expression.GREEN)));
        m.Add(new Phrase(Expression.KING, new Phrase(Expression.EVERY, Expression.GREEN)));
        m.Add(new Phrase(Expression.YELLOW, new Phrase(Expression.EVERY, Expression.GREEN)));
        m.Add(new Phrase(Expression.BLUE, new Phrase(Expression.EVERY, Expression.GREEN)));
        m.Add(new Phrase(Expression.RED, new Phrase(Expression.EVERY, Expression.GREEN)));
        m.Add(new Phrase(Expression.NEAR_YOU, new Phrase(Expression.EVERY, Expression.GREEN)));
        m.Add(new Phrase(Expression.IN_YELLOW_AREA, new Phrase(Expression.EVERY, Expression.GREEN)));
        m.Add(new Phrase(Expression.IN_GREEN_AREA, new Phrase(Expression.EVERY, Expression.GREEN)));
        m.Add(new Phrase(Expression.IN_BLUE_AREA, new Phrase(Expression.EVERY, Expression.GREEN)));
        m.Add(new Phrase(Expression.IN_RED_AREA, new Phrase(Expression.EVERY, Expression.GREEN)));

        // things Bob doesn't take to be true of the blue thing
        // m.Add(new Phrase(Expression.FOUNTAIN, new Phrase(Expression.THE, Expression.BLUE)));
        // m.Add(new Phrase(Expression.LAMP, new Phrase(Expression.THE, Expression.BLUE)));
        // m.Add(new Phrase(Expression.ACTIVE, new Phrase(Expression.THE, Expression.BLUE)));
        // m.Add(new Phrase(Expression.INACTIVE, new Phrase(Expression.THE, Expression.BLUE)));
        // m.Add(new Phrase(Expression.KING, new Phrase(Expression.THE, Expression.BLUE)));
        // m.Add(new Phrase(Expression.YELLOW, new Phrase(Expression.THE, Expression.BLUE)));
        // m.Add(new Phrase(Expression.GREEN, new Phrase(Expression.THE, Expression.BLUE)));
        // m.Add(new Phrase(Expression.BLUE, new Phrase(Expression.THE, Expression.BLUE)));
        // m.Add(new Phrase(Expression.RED, new Phrase(Expression.THE, Expression.BLUE)));
        // m.Add(new Phrase(Expression.NEAR_YOU, new Phrase(Expression.THE, Expression.BLUE)));
        // m.Add(new Phrase(Expression.IN_YELLOW_AREA, new Phrase(Expression.THE, Expression.BLUE)));
        // m.Add(new Phrase(Expression.IN_GREEN_AREA, new Phrase(Expression.THE, Expression.BLUE)));
        // m.Add(new Phrase(Expression.IN_BLUE_AREA, new Phrase(Expression.THE, Expression.BLUE)));
        // m.Add(new Phrase(Expression.IN_RED_AREA, new Phrase(Expression.THE, Expression.BLUE)));
        
        // things Bob doesn't take to be true of a blue thing
        m.Add(new Phrase(Expression.FOUNTAIN, new Phrase(Expression.A, Expression.BLUE)));
        m.Add(new Phrase(Expression.LAMP, new Phrase(Expression.A, Expression.BLUE)));
        m.Add(new Phrase(Expression.ACTIVE, new Phrase(Expression.A, Expression.BLUE)));
        m.Add(new Phrase(Expression.INACTIVE, new Phrase(Expression.A, Expression.BLUE)));
        m.Add(new Phrase(Expression.KING, new Phrase(Expression.A, Expression.BLUE)));
        m.Add(new Phrase(Expression.YELLOW, new Phrase(Expression.A, Expression.BLUE)));
        m.Add(new Phrase(Expression.GREEN, new Phrase(Expression.A, Expression.BLUE)));
        m.Add(new Phrase(Expression.BLUE, new Phrase(Expression.A, Expression.BLUE)));
        m.Add(new Phrase(Expression.RED, new Phrase(Expression.A, Expression.BLUE)));
        m.Add(new Phrase(Expression.NEAR_YOU, new Phrase(Expression.A, Expression.BLUE)));
        m.Add(new Phrase(Expression.IN_YELLOW_AREA, new Phrase(Expression.A, Expression.BLUE)));
        m.Add(new Phrase(Expression.IN_GREEN_AREA, new Phrase(Expression.A, Expression.BLUE)));
        m.Add(new Phrase(Expression.IN_BLUE_AREA, new Phrase(Expression.A, Expression.BLUE)));
        m.Add(new Phrase(Expression.IN_RED_AREA, new Phrase(Expression.A, Expression.BLUE)));

        // things Bob doesn't take to be true of two blue things
        m.Add(new Phrase(Expression.FOUNTAIN, new Phrase(Expression.TWO, Expression.BLUE)));
        m.Add(new Phrase(Expression.LAMP, new Phrase(Expression.TWO, Expression.BLUE)));
        m.Add(new Phrase(Expression.ACTIVE, new Phrase(Expression.TWO, Expression.BLUE)));
        m.Add(new Phrase(Expression.INACTIVE, new Phrase(Expression.TWO, Expression.BLUE)));
        m.Add(new Phrase(Expression.KING, new Phrase(Expression.TWO, Expression.BLUE)));
        m.Add(new Phrase(Expression.YELLOW, new Phrase(Expression.TWO, Expression.BLUE)));
        m.Add(new Phrase(Expression.GREEN, new Phrase(Expression.TWO, Expression.BLUE)));
        m.Add(new Phrase(Expression.BLUE, new Phrase(Expression.TWO, Expression.BLUE)));
        m.Add(new Phrase(Expression.RED, new Phrase(Expression.TWO, Expression.BLUE)));
        m.Add(new Phrase(Expression.NEAR_YOU, new Phrase(Expression.TWO, Expression.BLUE)));
        m.Add(new Phrase(Expression.IN_YELLOW_AREA, new Phrase(Expression.TWO, Expression.BLUE)));
        m.Add(new Phrase(Expression.IN_GREEN_AREA, new Phrase(Expression.TWO, Expression.BLUE)));
        m.Add(new Phrase(Expression.IN_BLUE_AREA, new Phrase(Expression.TWO, Expression.BLUE)));
        m.Add(new Phrase(Expression.IN_RED_AREA, new Phrase(Expression.TWO, Expression.BLUE)));

        // things Bob doesn't take to be true of three blue things
        m.Add(new Phrase(Expression.FOUNTAIN, new Phrase(Expression.THREE, Expression.BLUE)));
        m.Add(new Phrase(Expression.LAMP, new Phrase(Expression.THREE, Expression.BLUE)));
        m.Add(new Phrase(Expression.ACTIVE, new Phrase(Expression.THREE, Expression.BLUE)));
        m.Add(new Phrase(Expression.INACTIVE, new Phrase(Expression.THREE, Expression.BLUE)));
        m.Add(new Phrase(Expression.KING, new Phrase(Expression.THREE, Expression.BLUE)));
        m.Add(new Phrase(Expression.YELLOW, new Phrase(Expression.THREE, Expression.BLUE)));
        m.Add(new Phrase(Expression.GREEN, new Phrase(Expression.THREE, Expression.BLUE)));
        m.Add(new Phrase(Expression.BLUE, new Phrase(Expression.THREE, Expression.BLUE)));
        m.Add(new Phrase(Expression.RED, new Phrase(Expression.THREE, Expression.BLUE)));
        m.Add(new Phrase(Expression.NEAR_YOU, new Phrase(Expression.THREE, Expression.BLUE)));
        m.Add(new Phrase(Expression.IN_YELLOW_AREA, new Phrase(Expression.THREE, Expression.BLUE)));
        m.Add(new Phrase(Expression.IN_GREEN_AREA, new Phrase(Expression.THREE, Expression.BLUE)));
        m.Add(new Phrase(Expression.IN_BLUE_AREA, new Phrase(Expression.THREE, Expression.BLUE)));
        m.Add(new Phrase(Expression.IN_RED_AREA, new Phrase(Expression.THREE, Expression.BLUE)));

        // things Bob doesn't take to be true of every blue thing
        m.Add(new Phrase(Expression.FOUNTAIN, new Phrase(Expression.EVERY, Expression.BLUE)));
        m.Add(new Phrase(Expression.LAMP, new Phrase(Expression.EVERY, Expression.BLUE)));
        m.Add(new Phrase(Expression.ACTIVE, new Phrase(Expression.EVERY, Expression.BLUE)));
        m.Add(new Phrase(Expression.INACTIVE, new Phrase(Expression.EVERY, Expression.BLUE)));
        m.Add(new Phrase(Expression.KING, new Phrase(Expression.EVERY, Expression.BLUE)));
        m.Add(new Phrase(Expression.YELLOW, new Phrase(Expression.EVERY, Expression.BLUE)));
        m.Add(new Phrase(Expression.GREEN, new Phrase(Expression.EVERY, Expression.BLUE)));
        m.Add(new Phrase(Expression.RED, new Phrase(Expression.EVERY, Expression.BLUE)));
        m.Add(new Phrase(Expression.NEAR_YOU, new Phrase(Expression.EVERY, Expression.BLUE)));
        m.Add(new Phrase(Expression.IN_YELLOW_AREA, new Phrase(Expression.EVERY, Expression.BLUE)));
        m.Add(new Phrase(Expression.IN_GREEN_AREA, new Phrase(Expression.EVERY, Expression.BLUE)));
        m.Add(new Phrase(Expression.IN_BLUE_AREA, new Phrase(Expression.EVERY, Expression.BLUE)));
        m.Add(new Phrase(Expression.IN_RED_AREA, new Phrase(Expression.EVERY, Expression.BLUE)));

        // things Bob doesn't take to be true of the red thing
        // m.Add(new Phrase(Expression.FOUNTAIN, new Phrase(Expression.THE, Expression.RED)));
        // m.Add(new Phrase(Expression.LAMP, new Phrase(Expression.THE, Expression.RED)));
        // m.Add(new Phrase(Expression.ACTIVE, new Phrase(Expression.THE, Expression.RED)));
        // m.Add(new Phrase(Expression.INACTIVE, new Phrase(Expression.THE, Expression.RED)));
        // m.Add(new Phrase(Expression.KING, new Phrase(Expression.THE, Expression.RED)));
        // m.Add(new Phrase(Expression.YELLOW, new Phrase(Expression.THE, Expression.RED)));
        // m.Add(new Phrase(Expression.GREEN, new Phrase(Expression.THE, Expression.RED)));
        // m.Add(new Phrase(Expression.BLUE, new Phrase(Expression.THE, Expression.RED)));
        // m.Add(new Phrase(Expression.RED, new Phrase(Expression.THE, Expression.RED)));
        // m.Add(new Phrase(Expression.NEAR_YOU, new Phrase(Expression.THE, Expression.RED)));
        // m.Add(new Phrase(Expression.IN_YELLOW_AREA, new Phrase(Expression.THE, Expression.RED)));
        // m.Add(new Phrase(Expression.IN_GREEN_AREA, new Phrase(Expression.THE, Expression.RED)));
        // m.Add(new Phrase(Expression.IN_BLUE_AREA, new Phrase(Expression.THE, Expression.RED)));
        // m.Add(new Phrase(Expression.IN_RED_AREA, new Phrase(Expression.THE, Expression.RED)));
        
        // things Bob doesn't take to be true of a red thing
        m.Add(new Phrase(Expression.FOUNTAIN, new Phrase(Expression.A, Expression.RED)));
        m.Add(new Phrase(Expression.LAMP, new Phrase(Expression.A, Expression.RED)));
        m.Add(new Phrase(Expression.ACTIVE, new Phrase(Expression.A, Expression.RED)));
        m.Add(new Phrase(Expression.INACTIVE, new Phrase(Expression.A, Expression.RED)));
        m.Add(new Phrase(Expression.KING, new Phrase(Expression.A, Expression.RED)));
        m.Add(new Phrase(Expression.YELLOW, new Phrase(Expression.A, Expression.RED)));
        m.Add(new Phrase(Expression.GREEN, new Phrase(Expression.A, Expression.RED)));
        m.Add(new Phrase(Expression.BLUE, new Phrase(Expression.A, Expression.RED)));
        m.Add(new Phrase(Expression.RED, new Phrase(Expression.A, Expression.RED)));
        m.Add(new Phrase(Expression.NEAR_YOU, new Phrase(Expression.A, Expression.RED)));
        m.Add(new Phrase(Expression.IN_YELLOW_AREA, new Phrase(Expression.A, Expression.RED)));
        m.Add(new Phrase(Expression.IN_GREEN_AREA, new Phrase(Expression.A, Expression.RED)));
        m.Add(new Phrase(Expression.IN_BLUE_AREA, new Phrase(Expression.A, Expression.RED)));
        m.Add(new Phrase(Expression.IN_RED_AREA, new Phrase(Expression.A, Expression.RED)));

        // things Bob doesn't take to be true of two red things
        m.Add(new Phrase(Expression.FOUNTAIN, new Phrase(Expression.TWO, Expression.RED)));
        m.Add(new Phrase(Expression.LAMP, new Phrase(Expression.TWO, Expression.RED)));
        m.Add(new Phrase(Expression.ACTIVE, new Phrase(Expression.TWO, Expression.RED)));
        m.Add(new Phrase(Expression.INACTIVE, new Phrase(Expression.TWO, Expression.RED)));
        m.Add(new Phrase(Expression.KING, new Phrase(Expression.TWO, Expression.RED)));
        m.Add(new Phrase(Expression.YELLOW, new Phrase(Expression.TWO, Expression.RED)));
        m.Add(new Phrase(Expression.GREEN, new Phrase(Expression.TWO, Expression.RED)));
        m.Add(new Phrase(Expression.BLUE, new Phrase(Expression.TWO, Expression.RED)));
        m.Add(new Phrase(Expression.RED, new Phrase(Expression.TWO, Expression.RED)));
        m.Add(new Phrase(Expression.NEAR_YOU, new Phrase(Expression.TWO, Expression.RED)));
        m.Add(new Phrase(Expression.IN_YELLOW_AREA, new Phrase(Expression.TWO, Expression.RED)));
        m.Add(new Phrase(Expression.IN_GREEN_AREA, new Phrase(Expression.TWO, Expression.RED)));
        m.Add(new Phrase(Expression.IN_BLUE_AREA, new Phrase(Expression.TWO, Expression.RED)));
        m.Add(new Phrase(Expression.IN_RED_AREA, new Phrase(Expression.TWO, Expression.RED)));

        // things Bob doesn't take to be true of three red things
        m.Add(new Phrase(Expression.FOUNTAIN, new Phrase(Expression.THREE, Expression.RED)));
        m.Add(new Phrase(Expression.LAMP, new Phrase(Expression.THREE, Expression.RED)));
        m.Add(new Phrase(Expression.ACTIVE, new Phrase(Expression.THREE, Expression.RED)));
        m.Add(new Phrase(Expression.INACTIVE, new Phrase(Expression.THREE, Expression.RED)));
        m.Add(new Phrase(Expression.KING, new Phrase(Expression.THREE, Expression.RED)));
        m.Add(new Phrase(Expression.YELLOW, new Phrase(Expression.THREE, Expression.RED)));
        m.Add(new Phrase(Expression.GREEN, new Phrase(Expression.THREE, Expression.RED)));
        m.Add(new Phrase(Expression.BLUE, new Phrase(Expression.THREE, Expression.RED)));
        m.Add(new Phrase(Expression.RED, new Phrase(Expression.THREE, Expression.RED)));
        m.Add(new Phrase(Expression.NEAR_YOU, new Phrase(Expression.THREE, Expression.RED)));
        m.Add(new Phrase(Expression.IN_YELLOW_AREA, new Phrase(Expression.THREE, Expression.RED)));
        m.Add(new Phrase(Expression.IN_GREEN_AREA, new Phrase(Expression.THREE, Expression.RED)));
        m.Add(new Phrase(Expression.IN_BLUE_AREA, new Phrase(Expression.THREE, Expression.RED)));
        m.Add(new Phrase(Expression.IN_RED_AREA, new Phrase(Expression.THREE, Expression.RED)));

        // things Bob doesn't take to be true of every red thing
        m.Add(new Phrase(Expression.FOUNTAIN, new Phrase(Expression.EVERY, Expression.RED)));
        m.Add(new Phrase(Expression.LAMP, new Phrase(Expression.EVERY, Expression.RED)));
        m.Add(new Phrase(Expression.ACTIVE, new Phrase(Expression.EVERY, Expression.RED)));
        m.Add(new Phrase(Expression.INACTIVE, new Phrase(Expression.EVERY, Expression.RED)));
        m.Add(new Phrase(Expression.KING, new Phrase(Expression.EVERY, Expression.RED)));
        m.Add(new Phrase(Expression.YELLOW, new Phrase(Expression.EVERY, Expression.RED)));
        m.Add(new Phrase(Expression.GREEN, new Phrase(Expression.EVERY, Expression.RED)));
        m.Add(new Phrase(Expression.BLUE, new Phrase(Expression.EVERY, Expression.RED)));
        m.Add(new Phrase(Expression.NEAR_YOU, new Phrase(Expression.EVERY, Expression.RED)));
        m.Add(new Phrase(Expression.IN_YELLOW_AREA, new Phrase(Expression.EVERY, Expression.RED)));
        m.Add(new Phrase(Expression.IN_GREEN_AREA, new Phrase(Expression.EVERY, Expression.RED)));
        m.Add(new Phrase(Expression.IN_BLUE_AREA, new Phrase(Expression.EVERY, Expression.RED)));
        m.Add(new Phrase(Expression.IN_RED_AREA, new Phrase(Expression.EVERY, Expression.RED)));

        // things Bob doesn't take to be true of the near-Bob thing
        m.Add(new Phrase(Expression.LAMP, new Phrase(Expression.THE, Expression.NEAR_YOU)));
        m.Add(new Phrase(Expression.INACTIVE, new Phrase(Expression.THE, Expression.NEAR_YOU)));
        m.Add(new Phrase(Expression.KING, new Phrase(Expression.THE, Expression.NEAR_YOU)));
        m.Add(new Phrase(Expression.YELLOW, new Phrase(Expression.THE, Expression.NEAR_YOU)));
        m.Add(new Phrase(Expression.GREEN, new Phrase(Expression.THE, Expression.NEAR_YOU)));
        m.Add(new Phrase(Expression.BLUE, new Phrase(Expression.THE, Expression.NEAR_YOU)));
        m.Add(new Phrase(Expression.RED, new Phrase(Expression.THE, Expression.NEAR_YOU)));
        m.Add(new Phrase(Expression.IN_YELLOW_AREA, new Phrase(Expression.THE, Expression.NEAR_YOU)));
        m.Add(new Phrase(Expression.IN_GREEN_AREA, new Phrase(Expression.THE, Expression.NEAR_YOU)));
        m.Add(new Phrase(Expression.IN_BLUE_AREA, new Phrase(Expression.THE, Expression.NEAR_YOU)));

        // things Bob doesn't take to be true of a near-Bob thing
        m.Add(new Phrase(Expression.LAMP, new Phrase(Expression.A, Expression.NEAR_YOU)));
        m.Add(new Phrase(Expression.INACTIVE, new Phrase(Expression.A, Expression.NEAR_YOU)));
        m.Add(new Phrase(Expression.YELLOW, new Phrase(Expression.A, Expression.NEAR_YOU)));
        m.Add(new Phrase(Expression.GREEN, new Phrase(Expression.A, Expression.NEAR_YOU)));
        m.Add(new Phrase(Expression.BLUE, new Phrase(Expression.A, Expression.NEAR_YOU)));
        m.Add(new Phrase(Expression.RED, new Phrase(Expression.A, Expression.NEAR_YOU)));
        m.Add(new Phrase(Expression.IN_YELLOW_AREA, new Phrase(Expression.A, Expression.NEAR_YOU)));
        m.Add(new Phrase(Expression.IN_GREEN_AREA, new Phrase(Expression.A, Expression.NEAR_YOU)));
        m.Add(new Phrase(Expression.IN_BLUE_AREA, new Phrase(Expression.A, Expression.NEAR_YOU)));

        // things Bob doesn't take to be true of two near-Bob things
        m.Add(new Phrase(Expression.FOUNTAIN, new Phrase(Expression.TWO, Expression.NEAR_YOU)));
        m.Add(new Phrase(Expression.LAMP, new Phrase(Expression.TWO, Expression.NEAR_YOU)));
        m.Add(new Phrase(Expression.INACTIVE, new Phrase(Expression.TWO, Expression.NEAR_YOU)));
        m.Add(new Phrase(Expression.KING, new Phrase(Expression.TWO, Expression.NEAR_YOU)));
        m.Add(new Phrase(Expression.YELLOW, new Phrase(Expression.TWO, Expression.NEAR_YOU)));
        m.Add(new Phrase(Expression.GREEN, new Phrase(Expression.TWO, Expression.NEAR_YOU)));
        m.Add(new Phrase(Expression.BLUE, new Phrase(Expression.TWO, Expression.NEAR_YOU)));
        m.Add(new Phrase(Expression.RED, new Phrase(Expression.TWO, Expression.NEAR_YOU)));
        m.Add(new Phrase(Expression.IN_YELLOW_AREA, new Phrase(Expression.TWO, Expression.NEAR_YOU)));
        m.Add(new Phrase(Expression.IN_GREEN_AREA, new Phrase(Expression.TWO, Expression.NEAR_YOU)));
        m.Add(new Phrase(Expression.IN_BLUE_AREA, new Phrase(Expression.TWO, Expression.NEAR_YOU)));

        // things Bob doesn't take to be true of three near-Bob things
        m.Add(new Phrase(Expression.FOUNTAIN, new Phrase(Expression.THREE, Expression.NEAR_YOU)));
        m.Add(new Phrase(Expression.LAMP, new Phrase(Expression.THREE, Expression.NEAR_YOU)));
        m.Add(new Phrase(Expression.ACTIVE, new Phrase(Expression.THREE, Expression.NEAR_YOU)));
        m.Add(new Phrase(Expression.INACTIVE, new Phrase(Expression.THREE, Expression.NEAR_YOU)));
        m.Add(new Phrase(Expression.KING, new Phrase(Expression.THREE, Expression.NEAR_YOU)));
        m.Add(new Phrase(Expression.YELLOW, new Phrase(Expression.THREE, Expression.NEAR_YOU)));
        m.Add(new Phrase(Expression.GREEN, new Phrase(Expression.THREE, Expression.NEAR_YOU)));
        m.Add(new Phrase(Expression.BLUE, new Phrase(Expression.THREE, Expression.NEAR_YOU)));
        m.Add(new Phrase(Expression.RED, new Phrase(Expression.THREE, Expression.NEAR_YOU)));
        m.Add(new Phrase(Expression.NEAR_YOU, new Phrase(Expression.THREE, Expression.NEAR_YOU)));
        m.Add(new Phrase(Expression.IN_YELLOW_AREA, new Phrase(Expression.THREE, Expression.NEAR_YOU)));
        m.Add(new Phrase(Expression.IN_GREEN_AREA, new Phrase(Expression.THREE, Expression.NEAR_YOU)));
        m.Add(new Phrase(Expression.IN_BLUE_AREA, new Phrase(Expression.THREE, Expression.NEAR_YOU)));
        m.Add(new Phrase(Expression.IN_RED_AREA, new Phrase(Expression.THREE, Expression.NEAR_YOU)));

        // things Bob doesn't take to be true of every near-Bob thing
        m.Add(new Phrase(Expression.FOUNTAIN, new Phrase(Expression.EVERY, Expression.NEAR_YOU)));
        m.Add(new Phrase(Expression.LAMP, new Phrase(Expression.EVERY, Expression.NEAR_YOU)));
        m.Add(new Phrase(Expression.INACTIVE, new Phrase(Expression.EVERY, Expression.NEAR_YOU)));
        m.Add(new Phrase(Expression.KING, new Phrase(Expression.EVERY, Expression.NEAR_YOU)));
        m.Add(new Phrase(Expression.YELLOW, new Phrase(Expression.EVERY, Expression.NEAR_YOU)));
        m.Add(new Phrase(Expression.GREEN, new Phrase(Expression.EVERY, Expression.NEAR_YOU)));
        m.Add(new Phrase(Expression.BLUE, new Phrase(Expression.EVERY, Expression.NEAR_YOU)));
        m.Add(new Phrase(Expression.RED, new Phrase(Expression.EVERY, Expression.NEAR_YOU)));
        m.Add(new Phrase(Expression.IN_YELLOW_AREA, new Phrase(Expression.EVERY, Expression.NEAR_YOU)));
        m.Add(new Phrase(Expression.IN_GREEN_AREA, new Phrase(Expression.EVERY, Expression.NEAR_YOU)));
        m.Add(new Phrase(Expression.IN_BLUE_AREA, new Phrase(Expression.EVERY, Expression.NEAR_YOU)));

        // things Bob doesn't take to be true of the in-yellow-area thing
        // m.Add(new Phrase(Expression.FOUNTAIN, new Phrase(Expression.THE, Expression.NEAR_YOU)));
        // m.Add(new Phrase(Expression.LAMP, new Phrase(Expression.THE, Expression.NEAR_YOU)));
        // m.Add(new Phrase(Expression.ACTIVE, new Phrase(Expression.THE, Expression.NEAR_YOU)));
        // m.Add(new Phrase(Expression.INACTIVE, new Phrase(Expression.THE, Expression.NEAR_YOU)));
        // m.Add(new Phrase(Expression.KING, new Phrase(Expression.THE, Expression.NEAR_YOU)));
        // m.Add(new Phrase(Expression.YELLOW, new Phrase(Expression.THE, Expression.NEAR_YOU)));
        // m.Add(new Phrase(Expression.GREEN, new Phrase(Expression.THE, Expression.NEAR_YOU)));
        // m.Add(new Phrase(Expression.BLUE, new Phrase(Expression.THE, Expression.NEAR_YOU)));
        // m.Add(new Phrase(Expression.RED, new Phrase(Expression.THE, Expression.NEAR_YOU)));
        // m.Add(new Phrase(Expression.NEAR_YOU, new Phrase(Expression.THE, Expression.NEAR_YOU)));
        // m.Add(new Phrase(Expression.IN_YELLOW_AREA, new Phrase(Expression.THE, Expression.NEAR_YOU)));
        // m.Add(new Phrase(Expression.IN_GREEN_AREA, new Phrase(Expression.THE, Expression.NEAR_YOU)));
        // m.Add(new Phrase(Expression.IN_BLUE_AREA, new Phrase(Expression.THE, Expression.NEAR_YOU)));
        // m.Add(new Phrase(Expression.IN_RED_AREA, new Phrase(Expression.THE, Expression.NEAR_YOU)));

        // things Bob doesn't take to be true of an in-yellow-area thing
        m.Add(new Phrase(Expression.FOUNTAIN, new Phrase(Expression.A, Expression.IN_YELLOW_AREA)));
        m.Add(new Phrase(Expression.LAMP, new Phrase(Expression.A, Expression.IN_YELLOW_AREA)));
        m.Add(new Phrase(Expression.ACTIVE, new Phrase(Expression.A, Expression.IN_YELLOW_AREA)));
        m.Add(new Phrase(Expression.INACTIVE, new Phrase(Expression.A, Expression.IN_YELLOW_AREA)));
        m.Add(new Phrase(Expression.KING, new Phrase(Expression.A, Expression.IN_YELLOW_AREA)));
        m.Add(new Phrase(Expression.YELLOW, new Phrase(Expression.A, Expression.IN_YELLOW_AREA)));
        m.Add(new Phrase(Expression.GREEN, new Phrase(Expression.A, Expression.IN_YELLOW_AREA)));
        m.Add(new Phrase(Expression.BLUE, new Phrase(Expression.A, Expression.IN_YELLOW_AREA)));
        m.Add(new Phrase(Expression.RED, new Phrase(Expression.A, Expression.IN_YELLOW_AREA)));
        m.Add(new Phrase(Expression.NEAR_YOU, new Phrase(Expression.A, Expression.IN_YELLOW_AREA)));
        m.Add(new Phrase(Expression.IN_YELLOW_AREA, new Phrase(Expression.A, Expression.IN_YELLOW_AREA)));
        m.Add(new Phrase(Expression.IN_GREEN_AREA, new Phrase(Expression.A, Expression.IN_YELLOW_AREA)));
        m.Add(new Phrase(Expression.IN_BLUE_AREA, new Phrase(Expression.A, Expression.IN_YELLOW_AREA)));
        m.Add(new Phrase(Expression.IN_RED_AREA, new Phrase(Expression.A, Expression.IN_YELLOW_AREA)));

        // things Bob doesn't take to be true of two in-yellow-area things
        m.Add(new Phrase(Expression.FOUNTAIN, new Phrase(Expression.TWO, Expression.IN_YELLOW_AREA)));
        m.Add(new Phrase(Expression.LAMP, new Phrase(Expression.TWO, Expression.IN_YELLOW_AREA)));
        m.Add(new Phrase(Expression.ACTIVE, new Phrase(Expression.TWO, Expression.IN_YELLOW_AREA)));
        m.Add(new Phrase(Expression.INACTIVE, new Phrase(Expression.TWO, Expression.IN_YELLOW_AREA)));
        m.Add(new Phrase(Expression.KING, new Phrase(Expression.TWO, Expression.IN_YELLOW_AREA)));
        m.Add(new Phrase(Expression.YELLOW, new Phrase(Expression.TWO, Expression.IN_YELLOW_AREA)));
        m.Add(new Phrase(Expression.GREEN, new Phrase(Expression.TWO, Expression.IN_YELLOW_AREA)));
        m.Add(new Phrase(Expression.BLUE, new Phrase(Expression.TWO, Expression.IN_YELLOW_AREA)));
        m.Add(new Phrase(Expression.RED, new Phrase(Expression.TWO, Expression.IN_YELLOW_AREA)));
        m.Add(new Phrase(Expression.NEAR_YOU, new Phrase(Expression.TWO, Expression.IN_YELLOW_AREA)));
        m.Add(new Phrase(Expression.IN_YELLOW_AREA, new Phrase(Expression.TWO, Expression.IN_YELLOW_AREA)));
        m.Add(new Phrase(Expression.IN_GREEN_AREA, new Phrase(Expression.TWO, Expression.IN_YELLOW_AREA)));
        m.Add(new Phrase(Expression.IN_BLUE_AREA, new Phrase(Expression.TWO, Expression.IN_YELLOW_AREA)));
        m.Add(new Phrase(Expression.IN_RED_AREA, new Phrase(Expression.TWO, Expression.IN_YELLOW_AREA)));

        // things Bob doesn't take to be true of three in-yellow-area things
        m.Add(new Phrase(Expression.FOUNTAIN, new Phrase(Expression.THREE, Expression.IN_YELLOW_AREA)));
        m.Add(new Phrase(Expression.LAMP, new Phrase(Expression.THREE, Expression.IN_YELLOW_AREA)));
        m.Add(new Phrase(Expression.ACTIVE, new Phrase(Expression.THREE, Expression.IN_YELLOW_AREA)));
        m.Add(new Phrase(Expression.INACTIVE, new Phrase(Expression.THREE, Expression.IN_YELLOW_AREA)));
        m.Add(new Phrase(Expression.KING, new Phrase(Expression.THREE, Expression.IN_YELLOW_AREA)));
        m.Add(new Phrase(Expression.YELLOW, new Phrase(Expression.THREE, Expression.IN_YELLOW_AREA)));
        m.Add(new Phrase(Expression.GREEN, new Phrase(Expression.THREE, Expression.IN_YELLOW_AREA)));
        m.Add(new Phrase(Expression.BLUE, new Phrase(Expression.THREE, Expression.IN_YELLOW_AREA)));
        m.Add(new Phrase(Expression.RED, new Phrase(Expression.THREE, Expression.IN_YELLOW_AREA)));
        m.Add(new Phrase(Expression.NEAR_YOU, new Phrase(Expression.THREE, Expression.IN_YELLOW_AREA)));
        m.Add(new Phrase(Expression.IN_YELLOW_AREA, new Phrase(Expression.THREE, Expression.IN_YELLOW_AREA)));
        m.Add(new Phrase(Expression.IN_GREEN_AREA, new Phrase(Expression.THREE, Expression.IN_YELLOW_AREA)));
        m.Add(new Phrase(Expression.IN_BLUE_AREA, new Phrase(Expression.THREE, Expression.IN_YELLOW_AREA)));
        m.Add(new Phrase(Expression.IN_RED_AREA, new Phrase(Expression.THREE, Expression.IN_YELLOW_AREA)));

        // things Bob doesn't take to be true of every in-yellow-area thing
        m.Add(new Phrase(Expression.FOUNTAIN, new Phrase(Expression.EVERY, Expression.IN_YELLOW_AREA)));
        m.Add(new Phrase(Expression.LAMP, new Phrase(Expression.EVERY, Expression.IN_YELLOW_AREA)));
        m.Add(new Phrase(Expression.ACTIVE, new Phrase(Expression.EVERY, Expression.IN_YELLOW_AREA)));
        m.Add(new Phrase(Expression.INACTIVE, new Phrase(Expression.EVERY, Expression.IN_YELLOW_AREA)));
        m.Add(new Phrase(Expression.KING, new Phrase(Expression.EVERY, Expression.IN_YELLOW_AREA)));
        m.Add(new Phrase(Expression.YELLOW, new Phrase(Expression.EVERY, Expression.IN_YELLOW_AREA)));
        m.Add(new Phrase(Expression.GREEN, new Phrase(Expression.EVERY, Expression.IN_YELLOW_AREA)));
        m.Add(new Phrase(Expression.BLUE, new Phrase(Expression.EVERY, Expression.IN_YELLOW_AREA)));
        m.Add(new Phrase(Expression.RED, new Phrase(Expression.EVERY, Expression.IN_YELLOW_AREA)));
        m.Add(new Phrase(Expression.NEAR_YOU, new Phrase(Expression.EVERY, Expression.IN_YELLOW_AREA)));
        m.Add(new Phrase(Expression.IN_GREEN_AREA, new Phrase(Expression.EVERY, Expression.IN_YELLOW_AREA)));
        m.Add(new Phrase(Expression.IN_BLUE_AREA, new Phrase(Expression.EVERY, Expression.IN_YELLOW_AREA)));
        m.Add(new Phrase(Expression.IN_RED_AREA, new Phrase(Expression.EVERY, Expression.IN_YELLOW_AREA)));

        // things Bob doesn't take to be true of the in-green-area thing
        m.Add(new Phrase(Expression.FOUNTAIN, new Phrase(Expression.THE, Expression.IN_GREEN_AREA)));
        m.Add(new Phrase(Expression.LAMP, new Phrase(Expression.THE, Expression.IN_GREEN_AREA)));
        m.Add(new Phrase(Expression.INACTIVE, new Phrase(Expression.THE, Expression.IN_GREEN_AREA)));
        m.Add(new Phrase(Expression.KING, new Phrase(Expression.THE, Expression.IN_GREEN_AREA)));
        m.Add(new Phrase(Expression.YELLOW, new Phrase(Expression.THE, Expression.IN_GREEN_AREA)));
        m.Add(new Phrase(Expression.GREEN, new Phrase(Expression.THE, Expression.IN_GREEN_AREA)));
        m.Add(new Phrase(Expression.BLUE, new Phrase(Expression.THE, Expression.IN_GREEN_AREA)));
        m.Add(new Phrase(Expression.RED, new Phrase(Expression.THE, Expression.IN_GREEN_AREA)));
        m.Add(new Phrase(Expression.NEAR_YOU, new Phrase(Expression.THE, Expression.IN_GREEN_AREA)));
        m.Add(new Phrase(Expression.IN_YELLOW_AREA, new Phrase(Expression.THE, Expression.IN_GREEN_AREA)));
        m.Add(new Phrase(Expression.IN_BLUE_AREA, new Phrase(Expression.THE, Expression.IN_GREEN_AREA)));
        m.Add(new Phrase(Expression.IN_RED_AREA, new Phrase(Expression.THE, Expression.IN_GREEN_AREA)));
        
        // things Bob doesn't take to be true of an in-green-area thing
        m.Add(new Phrase(Expression.FOUNTAIN, new Phrase(Expression.A, Expression.IN_GREEN_AREA)));
        m.Add(new Phrase(Expression.LAMP, new Phrase(Expression.A, Expression.IN_GREEN_AREA)));
        m.Add(new Phrase(Expression.INACTIVE, new Phrase(Expression.A, Expression.IN_GREEN_AREA)));
        m.Add(new Phrase(Expression.KING, new Phrase(Expression.A, Expression.IN_GREEN_AREA)));
        m.Add(new Phrase(Expression.YELLOW, new Phrase(Expression.A, Expression.IN_GREEN_AREA)));
        m.Add(new Phrase(Expression.GREEN, new Phrase(Expression.A, Expression.IN_GREEN_AREA)));
        m.Add(new Phrase(Expression.BLUE, new Phrase(Expression.A, Expression.IN_GREEN_AREA)));
        m.Add(new Phrase(Expression.RED, new Phrase(Expression.A, Expression.IN_GREEN_AREA)));
        m.Add(new Phrase(Expression.NEAR_YOU, new Phrase(Expression.A, Expression.IN_GREEN_AREA)));
        m.Add(new Phrase(Expression.IN_YELLOW_AREA, new Phrase(Expression.A, Expression.IN_GREEN_AREA)));
        m.Add(new Phrase(Expression.IN_BLUE_AREA, new Phrase(Expression.A, Expression.IN_GREEN_AREA)));
        m.Add(new Phrase(Expression.IN_RED_AREA, new Phrase(Expression.A, Expression.IN_GREEN_AREA)));
        
        // things Bob doesn't take to be true of two in-green-area things
        m.Add(new Phrase(Expression.FOUNTAIN, new Phrase(Expression.TWO, Expression.IN_GREEN_AREA)));
        m.Add(new Phrase(Expression.LAMP, new Phrase(Expression.TWO, Expression.IN_GREEN_AREA)));
        m.Add(new Phrase(Expression.ACTIVE, new Phrase(Expression.TWO, Expression.IN_GREEN_AREA)));
        m.Add(new Phrase(Expression.INACTIVE, new Phrase(Expression.TWO, Expression.IN_GREEN_AREA)));
        m.Add(new Phrase(Expression.KING, new Phrase(Expression.TWO, Expression.IN_GREEN_AREA)));
        m.Add(new Phrase(Expression.YELLOW, new Phrase(Expression.TWO, Expression.IN_GREEN_AREA)));
        m.Add(new Phrase(Expression.GREEN, new Phrase(Expression.TWO, Expression.IN_GREEN_AREA)));
        m.Add(new Phrase(Expression.BLUE, new Phrase(Expression.TWO, Expression.IN_GREEN_AREA)));
        m.Add(new Phrase(Expression.RED, new Phrase(Expression.TWO, Expression.IN_GREEN_AREA)));
        m.Add(new Phrase(Expression.NEAR_YOU, new Phrase(Expression.TWO, Expression.IN_GREEN_AREA)));
        m.Add(new Phrase(Expression.IN_YELLOW_AREA, new Phrase(Expression.TWO, Expression.IN_GREEN_AREA)));
        m.Add(new Phrase(Expression.IN_GREEN_AREA, new Phrase(Expression.TWO, Expression.IN_GREEN_AREA)));
        m.Add(new Phrase(Expression.IN_BLUE_AREA, new Phrase(Expression.TWO, Expression.IN_GREEN_AREA)));
        m.Add(new Phrase(Expression.IN_RED_AREA, new Phrase(Expression.TWO, Expression.IN_GREEN_AREA)));
        
        // things Bob doesn't take to be true of three in-green-area things
        m.Add(new Phrase(Expression.FOUNTAIN, new Phrase(Expression.THREE, Expression.IN_GREEN_AREA)));
        m.Add(new Phrase(Expression.LAMP, new Phrase(Expression.THREE, Expression.IN_GREEN_AREA)));
        m.Add(new Phrase(Expression.ACTIVE, new Phrase(Expression.THREE, Expression.IN_GREEN_AREA)));
        m.Add(new Phrase(Expression.INACTIVE, new Phrase(Expression.THREE, Expression.IN_GREEN_AREA)));
        m.Add(new Phrase(Expression.KING, new Phrase(Expression.THREE, Expression.IN_GREEN_AREA)));
        m.Add(new Phrase(Expression.YELLOW, new Phrase(Expression.THREE, Expression.IN_GREEN_AREA)));
        m.Add(new Phrase(Expression.GREEN, new Phrase(Expression.THREE, Expression.IN_GREEN_AREA)));
        m.Add(new Phrase(Expression.BLUE, new Phrase(Expression.THREE, Expression.IN_GREEN_AREA)));
        m.Add(new Phrase(Expression.RED, new Phrase(Expression.THREE, Expression.IN_GREEN_AREA)));
        m.Add(new Phrase(Expression.NEAR_YOU, new Phrase(Expression.THREE, Expression.IN_GREEN_AREA)));
        m.Add(new Phrase(Expression.IN_YELLOW_AREA, new Phrase(Expression.THREE, Expression.IN_GREEN_AREA)));
        m.Add(new Phrase(Expression.IN_GREEN_AREA, new Phrase(Expression.THREE, Expression.IN_GREEN_AREA)));
        m.Add(new Phrase(Expression.IN_BLUE_AREA, new Phrase(Expression.THREE, Expression.IN_GREEN_AREA)));
        m.Add(new Phrase(Expression.IN_RED_AREA, new Phrase(Expression.THREE, Expression.IN_GREEN_AREA)));
        
        // things Bob doesn't take to be true of every in-green-area thing
        m.Add(new Phrase(Expression.FOUNTAIN, new Phrase(Expression.EVERY, Expression.IN_GREEN_AREA)));
        m.Add(new Phrase(Expression.LAMP, new Phrase(Expression.EVERY, Expression.IN_GREEN_AREA)));
        m.Add(new Phrase(Expression.INACTIVE, new Phrase(Expression.EVERY, Expression.IN_GREEN_AREA)));
        m.Add(new Phrase(Expression.KING, new Phrase(Expression.EVERY, Expression.IN_GREEN_AREA)));
        m.Add(new Phrase(Expression.YELLOW, new Phrase(Expression.EVERY, Expression.IN_GREEN_AREA)));
        m.Add(new Phrase(Expression.GREEN, new Phrase(Expression.EVERY, Expression.IN_GREEN_AREA)));
        m.Add(new Phrase(Expression.BLUE, new Phrase(Expression.EVERY, Expression.IN_GREEN_AREA)));
        m.Add(new Phrase(Expression.RED, new Phrase(Expression.EVERY, Expression.IN_GREEN_AREA)));
        m.Add(new Phrase(Expression.NEAR_YOU, new Phrase(Expression.EVERY, Expression.IN_GREEN_AREA)));
        m.Add(new Phrase(Expression.IN_YELLOW_AREA, new Phrase(Expression.EVERY, Expression.IN_GREEN_AREA)));
        m.Add(new Phrase(Expression.IN_BLUE_AREA, new Phrase(Expression.EVERY, Expression.IN_GREEN_AREA)));
        m.Add(new Phrase(Expression.IN_RED_AREA, new Phrase(Expression.EVERY, Expression.IN_GREEN_AREA)));

        // things Bob doesn't take to be true of the in-blue-area thing
        // m.Add(new Phrase(Expression.FOUNTAIN, new Phrase(Expression.THE, Expression.IN_BLUE_AREA)));
        // m.Add(new Phrase(Expression.LAMP, new Phrase(Expression.THE, Expression.IN_BLUE_AREA)));
        // m.Add(new Phrase(Expression.ACTIVE, new Phrase(Expression.THE, Expression.IN_BLUE_AREA)));
        // m.Add(new Phrase(Expression.INACTIVE, new Phrase(Expression.THE, Expression.IN_BLUE_AREA)));
        // m.Add(new Phrase(Expression.KING, new Phrase(Expression.THE, Expression.IN_BLUE_AREA)));
        // m.Add(new Phrase(Expression.YELLOW, new Phrase(Expression.THE, Expression.IN_BLUE_AREA)));
        // m.Add(new Phrase(Expression.GREEN, new Phrase(Expression.THE, Expression.IN_BLUE_AREA)));
        // m.Add(new Phrase(Expression.BLUE, new Phrase(Expression.THE, Expression.IN_BLUE_AREA)));
        // m.Add(new Phrase(Expression.RED, new Phrase(Expression.THE, Expression.IN_BLUE_AREA)));
        // m.Add(new Phrase(Expression.NEAR_YOU, new Phrase(Expression.THE, Expression.IN_BLUE_AREA)));
        // m.Add(new Phrase(Expression.IN_YELLOW_AREA, new Phrase(Expression.THE, Expression.IN_BLUE_AREA)));
        // m.Add(new Phrase(Expression.IN_GREEN_AREA, new Phrase(Expression.THE, Expression.IN_BLUE_AREA)));
        // m.Add(new Phrase(Expression.IN_BLUE_AREA, new Phrase(Expression.THE, Expression.IN_BLUE_AREA)));
        // m.Add(new Phrase(Expression.IN_RED_AREA, new Phrase(Expression.THE, Expression.IN_BLUE_AREA)));

        // things Bob doesn't take to be true of an in-blue-area thing
        m.Add(new Phrase(Expression.KING, new Phrase(Expression.A, Expression.IN_BLUE_AREA)));
        m.Add(new Phrase(Expression.YELLOW, new Phrase(Expression.A, Expression.IN_BLUE_AREA)));
        m.Add(new Phrase(Expression.GREEN, new Phrase(Expression.A, Expression.IN_BLUE_AREA)));
        m.Add(new Phrase(Expression.BLUE, new Phrase(Expression.A, Expression.IN_BLUE_AREA)));
        m.Add(new Phrase(Expression.RED, new Phrase(Expression.A, Expression.IN_BLUE_AREA)));
        m.Add(new Phrase(Expression.NEAR_YOU, new Phrase(Expression.A, Expression.IN_BLUE_AREA)));
        m.Add(new Phrase(Expression.IN_YELLOW_AREA, new Phrase(Expression.A, Expression.IN_BLUE_AREA)));
        m.Add(new Phrase(Expression.IN_GREEN_AREA, new Phrase(Expression.A, Expression.IN_BLUE_AREA)));
        m.Add(new Phrase(Expression.IN_RED_AREA, new Phrase(Expression.A, Expression.IN_BLUE_AREA)));
        
        // things Bob doesn't take to be true of two in-blue-area thing
        m.Add(new Phrase(Expression.LAMP, new Phrase(Expression.TWO, Expression.IN_BLUE_AREA)));
        m.Add(new Phrase(Expression.ACTIVE, new Phrase(Expression.TWO, Expression.IN_BLUE_AREA)));
        m.Add(new Phrase(Expression.KING, new Phrase(Expression.TWO, Expression.IN_BLUE_AREA)));
        m.Add(new Phrase(Expression.YELLOW, new Phrase(Expression.TWO, Expression.IN_BLUE_AREA)));
        m.Add(new Phrase(Expression.GREEN, new Phrase(Expression.TWO, Expression.IN_BLUE_AREA)));
        m.Add(new Phrase(Expression.BLUE, new Phrase(Expression.TWO, Expression.IN_BLUE_AREA)));
        m.Add(new Phrase(Expression.RED, new Phrase(Expression.TWO, Expression.IN_BLUE_AREA)));
        m.Add(new Phrase(Expression.NEAR_YOU, new Phrase(Expression.TWO, Expression.IN_BLUE_AREA)));
        m.Add(new Phrase(Expression.IN_YELLOW_AREA, new Phrase(Expression.TWO, Expression.IN_BLUE_AREA)));
        m.Add(new Phrase(Expression.IN_GREEN_AREA, new Phrase(Expression.TWO, Expression.IN_BLUE_AREA)));
        m.Add(new Phrase(Expression.IN_RED_AREA, new Phrase(Expression.TWO, Expression.IN_BLUE_AREA)));

        // things Bob doesn't take to be true of three in-blue-area thing
        m.Add(new Phrase(Expression.FOUNTAIN, new Phrase(Expression.THREE, Expression.IN_BLUE_AREA)));
        m.Add(new Phrase(Expression.LAMP, new Phrase(Expression.THREE, Expression.IN_BLUE_AREA)));
        m.Add(new Phrase(Expression.ACTIVE, new Phrase(Expression.THREE, Expression.IN_BLUE_AREA)));
        m.Add(new Phrase(Expression.INACTIVE, new Phrase(Expression.THREE, Expression.IN_BLUE_AREA)));
        m.Add(new Phrase(Expression.KING, new Phrase(Expression.THREE, Expression.IN_BLUE_AREA)));
        m.Add(new Phrase(Expression.YELLOW, new Phrase(Expression.THREE, Expression.IN_BLUE_AREA)));
        m.Add(new Phrase(Expression.GREEN, new Phrase(Expression.THREE, Expression.IN_BLUE_AREA)));
        m.Add(new Phrase(Expression.BLUE, new Phrase(Expression.THREE, Expression.IN_BLUE_AREA)));
        m.Add(new Phrase(Expression.RED, new Phrase(Expression.THREE, Expression.IN_BLUE_AREA)));
        m.Add(new Phrase(Expression.NEAR_YOU, new Phrase(Expression.THREE, Expression.IN_BLUE_AREA)));
        m.Add(new Phrase(Expression.IN_YELLOW_AREA, new Phrase(Expression.THREE, Expression.IN_BLUE_AREA)));
        m.Add(new Phrase(Expression.IN_GREEN_AREA, new Phrase(Expression.THREE, Expression.IN_BLUE_AREA)));
        m.Add(new Phrase(Expression.IN_RED_AREA, new Phrase(Expression.THREE, Expression.IN_BLUE_AREA)));
        
        // things Bob doesn't take to be true of every in-blue-area thing
        m.Add(new Phrase(Expression.FOUNTAIN, new Phrase(Expression.EVERY, Expression.IN_BLUE_AREA)));
        m.Add(new Phrase(Expression.LAMP, new Phrase(Expression.EVERY, Expression.IN_BLUE_AREA)));
        m.Add(new Phrase(Expression.ACTIVE, new Phrase(Expression.EVERY, Expression.IN_BLUE_AREA)));
        m.Add(new Phrase(Expression.INACTIVE, new Phrase(Expression.EVERY, Expression.IN_BLUE_AREA)));
        m.Add(new Phrase(Expression.KING, new Phrase(Expression.EVERY, Expression.IN_BLUE_AREA)));
        m.Add(new Phrase(Expression.YELLOW, new Phrase(Expression.EVERY, Expression.IN_BLUE_AREA)));
        m.Add(new Phrase(Expression.GREEN, new Phrase(Expression.EVERY, Expression.IN_BLUE_AREA)));
        m.Add(new Phrase(Expression.BLUE, new Phrase(Expression.EVERY, Expression.IN_BLUE_AREA)));
        m.Add(new Phrase(Expression.RED, new Phrase(Expression.EVERY, Expression.IN_BLUE_AREA)));
        m.Add(new Phrase(Expression.NEAR_YOU, new Phrase(Expression.EVERY, Expression.IN_BLUE_AREA)));
        m.Add(new Phrase(Expression.IN_YELLOW_AREA, new Phrase(Expression.EVERY, Expression.IN_BLUE_AREA)));
        m.Add(new Phrase(Expression.IN_GREEN_AREA, new Phrase(Expression.EVERY, Expression.IN_BLUE_AREA)));
        m.Add(new Phrase(Expression.IN_RED_AREA, new Phrase(Expression.EVERY, Expression.IN_BLUE_AREA)));

        // things Bob doesn't take to be true of the in-red-area thing
        // m.Add(new Phrase(Expression.FOUNTAIN, new Phrase(Expression.THE, Expression.IN_RED_AREA)));
        // m.Add(new Phrase(Expression.LAMP, new Phrase(Expression.THE, Expression.IN_RED_AREA)));
        // m.Add(new Phrase(Expression.ACTIVE, new Phrase(Expression.THE, Expression.IN_RED_AREA)));
        // m.Add(new Phrase(Expression.INACTIVE, new Phrase(Expression.THE, Expression.IN_RED_AREA)));
        // m.Add(new Phrase(Expression.KING, new Phrase(Expression.THE, Expression.IN_RED_AREA)));
        // m.Add(new Phrase(Expression.YELLOW, new Phrase(Expression.THE, Expression.IN_RED_AREA)));
        // m.Add(new Phrase(Expression.GREEN, new Phrase(Expression.THE, Expression.IN_RED_AREA)));
        // m.Add(new Phrase(Expression.BLUE, new Phrase(Expression.THE, Expression.IN_RED_AREA)));
        // m.Add(new Phrase(Expression.RED, new Phrase(Expression.THE, Expression.IN_RED_AREA)));
        // m.Add(new Phrase(Expression.NEAR_YOU, new Phrase(Expression.THE, Expression.IN_RED_AREA)));
        // m.Add(new Phrase(Expression.IN_YELLOW_AREA, new Phrase(Expression.THE, Expression.IN_RED_AREA)));
        // m.Add(new Phrase(Expression.IN_GREEN_AREA, new Phrase(Expression.THE, Expression.IN_RED_AREA)));
        // m.Add(new Phrase(Expression.IN_BLUE_AREA, new Phrase(Expression.THE, Expression.IN_RED_AREA)));
        // m.Add(new Phrase(Expression.IN_RED_AREA, new Phrase(Expression.THE, Expression.IN_RED_AREA)));

        // things Bob doesn't take to be true of an in-red-area thing
        m.Add(new Phrase(Expression.INACTIVE, new Phrase(Expression.A, Expression.IN_RED_AREA)));
        m.Add(new Phrase(Expression.YELLOW, new Phrase(Expression.A, Expression.IN_RED_AREA)));
        m.Add(new Phrase(Expression.GREEN, new Phrase(Expression.A, Expression.IN_RED_AREA)));
        m.Add(new Phrase(Expression.BLUE, new Phrase(Expression.A, Expression.IN_RED_AREA)));
        m.Add(new Phrase(Expression.RED, new Phrase(Expression.A, Expression.IN_RED_AREA)));
        m.Add(new Phrase(Expression.IN_YELLOW_AREA, new Phrase(Expression.A, Expression.IN_RED_AREA)));
        m.Add(new Phrase(Expression.IN_GREEN_AREA, new Phrase(Expression.A, Expression.IN_RED_AREA)));
        m.Add(new Phrase(Expression.IN_BLUE_AREA, new Phrase(Expression.A, Expression.IN_RED_AREA)));

        // things Bob doesn't take to be true of two in-red-area things
        m.Add(new Phrase(Expression.FOUNTAIN, new Phrase(Expression.TWO, Expression.IN_RED_AREA)));
        m.Add(new Phrase(Expression.LAMP, new Phrase(Expression.TWO, Expression.IN_RED_AREA)));
        m.Add(new Phrase(Expression.INACTIVE, new Phrase(Expression.TWO, Expression.IN_RED_AREA)));
        m.Add(new Phrase(Expression.KING, new Phrase(Expression.TWO, Expression.IN_RED_AREA)));
        m.Add(new Phrase(Expression.YELLOW, new Phrase(Expression.TWO, Expression.IN_RED_AREA)));
        m.Add(new Phrase(Expression.GREEN, new Phrase(Expression.TWO, Expression.IN_RED_AREA)));
        m.Add(new Phrase(Expression.BLUE, new Phrase(Expression.TWO, Expression.IN_RED_AREA)));
        m.Add(new Phrase(Expression.RED, new Phrase(Expression.TWO, Expression.IN_RED_AREA)));
        m.Add(new Phrase(Expression.IN_YELLOW_AREA, new Phrase(Expression.TWO, Expression.IN_RED_AREA)));
        m.Add(new Phrase(Expression.IN_GREEN_AREA, new Phrase(Expression.TWO, Expression.IN_RED_AREA)));
        m.Add(new Phrase(Expression.IN_BLUE_AREA, new Phrase(Expression.TWO, Expression.IN_RED_AREA)));
        

        // things Bob doesn't take to be true of three in-red-area things
        m.Add(new Phrase(Expression.FOUNTAIN, new Phrase(Expression.THREE, Expression.IN_RED_AREA)));
        m.Add(new Phrase(Expression.LAMP, new Phrase(Expression.THREE, Expression.IN_RED_AREA)));
        m.Add(new Phrase(Expression.INACTIVE, new Phrase(Expression.THREE, Expression.IN_RED_AREA)));
        m.Add(new Phrase(Expression.KING, new Phrase(Expression.THREE, Expression.IN_RED_AREA)));
        m.Add(new Phrase(Expression.YELLOW, new Phrase(Expression.THREE, Expression.IN_RED_AREA)));
        m.Add(new Phrase(Expression.GREEN, new Phrase(Expression.THREE, Expression.IN_RED_AREA)));
        m.Add(new Phrase(Expression.BLUE, new Phrase(Expression.THREE, Expression.IN_RED_AREA)));
        m.Add(new Phrase(Expression.RED, new Phrase(Expression.THREE, Expression.IN_RED_AREA)));
        m.Add(new Phrase(Expression.NEAR_YOU, new Phrase(Expression.THREE, Expression.IN_RED_AREA)));
        m.Add(new Phrase(Expression.IN_YELLOW_AREA, new Phrase(Expression.THREE, Expression.IN_RED_AREA)));
        m.Add(new Phrase(Expression.IN_GREEN_AREA, new Phrase(Expression.THREE, Expression.IN_RED_AREA)));
        m.Add(new Phrase(Expression.IN_BLUE_AREA, new Phrase(Expression.THREE, Expression.IN_RED_AREA)));

        // things Bob doesn't take to be true of every in-red-area thing
        m.Add(new Phrase(Expression.FOUNTAIN, new Phrase(Expression.EVERY, Expression.IN_RED_AREA)));
        m.Add(new Phrase(Expression.LAMP, new Phrase(Expression.EVERY, Expression.IN_RED_AREA)));
        m.Add(new Phrase(Expression.INACTIVE, new Phrase(Expression.EVERY, Expression.IN_RED_AREA)));
        m.Add(new Phrase(Expression.KING, new Phrase(Expression.EVERY, Expression.IN_RED_AREA)));
        m.Add(new Phrase(Expression.YELLOW, new Phrase(Expression.EVERY, Expression.IN_RED_AREA)));
        m.Add(new Phrase(Expression.GREEN, new Phrase(Expression.EVERY, Expression.IN_RED_AREA)));
        m.Add(new Phrase(Expression.BLUE, new Phrase(Expression.EVERY, Expression.IN_RED_AREA)));
        m.Add(new Phrase(Expression.RED, new Phrase(Expression.EVERY, Expression.IN_RED_AREA)));
        m.Add(new Phrase(Expression.NEAR_YOU, new Phrase(Expression.EVERY, Expression.IN_RED_AREA)));
        m.Add(new Phrase(Expression.IN_YELLOW_AREA, new Phrase(Expression.EVERY, Expression.IN_RED_AREA)));
        m.Add(new Phrase(Expression.IN_GREEN_AREA, new Phrase(Expression.EVERY, Expression.IN_RED_AREA)));
        m.Add(new Phrase(Expression.IN_BLUE_AREA, new Phrase(Expression.EVERY, Expression.IN_RED_AREA)));

        // ALL PREDICATES
        // m.Add(new Phrase(Expression.FOUNTAIN, new Phrase(Expression.XXX, Expression.YYY)));
        // m.Add(new Phrase(Expression.LAMP, new Phrase(Expression.XXX, Expression.YYY)));
        // m.Add(new Phrase(Expression.ACTIVE, new Phrase(Expression.XXX, Expression.YYY)));
        // m.Add(new Phrase(Expression.INACTIVE, new Phrase(Expression.XXX, Expression.YYY)));
        // m.Add(new Phrase(Expression.KING, new Phrase(Expression.XXX, Expression.YYY)));
        // m.Add(new Phrase(Expression.YELLOW, new Phrase(Expression.XXX, Expression.YYY)));
        // m.Add(new Phrase(Expression.GREEN, new Phrase(Expression.XXX, Expression.YYY)));
        // m.Add(new Phrase(Expression.BLUE, new Phrase(Expression.XXX, Expression.YYY)));
        // m.Add(new Phrase(Expression.RED, new Phrase(Expression.XXX, Expression.YYY)));
        // m.Add(new Phrase(Expression.NEAR_YOU, new Phrase(Expression.XXX, Expression.YYY)));
        // m.Add(new Phrase(Expression.IN_YELLOW_AREA, new Phrase(Expression.XXX, Expression.YYY)));
        // m.Add(new Phrase(Expression.IN_GREEN_AREA, new Phrase(Expression.XXX, Expression.YYY)));
        // m.Add(new Phrase(Expression.IN_BLUE_AREA, new Phrase(Expression.XXX, Expression.YYY)));
        // m.Add(new Phrase(Expression.IN_RED_AREA, new Phrase(Expression.XXX, Expression.YYY)));

        return m;
        
    }
}