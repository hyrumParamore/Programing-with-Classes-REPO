

public class CameraPhone : Phone {

    List<string> pictures = new List<string>();
    
    public CameraPhone(string phone_number) : base(phone_number) 
    {

    }

    public void take_picture(string picture_name)
    {
        pictures.Add(picture_name);
    }
    




}