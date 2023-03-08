import javafx.fxml.Initializable;

import java.net.URL;
import java.util.ResourceBundle;

import javafx.collections.FXCollections;
import javafx.collections.ObservableList;
import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.scene.control.ComboBox;
import javafx.scene.control.Label;
import javafx.scene.control.ListView;

public class MainController implements Initializable {
    @FXML
	public Label DisplayStatus;
	
	@FXML
	public ComboBox<String> emscombo;
	public ComboBox<String> cascombo;
	public ComboBox<String> mwcombo;
	
	@FXML
	public ListView<String> emsview;

	ObservableList<String> emslist = FXCollections.observableArrayList("NONE","AREL","EiTPL");
	ObservableList<String> caslist = FXCollections.observableArrayList("NONE", "NSTV","ABV");
	ObservableList<String> mwlist = FXCollections.observableArrayList("NONE", "Smasher","Suresoft","TCL","Corpus");
	
	@Override
	public void initialize(URL arg0, ResourceBundle arg1) {
		// TODO Auto-generated method stub
		emscombo.setItems(emslist);
		cascombo.setItems(caslist);
		mwcombo.setItems(mwlist);
		
		///emsview.setItems(emslist);
	}
			
	public void Submit(ActionEvent event) throws Exception {
		System.out.println("In Submit:");
		
		if (emscombo.getValue() == null || cascombo.getValue() == null || mwcombo.getValue() ==null) {
			DisplayStatus.setText("Please Choose the EMS/CAS/MW");
		} else {
			DisplayStatus.setText(" EMS Name:"+emscombo.getValue() +"\n CAS name:" +cascombo.getValue()+"\n MW name:" +mwcombo.getValue() );
		}
		System.out.println("EMS name:" +emscombo.getValue());
		System.out.println("CAS name:" +cascombo.getValue());
		System.out.println("MW name:" +mwcombo.getValue());
	}
    
}
