using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F99DTL - .
/// </summary>
public class F99DTL : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WDDOCO.
        /// </summary>
        public const string WDDOCO = "WDDOCO";

        /// <summary>
        /// WDITM.
        /// </summary>
        public const string WDITM = "WDITM";

        /// <summary>
        /// WDWFLNID.
        /// </summary>
        public const string WDWFLNID = "WDWFLNID";

        /// <summary>
        /// WDDESC.
        /// </summary>
        public const string WDDESC = "WDDESC";

        /// <summary>
        /// WDORQT.
        /// </summary>
        public const string WDORQT = "WDORQT";

        /// <summary>
        /// WDUNCS.
        /// </summary>
        public const string WDUNCS = "WDUNCS";

        /// <summary>
        /// WDUPRC.
        /// </summary>
        public const string WDUPRC = "WDUPRC";

        /// <summary>
        /// WDAEXPE1.
        /// </summary>
        public const string WDAEXPE1 = "WDAEXPE1";

        /// <summary>
        /// WDECST.
        /// </summary>
        public const string WDECST = "WDECST";

        /// <summary>
        /// WDEFF.
        /// </summary>
        public const string WDEFF = "WDEFF";
    }

    /// <inheritdoc />
    public override string TableName => "F99DTL";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WDDOCO", "WDDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("WDITM", "WDITM", JdeDataType.Numeric, null, true, true),
        new JdeField("WDWFLNID", "WDWFLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("WDDESC", "WDDESC", JdeDataType.String, 60),
        new JdeField("WDORQT", "WDORQT", JdeDataType.Numeric),
        new JdeField("WDUNCS", "WDUNCS", JdeDataType.Numeric),
        new JdeField("WDUPRC", "WDUPRC", JdeDataType.Numeric),
        new JdeField("WDAEXPE1", "WDAEXPE1", JdeDataType.Numeric),
        new JdeField("WDECST", "WDECST", JdeDataType.Numeric),
        new JdeField("WDEFF", "WDEFF", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F99DTL_0", "Primary Key on WDDOCO, WDITM, WDWFLNID", new[] { "WDDOCO", "WDITM", "WDWFLNID" }, isUnique: true, isPrimaryKey: true)
    };
}
