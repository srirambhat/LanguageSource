
import java.time.LocalDate;

import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.scene.control.DatePicker;
import javafx.scene.control.Label;

public class DatePickerController {
	@FXML private DatePicker dp;
	@FXML private Label lblDate;
	
	public void ShowDate (ActionEvent event) {
		LocalDate ld = dp.getValue();
		lblDate.setText(ld.toString());
	}
}
