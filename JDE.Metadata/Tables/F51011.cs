using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F51011 - .
/// </summary>
public class F51011 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CMEXSYSINS.
        /// </summary>
        public const string CMEXSYSINS = "CMEXSYSINS";

        /// <summary>
        /// CMAFTRSNM.
        /// </summary>
        public const string CMAFTRSNM = "CMAFTRSNM";

        /// <summary>
        /// CMAFTUSER.
        /// </summary>
        public const string CMAFTUSER = "CMAFTUSER";

        /// <summary>
        /// CMAFTPSWD.
        /// </summary>
        public const string CMAFTPSWD = "CMAFTPSWD";

        /// <summary>
        /// CMAFTLPATH.
        /// </summary>
        public const string CMAFTLPATH = "CMAFTLPATH";

        /// <summary>
        /// CMAFTRPATH.
        /// </summary>
        public const string CMAFTRPATH = "CMAFTRPATH";

        /// <summary>
        /// CMMKEY.
        /// </summary>
        public const string CMMKEY = "CMMKEY";

        /// <summary>
        /// CMPID.
        /// </summary>
        public const string CMPID = "CMPID";

        /// <summary>
        /// CMUSER.
        /// </summary>
        public const string CMUSER = "CMUSER";

        /// <summary>
        /// CMUPMJ.
        /// </summary>
        public const string CMUPMJ = "CMUPMJ";

        /// <summary>
        /// CMUPMT.
        /// </summary>
        public const string CMUPMT = "CMUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F51011";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CMEXSYSINS", "CMEXSYSINS", JdeDataType.String, 400, true, true),
        new JdeField("CMAFTRSNM", "CMAFTRSNM", JdeDataType.String, 256),
        new JdeField("CMAFTUSER", "CMAFTUSER", JdeDataType.String, 100),
        new JdeField("CMAFTPSWD", "CMAFTPSWD", JdeDataType.String),
        new JdeField("CMAFTLPATH", "CMAFTLPATH", JdeDataType.String, 512),
        new JdeField("CMAFTRPATH", "CMAFTRPATH", JdeDataType.String, 512),
        new JdeField("CMMKEY", "CMMKEY", JdeDataType.String, 30),
        new JdeField("CMPID", "CMPID", JdeDataType.String, 20),
        new JdeField("CMUSER", "CMUSER", JdeDataType.String, 20),
        new JdeField("CMUPMJ", "CMUPMJ", JdeDataType.Numeric),
        new JdeField("CMUPMT", "CMUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F51011_0", "Primary Key on CMEXSYSINS", new[] { "CMEXSYSINS" }, isUnique: true, isPrimaryKey: true)
    };
}
