using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B405 - .
/// </summary>
public class F76B405 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SFB76CTYC.
        /// </summary>
        public const string SFB76CTYC = "SFB76CTYC";

        /// <summary>
        /// SFB76SVTC.
        /// </summary>
        public const string SFB76SVTC = "SFB76SVTC";

        /// <summary>
        /// SFB76SFCT.
        /// </summary>
        public const string SFB76SFCT = "SFB76SFCT";

        /// <summary>
        /// SFB76FCTD.
        /// </summary>
        public const string SFB76FCTD = "SFB76FCTD";

        /// <summary>
        /// SFB76SFCP.
        /// </summary>
        public const string SFB76SFCP = "SFB76SFCP";

        /// <summary>
        /// SFB76FCPD.
        /// </summary>
        public const string SFB76FCPD = "SFB76FCPD";

        /// <summary>
        /// SFUSER.
        /// </summary>
        public const string SFUSER = "SFUSER";

        /// <summary>
        /// SFJOBN.
        /// </summary>
        public const string SFJOBN = "SFJOBN";

        /// <summary>
        /// SFPID.
        /// </summary>
        public const string SFPID = "SFPID";

        /// <summary>
        /// SFUPMJ.
        /// </summary>
        public const string SFUPMJ = "SFUPMJ";

        /// <summary>
        /// SFUPMT.
        /// </summary>
        public const string SFUPMT = "SFUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B405";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SFB76CTYC", "SFB76CTYC", JdeDataType.String, 20, true, true),
        new JdeField("SFB76SVTC", "SFB76SVTC", JdeDataType.String, 20, true, true),
        new JdeField("SFB76SFCT", "SFB76SFCT", JdeDataType.String, 60),
        new JdeField("SFB76FCTD", "SFB76FCTD", JdeDataType.String, 400),
        new JdeField("SFB76SFCP", "SFB76SFCP", JdeDataType.String, 60),
        new JdeField("SFB76FCPD", "SFB76FCPD", JdeDataType.String, 400),
        new JdeField("SFUSER", "SFUSER", JdeDataType.String, 20),
        new JdeField("SFJOBN", "SFJOBN", JdeDataType.String, 20),
        new JdeField("SFPID", "SFPID", JdeDataType.String, 20),
        new JdeField("SFUPMJ", "SFUPMJ", JdeDataType.Numeric),
        new JdeField("SFUPMT", "SFUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B405_0", "Primary Key on SFB76CTYC, SFB76SVTC", new[] { "SFB76CTYC", "SFB76SVTC" }, isUnique: true, isPrimaryKey: true)
    };
}
