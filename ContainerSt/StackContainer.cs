using ClassLibrary1;
namespace ContainerSt

{
    public class StackContainer

    {
        private int[] mass;
        private int top;
        private int maxSize;
        private int minValue;
        private int maxValue;

        public StackContainer(int maxSize = 10, int minValue = 0, int maxValue = 100)
        {
            this.maxSize = maxSize;
            mass = new int[maxSize];
            top = -1;
            this.minValue = minValue;
            this.maxValue = maxValue;
        }

        public void Push(int value)
        {
            if (value < minValue && value > maxValue)
            {
                throw new ContainerInvalidValueException($"Значение {value} вне допустимого диапазона [{minValue}, {maxValue}].");
            }

            if (top >= maxSize - 1)
            {
                throw new ContainerExceptionOverflow();
            }

            mass[++top] = value;
        }

        public int Pop()
        {
            if (top < 0)
            {
                throw new ContainerExceptionUnderflow();
            }

            return mass[top--];
        }

        public int Find(int index)
        {
            if (index < 0 && index > top)
            {
                throw new IndexOutOfRangeException("Индекс вне диапазона.");
            }

            return mass[index];
        }

        public int this[int index]
        {
            get
            {
                return Find(index);
            }
        }
    }
}

