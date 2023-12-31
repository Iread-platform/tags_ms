﻿using System;
using System.Collections.Generic;
using iread_story.Web.DTO.Tag;

namespace iread_story.Web.DTO.Story
{
    public class UpdateStoryDto
    {
        public int StoryId { get; set; }

        public string Title { get; set; }

        public int LanguageId { get; set; }

        public DateTime ReleaseDate { get; set; }

        public string Description { get; set; }

        public int StoryLevel { get; set; }

        public string Writer { get; set; }
        public string Color { get; set; }

    }
}