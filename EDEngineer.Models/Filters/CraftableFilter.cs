using System;

namespace EDEngineer.Models.Filters
{
    public class CraftableFilter : BlueprintFilter
    {
        public string Label { get; }
        public Predicate<Blueprint> AppliesToDelegate { get; }

        public override bool AppliesTo(Blueprint blueprint)
        {
            return AppliesToDelegate(blueprint);
        }

        public CraftableFilter(string label, Predicate<Blueprint> appliesToDelegate, string uniqueName) : base(uniqueName)
        {
            Label = label;
            AppliesToDelegate = appliesToDelegate;
        }
    }
}