namespace ClassLibrary1
{
    public class ContainerException : Exception
    {
        public ContainerException(string message) : base(message) { }
    }

 
    public class ContainerVolumeException : ContainerException 
    {
        public ContainerVolumeException(string message) : base(message) { }
    }

    public class ContainerExceptionOverflow : ContainerVolumeException
    {
        public ContainerExceptionOverflow() : base("Ошибка: Переполнение контейнера.") { }
    }

    public class ContainerExceptionUnderflow : ContainerVolumeException
    {
        public ContainerExceptionUnderflow() : base("Ошибка: Контейнер пуст.") { }
    }


    public class ContainerInvalidValueException : ContainerException
    {
        public ContainerInvalidValueException(string message) : base(message) { }
    }
}


