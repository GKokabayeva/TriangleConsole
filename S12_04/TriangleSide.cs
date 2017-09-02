using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S12_04
{
    class TriangleSide
    {
        private decimal side;
        public decimal Side
        {
            get { return side; }
        }

        public void EnterSide(int numberOfAttemptsRemaining)
        {
            try
            {
                if (decimal.TryParse(Console.ReadLine().Trim().Replace(",", "."),
                    System.Globalization.NumberStyles.Any,
                    System.Globalization.CultureInfo.InvariantCulture, out side))
                {
                }
                else
                {
                    throw new IncorrectTriangleSideValueException("Invalid side!");
                }
            }

            catch (Exception ex)
            {
                try
                {
                    Console.WriteLine(ex.Message);

                    if (numberOfAttemptsRemaining <= 0)
                        throw new SomethingBadHappenedException();

                    Console.Write("Let us try again: ");
                    EnterSide(numberOfAttemptsRemaining - 1);
                }
                catch (SomethingBadHappenedException e)
                {
                    e.WriteException();
                }
            }
        }
    }
}
