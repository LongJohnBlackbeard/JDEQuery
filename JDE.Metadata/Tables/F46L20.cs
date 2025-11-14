using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F46L20 - .
/// </summary>
public class F46L20 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LCUKID.
        /// </summary>
        public const string LCUKID = "LCUKID";

        /// <summary>
        /// LCMCU.
        /// </summary>
        public const string LCMCU = "LCMCU";

        /// <summary>
        /// LCLPNU.
        /// </summary>
        public const string LCLPNU = "LCLPNU";

        /// <summary>
        /// LCSNTY.
        /// </summary>
        public const string LCSNTY = "LCSNTY";

        /// <summary>
        /// LCCRLPN.
        /// </summary>
        public const string LCCRLPN = "LCCRLPN";

        /// <summary>
        /// LCCRLPT.
        /// </summary>
        public const string LCCRLPT = "LCCRLPT";

        /// <summary>
        /// LCLPNDC.
        /// </summary>
        public const string LCLPNDC = "LCLPNDC";

        /// <summary>
        /// LCUPMJ.
        /// </summary>
        public const string LCUPMJ = "LCUPMJ";

        /// <summary>
        /// LCTDAY.
        /// </summary>
        public const string LCTDAY = "LCTDAY";

        /// <summary>
        /// LCUSER.
        /// </summary>
        public const string LCUSER = "LCUSER";

        /// <summary>
        /// LCPID.
        /// </summary>
        public const string LCPID = "LCPID";

        /// <summary>
        /// LCMKEY.
        /// </summary>
        public const string LCMKEY = "LCMKEY";

        /// <summary>
        /// LCSVRNAME.
        /// </summary>
        public const string LCSVRNAME = "LCSVRNAME";

        /// <summary>
        /// LCURCD.
        /// </summary>
        public const string LCURCD = "LCURCD";

        /// <summary>
        /// LCURDT.
        /// </summary>
        public const string LCURDT = "LCURDT";

        /// <summary>
        /// LCURAB.
        /// </summary>
        public const string LCURAB = "LCURAB";

        /// <summary>
        /// LCURRF.
        /// </summary>
        public const string LCURRF = "LCURRF";
    }

    /// <inheritdoc />
    public override string TableName => "F46L20";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LCUKID", "LCUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("LCMCU", "LCMCU", JdeDataType.String, 24),
        new JdeField("LCLPNU", "LCLPNU", JdeDataType.String, 80),
        new JdeField("LCSNTY", "LCSNTY", JdeDataType.String, 10),
        new JdeField("LCCRLPN", "LCCRLPN", JdeDataType.String, 80),
        new JdeField("LCCRLPT", "LCCRLPT", JdeDataType.String, 10),
        new JdeField("LCLPNDC", "LCLPNDC", JdeDataType.Date),
        new JdeField("LCUPMJ", "LCUPMJ", JdeDataType.Numeric),
        new JdeField("LCTDAY", "LCTDAY", JdeDataType.Numeric),
        new JdeField("LCUSER", "LCUSER", JdeDataType.String, 20),
        new JdeField("LCPID", "LCPID", JdeDataType.String, 20),
        new JdeField("LCMKEY", "LCMKEY", JdeDataType.String, 30),
        new JdeField("LCSVRNAME", "LCSVRNAME", JdeDataType.String, 30),
        new JdeField("LCURCD", "LCURCD", JdeDataType.String, 4),
        new JdeField("LCURDT", "LCURDT", JdeDataType.Numeric),
        new JdeField("LCURAB", "LCURAB", JdeDataType.Numeric),
        new JdeField("LCURRF", "LCURRF", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F46L20_0", "Primary Key on LCUKID", new[] { "LCUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F46L20_2", "Index on SYS_NC00018$, SYS_NC00019$, LCLPNU, LCCRLPN", new[] { "SYS_NC00018$", "SYS_NC00019$", "LCLPNU", "LCCRLPN" })
    };
}
