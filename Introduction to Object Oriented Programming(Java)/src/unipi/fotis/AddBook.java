package unipi.fotis;

import java.io.*;
import java.util.Scanner;

public class AddBook {
    // Displays the menu to the user
    public static void main(String[] args) {

        displayMenu();

    }
    //Displays all the contacts written and saved in the txt file
    public static void ShowContacts() {
        try (BufferedReader br = new BufferedReader(new FileReader("Store.txt"))) {
            String line = null;
            while ((line = br.readLine()) != null) {
                System.out.println(line);
            }
        } catch (IOException e) {
            System.out.println(e.getMessage());
        }
    }
    //Saving every contact line by line in the txt file and split the info with "|"
    public static void SaveContact(String name, String phone, String email, String address) {

        try (PrintWriter pw = new PrintWriter(new FileWriter("Store.txt", true))) {
            pw.println(name + "/" + phone + "/" + email + "/" + address);
        } catch (IOException e) {
            System.out.println(e.getMessage());
        }
    }

    //Saving every contact line by line into an array and check every name to S[0]
    public static void findName(String name) {
        try (Scanner in = new Scanner(new File("Store.txt"))) {
            String s[];
            while (in.hasNextLine()) {
                s = in.nextLine().split("/");
                if (s[0].equals(name)) {
                    System.out.println(name +" "+"is saved in the address book");

                }
            }
        } catch (IOException e) {
            System.out.println(e.getMessage());
        }

    }
    // //Saving every contact line by line into an array and check every number to S[1]
    public static void findNum(String num) {
        try (Scanner in = new Scanner(new File("Store.txt"))) {
            String s[];
            while (in.hasNextLine()) {
                s = in.nextLine().split("/");
                if (s[1].equals(num)) {
                    System.out.println("This is"+" "+ s[0] + "'s phone number" );

                }
            }
        } catch (IOException e) {
            System.out.println(e.getMessage());
        }

    }

    //Editing the contact
    public static void EditContact(String nm) {
        try (Scanner in = new Scanner(new File("Store.txt"))) {
            String s[];
            while (in.hasNextLine()) {

                s = in.nextLine().split("/");
                if (s[0].equals(nm)) {

                    //Overwrite the Store.txt file using another temp in order to remove the contact asked from the user
                    File inputFile = new File("Store.txt");
                    File tempFile = new File("myTempFile.txt");

                    BufferedReader reader = new BufferedReader(new FileReader(inputFile));
                    BufferedWriter writer = new BufferedWriter(new FileWriter(tempFile));

                    String lineToRemove = nm + "/" + s[1] + "/" + s[2] + "/" + s[3];
                    String currentLine;

                    while ((currentLine = reader.readLine()) != null) {
                        String trimmedLine = currentLine.trim();
                        if (trimmedLine.equals(lineToRemove)) continue;
                        writer.write(currentLine + System.getProperty("line.separator"));

                    }
                    writer.close();
                    reader.close();

                    FileInputStream instream = null;
                    FileOutputStream outstream = null;

                    try {
                        File infile = new File("myTempFile.txt");
                        File outfile = new File("Store.txt");

                        instream = new FileInputStream(infile);
                        outstream = new FileOutputStream(outfile);

                        byte[] buffer = new byte[1024];

                        int length;
                        while ((length = instream.read(buffer)) > 0) {
                            outstream.write(buffer, 0, length);
                        }


                        instream.close();
                        outstream.close();
                    } catch (IOException e) {
                        System.out.println(e.getMessage());
                    }


                }
            }


        } catch(IOException e){
            System.out.println(e.getMessage());
        }
        Scanner in = new Scanner(System.in);
        //Getting all the info that user wants to change
        //Every "while" loop with "flag2" is used in order to specifically control every input of the user and terminate every possibility of
        //false input and wrong data written in the txt file.
        int flag2=0;
        System.out.println("Enter a new name: ");
        String  name= in.nextLine();
        while (flag2==0){

            if (name.matches("[a-zA-Z_]+")) {
                flag2=1;
            } else {
                System.out.println("Invalid input,please insert a name to proceed");
                name= in.nextLine();
            }
        }
        flag2=0;
        System.out.println("Enter a new phone number: ");
        String phone=in.nextLine();
        while (flag2==0){
            if (phone.matches("[0-9]+")&& phone.length()==10) {
                flag2=1;
            } else {
                System.out.println("Invalid input,please insert a phone number to proceed");
                phone=in.nextLine();
            }
        }
        flag2=0;
        System.out.println("Enter a new e-mail: ");
        String email = in.nextLine();
        while (flag2==0){
            if (email.matches("[0-9a-zA-Z@.]+")&& email.contains("@")&& email.contains(".")){
                flag2=1;
            } else {
                System.out.println("Invalid input,please insert an e-mail to proceed");
                email= in.nextLine();
            }
        }
        flag2=0;

        System.out.println("Enter a new address: ");
        String address = in.nextLine();
        while (flag2==0){
            if (name.matches("[0-9a-zA-Z ]+")){
                flag2=1;
            } else {
                System.out.println("Invalid input,please insert an address to proceed");
                address = in.nextLine();
            }
        }
        SaveContact(name, phone, email, address);

    }


    //Deleting contact
    public static void DeleteContact(String name) {
        try (Scanner in = new Scanner(new File("Store.txt"))) {
            String s[];
            //Searching for the name given by the user
            while (in.hasNextLine()) {
                s = in.nextLine().split("/");
                if (s[0].equals(name)) {
                    //Overwriting the Store.txt with the use of a tmp file
                    File inputFile = new File("Store.txt");

                    File tempFile = new File("myTempFile.txt");

                    BufferedReader reader = new BufferedReader(new FileReader(inputFile));
                    BufferedWriter writer = new BufferedWriter(new FileWriter(tempFile));

                    String lineToRemove = name + ":" + s[1] + ":" + s[2] + ":" + s[3];
                    String currentLine;

                    while ((currentLine = reader.readLine()) != null) {
                        String trimmedLine = currentLine.trim();
                        if (trimmedLine.equals(lineToRemove)) continue;
                        writer.write(currentLine + System.getProperty("line.separator"));

                    }

                    writer.close();
                    reader.close();


                }
                FileInputStream instream = null;
                FileOutputStream outstream = null;

                try{
                    File infile =new File("myTempFile.txt");
                    File outfile =new File("Store.txt");

                    instream = new FileInputStream(infile);
                    outstream = new FileOutputStream(outfile);

                    byte[] buffer = new byte[1024];

                    int length;
                    while ((length = instream.read(buffer)) > 0){
                        outstream.write(buffer, 0, length);
                    }


                    instream.close();
                    outstream.close();



                }catch(IOException ioe){
                    ioe.printStackTrace();

                }
            }

        } catch (IOException e) {
            System.out.println(e.getMessage());
        }
    }
    // Menu display with a while loop so the user can run the app as long as he/she/it doesn't exit on his/her/its own.
    public static void displayMenu() {
        int flag=0;

        Scanner in = new Scanner(System.in);
        while (flag==0){
        System.out.println("1.Προβολή όλων των διαθέσημων επαφών");
        System.out.println("2.Προσθήκη νέας επαφής");
        System.out.println("3.Αναζήτηση επαφής βάσει ονόματος");
        System.out.println("4.Αναζήτηση επαφής βάσει τηλεφώνου");
        System.out.println("5.Επεξεργασία επαφής βάσει ονόματος");
        System.out.println("6.Διαγραφή επαφής βάσει ονόματος");
        System.out.println("7.Εξοδος");

        int choice = in.nextInt();
        in.nextLine();

        if (choice == 1) {
            ShowContacts();
        }


        else if (choice == 2){
            //Every "while" loop with "flag2" is used in order to specifically control every input of the user and terminate every possibility of
            //false input and wrong data written in the txt file.
            int flag2=0;
            System.out.println("Enter a new name: ");
            String  name= in.nextLine();
            while (flag2==0){

                if (name.matches("[a-zA-Z_]+")) {
                    flag2=1;
                } else {
                    System.out.println("Invalid input,please insert a name to proceed");
                    name= in.nextLine();
                }
            }
            flag2=0;
            System.out.println("Enter a new phone number: ");
            String phone=in.nextLine();
            while (flag2==0){
                if (phone.matches("[0-9]+")&& phone.length()==10) {
                    flag2=1;
                } else {
                    System.out.println("Invalid input,please insert a phone number to proceed");
                    phone=in.nextLine();
                }
            }
            flag2=0;
            System.out.println("Enter a new e-mail: ");
            String email = in.nextLine();
            while (flag2==0){
                if (email.matches("[0-9a-zA-Z@.]+")&& email.contains("@")&& email.contains(".")){
                    flag2=1;
                } else {
                    System.out.println("Invalid input,please insert an e-mail to proceed");
                    email= in.nextLine();
                }
            }
            flag2=0;

            System.out.println("Enter a new address: ");
            String address = in.nextLine();
            while (flag2==0){
                if (name.matches("[0-9a-zA-Z ]+")){
                    flag2=1;
                } else {
                    System.out.println("Invalid input,please insert an address to proceed");
                    address = in.nextLine();
                }
            }
            SaveContact(name, phone, email, address);

        }
        else if (choice == 3) {
            System.out.println("Enter a name to proceed the searching in the address book");
            String name = in.nextLine();
            findName(name);
        }
        else if (choice == 4 ){
            System.out.println("Enter a number to proceed with searching in the address book");
            String num =in.nextLine();
            findNum(num);
        }
        else if (choice ==5 ) {
            System.out.println("Enter a name to proceed with editing");
            String nm = in.nextLine();
            EditContact(nm);


        }
        else if (choice==6){
            System.out.println("Enter a name to delete the contact");
            String name=in.nextLine();
            DeleteContact(name);

        }
        else if (choice == 7) {
            System.out.println("Thanks for using my app!");
            flag=1;

        }
        else{
            System.out.println('\n'+"Please select one of the 7 options"+'\n');

        }
    }
    }
}

