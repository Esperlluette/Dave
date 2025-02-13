using Dave.Objects.Removers;

namespace Dave.Strategies
{
    public enum PredicatType
    {
        Before,
        After,
        ExacteDate
    }
    internal class DateStrategie<T> : Strategie<T>
    {
        private DateTime predicat;
        private PredicatType PredicatType;
        public DateStrategie(Subject subject,DateTime predicat, Remover<T> remover, PredicatType predicatType = PredicatType.Before)
        {
            this.predicat = predicat;
            base.subject = subject;
            base.Remover = remover;
            base.Bin = new List<string>();
            PredicatType = predicatType;
        }

        private bool SatisfiesPredicate(DateTime time)
        {
            switch (PredicatType)
            {
                default:
                case PredicatType.Before:
                    return time < predicat;
                case PredicatType.After:
                    return time > predicat;
                case PredicatType.ExacteDate:
                    return time == predicat;
            }
        }
    }
}
