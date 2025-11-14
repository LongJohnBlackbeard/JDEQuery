using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F52425 - .
/// </summary>
public class F52425 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TKCO.
        /// </summary>
        public const string TKCO = "TKCO";

        /// <summary>
        /// TKLNID.
        /// </summary>
        public const string TKLNID = "TKLNID";

        /// <summary>
        /// TKDOCO.
        /// </summary>
        public const string TKDOCO = "TKDOCO";

        /// <summary>
        /// TKDCTO.
        /// </summary>
        public const string TKDCTO = "TKDCTO";

        /// <summary>
        /// TKMCUS.
        /// </summary>
        public const string TKMCUS = "TKMCUS";

        /// <summary>
        /// TKPCTN.
        /// </summary>
        public const string TKPCTN = "TKPCTN";

        /// <summary>
        /// TKJMCU.
        /// </summary>
        public const string TKJMCU = "TKJMCU";

        /// <summary>
        /// TKAN8.
        /// </summary>
        public const string TKAN8 = "TKAN8";

        /// <summary>
        /// TKPRTP.
        /// </summary>
        public const string TKPRTP = "TKPRTP";

        /// <summary>
        /// TKCOCH.
        /// </summary>
        public const string TKCOCH = "TKCOCH";

        /// <summary>
        /// TKOPIM.
        /// </summary>
        public const string TKOPIM = "TKOPIM";

        /// <summary>
        /// TKAI01.
        /// </summary>
        public const string TKAI01 = "TKAI01";

        /// <summary>
        /// TKAI02.
        /// </summary>
        public const string TKAI02 = "TKAI02";

        /// <summary>
        /// TKAI03.
        /// </summary>
        public const string TKAI03 = "TKAI03";

        /// <summary>
        /// TKAI04.
        /// </summary>
        public const string TKAI04 = "TKAI04";

        /// <summary>
        /// TKAI05.
        /// </summary>
        public const string TKAI05 = "TKAI05";

        /// <summary>
        /// TKRRF.
        /// </summary>
        public const string TKRRF = "TKRRF";

        /// <summary>
        /// TKCONFD.
        /// </summary>
        public const string TKCONFD = "TKCONFD";

        /// <summary>
        /// TKRDF.
        /// </summary>
        public const string TKRDF = "TKRDF";

        /// <summary>
        /// TKVALFJ.
        /// </summary>
        public const string TKVALFJ = "TKVALFJ";

        /// <summary>
        /// TKVALTJ.
        /// </summary>
        public const string TKVALTJ = "TKVALTJ";

        /// <summary>
        /// TKUPMT.
        /// </summary>
        public const string TKUPMT = "TKUPMT";

        /// <summary>
        /// TKUPMJ.
        /// </summary>
        public const string TKUPMJ = "TKUPMJ";

        /// <summary>
        /// TKUSER.
        /// </summary>
        public const string TKUSER = "TKUSER";

        /// <summary>
        /// TKPID.
        /// </summary>
        public const string TKPID = "TKPID";

        /// <summary>
        /// TKJOBN.
        /// </summary>
        public const string TKJOBN = "TKJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F52425";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TKCO", "TKCO", JdeDataType.String, 10, true, true),
        new JdeField("TKLNID", "TKLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("TKDOCO", "TKDOCO", JdeDataType.Numeric),
        new JdeField("TKDCTO", "TKDCTO", JdeDataType.String, 4),
        new JdeField("TKMCUS", "TKMCUS", JdeDataType.String, 24),
        new JdeField("TKPCTN", "TKPCTN", JdeDataType.Numeric),
        new JdeField("TKJMCU", "TKJMCU", JdeDataType.String, 24),
        new JdeField("TKAN8", "TKAN8", JdeDataType.Numeric),
        new JdeField("TKPRTP", "TKPRTP", JdeDataType.String, 2),
        new JdeField("TKCOCH", "TKCOCH", JdeDataType.String, 6),
        new JdeField("TKOPIM", "TKOPIM", JdeDataType.String, 30),
        new JdeField("TKAI01", "TKAI01", JdeDataType.String, 6),
        new JdeField("TKAI02", "TKAI02", JdeDataType.String, 6),
        new JdeField("TKAI03", "TKAI03", JdeDataType.String, 6),
        new JdeField("TKAI04", "TKAI04", JdeDataType.String, 6),
        new JdeField("TKAI05", "TKAI05", JdeDataType.String, 6),
        new JdeField("TKRRF", "TKRRF", JdeDataType.String, 2),
        new JdeField("TKCONFD", "TKCONFD", JdeDataType.Numeric),
        new JdeField("TKRDF", "TKRDF", JdeDataType.String, 2),
        new JdeField("TKVALFJ", "TKVALFJ", JdeDataType.Numeric),
        new JdeField("TKVALTJ", "TKVALTJ", JdeDataType.Numeric),
        new JdeField("TKUPMT", "TKUPMT", JdeDataType.Numeric),
        new JdeField("TKUPMJ", "TKUPMJ", JdeDataType.Numeric),
        new JdeField("TKUSER", "TKUSER", JdeDataType.String, 20),
        new JdeField("TKPID", "TKPID", JdeDataType.String, 20),
        new JdeField("TKJOBN", "TKJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F52425_0", "Primary Key on TKCO, TKLNID", new[] { "TKCO", "TKLNID" }, isUnique: true, isPrimaryKey: true)
    };
}
