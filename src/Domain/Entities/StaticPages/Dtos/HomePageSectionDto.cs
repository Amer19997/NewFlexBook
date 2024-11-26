using System;
using System.Collections.Generic;
using FlexBook.Domain.Entities.Catalog.Dtos;

namespace FlexBook.Domain.Entities.StaticPages.Dtos
{
    public class HomePageSectionDto
    {
        // Books Section
        public string BooksTitleAr { get; set; } = string.Empty;
        public string BooksTitleEn { get; set; } = string.Empty;
        public string BooksDescriptionAr { get; set; } = string.Empty;
        public string BooksDescriptionEn { get; set; } = string.Empty;

        // First Feature
        public string FirstFeatureTitleAr { get; set; } = string.Empty;
        public string FirstFeatureTitleEn { get; set; } = string.Empty;
        public string FirstFeatureDescriptionAr { get; set; } = string.Empty;
        public string FirstFeatureDescriptionEn { get; set; } = string.Empty;

        // Second Feature
        public string SeconedFeatureTitleAr { get; set; } = string.Empty;
        public string SeconedFeatureTitleEn { get; set; } = string.Empty;
        public string SeconedFeatureDescriptionAr { get; set; } = string.Empty;
        public string SeconedFeatureDescriptionEn { get; set; } = string.Empty;
        public string FeaturedImage { get; set; } = string.Empty;

        // Featured Images
        //public List<string> FeaturedImages { get; set; } = new();

        // Growth Section
        public string GrowthTitleAr { get; set; } = string.Empty;
        public string GrowthTitleEn { get; set; } = string.Empty;
        public string GrowthDescriptionAr { get; set; } = string.Empty;
        public string GrowthDescriptionEn { get; set; } = string.Empty;
        public string GrowthImage { get; set; } = string.Empty;

        // Highlighted Books Section
        public string HighlightedBooksTitleAr { get; set; } = string.Empty;
        public string HighlightedBooksTitleEn { get; set; } = string.Empty;
        public string HighlightedBooksDescriptionAr { get; set; } = string.Empty;
        public string HighlightedBooksDescriptionEn { get; set; } = string.Empty;
        public IEnumerable<CourseDto> HighlightedCourses { get; set; } = new List<CourseDto>();

        // Video Section
        public string VideoTitleAr { get; set; } = string.Empty;
        public string VideoTitleEn { get; set; } = string.Empty;
        public string VideoDescriptionAr { get; set; } = string.Empty;
        public string VideoDescriptionEn { get; set; } = string.Empty;
        public string VideoUrl { get; set; } = string.Empty;
    }
}
