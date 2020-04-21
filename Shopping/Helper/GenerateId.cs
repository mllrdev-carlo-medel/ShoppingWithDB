using System;
namespace Shopping.Helper
{
    public static class GenerateID
    {
        public static int GetGeneratedID()
        {
            Guid guid = Guid.NewGuid();
            Random random = new Random();
            return random.Next();
        }
    }
}
