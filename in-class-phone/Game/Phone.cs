
public class Phone {

    // public string phone_number = 4567890;
    public string phone_number = "";
    List<string> text_messages = new List<string>(); 

    public Phone(string phone_number) {
        this.phone_number = phone_number;
    }

    public void place_call(string number_to_call) 
    {
        // phone_number = number_to_call;
        Console.WriteLine("Calling");

    }

    public void place_text(string number_to_text, string message_to_send) 
    {

    }

    public void save_text(string message_to_save) 
    {

    }

    public void get_text() 
    {
        
    }
    public string get_number() 
    {
        return phone_number;
    }



}