namespace Chuck.Sonarqube
{
    public class CrossProcedural
    {
        private int myValue;
        public int MyValue
        {
            // below there are two False Positives
            get => this.GetMyValue();
            set => this.SetMyValue(value);
        }

        private int GetMyValue() => this.myValue;
        private void SetMyValue(int value) => this.myValue = value;
    }
}
