using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1794 - .
/// </summary>
public class F1794 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// NKDOCO.
        /// </summary>
        public const string NKDOCO = "NKDOCO";

        /// <summary>
        /// NKDCTO.
        /// </summary>
        public const string NKDCTO = "NKDCTO";

        /// <summary>
        /// NKKCOO.
        /// </summary>
        public const string NKKCOO = "NKKCOO";

        /// <summary>
        /// NKCOCH.
        /// </summary>
        public const string NKCOCH = "NKCOCH";

        /// <summary>
        /// NKLNID.
        /// </summary>
        public const string NKLNID = "NKLNID";

        /// <summary>
        /// NKGENT.
        /// </summary>
        public const string NKGENT = "NKGENT";

        /// <summary>
        /// NKCTRY.
        /// </summary>
        public const string NKCTRY = "NKCTRY";

        /// <summary>
        /// NKFY.
        /// </summary>
        public const string NKFY = "NKFY";

        /// <summary>
        /// NKBF01.
        /// </summary>
        public const string NKBF01 = "NKBF01";

        /// <summary>
        /// NKAB01.
        /// </summary>
        public const string NKAB01 = "NKAB01";

        /// <summary>
        /// NKBF02.
        /// </summary>
        public const string NKBF02 = "NKBF02";

        /// <summary>
        /// NKAB02.
        /// </summary>
        public const string NKAB02 = "NKAB02";

        /// <summary>
        /// NKBF03.
        /// </summary>
        public const string NKBF03 = "NKBF03";

        /// <summary>
        /// NKAB03.
        /// </summary>
        public const string NKAB03 = "NKAB03";

        /// <summary>
        /// NKBF04.
        /// </summary>
        public const string NKBF04 = "NKBF04";

        /// <summary>
        /// NKAB04.
        /// </summary>
        public const string NKAB04 = "NKAB04";

        /// <summary>
        /// NKBF05.
        /// </summary>
        public const string NKBF05 = "NKBF05";

        /// <summary>
        /// NKAB05.
        /// </summary>
        public const string NKAB05 = "NKAB05";

        /// <summary>
        /// NKBF06.
        /// </summary>
        public const string NKBF06 = "NKBF06";

        /// <summary>
        /// NKAB06.
        /// </summary>
        public const string NKAB06 = "NKAB06";

        /// <summary>
        /// NKBF07.
        /// </summary>
        public const string NKBF07 = "NKBF07";

        /// <summary>
        /// NKAB07.
        /// </summary>
        public const string NKAB07 = "NKAB07";

        /// <summary>
        /// NKBF08.
        /// </summary>
        public const string NKBF08 = "NKBF08";

        /// <summary>
        /// NKAB08.
        /// </summary>
        public const string NKAB08 = "NKAB08";

        /// <summary>
        /// NKBF09.
        /// </summary>
        public const string NKBF09 = "NKBF09";

        /// <summary>
        /// NKAB09.
        /// </summary>
        public const string NKAB09 = "NKAB09";

        /// <summary>
        /// NKBF10.
        /// </summary>
        public const string NKBF10 = "NKBF10";

        /// <summary>
        /// NKAB10.
        /// </summary>
        public const string NKAB10 = "NKAB10";

        /// <summary>
        /// NKBF11.
        /// </summary>
        public const string NKBF11 = "NKBF11";

        /// <summary>
        /// NKAB11.
        /// </summary>
        public const string NKAB11 = "NKAB11";

        /// <summary>
        /// NKBF12.
        /// </summary>
        public const string NKBF12 = "NKBF12";

        /// <summary>
        /// NKAB12.
        /// </summary>
        public const string NKAB12 = "NKAB12";

        /// <summary>
        /// NKBF13.
        /// </summary>
        public const string NKBF13 = "NKBF13";

        /// <summary>
        /// NKAB13.
        /// </summary>
        public const string NKAB13 = "NKAB13";

        /// <summary>
        /// NKBF14.
        /// </summary>
        public const string NKBF14 = "NKBF14";

        /// <summary>
        /// NKAB14.
        /// </summary>
        public const string NKAB14 = "NKAB14";

        /// <summary>
        /// NKCRTU.
        /// </summary>
        public const string NKCRTU = "NKCRTU";

        /// <summary>
        /// NKUSER.
        /// </summary>
        public const string NKUSER = "NKUSER";

        /// <summary>
        /// NKPID.
        /// </summary>
        public const string NKPID = "NKPID";

        /// <summary>
        /// NKJOBN.
        /// </summary>
        public const string NKJOBN = "NKJOBN";

        /// <summary>
        /// NKUPMJ.
        /// </summary>
        public const string NKUPMJ = "NKUPMJ";

        /// <summary>
        /// NKUPMT.
        /// </summary>
        public const string NKUPMT = "NKUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F1794";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("NKDOCO", "NKDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("NKDCTO", "NKDCTO", JdeDataType.String, 4, true, true),
        new JdeField("NKKCOO", "NKKCOO", JdeDataType.String, 10, true, true),
        new JdeField("NKCOCH", "NKCOCH", JdeDataType.String, 6, true, true),
        new JdeField("NKLNID", "NKLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("NKGENT", "NKGENT", JdeDataType.String, 2, true, true),
        new JdeField("NKCTRY", "NKCTRY", JdeDataType.Numeric, null, true, true),
        new JdeField("NKFY", "NKFY", JdeDataType.Numeric, null, true, true),
        new JdeField("NKBF01", "NKBF01", JdeDataType.String, 2),
        new JdeField("NKAB01", "NKAB01", JdeDataType.Numeric),
        new JdeField("NKBF02", "NKBF02", JdeDataType.String, 2),
        new JdeField("NKAB02", "NKAB02", JdeDataType.Numeric),
        new JdeField("NKBF03", "NKBF03", JdeDataType.String, 2),
        new JdeField("NKAB03", "NKAB03", JdeDataType.Numeric),
        new JdeField("NKBF04", "NKBF04", JdeDataType.String, 2),
        new JdeField("NKAB04", "NKAB04", JdeDataType.Numeric),
        new JdeField("NKBF05", "NKBF05", JdeDataType.String, 2),
        new JdeField("NKAB05", "NKAB05", JdeDataType.Numeric),
        new JdeField("NKBF06", "NKBF06", JdeDataType.String, 2),
        new JdeField("NKAB06", "NKAB06", JdeDataType.Numeric),
        new JdeField("NKBF07", "NKBF07", JdeDataType.String, 2),
        new JdeField("NKAB07", "NKAB07", JdeDataType.Numeric),
        new JdeField("NKBF08", "NKBF08", JdeDataType.String, 2),
        new JdeField("NKAB08", "NKAB08", JdeDataType.Numeric),
        new JdeField("NKBF09", "NKBF09", JdeDataType.String, 2),
        new JdeField("NKAB09", "NKAB09", JdeDataType.Numeric),
        new JdeField("NKBF10", "NKBF10", JdeDataType.String, 2),
        new JdeField("NKAB10", "NKAB10", JdeDataType.Numeric),
        new JdeField("NKBF11", "NKBF11", JdeDataType.String, 2),
        new JdeField("NKAB11", "NKAB11", JdeDataType.Numeric),
        new JdeField("NKBF12", "NKBF12", JdeDataType.String, 2),
        new JdeField("NKAB12", "NKAB12", JdeDataType.Numeric),
        new JdeField("NKBF13", "NKBF13", JdeDataType.String, 2),
        new JdeField("NKAB13", "NKAB13", JdeDataType.Numeric),
        new JdeField("NKBF14", "NKBF14", JdeDataType.String, 2),
        new JdeField("NKAB14", "NKAB14", JdeDataType.Numeric),
        new JdeField("NKCRTU", "NKCRTU", JdeDataType.String, 20),
        new JdeField("NKUSER", "NKUSER", JdeDataType.String, 20),
        new JdeField("NKPID", "NKPID", JdeDataType.String, 20),
        new JdeField("NKJOBN", "NKJOBN", JdeDataType.String, 20),
        new JdeField("NKUPMJ", "NKUPMJ", JdeDataType.Numeric),
        new JdeField("NKUPMT", "NKUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1794_0", "Primary Key on NKDOCO, NKDCTO, NKKCOO, NKCOCH, NKLNID, NKGENT, NKCTRY, NKFY", new[] { "NKDOCO", "NKDCTO", "NKKCOO", "NKCOCH", "NKLNID", "NKGENT", "NKCTRY", "NKFY" }, isUnique: true, isPrimaryKey: true)
    };
}
