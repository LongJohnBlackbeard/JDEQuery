using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F3411 - .
/// </summary>
public class F3411 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// MMUKID.
        /// </summary>
        public const string MMUKID = "MMUKID";

        /// <summary>
        /// MMITM.
        /// </summary>
        public const string MMITM = "MMITM";

        /// <summary>
        /// MMMCU.
        /// </summary>
        public const string MMMCU = "MMMCU";

        /// <summary>
        /// MMMMCU.
        /// </summary>
        public const string MMMMCU = "MMMMCU";

        /// <summary>
        /// MMMSGT.
        /// </summary>
        public const string MMMSGT = "MMMSGT";

        /// <summary>
        /// MMMSGA.
        /// </summary>
        public const string MMMSGA = "MMMSGA";

        /// <summary>
        /// MMHCLD.
        /// </summary>
        public const string MMHCLD = "MMHCLD";

        /// <summary>
        /// MMKCOO.
        /// </summary>
        public const string MMKCOO = "MMKCOO";

        /// <summary>
        /// MMDOCO.
        /// </summary>
        public const string MMDOCO = "MMDOCO";

        /// <summary>
        /// MMDCTO.
        /// </summary>
        public const string MMDCTO = "MMDCTO";

        /// <summary>
        /// MMLNID.
        /// </summary>
        public const string MMLNID = "MMLNID";

        /// <summary>
        /// MMSFXO.
        /// </summary>
        public const string MMSFXO = "MMSFXO";

        /// <summary>
        /// MMDSC1.
        /// </summary>
        public const string MMDSC1 = "MMDSC1";

        /// <summary>
        /// MMTRQT.
        /// </summary>
        public const string MMTRQT = "MMTRQT";

        /// <summary>
        /// MMVEND.
        /// </summary>
        public const string MMVEND = "MMVEND";

        /// <summary>
        /// MMDRQJ.
        /// </summary>
        public const string MMDRQJ = "MMDRQJ";

        /// <summary>
        /// MMSTRT.
        /// </summary>
        public const string MMSTRT = "MMSTRT";

        /// <summary>
        /// MMRSTJ.
        /// </summary>
        public const string MMRSTJ = "MMRSTJ";

        /// <summary>
        /// MMRRQJ.
        /// </summary>
        public const string MMRRQJ = "MMRRQJ";

        /// <summary>
        /// MMUPMJ.
        /// </summary>
        public const string MMUPMJ = "MMUPMJ";

        /// <summary>
        /// MMTDAY.
        /// </summary>
        public const string MMTDAY = "MMTDAY";

        /// <summary>
        /// MMUSER.
        /// </summary>
        public const string MMUSER = "MMUSER";

        /// <summary>
        /// MMJOBN.
        /// </summary>
        public const string MMJOBN = "MMJOBN";

        /// <summary>
        /// MMPID.
        /// </summary>
        public const string MMPID = "MMPID";

        /// <summary>
        /// MMREDJ.
        /// </summary>
        public const string MMREDJ = "MMREDJ";

        /// <summary>
        /// MMOEDJ.
        /// </summary>
        public const string MMOEDJ = "MMOEDJ";

        /// <summary>
        /// MMLINE.
        /// </summary>
        public const string MMLINE = "MMLINE";

        /// <summary>
        /// MMPRJM.
        /// </summary>
        public const string MMPRJM = "MMPRJM";

        /// <summary>
        /// MMSRDM.
        /// </summary>
        public const string MMSRDM = "MMSRDM";

        /// <summary>
        /// MMOSTT.
        /// </summary>
        public const string MMOSTT = "MMOSTT";

        /// <summary>
        /// MMLOTN.
        /// </summary>
        public const string MMLOTN = "MMLOTN";

        /// <summary>
        /// MMPNS.
        /// </summary>
        public const string MMPNS = "MMPNS";

        /// <summary>
        /// MMPMPN.
        /// </summary>
        public const string MMPMPN = "MMPMPN";
    }

    /// <inheritdoc />
    public override string TableName => "F3411";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("MMUKID", "MMUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("MMITM", "MMITM", JdeDataType.Numeric),
        new JdeField("MMMCU", "MMMCU", JdeDataType.String, 24),
        new JdeField("MMMMCU", "MMMMCU", JdeDataType.String, 24),
        new JdeField("MMMSGT", "MMMSGT", JdeDataType.String, 2),
        new JdeField("MMMSGA", "MMMSGA", JdeDataType.String, 2),
        new JdeField("MMHCLD", "MMHCLD", JdeDataType.String, 2),
        new JdeField("MMKCOO", "MMKCOO", JdeDataType.String, 10),
        new JdeField("MMDOCO", "MMDOCO", JdeDataType.Numeric),
        new JdeField("MMDCTO", "MMDCTO", JdeDataType.String, 4),
        new JdeField("MMLNID", "MMLNID", JdeDataType.Numeric),
        new JdeField("MMSFXO", "MMSFXO", JdeDataType.String, 6),
        new JdeField("MMDSC1", "MMDSC1", JdeDataType.String, 60),
        new JdeField("MMTRQT", "MMTRQT", JdeDataType.Numeric),
        new JdeField("MMVEND", "MMVEND", JdeDataType.Numeric),
        new JdeField("MMDRQJ", "MMDRQJ", JdeDataType.Numeric),
        new JdeField("MMSTRT", "MMSTRT", JdeDataType.Numeric),
        new JdeField("MMRSTJ", "MMRSTJ", JdeDataType.Numeric),
        new JdeField("MMRRQJ", "MMRRQJ", JdeDataType.Numeric),
        new JdeField("MMUPMJ", "MMUPMJ", JdeDataType.Numeric),
        new JdeField("MMTDAY", "MMTDAY", JdeDataType.Numeric),
        new JdeField("MMUSER", "MMUSER", JdeDataType.String, 20),
        new JdeField("MMJOBN", "MMJOBN", JdeDataType.String, 20),
        new JdeField("MMPID", "MMPID", JdeDataType.String, 20),
        new JdeField("MMREDJ", "MMREDJ", JdeDataType.Numeric),
        new JdeField("MMOEDJ", "MMOEDJ", JdeDataType.Numeric),
        new JdeField("MMLINE", "MMLINE", JdeDataType.String, 24),
        new JdeField("MMPRJM", "MMPRJM", JdeDataType.Numeric),
        new JdeField("MMSRDM", "MMSRDM", JdeDataType.Numeric),
        new JdeField("MMOSTT", "MMOSTT", JdeDataType.String, 2),
        new JdeField("MMLOTN", "MMLOTN", JdeDataType.String, 60),
        new JdeField("MMPNS", "MMPNS", JdeDataType.Numeric),
        new JdeField("MMPMPN", "MMPMPN", JdeDataType.String, 60)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F3411_0", "Primary Key on MMUKID", new[] { "MMUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F3411_10", "Index on MMITM, MMMCU, MMDCTO", new[] { "MMITM", "MMMCU", "MMDCTO" }),
        new JdeIndex("F3411_2", "Index on MMITM, MMMCU, MMHCLD, MMMSGT, MMRRQJ", new[] { "MMITM", "MMMCU", "MMHCLD", "MMMSGT", "MMRRQJ" }),
        new JdeIndex("F3411_3", "Index on MMDOCO, MMDCTO, MMKCOO", new[] { "MMDOCO", "MMDCTO", "MMKCOO" }),
        new JdeIndex("F3411_4", "Index on MMMCU, MMITM, MMMMCU, MMDRQJ", new[] { "MMMCU", "MMITM", "MMMMCU", "MMDRQJ" }),
        new JdeIndex("F3411_5", "Index on MMITM, MMMCU, MMDRQJ", new[] { "MMITM", "MMMCU", "MMDRQJ" }),
        new JdeIndex("F3411_6", "Index on MMITM, MMMMCU, MMHCLD, MMMSGT, MMRRQJ", new[] { "MMITM", "MMMMCU", "MMHCLD", "MMMSGT", "MMRRQJ" }),
        new JdeIndex("F3411_7", "Index on MMMMCU, MMITM, MMDRQJ", new[] { "MMMMCU", "MMITM", "MMDRQJ" }),
        new JdeIndex("F3411_8", "Index on MMITM, MMMCU, MMMSGA, MMRRQJ, MMMSGT", new[] { "MMITM", "MMMCU", "MMMSGA", "MMRRQJ", "MMMSGT" }),
        new JdeIndex("F3411_9", "Index on MMMCU", new[] { "MMMCU" })
    };
}
