using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FCW19 - .
/// </summary>
public class FCW19 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WFITM.
        /// </summary>
        public const string WFITM = "WFITM";

        /// <summary>
        /// WFEV01.
        /// </summary>
        public const string WFEV01 = "WFEV01";

        /// <summary>
        /// WFMCU.
        /// </summary>
        public const string WFMCU = "WFMCU";

        /// <summary>
        /// WFDLTN.
        /// </summary>
        public const string WFDLTN = "WFDLTN";

        /// <summary>
        /// WFVLOC.
        /// </summary>
        public const string WFVLOC = "WFVLOC";

        /// <summary>
        /// WFHLOC.
        /// </summary>
        public const string WFHLOC = "WFHLOC";

        /// <summary>
        /// WFPPUT.
        /// </summary>
        public const string WFPPUT = "WFPPUT";

        /// <summary>
        /// WFPPIK.
        /// </summary>
        public const string WFPPIK = "WFPPIK";

        /// <summary>
        /// WFLCOD.
        /// </summary>
        public const string WFLCOD = "WFLCOD";

        /// <summary>
        /// WFPKPH.
        /// </summary>
        public const string WFPKPH = "WFPKPH";

        /// <summary>
        /// WFRPPH.
        /// </summary>
        public const string WFRPPH = "WFRPPH";

        /// <summary>
        /// WFMLIT.
        /// </summary>
        public const string WFMLIT = "WFMLIT";

        /// <summary>
        /// WFMLOT.
        /// </summary>
        public const string WFMLOT = "WFMLOT";

        /// <summary>
        /// WFSPLP.
        /// </summary>
        public const string WFSPLP = "WFSPLP";

        /// <summary>
        /// WFPTPH.
        /// </summary>
        public const string WFPTPH = "WFPTPH";

        /// <summary>
        /// WFMPTL.
        /// </summary>
        public const string WFMPTL = "WFMPTL";

        /// <summary>
        /// WFMUMS.
        /// </summary>
        public const string WFMUMS = "WFMUMS";

        /// <summary>
        /// WFFIFR.
        /// </summary>
        public const string WFFIFR = "WFFIFR";
    }

    /// <inheritdoc />
    public override string TableName => "FCW19";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WFITM", "WFITM", JdeDataType.Numeric, null, true, true),
        new JdeField("WFEV01", "WFEV01", JdeDataType.String, 2, true, true),
        new JdeField("WFMCU", "WFMCU", JdeDataType.String, 24, true, true),
        new JdeField("WFDLTN", "WFDLTN", JdeDataType.String, 40),
        new JdeField("WFVLOC", "WFVLOC", JdeDataType.String, 40),
        new JdeField("WFHLOC", "WFHLOC", JdeDataType.String, 40),
        new JdeField("WFPPUT", "WFPPUT", JdeDataType.String, 40),
        new JdeField("WFPPIK", "WFPPIK", JdeDataType.String, 40),
        new JdeField("WFLCOD", "WFLCOD", JdeDataType.String, 4),
        new JdeField("WFPKPH", "WFPKPH", JdeDataType.String, 2),
        new JdeField("WFRPPH", "WFRPPH", JdeDataType.String, 2),
        new JdeField("WFMLIT", "WFMLIT", JdeDataType.String, 2),
        new JdeField("WFMLOT", "WFMLOT", JdeDataType.String, 2),
        new JdeField("WFSPLP", "WFSPLP", JdeDataType.String, 2),
        new JdeField("WFPTPH", "WFPTPH", JdeDataType.String, 2),
        new JdeField("WFMPTL", "WFMPTL", JdeDataType.String, 2),
        new JdeField("WFMUMS", "WFMUMS", JdeDataType.String, 2),
        new JdeField("WFFIFR", "WFFIFR", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FCW19_0", "Primary Key on WFITM, WFEV01, WFMCU", new[] { "WFITM", "WFEV01", "WFMCU" }, isUnique: true, isPrimaryKey: true)
    };
}
