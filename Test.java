import java.util.Scanner;

public class Test
{
    public static void main(String[] args)
    {
        String resp;
        Scanner input = new Scanner(System.in);

        System.out.println("Send help.");
        resp = input.nextLine();

        System.out.println(resp);
    }
}