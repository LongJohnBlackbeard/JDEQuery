using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// FF31K52 - .
/// </summary>
public class FF31K52 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LMKLBMSG.
        /// </summary>
        public const string LMKLBMSG = "LMKLBMSG";

        /// <summary>
        /// LMLNPOW.
        /// </summary>
        public const string LMLNPOW = "LMLNPOW";

        /// <summary>
        /// LMURAB.
        /// </summary>
        public const string LMURAB = "LMURAB";

        /// <summary>
        /// LMURAT.
        /// </summary>
        public const string LMURAT = "LMURAT";

        /// <summary>
        /// LMURCD.
        /// </summary>
        public const string LMURCD = "LMURCD";

        /// <summary>
        /// LMURDT.
        /// </summary>
        public const string LMURDT = "LMURDT";

        /// <summary>
        /// LMURRF.
        /// </summary>
        public const string LMURRF = "LMURRF";

        /// <summary>
        /// LMTORG.
        /// </summary>
        public const string LMTORG = "LMTORG";

        /// <summary>
        /// LMUSER.
        /// </summary>
        public const string LMUSER = "LMUSER";

        /// <summary>
        /// LMPID.
        /// </summary>
        public const string LMPID = "LMPID";

        /// <summary>
        /// LMJOBN.
        /// </summary>
        public const string LMJOBN = "LMJOBN";

        /// <summary>
        /// LMUUPMJ.
        /// </summary>
        public const string LMUUPMJ = "LMUUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "FF31K52";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LMKLBMSG", "LMKLBMSG", JdeDataType.String, 20, true, true),
        new JdeField("LMLNPOW", "LMLNPOW", JdeDataType.String, 4, true, true),
        new JdeField("LMURAB", "LMURAB", JdeDataType.Numeric),
        new JdeField("LMURAT", "LMURAT", JdeDataType.Numeric),
        new JdeField("LMURCD", "LMURCD", JdeDataType.String, 4),
        new JdeField("LMURDT", "LMURDT", JdeDataType.Numeric),
        new JdeField("LMURRF", "LMURRF", JdeDataType.String, 30),
        new JdeField("LMTORG", "LMTORG", JdeDataType.String, 20),
        new JdeField("LMUSER", "LMUSER", JdeDataType.String, 20),
        new JdeField("LMPID", "LMPID", JdeDataType.String, 20),
        new JdeField("LMJOBN", "LMJOBN", JdeDataType.String, 20),
        new JdeField("LMUUPMJ", "LMUUPMJ", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("FF31K52_0", "Primary Key on LMKLBMSG, LMLNPOW", new[] { "LMKLBMSG", "LMLNPOW" }, isUnique: true, isPrimaryKey: true)
    };
}
