
/*
    Question2
    Java
    Adam Giaccaglia

 */

public class Question2 {
    public static void main( String[] args ) {
        Musician guy = new Musician("billy");

        guy.sing();
        guy.pianoPlay();
        guy.violinPlay();
    }
}

class Pianist
{
    private String name;
    public Pianist(String x)
    {
        name = x;
    }
    public void pianoPlay(){
        System.out.println("Play a piano!");
    }
}

class Violinist implements IViolinist{
    public void violinPlay() {
            System.out.println("Play a violin!");
    }

}

interface IViolinist
{
    void violinPlay();
}


class Musician extends Pianist implements IViolinist{

    public Musician(String nm) {
             super(nm);
    }
    public void sing() {
            System.out.println("Sing a song!");
    }

    // makes having a violinist class redundant
    public void violinPlay() {
            System.out.println("Play a violin!");
    }
}
