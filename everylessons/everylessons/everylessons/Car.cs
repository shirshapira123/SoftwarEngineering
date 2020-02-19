using System;
using System.Collections.Generic;
using System.Text;

namespace everylessons
{
    class Car
    {
        string licenseNum;
        bool isRented;
        int days;

        public Car(string licenseNum, bool isRented, int days)
        {
            this.licenseNum = licenseNum;
            this.isRented = isRented;
            this.days = days;
        }

        public string GetLicenseNum() => licenseNum;
        public bool GetIsRented() => isRented;
        public int GetDays() => days;
        public void SetLicenseNum(string licenseNum)
        {
            this.licenseNum = licenseNum;
        }
        public void SetIsRented(bool isRented)
        {
            this.isRented = isRented;
        }
        public void SetDays(int days)
        {
            this.days = days;
        }
        public bool Status(int min, int max)
        {
            if (days >= min && days <= max)
                return true;
            return false;
        }

    }
}
