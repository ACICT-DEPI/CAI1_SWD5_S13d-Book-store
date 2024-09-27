﻿namespace BKStore_MVC.ViewModel
{
    public class BookWithAuthorWithPuplisherWithCategVM
    {
        public int BookID { get; set; }
        public string Title { get; set; }
        public int? StockQuantity { get; set; }
        public int PublisherID { get; set; }
        public double Price { get; set; }
        public int CategoryID { get; set; }
        public string BookImagePath { get; set; }
        public string Description { get; set; }
        public int AuthorId { get; set; }
        public string AuthorName { get; set; }
        public string PublisherName { get; set; }
        public string CategoryName { get; set; }

    }
}
