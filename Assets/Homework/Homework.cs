using UnityEngine;
using UnityEngine.UIElements;

class Homework : MonoBehaviour
{
    void Start()
    {
        int amount = HowManyCanIBuy(10, 23, 30, 50);

        bool is73Prime = IsPrime(73);
        bool is113Prime = IsPrime(113);


        Debug.Log(amount);
    }

    int HowManyCanIBuy(int fullPrice, int allMoney, float discountPercent, int creditYet)
    {
        creditYet = Clamp(creditYet, 0, 100);
        discountPercent = Clamp(discountPercent, 0, 100);

        int moneyToSpend = allMoney + (100 - creditYet);
        float priceMultiplier = 1 - (discountPercent / 100);
        float realPrice = fullPrice * priceMultiplier;

        return (int)(moneyToSpend / realPrice);
    }

    void OnValidate()
    {
        float min = Min(1, 4);
        Debug.Log(min);
    }

    float Min(float a, float b)
    {
        if (a < b)
            return a;
        else
            return b;
    }

    float Max(float a, float b)
    {
        return a > b ? a : b;
    }

    float Clamp(float value, float min, float max)
    {
        if (value > max)
            return max;

        if (value < min)
            return min;

        return value;
    }

    int Clamp(int value, int min, int max)
    {
        if (value > max)
            return max;

        if (value < min)
            return min;

        return value;
    }

    int SumOfDigits(int number)
    {
        string st = number.ToString();  // "1234"

        int sum = 0;

        for (int i = 0; i < st.Length; i++)
        {
            char c = st[i];
            int n = int.Parse(c.ToString());
            sum += n;
        }

        return sum;
    }

    int SumOfDigits2(int number)
    {
        int sum = 0;
        number = Mathf.Abs(number);

        while (number > 0)
        {
            int lastDigit = number % 10;
            sum += lastDigit;
            number = number / 10;
        }

        return sum;
    }

    int DivisibleCount(int a, int b, int max)
    {
        int count = 0;
        for (int i = 1; i <= max; i++)
        {
            if (i % a == 0 || i % b == 0)
                count++;
        }

        return count;
    }

    bool IsPrime(int number) 
    {
        for (int i = 2; i < number/2; i++)
        {
            if (number % i == 0)
                return false;
        }
        return true;
    }

    void WritePrimes(int count) 
    {
        int primesFound = 0;
        for (int i = 2; primesFound < count; i++)
        {
            if (IsPrime(i))
            {
                Debug.Log(i);
                primesFound++;
            }
        }
    }
}