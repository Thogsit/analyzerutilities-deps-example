using Analyzer.Utilities;
using Microsoft.CodeAnalysis.FlowAnalysis.DataFlow;

namespace base_analyzer.Sample;

public class SomeAbstractValue : CacheBasedEquatable<SomeAbstractValue>
{
    protected override void ComputeHashCodeParts(ref RoslynHashCode hashCode)
    {
        throw new System.NotImplementedException();
    }

    protected override bool ComputeEqualsByHashCodeParts(CacheBasedEquatable<SomeAbstractValue> obj)
    {
        throw new System.NotImplementedException();
    }
}