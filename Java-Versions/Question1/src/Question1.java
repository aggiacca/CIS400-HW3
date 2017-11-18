
/*
    Java
    Question1
    Adam Giaccaglia

 */

public class Question1 {
    public static void main( String[] args ) {

        Animal[] animals = new Animal[4];

        animals[0] = new Animal();
        animals[1] = new Cow();
        animals[2] = new Pig();
        animals[3] = new Snake();

        for (int i = 0; i < animals.length; i++)
        {
            animals[i].talk();
        }

    }
}

class Animal
{
    private int Leg;
    public Animal()
    {
        Leg = 4;
    }

    public void talk()
    {
        System.out.println("Animals Can't Talk!");
    }
}

class Cow extends Animal {
    // functions are virtual by default
    public void talk() {
      System.out.println("Moo!");
  }
}

class Pig extends Animal {
    public void talk() {
        System.out.println("Grunt!");
    }
}
class Snake extends Animal {

}