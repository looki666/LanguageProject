using System;
using System.Text;
using System.Collections.Generic;

public class SubstitutionRule {
    protected IPattern[] conditions;
    protected IPattern[] top;
    protected IPattern[] bottom;
    protected EntailmentContext? exclusiveContext;
    public bool isTransposable {get; protected set;}
    
    public SubstitutionRule(IPattern[] conditions, IPattern[] top, IPattern[] bottom, EntailmentContext? exclusiveContext, bool isTransposable) {
        this.conditions = conditions;
        this.top = top;
        this.bottom = bottom;
        this.exclusiveContext = exclusiveContext;
        this.isTransposable = isTransposable;
    }

    public SubstitutionRule(IPattern[] conditions, IPattern[] top, IPattern[] bottom, EntailmentContext? exclusiveContext):
        this(conditions, top, bottom, exclusiveContext, true) {}

    public SubstitutionRule(IPattern[] conditions, IPattern[] top, IPattern[] bottom): this(conditions, top, bottom, null) {}

        public SubstitutionRule(IPattern[] top, IPattern[] bottom, EntailmentContext? exclusiveContext, bool isTransposable):
        this(new IPattern[0], top, bottom, exclusiveContext, isTransposable) {}

    public SubstitutionRule(IPattern[] top, IPattern[] bottom, EntailmentContext? exclusiveContext):
        this(new IPattern[0], top, bottom, exclusiveContext) {}

    public SubstitutionRule(IPattern[] top, IPattern[] bottom, bool isTransposable):
        this(new IPattern[0], top, bottom, null, isTransposable) {}


    public SubstitutionRule(IPattern[] top, IPattern[] bottom): this(new IPattern[0], top, bottom, null) {}

    public void AddToDomain(Model m) {
        for (int i = 0; i < conditions.Length; i++) {
            conditions[i].AddToDomain(m);
        }

        for (int i = 0; i < top.Length; i++) {
            top[i].AddToDomain(m);
        }
        
        for (int i = 0; i < bottom.Length; i++) {
            bottom[i].AddToDomain(m);
        }
    }

    public List<List<IPattern>[]> Substitute(Model m, Expression expr, EntailmentContext context) {
        if ((this.exclusiveContext != null && context != this.exclusiveContext) || context == EntailmentContext.None) {
            return null;
        }

        IPattern[] match = null;
        IPattern[] substitution = null;

        if (context == EntailmentContext.Upward) {
            match = this.top;
            substitution = this.bottom;
        }

        if (context == EntailmentContext.Downward) {
            match = this.bottom;
            substitution = this.top;
        }

        List<List<IPattern>[]> admissibleSubstitutions = new List<List<IPattern>[]>();

        // go through the match row, and act on the patterns
        // that match expr.
        for (int i = 0; i < match.Length; i++) {
            List<Dictionary<MetaVariable, Expression>> bindings = match[i].GetBindings(expr);
            if (bindings == null) {
                continue;
            }

            if (bindings.Count == 0) {
                // edge case: successful match but no bindings
                
                HashSet<Dictionary<MetaVariable, Expression>> domain;
                if (conditions == null || conditions.Length == 0) {
                    domain = new HashSet<Dictionary<MetaVariable, Expression>>();
                } else {
                    domain = m.Find(EntailmentContext.Downward, null, conditions);
                }

                if (domain == null) {
                    // this means nothing satisfied the specified conditions.
                    continue;
                }

                List<IPattern>[] conjunctPatterns = new List<IPattern>[2];
                conjunctPatterns[0] = new List<IPattern>();
                conjunctPatterns[1] = new List<IPattern>();

                for (int j = 0; j < substitution.Length; j++) {
                    conjunctPatterns[0].Add(substitution[j]);
                }

                for (int j = 0; j < match.Length; j++) {
                    if (j == i) {
                        continue;
                    }

                    conjunctPatterns[1].Add(match[j]);
                }

                if (domain.Count == 0) {
                    admissibleSubstitutions.Add(conjunctPatterns);
                }

                foreach (Dictionary<MetaVariable, Expression> binding in domain) {
                    List<IPattern>[] conditionBoundConjunctPatterns = new List<IPattern>[2];
                    conditionBoundConjunctPatterns[0] = new List<IPattern>();
                    conditionBoundConjunctPatterns[1] = new List<IPattern>();
                    
                    foreach (IPattern pattern in conjunctPatterns[0]) {
                        conditionBoundConjunctPatterns[0].Add(pattern.Bind(binding));
                    }

                    foreach (IPattern pattern in conjunctPatterns[1]) {
                        conditionBoundConjunctPatterns[0].Add(pattern.Bind(binding));
                    }

                    admissibleSubstitutions.Add(conditionBoundConjunctPatterns);
                }
            }

            // CAREFUL: this code isn't (entirely) redundant
            foreach (Dictionary<MetaVariable, Expression> binding in bindings) {
                // each of these bindings is a separate match.
                IPattern[] boundConditions = new IPattern[conditions.Length];
                
                for (int j = 0; j < conditions.Length; j++) {
                    boundConditions[j] = conditions[j].Bind(binding);
                }

                HashSet<Dictionary<MetaVariable, Expression>> domain;
                if (conditions == null || conditions.Length == 0) {
                    domain = new HashSet<Dictionary<MetaVariable, Expression>>();
                } else {
                    domain = m.Find(EntailmentContext.Downward, null, boundConditions);
                }

                if (domain == null) {
                    // this means nothing satisfied the specified conditions.
                    continue;
                }

                List<IPattern>[] conjunctPatterns = new List<IPattern>[2];
                conjunctPatterns[0] = new List<IPattern>();
                conjunctPatterns[1] = new List<IPattern>();

                for (int j = 0; j < substitution.Length; j++) {
                    conjunctPatterns[0].Add(substitution[j].Bind(binding));
                }

                for (int j = 0; j < match.Length; j++) {
                    if (j == i) {
                        continue;
                    }
                    conjunctPatterns[1].Add(match[j].Bind(binding));
                }

                if (domain.Count == 0) {
                    admissibleSubstitutions.Add(conjunctPatterns);
                }

                foreach (Dictionary<MetaVariable, Expression> assignment in domain) {
                    List<IPattern>[] conditionBoundConjunctPatterns = new List<IPattern>[2];
                    conditionBoundConjunctPatterns[0] = new List<IPattern>();
                    conditionBoundConjunctPatterns[1] = new List<IPattern>();
                    
                    foreach (IPattern pattern in conjunctPatterns[0]) {
                        conditionBoundConjunctPatterns[0].Add(pattern.Bind(assignment));
                    }

                    foreach (IPattern pattern in conjunctPatterns[1]) {
                        conditionBoundConjunctPatterns[1].Add(pattern.Bind(assignment));
                    }

                    admissibleSubstitutions.Add(conditionBoundConjunctPatterns);
                }
            }
        }

        if (admissibleSubstitutions.Count == 0) {
            return null;
        }
        
        return admissibleSubstitutions;
    }

    public SubstitutionRule Contrapositive() {
        IPattern[] newTop = new IPattern[this.bottom.Length];
        IPattern[] newBottom = new IPattern[this.top.Length];

        for (int i = 0; i < bottom.Length; i++) {
            newTop[i] = new ExpressionPattern(Expression.NOT, bottom[i]);
        }

        for (int i = 0; i < top.Length; i++) {
            newBottom[i] = new ExpressionPattern(Expression.NOT, top[i]);
        }

        if (exclusiveContext == null) {
            return new SubstitutionRule(conditions, newTop, newBottom, null);
        }

        return new SubstitutionRule(conditions, newTop, newBottom,
            EvaluationPattern.MergeContext(exclusiveContext.GetValueOrDefault(), EntailmentContext.Downward));
    }

    public override String ToString() {
        StringBuilder s = new StringBuilder();

        if (conditions != null) {
            s.Append(" [");

            for (int i = 0; i < conditions.Length; i++) {
                s.Append(conditions[i] + ", ");
            }
            s.Append("]");
        }

        for (int i = 0; i < top.Length; i++) {
            s.Append(top[i]);
            s.Append(", ");
        }

        s.Append(" |- ");

        for (int i = 0; i < bottom.Length; i++) {
            s.Append(bottom[i]);
            s.Append(", ");
        }

        return s.ToString();
    }
}
