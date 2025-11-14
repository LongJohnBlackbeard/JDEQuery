using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B032 - .
/// </summary>
public class F31B032 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// BTBATP.
        /// </summary>
        public const string BTBATP = "BTBATP";

        /// <summary>
        /// BTTOCAP.
        /// </summary>
        public const string BTTOCAP = "BTTOCAP";

        /// <summary>
        /// BTFCAP.
        /// </summary>
        public const string BTFCAP = "BTFCAP";

        /// <summary>
        /// BTURCD.
        /// </summary>
        public const string BTURCD = "BTURCD";

        /// <summary>
        /// BTURDT.
        /// </summary>
        public const string BTURDT = "BTURDT";

        /// <summary>
        /// BTURRF.
        /// </summary>
        public const string BTURRF = "BTURRF";

        /// <summary>
        /// BTURAB.
        /// </summary>
        public const string BTURAB = "BTURAB";

        /// <summary>
        /// BTURAT.
        /// </summary>
        public const string BTURAT = "BTURAT";

        /// <summary>
        /// BTPID.
        /// </summary>
        public const string BTPID = "BTPID";

        /// <summary>
        /// BTUSER.
        /// </summary>
        public const string BTUSER = "BTUSER";

        /// <summary>
        /// BTUPMJ.
        /// </summary>
        public const string BTUPMJ = "BTUPMJ";

        /// <summary>
        /// BTUPMT.
        /// </summary>
        public const string BTUPMT = "BTUPMT";

        /// <summary>
        /// BTMCU.
        /// </summary>
        public const string BTMCU = "BTMCU";

        /// <summary>
        /// BTBCUOM.
        /// </summary>
        public const string BTBCUOM = "BTBCUOM";

        /// <summary>
        /// BTWCG.
        /// </summary>
        public const string BTWCG = "BTWCG";

        /// <summary>
        /// BTWRF.
        /// </summary>
        public const string BTWRF = "BTWRF";

        /// <summary>
        /// BTWCD.
        /// </summary>
        public const string BTWCD = "BTWCD";

        /// <summary>
        /// BTWAB.
        /// </summary>
        public const string BTWAB = "BTWAB";

        /// <summary>
        /// BTWNUM.
        /// </summary>
        public const string BTWNUM = "BTWNUM";

        /// <summary>
        /// BTWMDT.
        /// </summary>
        public const string BTWMDT = "BTWMDT";
    }

    /// <inheritdoc />
    public override string TableName => "F31B032";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("BTBATP", "BTBATP", JdeDataType.String, 8, true, true),
        new JdeField("BTTOCAP", "BTTOCAP", JdeDataType.Numeric),
        new JdeField("BTFCAP", "BTFCAP", JdeDataType.Numeric),
        new JdeField("BTURCD", "BTURCD", JdeDataType.String, 4),
        new JdeField("BTURDT", "BTURDT", JdeDataType.Numeric),
        new JdeField("BTURRF", "BTURRF", JdeDataType.String, 30),
        new JdeField("BTURAB", "BTURAB", JdeDataType.Numeric),
        new JdeField("BTURAT", "BTURAT", JdeDataType.Numeric),
        new JdeField("BTPID", "BTPID", JdeDataType.String, 20),
        new JdeField("BTUSER", "BTUSER", JdeDataType.String, 20),
        new JdeField("BTUPMJ", "BTUPMJ", JdeDataType.Numeric),
        new JdeField("BTUPMT", "BTUPMT", JdeDataType.Numeric),
        new JdeField("BTMCU", "BTMCU", JdeDataType.String, 24),
        new JdeField("BTBCUOM", "BTBCUOM", JdeDataType.String, 4),
        new JdeField("BTWCG", "BTWCG", JdeDataType.String, 24),
        new JdeField("BTWRF", "BTWRF", JdeDataType.String, 60),
        new JdeField("BTWCD", "BTWCD", JdeDataType.String, 6),
        new JdeField("BTWAB", "BTWAB", JdeDataType.Numeric),
        new JdeField("BTWNUM", "BTWNUM", JdeDataType.Numeric),
        new JdeField("BTWMDT", "BTWMDT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B032_0", "Primary Key on BTBATP", new[] { "BTBATP" }, isUnique: true, isPrimaryKey: true)
    };
}
