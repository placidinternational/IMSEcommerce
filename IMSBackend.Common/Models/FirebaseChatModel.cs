namespace IMSBackend.Common.Models;
public class FirebaseNotification
{
    public string body { get; set; }
    public string title { get; set; }
    public string sound { get; set; }
}
public class FirebaseNotificationExtension : FirebaseNotification
{
    public string image { get; set; }
}
public class FirebaseData
{
    public string body { get; set; }
    public string title { get; set; }
    public string fullName { get; set; }
    public string userName { get; set; }
    public string userId { get; set; }
    public string click_action { get; set; }
    public string image { get; set; } = string.Empty;
}

public class FirebaseData2
{
    public string body { get; set; }
    public string title { get; set; }
    public string fullName { get; set; }
    public string userName { get; set; }
    public string BookingId { get; set; }
    public string ProductId { get; set; }
    public string click_action { get; set; }
    public string type { get; set; }
    public string image { get; set; }
}

public class FirebaseRoot
{
    public string to { get; set; }
    public string image { get; set; }
    public FirebaseNotification notification { get; set; }
    public FirebaseData data { get; set; }
}

public class FirebaseRoot2
{
    public string to { get; set; }
    public string image { get; set; }
    public FirebaseNotification notification { get; set; }
    public FirebaseData2 data { get; set; }
}

public class FirebaseModel
{
    //string body, string userId, string token, string title
    public string body { get; set; }
    public string userId { get; set; }
    public string token { get; set; }
    public string title { get; set; }

}

public class FirebaseChatModel
{
    public string body { get; set; }
    public string type { get; set; }
    public string token { get; set; }
    public string title { get; set; }
    public string ProductId { get; set; }
}
