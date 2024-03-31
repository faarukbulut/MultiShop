﻿namespace MultiShop.DtoLayer.CommentDtos.UserCommentDtos
{
    public class UpdateUserCommentDto
    {
        public int UserCommentID { get; set; }
        public string ProductID { get; set; }
        public string NameSurname { get; set; }
        public string Email { get; set; }
        public string CommentDetail { get; set; }
        public int Rating { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool Status { get; set; }
    }
}
