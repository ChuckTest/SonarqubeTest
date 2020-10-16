namespace Chuck.Sonarqube
{
    public class CrossProcedural
    {
        private int myValue;
        public int MyValue
        {
            // below there are two False Positives
            get => this.GetMyValue(); // Noncompliant {{Refactor this getter so that it actually refers to the field 'myValue'.}}
            set => this.SetMyValue(value); // Noncompliant {{Refactor this setter so that it actually refers to the field 'myValue'.}}
        }

        private int GetMyValue() => this.myValue;
        private void SetMyValue(int value) => this.myValue = value;
    }
}
