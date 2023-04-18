﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreBlog.EntityLayer.Concrete
{
    public class Writer
    {
        public int WriterId { get; set; }
        public string WriterNameSurname { get; set; }
        public string WriterAbout { get; set; }
        public string WriterImage { get; set; }
        public string WriterEmail { get; set; }
        public string WriterPassword { get; set; }
        public string ConfirmPassword { get; set; }
        public bool WriterStatus { get; set; }

        public List<Blog> Blogs { get; set; }
    }
}
