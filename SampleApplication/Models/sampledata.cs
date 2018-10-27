using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace SampleApplication.Models
{
    public class SampleData
    {
        private int id;
        private int applicationId;
        private string type;
        private string summary;
        private double amount;
        private DateTime postingDate;
        private bool isCleared;
        private DateTime clearedDate;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

      public int ApplicationId
        {
            get
            {
                return applicationId;
            }

            set
            {
                this.applicationId = value;
            }
        }

        public string Type
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
            }
        }

        public string Summary
        {
            get
            {
                return Summary;
            }

            set
            {
                Summary = value;
            }
        }

        public double Amount
        {
            get
            {
                return amount;
            }

            set
            {
                amount = value;
            }
        }

        public DateTime PostingDate
        {
            get
            {
                return postingDate;
            }

            set
            {
                postingDate = value;
            }
        }

        public bool IsCleared
        {
            get
            {
                return isCleared;
            }

            set
            {
                isCleared = value;
            }
        }

        public DateTime ClearedDate
        {
            get
            {
                return clearedDate;
            }

            set
            {
                clearedDate = value;
            }
        }
    }
}