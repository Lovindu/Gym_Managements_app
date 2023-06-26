using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gym_Managements_app.Calculations
{
    internal class Calculations
    {
        public double finalPrice;
        public double calculateMembeshipFee(string paymentType, string membershipType, double membershipTypePrice, string personalTraining, double personalTrainingPrice)
        {
            // individual = 4000, per month
            // family = 12000 per month
            // couple = 6000 per month
            // if personal trainig is yes add 4000 more
            // if the payment method is per year multiply and give 25% off discount

            // double finalPrice;

            if (paymentType == "monthly")
            {
                if(membershipType == "individual" && personalTraining == "yes")
                {
                    finalPrice = membershipTypePrice + personalTrainingPrice; 
                } 
                else if (membershipType == "individual" && personalTraining == "no") 
                {
                    finalPrice = membershipTypePrice;
                }

                if (membershipType == "family" && personalTraining == "yes")
                {
                    finalPrice = membershipTypePrice + personalTrainingPrice;
                } else if (membershipType == "family" && personalTraining == "no")
                {
                    finalPrice = membershipTypePrice;
                }

                if(membershipType == "couple" && personalTraining == "yes")
                {
                    finalPrice = membershipTypePrice + personalTrainingPrice;
                } else if (membershipType == "couple" && personalTraining == "no")
                {
                    finalPrice = membershipTypePrice;
                }
            } else
            {
                if (membershipType == "individual" && personalTraining == "yes")
                {
                    finalPrice = ((membershipTypePrice * 12) - ((membershipTypePrice / 100) * 25)) + (personalTrainingPrice * 12);
                }
                else if (membershipType == "individual" && personalTraining == "no")
                {
                    finalPrice = ((membershipTypePrice * 12) - ((membershipTypePrice / 100) * 25));
                }

                if (membershipType == "family" && personalTraining == "yes")
                {
                    finalPrice = ((membershipTypePrice * 12) - ((membershipTypePrice / 100) * 25)) + (personalTrainingPrice * 12);
                }
                else if (membershipType == "family" && personalTraining == "no")
                {
                    finalPrice = ((membershipTypePrice * 12) - ((membershipTypePrice / 100) * 25));
                }

                if (membershipType == "couple" && personalTraining == "yes")
                {
                    finalPrice = ((membershipTypePrice * 12) - ((membershipTypePrice / 100) * 25)) + (personalTrainingPrice * 12);
                }
                else if (membershipType == "couple" && personalTraining == "no")
                {
                    finalPrice = ((membershipTypePrice * 12) - ((membershipTypePrice / 100) * 25));
                }
            }
            return finalPrice; 
        }
    }
}
