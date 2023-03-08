import java.util.Enumeration;
import java.util.Hashtable;

public class HashTableExample {

	public static void main(String[] args) {
		 
		Enumeration names;
		Object key;
		 
		// Creating a Hashtable
		Hashtable<Integer, String> hashtable = 
		              new Hashtable<Integer, String>();
		 
		// Adding Key and Value pairs to Hashtable
		hashtable.put(55,"Chaitanya");
		hashtable.put(22,"Ajeet");
		hashtable.put(74,"Peter");
		hashtable.put(122,"Ricky");
		hashtable.put(1,"Mona");
		 
		names = hashtable.keys();
		while(names.hasMoreElements()) {
		   key = names.nextElement();
		   System.out.println("Key: " +key+ " & Value: " +
		   hashtable.get(key));
		}
	}
}
