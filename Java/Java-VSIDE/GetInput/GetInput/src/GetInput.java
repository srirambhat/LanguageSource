import java.util.Scanner;
import java.io.FileInputStream;
import java.io.FileNotFoundException;

public class GetInput {
	public static void main(String args[]) {
		
		/* 	
		File file = new File(".");
		for(String fileNames : file.list()) System.out.println(fileNames);
		*/
		FileInputStream FS;
		try {
			FS = new FileInputStream("dummy.txt");
			Scanner scanner = new Scanner(FS);
	        int counter = 0;
	        
	        while (scanner.hasNext()) {
	            counter++;
	            // String P = scanner.findWithinHorizon(scanner.next(), 100);
	            String P = scanner.next();
	            if (P!=null)
	                System.out.println(counter+" "+P);
	            
	        }
		} catch (FileNotFoundException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}

		/*
		try (Scanner in = new Scanner("abc123")) {
			for(;;) {
			    String found = in.findWithinHorizon(".", 2);
			    if(found == null) break;

			    System.out.println(found);
			}
			
			
			int input;
			Scanner keyboard = new Scanner(System.in);
			int random = new Random().nextInt(10) + 1;
					
			System.out.print("Enter a number between 1-10: ");
			input = keyboard.nextInt();
			
			System.out.println("The number entered: " +input + " Random Number: " +random);
			System.out.println("\n\r");
			if (input == random) {
				System.out.println("You guessed it right");
			} else {
				System.out.println("Try again");
			}
			
			String password;
			System.out.print("What is the password: ");
			password = keyboard.next();
			
			if (password.equals("Pass")) {
				System.out.println("Passwrd Entered is correct");
			} else {
				System.out.println("Password is incorrect");
			}
			
			String username = JOptionPane.showInputDialog("Username:");
			password = JOptionPane.showInputDialog("Password:");
			
			JOptionPane.showMessageDialog(null, "Username: " + username + "Password: " +password);
			keyboard.close();
			in.close();
		} catch (HeadlessException e) {
			// TODO Auto-generated catch block
			e.printStackTrace();
		}
		*/
	}
}
