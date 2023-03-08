import java.awt.*;

public class Brdr1 extends Frame {

		// constructor
	    public Brdr1(String title)
	    {   
	        /* It would create the Frame by calling
	         * the constructor of Frame class.
	         */
	        super(title);    
	        
	        //Setting up Border Layout
	        setLayout(new BorderLayout());
	        
	        //Creating a button and adding it to PAGE_START area
	        Button b1 = new Button("PAGE_START");
	        add(b1, BorderLayout.PAGE_START);
	        
	        /* Similarly creating 4 other buttons and adding
	         * them to other 4 areas of Border Layout
	         */
	        Button b2= new Button("CENTER");
	        add(b2, BorderLayout.CENTER);

	        Button b3= new Button("LINE_START");
	        add(b3, BorderLayout.LINE_START);

	        Button b4= new Button("PAGE_END");
	        add(b4, BorderLayout.PAGE_END);

	        Button b5= new Button("LINE_END");
	        add(b5, BorderLayout.LINE_END);
	    }
	    public static void main(String[] args)
	    {   Brdr1 screen = 
	            new Brdr1("Border Layout - sriram.in");
	        screen.setSize(500,250);
	        screen.setVisible(true);	
	    }
}
