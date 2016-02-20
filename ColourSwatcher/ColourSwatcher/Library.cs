using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColourSwatcher
{
    
    public class Library
    {

        private static Library library;
        private object map;
        private string pullerObject;

        public static Library Instance {
            get
            {
                if (library == null)
                {
                    library = new Library();
                }

                return library;

            }
            private set { }
        }

        Dictionary<string, PalleteColor> colors = new Dictionary<string, PalleteColor>();

        private Library(string category, PalleteColour color)
        { 
 
       

        Hashtable colourLibrary = new Hashtable();
        pullerObject = "";
            if (category == "")
            {
                category = "uncategorised";
                colourLibrary.Add(category, color);
            
            }
        
   


                 } 


        public bool addColour(string category, PalleteColor color)
        {
            
            colors.Add(category, color);
        }


        }
   


    }

