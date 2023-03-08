import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.scene.control.Label;
import javafx.scene.control.Button;

public class MainSceneController {

    @FXML
    private Label result;
	private long number1 = 0;
	private String operator="";
	private boolean start = true;
    private NumberCrunch numCrunch = new NumberCrunch();

    @FXML
    void ProcessNumbers(ActionEvent event) {

        if (start) {
			result.setText("");
	        start = false;
		}

		String value = ((Button)event.getSource()).getText();
	    result.setText(result.getText() + value);
		System.out.println("In Process Numbers Value: " +value);
    }

    @FXML
    void ProcessOperators(ActionEvent event) {
        
        String value = ((Button)event.getSource()).getText();

        if (!"=".equals(value)) {
            if (!operator.isEmpty())
                return;

            operator = value;
            number1 = Long.parseLong(result.getText());
            result.setText("");
            System.out.println("In Process Operators Value: " +number1);
        }
        else {
            if (operator.isEmpty())
                return;

            result.setText(String.valueOf(numCrunch.calculate(number1, Long.parseLong(result.getText()), operator)));
            operator = "";
            start = true;
        }
		System.out.println("In Process Operators");
	}
}
