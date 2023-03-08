import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import javax.swing.*;

public class MainFrame extends JFrame {
    final private Font mainFont = new Font("Segoe print", Font.BOLD, 18);
    JTextField tfFirstName;
    JTextField tfLastName;
    JLabel lbWelcome;
    
    public void Initialize() 
    {

        /* *********Form Panel ************ */

        JLabel lblFirstName = new JLabel("First Name");
        lblFirstName.setFont(mainFont);

        tfFirstName = new JTextField();
        tfFirstName.setFont(mainFont);

        JLabel lblLastName = new JLabel("Last Name");
        lblLastName.setFont(mainFont);

        tfLastName = new JTextField();
        tfLastName.setFont(mainFont);

        /* **** Welcome Label ************* */
        lbWelcome = new JLabel();
        lbWelcome.setFont(mainFont);;

        /* **************** Button Panel ************* */
        JButton btnOk = new JButton("OK");
        btnOk.setFont(mainFont);

        btnOk.addActionListener(new ActionListener() {

            @Override
            public void actionPerformed(ActionEvent e) {
                /* TODO Auto-generated method stub  */
                String firstName = tfFirstName.getText();
                String LastName = tfLastName.getText();

                lbWelcome.setText("Hello" +firstName + " " + LastName);
            }

            
        });

        JButton btnClear = new JButton("Clear");
        btnOk.setFont(mainFont);

        btnClear.addActionListener(new ActionListener() {

            @Override
            public void actionPerformed(ActionEvent e) {
                /* TODO Auto-generated method stub  */
                tfFirstName.setText("");
                tfLastName.setText("");
                lbWelcome.setText("");
            }

        });

        JPanel buttonPanel = new JPanel();
        buttonPanel.setLayout(new GridLayout(1,2,5,5));
        buttonPanel.add(btnOk);
        buttonPanel.add(btnClear);

        JPanel formPanel = new JPanel();
        formPanel.setLayout(new GridLayout(4,1,5,5));
        formPanel.add(lblFirstName);
        formPanel.add(tfFirstName);
        formPanel.add(lblLastName);
        formPanel.add(tfLastName);

        JPanel mainPanel = new JPanel();
        mainPanel.setLayout(new BorderLayout());
        mainPanel.setBackground(new Color(128,128,255));
        mainPanel.add(formPanel, BorderLayout.NORTH);
        mainPanel.add(lbWelcome, BorderLayout.CENTER);
        mainPanel.add(buttonPanel, BorderLayout.SOUTH);

        add(mainPanel);


        setTitle("Welcome");
        setSize(500,600);
        setMinimumSize(new Dimension(300, 400));
        setDefaultCloseOperation(WindowConstants.EXIT_ON_CLOSE);
        setVisible(true);
    }
    
    public static void main(String[] args) {
        MainFrame myFrame = new MainFrame();
        myFrame.Initialize();

    }
}
