using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F70UI005 - .
/// </summary>
public class F70UI005 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TTK70TT.
        /// </summary>
        public const string TTK70TT = "TTK70TT";

        /// <summary>
        /// TTK70TC.
        /// </summary>
        public const string TTK70TC = "TTK70TC";

        /// <summary>
        /// TTTXR1.
        /// </summary>
        public const string TTTXR1 = "TTTXR1";

        /// <summary>
        /// TTSTAM.
        /// </summary>
        public const string TTSTAM = "TTSTAM";

        /// <summary>
        /// TTCRCD.
        /// </summary>
        public const string TTCRCD = "TTCRCD";

        /// <summary>
        /// TTACR.
        /// </summary>
        public const string TTACR = "TTACR";

        /// <summary>
        /// TTCRR.
        /// </summary>
        public const string TTCRR = "TTCRR";

        /// <summary>
        /// TTEV01.
        /// </summary>
        public const string TTEV01 = "TTEV01";

        /// <summary>
        /// TTUSER.
        /// </summary>
        public const string TTUSER = "TTUSER";

        /// <summary>
        /// TTPID.
        /// </summary>
        public const string TTPID = "TTPID";

        /// <summary>
        /// TTJOBN.
        /// </summary>
        public const string TTJOBN = "TTJOBN";

        /// <summary>
        /// TTUPMJ.
        /// </summary>
        public const string TTUPMJ = "TTUPMJ";

        /// <summary>
        /// TTUPMT.
        /// </summary>
        public const string TTUPMT = "TTUPMT";

        /// <summary>
        /// TTLNID.
        /// </summary>
        public const string TTLNID = "TTLNID";
    }

    /// <inheritdoc />
    public override string TableName => "F70UI005";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TTK70TT", "TTK70TT", JdeDataType.String, 18, true, true),
        new JdeField("TTK70TC", "TTK70TC", JdeDataType.String, 18, true, true),
        new JdeField("TTTXR1", "TTTXR1", JdeDataType.Numeric, null, true, true),
        new JdeField("TTSTAM", "TTSTAM", JdeDataType.Numeric),
        new JdeField("TTCRCD", "TTCRCD", JdeDataType.String, 6),
        new JdeField("TTACR", "TTACR", JdeDataType.Numeric),
        new JdeField("TTCRR", "TTCRR", JdeDataType.Numeric),
        new JdeField("TTEV01", "TTEV01", JdeDataType.String, 2),
        new JdeField("TTUSER", "TTUSER", JdeDataType.String, 20, true, true),
        new JdeField("TTPID", "TTPID", JdeDataType.String, 20),
        new JdeField("TTJOBN", "TTJOBN", JdeDataType.String, 20),
        new JdeField("TTUPMJ", "TTUPMJ", JdeDataType.Numeric),
        new JdeField("TTUPMT", "TTUPMT", JdeDataType.Numeric),
        new JdeField("TTLNID", "TTLNID", JdeDataType.Numeric, null, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F70UI005_0", "Primary Key on TTK70TT, TTK70TC, TTTXR1, TTUSER, TTLNID", new[] { "TTK70TT", "TTK70TC", "TTTXR1", "TTUSER", "TTLNID" }, isUnique: true, isPrimaryKey: true)
    };
}
