namespace WebApplication1.Data
{
    public class FakeDb
    {
        private int _dbValue;

        public void IncreaseValue()
        {
            _dbValue++;
        }

        public int GetDbValue()
        {
            return _dbValue;
        }
    }
}
