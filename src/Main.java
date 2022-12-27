import java.util.Random;
import java.util.Scanner;
public class Main {
    public static void main(String[] args) {
        System.out.println("----------------------------------Coin Toss--------------------------------");
        System.out.println("Heads or Tails? Press 0 for Heads, 1 for tails");
        Scanner choice= new Scanner(System.in);
        int choices = choice.nextInt();
        if (choices==0){
            System.out.println("You Chose: Heads");
        } else if (choices==1) {
            System.out.println("You Chose: Tails");
        }
        Random random = new Random();
        int randomint = random.nextInt(2);
        if (randomint==0){
            System.out.println("RESULT: Heads");
        }
        if (randomint==1){
            System.out.println("RESULT: Tails");
        }
        System.out.println("Do you want to flip again? Press 1 to continue");
        int option = choice.nextInt();
        if (option==1){
            main(null);
        }

    }
}
