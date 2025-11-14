using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F41182 - .
/// </summary>
public class F41182 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CSCNID.
        /// </summary>
        public const string CSCNID = "CSCNID";

        /// <summary>
        /// CSPLT.
        /// </summary>
        public const string CSPLT = "CSPLT";

        /// <summary>
        /// CSPA8.
        /// </summary>
        public const string CSPA8 = "CSPA8";

        /// <summary>
        /// CSAN8.
        /// </summary>
        public const string CSAN8 = "CSAN8";

        /// <summary>
        /// CSITM.
        /// </summary>
        public const string CSITM = "CSITM";

        /// <summary>
        /// CSADDJ.
        /// </summary>
        public const string CSADDJ = "CSADDJ";

        /// <summary>
        /// CSSHRE.
        /// </summary>
        public const string CSSHRE = "CSSHRE";

        /// <summary>
        /// CSTRPK.
        /// </summary>
        public const string CSTRPK = "CSTRPK";
    }

    /// <inheritdoc />
    public override string TableName => "F41182";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CSCNID", "CSCNID", JdeDataType.String, 40, true, true),
        new JdeField("CSPLT", "CSPLT", JdeDataType.String, 36, true, true),
        new JdeField("CSPA8", "CSPA8", JdeDataType.Numeric),
        new JdeField("CSAN8", "CSAN8", JdeDataType.Numeric),
        new JdeField("CSITM", "CSITM", JdeDataType.Numeric),
        new JdeField("CSADDJ", "CSADDJ", JdeDataType.Numeric),
        new JdeField("CSSHRE", "CSSHRE", JdeDataType.String, 2),
        new JdeField("CSTRPK", "CSTRPK", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F41182_0", "Primary Key on CSCNID, CSPLT", new[] { "CSCNID", "CSPLT" }, isUnique: true, isPrimaryKey: true)
    };
}
