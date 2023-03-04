using System;

namespace HotelAccounting
{
    class AccountingModel : ModelBase
    {
        private double _price;
        private int _nightsCount;
        private double _discount;
        private double _total;

        public double Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentException();
                _price = value;
                _total = _price * _nightsCount * (1 - _discount / 100);
                Notify(nameof(Total));
                Notify(nameof(Price));
            }
        }

        public int NightsCount
        {
            get
            {
                return _nightsCount;
            }
            set
            {

                if (value <= 0)
                    throw new ArgumentException();
                _nightsCount = value;
                _total = _price * _nightsCount * (1 - _discount / 100);
                Notify(nameof(NightsCount));
                Notify(nameof(Total));

            }
        }
        public double Discount
        {
            get
            {
                return _discount;
            }
            set
            {
                if (value > 100)
                    throw new ArgumentException();
                _discount = value;
                _total = _price * _nightsCount * (1 - _discount / 100);
                Notify(nameof(Discount));
                Notify(nameof(Total));
            }
        }

        public double Total
        {
            get
            {
                return _total;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentException();
                _total = value;
                _discount = 100 - (_total * 100 / (_price * _nightsCount));
                Notify(nameof(Discount));
                Notify(nameof(Total));
            }
        }
    }
}
