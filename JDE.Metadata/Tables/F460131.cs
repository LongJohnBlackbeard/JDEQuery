using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F460131 - .
/// </summary>
public class F460131 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SPMCU.
        /// </summary>
        public const string SPMCU = "SPMCU";

        /// <summary>
        /// SPAN8.
        /// </summary>
        public const string SPAN8 = "SPAN8";

        /// <summary>
        /// SPSHAN.
        /// </summary>
        public const string SPSHAN = "SPSHAN";

        /// <summary>
        /// SPITM.
        /// </summary>
        public const string SPITM = "SPITM";

        /// <summary>
        /// SPPRP6.
        /// </summary>
        public const string SPPRP6 = "SPPRP6";

        /// <summary>
        /// SPUOM.
        /// </summary>
        public const string SPUOM = "SPUOM";

        /// <summary>
        /// SPEQT2.
        /// </summary>
        public const string SPEQT2 = "SPEQT2";

        /// <summary>
        /// SPEQTY.
        /// </summary>
        public const string SPEQTY = "SPEQTY";

        /// <summary>
        /// SPSTPK.
        /// </summary>
        public const string SPSTPK = "SPSTPK";

        /// <summary>
        /// SPCEQT.
        /// </summary>
        public const string SPCEQT = "SPCEQT";

        /// <summary>
        /// SPRECSQ.
        /// </summary>
        public const string SPRECSQ = "SPRECSQ";

        /// <summary>
        /// SPC1FU.
        /// </summary>
        public const string SPC1FU = "SPC1FU";

        /// <summary>
        /// SPCFC1.
        /// </summary>
        public const string SPCFC1 = "SPCFC1";

        /// <summary>
        /// SPCFS1.
        /// </summary>
        public const string SPCFS1 = "SPCFS1";

        /// <summary>
        /// SPD1FU.
        /// </summary>
        public const string SPD1FU = "SPD1FU";

        /// <summary>
        /// SPURCD.
        /// </summary>
        public const string SPURCD = "SPURCD";

        /// <summary>
        /// SPURDT.
        /// </summary>
        public const string SPURDT = "SPURDT";

        /// <summary>
        /// SPURAT.
        /// </summary>
        public const string SPURAT = "SPURAT";

        /// <summary>
        /// SPURAB.
        /// </summary>
        public const string SPURAB = "SPURAB";

        /// <summary>
        /// SPURRF.
        /// </summary>
        public const string SPURRF = "SPURRF";

        /// <summary>
        /// SPUSER.
        /// </summary>
        public const string SPUSER = "SPUSER";

        /// <summary>
        /// SPPID.
        /// </summary>
        public const string SPPID = "SPPID";

        /// <summary>
        /// SPJOBN.
        /// </summary>
        public const string SPJOBN = "SPJOBN";

        /// <summary>
        /// SPUPMJ.
        /// </summary>
        public const string SPUPMJ = "SPUPMJ";

        /// <summary>
        /// SPTDAY.
        /// </summary>
        public const string SPTDAY = "SPTDAY";

        /// <summary>
        /// SPMPGP.
        /// </summary>
        public const string SPMPGP = "SPMPGP";
    }

    /// <inheritdoc />
    public override string TableName => "F460131";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SPMCU", "SPMCU", JdeDataType.String, 24, true, true),
        new JdeField("SPAN8", "SPAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("SPSHAN", "SPSHAN", JdeDataType.Numeric, null, true, true),
        new JdeField("SPITM", "SPITM", JdeDataType.Numeric, null, true, true),
        new JdeField("SPPRP6", "SPPRP6", JdeDataType.String, 12, true, true),
        new JdeField("SPUOM", "SPUOM", JdeDataType.String, 4, true, true),
        new JdeField("SPEQT2", "SPEQT2", JdeDataType.String, 10, true, true),
        new JdeField("SPEQTY", "SPEQTY", JdeDataType.String, 10, true, true),
        new JdeField("SPSTPK", "SPSTPK", JdeDataType.Numeric),
        new JdeField("SPCEQT", "SPCEQT", JdeDataType.String, 50),
        new JdeField("SPRECSQ", "SPRECSQ", JdeDataType.Numeric),
        new JdeField("SPC1FU", "SPC1FU", JdeDataType.String, 2),
        new JdeField("SPCFC1", "SPCFC1", JdeDataType.String, 6),
        new JdeField("SPCFS1", "SPCFS1", JdeDataType.Numeric),
        new JdeField("SPD1FU", "SPD1FU", JdeDataType.Numeric),
        new JdeField("SPURCD", "SPURCD", JdeDataType.String, 4),
        new JdeField("SPURDT", "SPURDT", JdeDataType.Numeric),
        new JdeField("SPURAT", "SPURAT", JdeDataType.Numeric),
        new JdeField("SPURAB", "SPURAB", JdeDataType.Numeric),
        new JdeField("SPURRF", "SPURRF", JdeDataType.String, 30),
        new JdeField("SPUSER", "SPUSER", JdeDataType.String, 20),
        new JdeField("SPPID", "SPPID", JdeDataType.String, 20),
        new JdeField("SPJOBN", "SPJOBN", JdeDataType.String, 20),
        new JdeField("SPUPMJ", "SPUPMJ", JdeDataType.Numeric),
        new JdeField("SPTDAY", "SPTDAY", JdeDataType.Numeric),
        new JdeField("SPMPGP", "SPMPGP", JdeDataType.String, 12, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F460131_0", "Primary Key on SPMCU, SPAN8, SPITM, SPPRP6, SPUOM, SPSHAN, SPEQT2, SPEQTY, SPMPGP", new[] { "SPMCU", "SPAN8", "SPITM", "SPPRP6", "SPUOM", "SPSHAN", "SPEQT2", "SPEQTY", "SPMPGP" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F460131_2", "Index on SPMCU, SPUOM, SPITM, SPAN8, SPSHAN, SPRECSQ", new[] { "SPMCU", "SPUOM", "SPITM", "SPAN8", "SPSHAN", "SPRECSQ" }),
        new JdeIndex("F460131_3", "Index on SPMCU, SPUOM, SPPRP6, SPAN8, SPSHAN, SPRECSQ", new[] { "SPMCU", "SPUOM", "SPPRP6", "SPAN8", "SPSHAN", "SPRECSQ" }),
        new JdeIndex("F460131_4", "Index on SPMCU, SPEQT2, SPAN8, SPSHAN, SPRECSQ", new[] { "SPMCU", "SPEQT2", "SPAN8", "SPSHAN", "SPRECSQ" }),
        new JdeIndex("F460131_5", "Index on SPMCU, SPUOM, SPMPGP, SPAN8, SPSHAN, SPRECSQ", new[] { "SPMCU", "SPUOM", "SPMPGP", "SPAN8", "SPSHAN", "SPRECSQ" })
    };
}
