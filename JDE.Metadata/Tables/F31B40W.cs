using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B40W - .
/// </summary>
public class F31B40W : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// QWMATH01.
        /// </summary>
        public const string QWMATH01 = "QWMATH01";

        /// <summary>
        /// QWSATENT.
        /// </summary>
        public const string QWSATENT = "QWSATENT";

        /// <summary>
        /// QWSARTFLD.
        /// </summary>
        public const string QWSARTFLD = "QWSARTFLD";

        /// <summary>
        /// QWSASLRUL.
        /// </summary>
        public const string QWSASLRUL = "QWSASLRUL";

        /// <summary>
        /// QWSASLFLD.
        /// </summary>
        public const string QWSASLFLD = "QWSASLFLD";

        /// <summary>
        /// QWSADATYP.
        /// </summary>
        public const string QWSADATYP = "QWSADATYP";

        /// <summary>
        /// QWUSER.
        /// </summary>
        public const string QWUSER = "QWUSER";

        /// <summary>
        /// QWPID.
        /// </summary>
        public const string QWPID = "QWPID";

        /// <summary>
        /// QWJOBN.
        /// </summary>
        public const string QWJOBN = "QWJOBN";

        /// <summary>
        /// QWUPMJ.
        /// </summary>
        public const string QWUPMJ = "QWUPMJ";

        /// <summary>
        /// QWUPMT.
        /// </summary>
        public const string QWUPMT = "QWUPMT";

        /// <summary>
        /// QWURCD.
        /// </summary>
        public const string QWURCD = "QWURCD";

        /// <summary>
        /// QWURDT.
        /// </summary>
        public const string QWURDT = "QWURDT";

        /// <summary>
        /// QWURAT.
        /// </summary>
        public const string QWURAT = "QWURAT";

        /// <summary>
        /// QWURRF.
        /// </summary>
        public const string QWURRF = "QWURRF";

        /// <summary>
        /// QWURAB.
        /// </summary>
        public const string QWURAB = "QWURAB";
    }

    /// <inheritdoc />
    public override string TableName => "F31B40W";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("QWMATH01", "QWMATH01", JdeDataType.Numeric, null, true, true),
        new JdeField("QWSATENT", "QWSATENT", JdeDataType.String, 4),
        new JdeField("QWSARTFLD", "QWSARTFLD", JdeDataType.String, 60),
        new JdeField("QWSASLRUL", "QWSASLRUL", JdeDataType.String, 60),
        new JdeField("QWSASLFLD", "QWSASLFLD", JdeDataType.String, 60),
        new JdeField("QWSADATYP", "QWSADATYP", JdeDataType.String, 20),
        new JdeField("QWUSER", "QWUSER", JdeDataType.String, 20),
        new JdeField("QWPID", "QWPID", JdeDataType.String, 20),
        new JdeField("QWJOBN", "QWJOBN", JdeDataType.String, 20),
        new JdeField("QWUPMJ", "QWUPMJ", JdeDataType.Numeric),
        new JdeField("QWUPMT", "QWUPMT", JdeDataType.Numeric),
        new JdeField("QWURCD", "QWURCD", JdeDataType.String, 4),
        new JdeField("QWURDT", "QWURDT", JdeDataType.Numeric),
        new JdeField("QWURAT", "QWURAT", JdeDataType.Numeric),
        new JdeField("QWURRF", "QWURRF", JdeDataType.String, 30),
        new JdeField("QWURAB", "QWURAB", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B40W_0", "Primary Key on QWMATH01", new[] { "QWMATH01" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F31B40W_2", "Index on QWSATENT, QWSADATYP, QWSARTFLD", new[] { "QWSATENT", "QWSADATYP", "QWSARTFLD" }),
        new JdeIndex("F31B40W_4", "Index on QWSATENT, QWSARTFLD, QWSASLRUL", new[] { "QWSATENT", "QWSARTFLD", "QWSASLRUL" }),
        new JdeIndex("F31B40W_5", "Index on QWSATENT, QWSASLFLD", new[] { "QWSATENT", "QWSASLFLD" })
    };
}
