﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enities.ViweModel.Payment
{
    public class CreateCheckoutVM
    {
        public int CourseId { get; set; }   
        public string Title { get; set; }
        public string Description { get; set; }
        public long Price { get; set; }

    }
}
