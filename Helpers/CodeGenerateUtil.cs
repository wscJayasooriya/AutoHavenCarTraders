using CarTraders.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarTraders.Helpers
{
    public class CodeGenerateUtil
    {
        public string GetNextUserCode(string role)
        {
            using (var dbContext = new ApplicationDBContext())
            {
                string prefix = role == "Customer_Role" ? "C" : "U";
                var lastUser = dbContext.users
                    .Where(u => u.UserRole == role && u.UserCode.StartsWith(prefix))
                    .OrderByDescending(u => u.UserCode)
                    .FirstOrDefault();

                if (lastUser != null)
                {
                    int currentNumber = int.Parse(lastUser.UserCode.Substring(1)) + 1;
                    return prefix + currentNumber.ToString("D5");
                }
                else
                {
                    // Initialize if not present
                    return prefix + "00001";
                }
            }
        }

        public string GetNextCarCode()
        {
            using (var dbContext = new ApplicationDBContext())
            {
                string prefix = "CAR";
                var car = dbContext.cars
                    .Where(c => c.CarCode.StartsWith(prefix))
                    .OrderByDescending(c => c.CarCode)
                    .FirstOrDefault();

                if (car != null)
                {
                    int currentNumber = int.Parse(car.CarCode.Substring(3)) + 1;
                    return prefix + currentNumber.ToString("D5");
                }
                else
                {
                    return prefix + "00001";
                }
            }
        }

        public string GetNextCarPartCode()
        {
            using (var dbContext = new ApplicationDBContext())
            {
                string prefix = "CP";
                var car = dbContext.carParts
                    .Where(c => c.CarPartCode.StartsWith(prefix))
                    .OrderByDescending(c => c.CarPartCode)
                    .FirstOrDefault();

                if (car != null)
                {
                    int currentNumber = int.Parse(car.CarPartCode.Substring(2)) + 1;
                    return prefix + currentNumber.ToString("D5");
                }
                else
                {
                    return prefix + "00001";
                }
            }
        }
        public string GenerateOrderCode()
        {
            using (var dbContext = new ApplicationDBContext())
            {
                string prefix = "INV";
                var car = dbContext.orderDetails
                    .Where(c => c.OrderCode.StartsWith(prefix))
                    .OrderByDescending(c => c.OrderCode)
                    .FirstOrDefault();

                if (car != null)
                {
                    int currentNumber = int.Parse(car.OrderCode.Substring(3)) + 1;
                    return prefix + currentNumber.ToString("D5");
                }
                else
                {
                    return prefix + "00001";
                }
            }
        }

    }
}
