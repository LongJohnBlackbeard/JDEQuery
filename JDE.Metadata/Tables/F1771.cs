using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1771 - .
/// </summary>
public class F1771 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RTPRODF.
        /// </summary>
        public const string RTPRODF = "RTPRODF";

        /// <summary>
        /// RTPRODM.
        /// </summary>
        public const string RTPRODM = "RTPRODM";

        /// <summary>
        /// RTITM.
        /// </summary>
        public const string RTITM = "RTITM";

        /// <summary>
        /// RTVMRS31.
        /// </summary>
        public const string RTVMRS31 = "RTVMRS31";

        /// <summary>
        /// RTVMRS32.
        /// </summary>
        public const string RTVMRS32 = "RTVMRS32";

        /// <summary>
        /// RTVMRS33.
        /// </summary>
        public const string RTVMRS33 = "RTVMRS33";

        /// <summary>
        /// RTDEFLBR.
        /// </summary>
        public const string RTDEFLBR = "RTDEFLBR";

        /// <summary>
        /// RTUSER.
        /// </summary>
        public const string RTUSER = "RTUSER";

        /// <summary>
        /// RTPID.
        /// </summary>
        public const string RTPID = "RTPID";

        /// <summary>
        /// RTUPMJ.
        /// </summary>
        public const string RTUPMJ = "RTUPMJ";

        /// <summary>
        /// RTUPMT.
        /// </summary>
        public const string RTUPMT = "RTUPMT";

        /// <summary>
        /// RTJOBN.
        /// </summary>
        public const string RTJOBN = "RTJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F1771";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RTPRODF", "RTPRODF", JdeDataType.String, 16, true, true),
        new JdeField("RTPRODM", "RTPRODM", JdeDataType.String, 16, true, true),
        new JdeField("RTITM", "RTITM", JdeDataType.Numeric, null, true, true),
        new JdeField("RTVMRS31", "RTVMRS31", JdeDataType.String, 4, true, true),
        new JdeField("RTVMRS32", "RTVMRS32", JdeDataType.String, 16, true, true),
        new JdeField("RTVMRS33", "RTVMRS33", JdeDataType.String, 20, true, true),
        new JdeField("RTDEFLBR", "RTDEFLBR", JdeDataType.Numeric),
        new JdeField("RTUSER", "RTUSER", JdeDataType.String, 20),
        new JdeField("RTPID", "RTPID", JdeDataType.String, 20),
        new JdeField("RTUPMJ", "RTUPMJ", JdeDataType.Numeric),
        new JdeField("RTUPMT", "RTUPMT", JdeDataType.Numeric),
        new JdeField("RTJOBN", "RTJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1771_0", "Primary Key on RTPRODF, RTPRODM, RTITM, RTVMRS31, RTVMRS32, RTVMRS33", new[] { "RTPRODF", "RTPRODM", "RTITM", "RTVMRS31", "RTVMRS32", "RTVMRS33" }, isUnique: true, isPrimaryKey: true)
    };
}
