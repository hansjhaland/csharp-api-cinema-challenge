﻿using Microsoft.AspNetCore.Http.HttpResults;

namespace api_cinema_challenge.DTOs
{
    public class MovieGet
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Rating { get; set; }
        public string Description { get; set; }
        public int RuntimeMins { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
