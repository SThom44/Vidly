using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Vidly.Models;

namespace Vidly.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "A name is required.")]
        [StringLength(55)]
        public string Name { get; set; }
        [Required(ErrorMessage = "A Genre is required.")]
        public GenreDto Genre { get; set; }
        public byte GenreId { get; set; }
        [Required(ErrorMessage = "A release date is required.")]
        [Display(Name = "Release Date")]
        public int ReleaseDate { get; set; }
        [Required(ErrorMessage = "A Description is required.")]
        [StringLength(255)]
        public string Description { get; set; }
        [Required(ErrorMessage = "A date is required.")]
        [Display(Name = "Date Added")]
        public DateTime DateAdded { get; set; }
        [Required(ErrorMessage = "Stock is required.")]
        [Display(Name = "Number in Stock")]
        [Range(1, 20, ErrorMessage = ("Value must be between 1 and 20."))]
        public int InStock { get; set; }
    }
}