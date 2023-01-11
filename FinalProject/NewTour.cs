using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class NewTour
    {
        private List<string> NewTourName = new List<string>();
        private List<string> NewTourTime = new List<string>();
        private List<string> NewTourPrice = new List<string>();
        private List<string> NewTourPic = new List<string>();
        
        public List<string> getset_NewTourName
        {
            get
            {
                return NewTourName;
            }
            set
            {
                NewTourName.Add(value.ToString());
            }
        }
        public List<string> getset_NewTourTime
        {
            get
            {
                return NewTourTime;
            }
            set
            {
                NewTourTime.Add(value.ToString());
            }
        }
        public List<string> getset_NewTourPrice
        {
            get
            {
                return NewTourPrice;
            }
            set
            {
                NewTourPrice.Add(value.ToString());
            }
        }
        public List<string> getset_NewTourPic
        {
            get
            {
                return NewTourPic;
            }
            set
            {
                NewTourPic = value;
            }
        }
    }
}

