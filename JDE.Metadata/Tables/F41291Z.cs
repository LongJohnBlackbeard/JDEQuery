using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F41291Z - .
/// </summary>
public class F41291Z : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IGCTID.
        /// </summary>
        public const string IGCTID = "IGCTID";

        /// <summary>
        /// IGJOBS.
        /// </summary>
        public const string IGJOBS = "IGJOBS";

        /// <summary>
        /// IGDOCO.
        /// </summary>
        public const string IGDOCO = "IGDOCO";

        /// <summary>
        /// IGDCTO.
        /// </summary>
        public const string IGDCTO = "IGDCTO";

        /// <summary>
        /// IGKCOO.
        /// </summary>
        public const string IGKCOO = "IGKCOO";

        /// <summary>
        /// IGSFXO.
        /// </summary>
        public const string IGSFXO = "IGSFXO";

        /// <summary>
        /// IGLNID.
        /// </summary>
        public const string IGLNID = "IGLNID";

        /// <summary>
        /// IGALIN.
        /// </summary>
        public const string IGALIN = "IGALIN";

        /// <summary>
        /// IGDSC1.
        /// </summary>
        public const string IGDSC1 = "IGDSC1";

        /// <summary>
        /// IGUOPN.
        /// </summary>
        public const string IGUOPN = "IGUOPN";

        /// <summary>
        /// IGPRRC.
        /// </summary>
        public const string IGPRRC = "IGPRRC";

        /// <summary>
        /// IGAOPN.
        /// </summary>
        public const string IGAOPN = "IGAOPN";

        /// <summary>
        /// IGAN8.
        /// </summary>
        public const string IGAN8 = "IGAN8";

        /// <summary>
        /// IGCRCP.
        /// </summary>
        public const string IGCRCP = "IGCRCP";

        /// <summary>
        /// IGGLC.
        /// </summary>
        public const string IGGLC = "IGGLC";

        /// <summary>
        /// IGINYN.
        /// </summary>
        public const string IGINYN = "IGINYN";

        /// <summary>
        /// IGRCYN.
        /// </summary>
        public const string IGRCYN = "IGRCYN";

        /// <summary>
        /// IGRWT1.
        /// </summary>
        public const string IGRWT1 = "IGRWT1";

        /// <summary>
        /// IGSEQ.
        /// </summary>
        public const string IGSEQ = "IGSEQ";

        /// <summary>
        /// IGALPH.
        /// </summary>
        public const string IGALPH = "IGALPH";

        /// <summary>
        /// IGCRR.
        /// </summary>
        public const string IGCRR = "IGCRR";

        /// <summary>
        /// IGCRCD.
        /// </summary>
        public const string IGCRCD = "IGCRCD";

        /// <summary>
        /// IGLVLA.
        /// </summary>
        public const string IGLVLA = "IGLVLA";

        /// <summary>
        /// IGNLIN.
        /// </summary>
        public const string IGNLIN = "IGNLIN";

        /// <summary>
        /// IGLNTY.
        /// </summary>
        public const string IGLNTY = "IGLNTY";

        /// <summary>
        /// IGMCU.
        /// </summary>
        public const string IGMCU = "IGMCU";

        /// <summary>
        /// IGTRR1.
        /// </summary>
        public const string IGTRR1 = "IGTRR1";

        /// <summary>
        /// IGTRR2.
        /// </summary>
        public const string IGTRR2 = "IGTRR2";

        /// <summary>
        /// IGCRCM.
        /// </summary>
        public const string IGCRCM = "IGCRCM";

        /// <summary>
        /// IGAVCO.
        /// </summary>
        public const string IGAVCO = "IGAVCO";

        /// <summary>
        /// IGJELN.
        /// </summary>
        public const string IGJELN = "IGJELN";

        /// <summary>
        /// IGJEL0.
        /// </summary>
        public const string IGJEL0 = "IGJEL0";

        /// <summary>
        /// IGMATH80.
        /// </summary>
        public const string IGMATH80 = "IGMATH80";
    }

    /// <inheritdoc />
    public override string TableName => "F41291Z";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IGCTID", "IGCTID", JdeDataType.String, 30, true, true),
        new JdeField("IGJOBS", "IGJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("IGDOCO", "IGDOCO", JdeDataType.Numeric),
        new JdeField("IGDCTO", "IGDCTO", JdeDataType.String, 4),
        new JdeField("IGKCOO", "IGKCOO", JdeDataType.String, 10),
        new JdeField("IGSFXO", "IGSFXO", JdeDataType.String, 6),
        new JdeField("IGLNID", "IGLNID", JdeDataType.Numeric),
        new JdeField("IGALIN", "IGALIN", JdeDataType.Numeric),
        new JdeField("IGDSC1", "IGDSC1", JdeDataType.String, 60),
        new JdeField("IGUOPN", "IGUOPN", JdeDataType.Numeric),
        new JdeField("IGPRRC", "IGPRRC", JdeDataType.Numeric),
        new JdeField("IGAOPN", "IGAOPN", JdeDataType.Numeric),
        new JdeField("IGAN8", "IGAN8", JdeDataType.Numeric),
        new JdeField("IGCRCP", "IGCRCP", JdeDataType.String, 6),
        new JdeField("IGGLC", "IGGLC", JdeDataType.String, 8),
        new JdeField("IGINYN", "IGINYN", JdeDataType.String, 2),
        new JdeField("IGRCYN", "IGRCYN", JdeDataType.String, 2),
        new JdeField("IGRWT1", "IGRWT1", JdeDataType.String, 2),
        new JdeField("IGSEQ", "IGSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("IGALPH", "IGALPH", JdeDataType.String, 80),
        new JdeField("IGCRR", "IGCRR", JdeDataType.Numeric),
        new JdeField("IGCRCD", "IGCRCD", JdeDataType.String, 6),
        new JdeField("IGLVLA", "IGLVLA", JdeDataType.String, 6),
        new JdeField("IGNLIN", "IGNLIN", JdeDataType.Numeric),
        new JdeField("IGLNTY", "IGLNTY", JdeDataType.String, 4),
        new JdeField("IGMCU", "IGMCU", JdeDataType.String, 24),
        new JdeField("IGTRR1", "IGTRR1", JdeDataType.Numeric),
        new JdeField("IGTRR2", "IGTRR2", JdeDataType.Numeric),
        new JdeField("IGCRCM", "IGCRCM", JdeDataType.String, 2),
        new JdeField("IGAVCO", "IGAVCO", JdeDataType.Numeric),
        new JdeField("IGJELN", "IGJELN", JdeDataType.Numeric),
        new JdeField("IGJEL0", "IGJEL0", JdeDataType.Numeric),
        new JdeField("IGMATH80", "IGMATH80", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F41291Z_0", "Primary Key on IGCTID, IGJOBS, IGSEQ", new[] { "IGCTID", "IGJOBS", "IGSEQ" }, isUnique: true, isPrimaryKey: true)
    };
}
