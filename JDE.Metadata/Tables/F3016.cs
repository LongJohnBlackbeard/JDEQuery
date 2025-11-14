using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F3016 - .
/// </summary>
public class F3016 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// KMKID1.
        /// </summary>
        public const string KMKID1 = "KMKID1";

        /// <summary>
        /// KMKBST.
        /// </summary>
        public const string KMKBST = "KMKBST";

        /// <summary>
        /// KMITM.
        /// </summary>
        public const string KMITM = "KMITM";

        /// <summary>
        /// KMLITM.
        /// </summary>
        public const string KMLITM = "KMLITM";

        /// <summary>
        /// KMAITM.
        /// </summary>
        public const string KMAITM = "KMAITM";

        /// <summary>
        /// KMDOCO.
        /// </summary>
        public const string KMDOCO = "KMDOCO";

        /// <summary>
        /// KMDCTO.
        /// </summary>
        public const string KMDCTO = "KMDCTO";

        /// <summary>
        /// KMLNID.
        /// </summary>
        public const string KMLNID = "KMLNID";

        /// <summary>
        /// KMLOCN.
        /// </summary>
        public const string KMLOCN = "KMLOCN";

        /// <summary>
        /// KMMCU.
        /// </summary>
        public const string KMMCU = "KMMCU";

        /// <summary>
        /// KMTLOC.
        /// </summary>
        public const string KMTLOC = "KMTLOC";

        /// <summary>
        /// KMMMCU.
        /// </summary>
        public const string KMMMCU = "KMMMCU";

        /// <summary>
        /// KMREPT.
        /// </summary>
        public const string KMREPT = "KMREPT";

        /// <summary>
        /// KMAVRT.
        /// </summary>
        public const string KMAVRT = "KMAVRT";

        /// <summary>
        /// KMKBQT.
        /// </summary>
        public const string KMKBQT = "KMKBQT";

        /// <summary>
        /// KMUOM.
        /// </summary>
        public const string KMUOM = "KMUOM";

        /// <summary>
        /// KMCNTS.
        /// </summary>
        public const string KMCNTS = "KMCNTS";

        /// <summary>
        /// KMUM.
        /// </summary>
        public const string KMUM = "KMUM";

        /// <summary>
        /// KMKBTM.
        /// </summary>
        public const string KMKBTM = "KMKBTM";

        /// <summary>
        /// KMKBOV.
        /// </summary>
        public const string KMKBOV = "KMKBOV";

        /// <summary>
        /// KMAN8.
        /// </summary>
        public const string KMAN8 = "KMAN8";

        /// <summary>
        /// KMLINE.
        /// </summary>
        public const string KMLINE = "KMLINE";

        /// <summary>
        /// KMKBRC.
        /// </summary>
        public const string KMKBRC = "KMKBRC";

        /// <summary>
        /// KMURCD.
        /// </summary>
        public const string KMURCD = "KMURCD";

        /// <summary>
        /// KMURDT.
        /// </summary>
        public const string KMURDT = "KMURDT";

        /// <summary>
        /// KMURAT.
        /// </summary>
        public const string KMURAT = "KMURAT";

        /// <summary>
        /// KMURAB.
        /// </summary>
        public const string KMURAB = "KMURAB";

        /// <summary>
        /// KMURRF.
        /// </summary>
        public const string KMURRF = "KMURRF";

        /// <summary>
        /// KMTRQT.
        /// </summary>
        public const string KMTRQT = "KMTRQT";

        /// <summary>
        /// KMUSER.
        /// </summary>
        public const string KMUSER = "KMUSER";

        /// <summary>
        /// KMPID.
        /// </summary>
        public const string KMPID = "KMPID";

        /// <summary>
        /// KMJOBN.
        /// </summary>
        public const string KMJOBN = "KMJOBN";

        /// <summary>
        /// KMUPMJ.
        /// </summary>
        public const string KMUPMJ = "KMUPMJ";

        /// <summary>
        /// KMTDAY.
        /// </summary>
        public const string KMTDAY = "KMTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F3016";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("KMKID1", "KMKID1", JdeDataType.Numeric, null, true, true),
        new JdeField("KMKBST", "KMKBST", JdeDataType.String, 2),
        new JdeField("KMITM", "KMITM", JdeDataType.Numeric),
        new JdeField("KMLITM", "KMLITM", JdeDataType.String, 50),
        new JdeField("KMAITM", "KMAITM", JdeDataType.String, 50),
        new JdeField("KMDOCO", "KMDOCO", JdeDataType.Numeric),
        new JdeField("KMDCTO", "KMDCTO", JdeDataType.String, 4),
        new JdeField("KMLNID", "KMLNID", JdeDataType.Numeric),
        new JdeField("KMLOCN", "KMLOCN", JdeDataType.String, 40),
        new JdeField("KMMCU", "KMMCU", JdeDataType.String, 24),
        new JdeField("KMTLOC", "KMTLOC", JdeDataType.String, 40),
        new JdeField("KMMMCU", "KMMMCU", JdeDataType.String, 24),
        new JdeField("KMREPT", "KMREPT", JdeDataType.String, 2),
        new JdeField("KMAVRT", "KMAVRT", JdeDataType.Numeric),
        new JdeField("KMKBQT", "KMKBQT", JdeDataType.Numeric),
        new JdeField("KMUOM", "KMUOM", JdeDataType.String, 4),
        new JdeField("KMCNTS", "KMCNTS", JdeDataType.Numeric),
        new JdeField("KMUM", "KMUM", JdeDataType.String, 4),
        new JdeField("KMKBTM", "KMKBTM", JdeDataType.String, 2),
        new JdeField("KMKBOV", "KMKBOV", JdeDataType.String, 2),
        new JdeField("KMAN8", "KMAN8", JdeDataType.Numeric),
        new JdeField("KMLINE", "KMLINE", JdeDataType.String, 24),
        new JdeField("KMKBRC", "KMKBRC", JdeDataType.String, 2),
        new JdeField("KMURCD", "KMURCD", JdeDataType.String, 4),
        new JdeField("KMURDT", "KMURDT", JdeDataType.Numeric),
        new JdeField("KMURAT", "KMURAT", JdeDataType.Numeric),
        new JdeField("KMURAB", "KMURAB", JdeDataType.Numeric),
        new JdeField("KMURRF", "KMURRF", JdeDataType.String, 30),
        new JdeField("KMTRQT", "KMTRQT", JdeDataType.Numeric),
        new JdeField("KMUSER", "KMUSER", JdeDataType.String, 20),
        new JdeField("KMPID", "KMPID", JdeDataType.String, 20),
        new JdeField("KMJOBN", "KMJOBN", JdeDataType.String, 20),
        new JdeField("KMUPMJ", "KMUPMJ", JdeDataType.Numeric),
        new JdeField("KMTDAY", "KMTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F3016_0", "Primary Key on KMKID1", new[] { "KMKID1" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F3016_10", "Index on KMITM, KMMMCU, KMTLOC, KMLOCN, KMMCU, KMKID1", new[] { "KMITM", "KMMMCU", "KMTLOC", "KMLOCN", "KMMCU", "KMKID1" }),
        new JdeIndex("F3016_11", "Index on KMITM, KMLOCN, KMMCU, KMTLOC, KMMMCU, KMKID1", new[] { "KMITM", "KMLOCN", "KMMCU", "KMTLOC", "KMMMCU", "KMKID1" }),
        new JdeIndex("F3016_12", "Index on KMITM, KMMCU, KMLOCN, KMTLOC", new[] { "KMITM", "KMMCU", "KMLOCN", "KMTLOC" }),
        new JdeIndex("F3016_13", "Index on KMITM, KMMCU, KMLOCN, KMMMCU, KMTLOC, KMREPT, KMKBST", new[] { "KMITM", "KMMCU", "KMLOCN", "KMMMCU", "KMTLOC", "KMREPT", "KMKBST" }),
        new JdeIndex("F3016_5", "Index on KMTLOC, KMMMCU, KMLOCN, KMMCU, KMITM, KMKID1", new[] { "KMTLOC", "KMMMCU", "KMLOCN", "KMMCU", "KMITM", "KMKID1" }),
        new JdeIndex("F3016_7", "Index on KMLOCN, KMMCU, KMTLOC, KMMMCU, KMITM, KMKID1", new[] { "KMLOCN", "KMMCU", "KMTLOC", "KMMMCU", "KMITM", "KMKID1" }),
        new JdeIndex("F3016_8", "Index on KMAN8", new[] { "KMAN8" }),
        new JdeIndex("F3016_9", "Index on KMDOCO, KMDCTO", new[] { "KMDOCO", "KMDCTO" })
    };
}
