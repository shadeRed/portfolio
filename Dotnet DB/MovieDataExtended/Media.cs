using System;
using System.Collections.Generic;
using System.IO;

namespace MovieDataExtended {
    abstract class Media {
        public int id;
        public string title;

        public virtual string Display() {
            return $"id: {this.id}\ntitle: {this.title}";
        }
    }
}