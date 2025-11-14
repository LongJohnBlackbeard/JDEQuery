using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F47061 - .
/// </summary>
public class F47061 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// MJEDTY.
        /// </summary>
        public const string MJEDTY = "MJEDTY";

        /// <summary>
        /// MJEDSQ.
        /// </summary>
        public const string MJEDSQ = "MJEDSQ";

        /// <summary>
        /// MJEKCO.
        /// </summary>
        public const string MJEKCO = "MJEKCO";

        /// <summary>
        /// MJEDOC.
        /// </summary>
        public const string MJEDOC = "MJEDOC";

        /// <summary>
        /// MJEDCT.
        /// </summary>
        public const string MJEDCT = "MJEDCT";

        /// <summary>
        /// MJEDLN.
        /// </summary>
        public const string MJEDLN = "MJEDLN";

        /// <summary>
        /// MJEDST.
        /// </summary>
        public const string MJEDST = "MJEDST";

        /// <summary>
        /// MJEDFT.
        /// </summary>
        public const string MJEDFT = "MJEDFT";

        /// <summary>
        /// MJEDDT.
        /// </summary>
        public const string MJEDDT = "MJEDDT";

        /// <summary>
        /// MJEDER.
        /// </summary>
        public const string MJEDER = "MJEDER";

        /// <summary>
        /// MJEDDL.
        /// </summary>
        public const string MJEDDL = "MJEDDL";

        /// <summary>
        /// MJEDSP.
        /// </summary>
        public const string MJEDSP = "MJEDSP";

        /// <summary>
        /// MJEDBT.
        /// </summary>
        public const string MJEDBT = "MJEDBT";

        /// <summary>
        /// MJPNID.
        /// </summary>
        public const string MJPNID = "MJPNID";

        /// <summary>
        /// MJTPUR.
        /// </summary>
        public const string MJTPUR = "MJTPUR";

        /// <summary>
        /// MJVR01.
        /// </summary>
        public const string MJVR01 = "MJVR01";

        /// <summary>
        /// MJVR02.
        /// </summary>
        public const string MJVR02 = "MJVR02";

        /// <summary>
        /// MJSTQC.
        /// </summary>
        public const string MJSTQC = "MJSTQC";

        /// <summary>
        /// MJSQQC.
        /// </summary>
        public const string MJSQQC = "MJSQQC";

        /// <summary>
        /// MJDTFR.
        /// </summary>
        public const string MJDTFR = "MJDTFR";

        /// <summary>
        /// MJDTTO.
        /// </summary>
        public const string MJDTTO = "MJDTTO";

        /// <summary>
        /// MJTRDJ.
        /// </summary>
        public const string MJTRDJ = "MJTRDJ";

        /// <summary>
        /// MJKCOO.
        /// </summary>
        public const string MJKCOO = "MJKCOO";

        /// <summary>
        /// MJDOCO.
        /// </summary>
        public const string MJDOCO = "MJDOCO";

        /// <summary>
        /// MJDCTO.
        /// </summary>
        public const string MJDCTO = "MJDCTO";

        /// <summary>
        /// MJSFXO.
        /// </summary>
        public const string MJSFXO = "MJSFXO";

        /// <summary>
        /// MJAN8.
        /// </summary>
        public const string MJAN8 = "MJAN8";

        /// <summary>
        /// MJALPH.
        /// </summary>
        public const string MJALPH = "MJALPH";

        /// <summary>
        /// MJBPFC.
        /// </summary>
        public const string MJBPFC = "MJBPFC";

        /// <summary>
        /// MJRVIS.
        /// </summary>
        public const string MJRVIS = "MJRVIS";

        /// <summary>
        /// MJURCD.
        /// </summary>
        public const string MJURCD = "MJURCD";

        /// <summary>
        /// MJURDT.
        /// </summary>
        public const string MJURDT = "MJURDT";

        /// <summary>
        /// MJURAT.
        /// </summary>
        public const string MJURAT = "MJURAT";

        /// <summary>
        /// MJURAB.
        /// </summary>
        public const string MJURAB = "MJURAB";

        /// <summary>
        /// MJURRF.
        /// </summary>
        public const string MJURRF = "MJURRF";

        /// <summary>
        /// MJTORG.
        /// </summary>
        public const string MJTORG = "MJTORG";

        /// <summary>
        /// MJUSER.
        /// </summary>
        public const string MJUSER = "MJUSER";

        /// <summary>
        /// MJPID.
        /// </summary>
        public const string MJPID = "MJPID";

        /// <summary>
        /// MJJOBN.
        /// </summary>
        public const string MJJOBN = "MJJOBN";

        /// <summary>
        /// MJUPMJ.
        /// </summary>
        public const string MJUPMJ = "MJUPMJ";

        /// <summary>
        /// MJTDAY.
        /// </summary>
        public const string MJTDAY = "MJTDAY";

        /// <summary>
        /// MJGAN8.
        /// </summary>
        public const string MJGAN8 = "MJGAN8";
    }

    /// <inheritdoc />
    public override string TableName => "F47061";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("MJEDTY", "MJEDTY", JdeDataType.String, 2),
        new JdeField("MJEDSQ", "MJEDSQ", JdeDataType.Numeric),
        new JdeField("MJEKCO", "MJEKCO", JdeDataType.String, 10, true, true),
        new JdeField("MJEDOC", "MJEDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("MJEDCT", "MJEDCT", JdeDataType.String, 4, true, true),
        new JdeField("MJEDLN", "MJEDLN", JdeDataType.Numeric),
        new JdeField("MJEDST", "MJEDST", JdeDataType.String, 12),
        new JdeField("MJEDFT", "MJEDFT", JdeDataType.String, 20),
        new JdeField("MJEDDT", "MJEDDT", JdeDataType.Numeric),
        new JdeField("MJEDER", "MJEDER", JdeDataType.String, 2),
        new JdeField("MJEDDL", "MJEDDL", JdeDataType.Numeric),
        new JdeField("MJEDSP", "MJEDSP", JdeDataType.String, 2),
        new JdeField("MJEDBT", "MJEDBT", JdeDataType.String, 30),
        new JdeField("MJPNID", "MJPNID", JdeDataType.String, 30),
        new JdeField("MJTPUR", "MJTPUR", JdeDataType.String, 4),
        new JdeField("MJVR01", "MJVR01", JdeDataType.String, 50),
        new JdeField("MJVR02", "MJVR02", JdeDataType.String, 50),
        new JdeField("MJSTQC", "MJSTQC", JdeDataType.String, 4),
        new JdeField("MJSQQC", "MJSQQC", JdeDataType.String, 2),
        new JdeField("MJDTFR", "MJDTFR", JdeDataType.Numeric),
        new JdeField("MJDTTO", "MJDTTO", JdeDataType.Numeric),
        new JdeField("MJTRDJ", "MJTRDJ", JdeDataType.Numeric),
        new JdeField("MJKCOO", "MJKCOO", JdeDataType.String, 10),
        new JdeField("MJDOCO", "MJDOCO", JdeDataType.Numeric),
        new JdeField("MJDCTO", "MJDCTO", JdeDataType.String, 4),
        new JdeField("MJSFXO", "MJSFXO", JdeDataType.String, 6),
        new JdeField("MJAN8", "MJAN8", JdeDataType.Numeric),
        new JdeField("MJALPH", "MJALPH", JdeDataType.String, 80),
        new JdeField("MJBPFC", "MJBPFC", JdeDataType.String, 2),
        new JdeField("MJRVIS", "MJRVIS", JdeDataType.String, 2),
        new JdeField("MJURCD", "MJURCD", JdeDataType.String, 4),
        new JdeField("MJURDT", "MJURDT", JdeDataType.Numeric),
        new JdeField("MJURAT", "MJURAT", JdeDataType.Numeric),
        new JdeField("MJURAB", "MJURAB", JdeDataType.Numeric),
        new JdeField("MJURRF", "MJURRF", JdeDataType.String, 30),
        new JdeField("MJTORG", "MJTORG", JdeDataType.String, 20),
        new JdeField("MJUSER", "MJUSER", JdeDataType.String, 20),
        new JdeField("MJPID", "MJPID", JdeDataType.String, 20),
        new JdeField("MJJOBN", "MJJOBN", JdeDataType.String, 20),
        new JdeField("MJUPMJ", "MJUPMJ", JdeDataType.Numeric),
        new JdeField("MJTDAY", "MJTDAY", JdeDataType.Numeric),
        new JdeField("MJGAN8", "MJGAN8", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F47061_0", "Primary Key on MJEDOC, MJEDCT, MJEKCO", new[] { "MJEDOC", "MJEDCT", "MJEKCO" }, isUnique: true, isPrimaryKey: true)
    };
}
