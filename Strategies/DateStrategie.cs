using Dave.Objects.Removers;

namespace Dave.Strategies
{
    public enum PredicatType
    {
        Before,
        After,
        ExacteDate
    }
    public class DateStrategie<T> : Strategie<T>
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

        public override void AddToBin()
        {
            throw new NotImplementedException();
        }


        public override bool SatisfiesPredicate(T time)
        {
            if (time is null) return false;
            if (DateTime.TryParse(time.ToString(), out DateTime outTime) is false) return false;
            switch (PredicatType)
            {
                default:
                case PredicatType.Before:
                    return outTime < predicat;
                case PredicatType.After:
                    return outTime > predicat;
                case PredicatType.ExacteDate:
                    return outTime == predicat;
            }
        }
    }
}
