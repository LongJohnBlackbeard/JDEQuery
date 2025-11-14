using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FCW16 - .
/// </summary>
public class FCW16 : JdeTable
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
        /// WFLNGP.
        /// </summary>
        public const string WFLNGP = "WFLNGP";

        /// <summary>
        /// WFINMG.
        /// </summary>
        public const string WFINMG = "WFINMG";

        /// <summary>
        /// WFEFTJ.
        /// </summary>
        public const string WFEFTJ = "WFEFTJ";

        /// <summary>
        /// WFEXDJ.
        /// </summary>
        public const string WFEXDJ = "WFEXDJ";

        /// <summary>
        /// WFPNTC.
        /// </summary>
        public const string WFPNTC = "WFPNTC";
    }

    /// <inheritdoc />
    public override string TableName => "FCW16";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WFITM", "WFITM", JdeDataType.Numeric, null, true, true),
        new JdeField("WFEV01", "WFEV01", JdeDataType.String, 2, true, true),
        new JdeField("WFLNGP", "WFLNGP", JdeDataType.String, 4, true, true),
        new JdeField("WFINMG", "WFINMG", JdeDataType.String, 20, true, true),
        new JdeField("WFEFTJ", "WFEFTJ", JdeDataType.Numeric),
        new JdeField("WFEXDJ", "WFEXDJ", JdeDataType.Numeric),
        new JdeField("WFPNTC", "WFPNTC", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FCW16_0", "Primary Key on WFITM, WFEV01, WFLNGP, WFINMG", new[] { "WFITM", "WFEV01", "WFLNGP", "WFINMG" }, isUnique: true, isPrimaryKey: true)
    };
}
