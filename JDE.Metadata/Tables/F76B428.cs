using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B428 - .
/// </summary>
public class F76B428 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SSBNNF.
        /// </summary>
        public const string SSBNNF = "SSBNNF";

        /// <summary>
        /// SSBSER.
        /// </summary>
        public const string SSBSER = "SSBSER";

        /// <summary>
        /// SSN001.
        /// </summary>
        public const string SSN001 = "SSN001";

        /// <summary>
        /// SSDCT.
        /// </summary>
        public const string SSDCT = "SSDCT";

        /// <summary>
        /// SSUKID.
        /// </summary>
        public const string SSUKID = "SSUKID";

        /// <summary>
        /// SSBRTX.
        /// </summary>
        public const string SSBRTX = "SSBRTX";

        /// <summary>
        /// SSB76CTYC.
        /// </summary>
        public const string SSB76CTYC = "SSB76CTYC";

        /// <summary>
        /// SSB76SVTC.
        /// </summary>
        public const string SSB76SVTC = "SSB76SVTC";

        /// <summary>
        /// SSB76APIS.
        /// </summary>
        public const string SSB76APIS = "SSB76APIS";

        /// <summary>
        /// SSB76SENC.
        /// </summary>
        public const string SSB76SENC = "SSB76SENC";

        /// <summary>
        /// SSB76SFCT.
        /// </summary>
        public const string SSB76SFCT = "SSB76SFCT";

        /// <summary>
        /// SSBRTXB.
        /// </summary>
        public const string SSBRTXB = "SSBRTXB";

        /// <summary>
        /// SSBRTXA.
        /// </summary>
        public const string SSBRTXA = "SSBRTXA";

        /// <summary>
        /// SSBRTXR.
        /// </summary>
        public const string SSBRTXR = "SSBRTXR";

        /// <summary>
        /// SSUPMJ.
        /// </summary>
        public const string SSUPMJ = "SSUPMJ";

        /// <summary>
        /// SSUPMT.
        /// </summary>
        public const string SSUPMT = "SSUPMT";

        /// <summary>
        /// SSJOBN.
        /// </summary>
        public const string SSJOBN = "SSJOBN";

        /// <summary>
        /// SSUSER.
        /// </summary>
        public const string SSUSER = "SSUSER";

        /// <summary>
        /// SSPID.
        /// </summary>
        public const string SSPID = "SSPID";

        /// <summary>
        /// SSTORG.
        /// </summary>
        public const string SSTORG = "SSTORG";
    }

    /// <inheritdoc />
    public override string TableName => "F76B428";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SSBNNF", "SSBNNF", JdeDataType.Numeric, null, true, true),
        new JdeField("SSBSER", "SSBSER", JdeDataType.String, 4, true, true),
        new JdeField("SSN001", "SSN001", JdeDataType.Numeric, null, true, true),
        new JdeField("SSDCT", "SSDCT", JdeDataType.String, 4, true, true),
        new JdeField("SSUKID", "SSUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("SSBRTX", "SSBRTX", JdeDataType.String, 4, true, true),
        new JdeField("SSB76CTYC", "SSB76CTYC", JdeDataType.String, 20),
        new JdeField("SSB76SVTC", "SSB76SVTC", JdeDataType.String, 20),
        new JdeField("SSB76APIS", "SSB76APIS", JdeDataType.String, 2),
        new JdeField("SSB76SENC", "SSB76SENC", JdeDataType.String, 20),
        new JdeField("SSB76SFCT", "SSB76SFCT", JdeDataType.String, 60),
        new JdeField("SSBRTXB", "SSBRTXB", JdeDataType.Numeric),
        new JdeField("SSBRTXA", "SSBRTXA", JdeDataType.Numeric),
        new JdeField("SSBRTXR", "SSBRTXR", JdeDataType.Numeric),
        new JdeField("SSUPMJ", "SSUPMJ", JdeDataType.Numeric),
        new JdeField("SSUPMT", "SSUPMT", JdeDataType.Numeric),
        new JdeField("SSJOBN", "SSJOBN", JdeDataType.String, 20),
        new JdeField("SSUSER", "SSUSER", JdeDataType.String, 20),
        new JdeField("SSPID", "SSPID", JdeDataType.String, 20),
        new JdeField("SSTORG", "SSTORG", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B428_0", "Primary Key on SSBNNF, SSBSER, SSN001, SSDCT, SSUKID, SSBRTX", new[] { "SSBNNF", "SSBSER", "SSN001", "SSDCT", "SSUKID", "SSBRTX" }, isUnique: true, isPrimaryKey: true)
    };
}
