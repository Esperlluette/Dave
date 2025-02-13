using Dave.Objects.Removers;

namespace Dave.Strategies
{
    public enum PredicatType
    {
        Before,
        After,
        ExacteDate
    }
    internal class DateStrategie : Strategie
    {
        private DateTime predicat;
        private PredicatType PredicatType;
        public DateStrategie(Subject subject,DateTime predicat, Remover<Type> remover, PredicatType predicatType = PredicatType.Before)
        {
            this.predicat = predicat;
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
