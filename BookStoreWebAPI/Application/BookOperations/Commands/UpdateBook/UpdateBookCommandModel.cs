﻿namespace BookStoreWebAPI.BookOperations.UpdateBook
{
    public class UpdateBookCommandModel
    {
        public string Title { get; set; }
        public int GenreId { get; set; }
        //public int PageCount { get; set; }
        //public DateTime PublishDate { get; set; }
    }
}
