﻿using System.ComponentModel.DataAnnotations;
using tp55.Models;

namespace tp55.Dtos
{
    public class MovieDetailsDto
    {
        public int Id { get; set; }

        public string Title { get; set; }
        public int Year { get; set; }
        public double Rate { get; set; }

        public string Storeline { get; set; }
        public byte[] Poster { get; set; }
        public byte GenreId { get; set; }
        public String GenreName { get; set; }

    }
}
