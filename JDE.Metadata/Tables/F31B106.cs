using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B106 - .
/// </summary>
public class F31B106 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PDNCPATHID.
        /// </summary>
        public const string PDNCPATHID = "PDNCPATHID";

        /// <summary>
        /// PDNCPSQNO.
        /// </summary>
        public const string PDNCPSQNO = "PDNCPSQNO";

        /// <summary>
        /// PDNCFRMTID.
        /// </summary>
        public const string PDNCFRMTID = "PDNCFRMTID";

        /// <summary>
        /// PDURAB.
        /// </summary>
        public const string PDURAB = "PDURAB";

        /// <summary>
        /// PDURAT.
        /// </summary>
        public const string PDURAT = "PDURAT";

        /// <summary>
        /// PDURCD.
        /// </summary>
        public const string PDURCD = "PDURCD";

        /// <summary>
        /// PDURDT.
        /// </summary>
        public const string PDURDT = "PDURDT";

        /// <summary>
        /// PDURRF.
        /// </summary>
        public const string PDURRF = "PDURRF";

        /// <summary>
        /// PDWAB.
        /// </summary>
        public const string PDWAB = "PDWAB";

        /// <summary>
        /// PDWNUM.
        /// </summary>
        public const string PDWNUM = "PDWNUM";

        /// <summary>
        /// PDWCD.
        /// </summary>
        public const string PDWCD = "PDWCD";

        /// <summary>
        /// PDWMDT.
        /// </summary>
        public const string PDWMDT = "PDWMDT";

        /// <summary>
        /// PDWRF.
        /// </summary>
        public const string PDWRF = "PDWRF";

        /// <summary>
        /// PDUSER.
        /// </summary>
        public const string PDUSER = "PDUSER";

        /// <summary>
        /// PDUPMJ.
        /// </summary>
        public const string PDUPMJ = "PDUPMJ";

        /// <summary>
        /// PDUPMT.
        /// </summary>
        public const string PDUPMT = "PDUPMT";

        /// <summary>
        /// PDJOBN.
        /// </summary>
        public const string PDJOBN = "PDJOBN";

        /// <summary>
        /// PDMKEY.
        /// </summary>
        public const string PDMKEY = "PDMKEY";

        /// <summary>
        /// PDPID.
        /// </summary>
        public const string PDPID = "PDPID";
    }

    /// <inheritdoc />
    public override string TableName => "F31B106";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PDNCPATHID", "PDNCPATHID", JdeDataType.Numeric, null, true, true),
        new JdeField("PDNCPSQNO", "PDNCPSQNO", JdeDataType.Numeric, null, true, true),
        new JdeField("PDNCFRMTID", "PDNCFRMTID", JdeDataType.Numeric),
        new JdeField("PDURAB", "PDURAB", JdeDataType.Numeric),
        new JdeField("PDURAT", "PDURAT", JdeDataType.Numeric),
        new JdeField("PDURCD", "PDURCD", JdeDataType.String, 4),
        new JdeField("PDURDT", "PDURDT", JdeDataType.Numeric),
        new JdeField("PDURRF", "PDURRF", JdeDataType.String, 30),
        new JdeField("PDWAB", "PDWAB", JdeDataType.Numeric),
        new JdeField("PDWNUM", "PDWNUM", JdeDataType.Numeric),
        new JdeField("PDWCD", "PDWCD", JdeDataType.String, 6),
        new JdeField("PDWMDT", "PDWMDT", JdeDataType.Numeric),
        new JdeField("PDWRF", "PDWRF", JdeDataType.String, 60),
        new JdeField("PDUSER", "PDUSER", JdeDataType.String, 20),
        new JdeField("PDUPMJ", "PDUPMJ", JdeDataType.Numeric),
        new JdeField("PDUPMT", "PDUPMT", JdeDataType.Numeric),
        new JdeField("PDJOBN", "PDJOBN", JdeDataType.String, 20),
        new JdeField("PDMKEY", "PDMKEY", JdeDataType.String, 30),
        new JdeField("PDPID", "PDPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B106_0", "Primary Key on PDNCPATHID, PDNCPSQNO", new[] { "PDNCPATHID", "PDNCPSQNO" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F31B106_2", "Index on PDNCFRMTID", new[] { "PDNCFRMTID" })
    };
}
