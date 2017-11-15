public class Question2 {
    public static void main( String[] args ) {
        Bank bank1 = new Bank();
        Manager boss = new Manager();
        boss.securityAccess(bank1);
    }
}

class Bank
{
    private String name;
    protected String securityInfo;
    public void display(){
        System.out.println("This is a bank!");
    }

}
class Manager
{
    private int id;
    public void display()
    {
        System.out.println("I am a manager!");
    }
    public void securityAccess(Bank x){
        System.out.println("Security Information is: " + x.securityInfo);
    }
}