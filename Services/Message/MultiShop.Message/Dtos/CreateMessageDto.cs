namespace MultiShop.Message.Dtos
{
    public class CreateMessageDto
    {
        public string SenderID { get; set; }
        public string ReceiverID { get; set; }
        public string Subject { get; set; }
        public string MessageDetail { get; set; }
        public bool isRead { get; set; }
        public DateTime MessageDate { get; set; }
    }
}
