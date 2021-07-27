import java.util.Scanner;

public class Main {
    static class Prime
    {
        public boolean isPrime(long number)
        {

            if (number <= 1) return false; // if number equals 0 or 1 or negative it's not prime

            for (long i = 2; i <= Math.sqrt(number); i++) if (number % i == 0) return false;
            //in bound: number square root user instead of number can reduce loop runtime by 50%

            return true;
        }

        public String printUntil(long bound)
        {
            String outPut = "";

            for (long i = 2; i < bound; ++i) if (isPrime(i)) outPut += i + "\n"; //if number is prime add to output string

            return outPut;
        }

    }

    public static void main(String[] args){
        Scanner scanner = new Scanner(System.in);
        //make program loop for multiple operations
        while (true)
        {
            Prime myPrimeClass = new Prime();
            int choice;
            long number;

            System.out.println("Prime Numbers Program:");
            System.out.println( "Enter 1 to check number");
            System.out.println( "Enter 2 to print numbers");

            choice = scanner.nextInt();

            switch (choice)
            {
                case 1:

                    System.out.println( "Enter Number: ");
                    number = scanner.nextLong();
                    System.out.println( (myPrimeClass.isPrime(number) ? "it's prime" : "not prime")); //check number and print output using inline if
                    break;

                case 2:
                    System.out.println( "Enter bound (execluded): ");
                    number = scanner.nextLong();
                    System.out.println( myPrimeClass.printUntil(number)); //print numbers
                    break;

                default:
                    System.out.println( "unExpected choice !");
            }
        }
    }
}
