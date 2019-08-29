using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Diagnostics;
using System.Collections.Immutable;

namespace DiagnosticSuppressorTest
{
    [DiagnosticAnalyzer(LanguageNames.CSharp)]
    public class MySuppressor : DiagnosticSuppressor
    {
        public override ImmutableArray<SuppressionDescriptor> SupportedSuppressions { get; } = new[]
        {
            new SuppressionDescriptor("SUPP3662", "CS0649", "Test suppression")
        }.ToImmutableArray();

        public override void ReportSuppressions(SuppressionAnalysisContext context)
        {
            foreach (Diagnostic diagnostic in context.ReportedDiagnostics)
            {
                if (diagnostic.GetMessage().Contains("TestStruct.X")) // Filtering on the message is gross and terrible. Don't actually do this in a real suppressor.
                {
                    context.ReportSuppression(Suppression.Create(SupportedSuppressions[0], diagnostic));
                }
            }
        }
    }
}
