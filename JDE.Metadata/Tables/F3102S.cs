using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F3102S - .
/// </summary>
public class F3102S : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IGDOCO.
        /// </summary>
        public const string IGDOCO = "IGDOCO";

        /// <summary>
        /// IGDCTO.
        /// </summary>
        public const string IGDCTO = "IGDCTO";

        /// <summary>
        /// IGOPSQ.
        /// </summary>
        public const string IGOPSQ = "IGOPSQ";

        /// <summary>
        /// IGITM.
        /// </summary>
        public const string IGITM = "IGITM";

        /// <summary>
        /// IGLITM.
        /// </summary>
        public const string IGLITM = "IGLITM";

        /// <summary>
        /// IGAITM.
        /// </summary>
        public const string IGAITM = "IGAITM";

        /// <summary>
        /// IGCOST.
        /// </summary>
        public const string IGCOST = "IGCOST";

        /// <summary>
        /// IGPART.
        /// </summary>
        public const string IGPART = "IGPART";

        /// <summary>
        /// IGOPUN.
        /// </summary>
        public const string IGOPUN = "IGOPUN";

        /// <summary>
        /// IGOPAT.
        /// </summary>
        public const string IGOPAT = "IGOPAT";

        /// <summary>
        /// IGCLUN.
        /// </summary>
        public const string IGCLUN = "IGCLUN";

        /// <summary>
        /// IGCLAT.
        /// </summary>
        public const string IGCLAT = "IGCLAT";

        /// <summary>
        /// IGCCCU.
        /// </summary>
        public const string IGCCCU = "IGCCCU";

        /// <summary>
        /// IGCCCA.
        /// </summary>
        public const string IGCCCA = "IGCCCA";

        /// <summary>
        /// IGPLUN.
        /// </summary>
        public const string IGPLUN = "IGPLUN";

        /// <summary>
        /// IGPLAT.
        /// </summary>
        public const string IGPLAT = "IGPLAT";

        /// <summary>
        /// IGCPUN.
        /// </summary>
        public const string IGCPUN = "IGCPUN";

        /// <summary>
        /// IGCPAT.
        /// </summary>
        public const string IGCPAT = "IGCPAT";

        /// <summary>
        /// IGSLUN.
        /// </summary>
        public const string IGSLUN = "IGSLUN";

        /// <summary>
        /// IGSLAT.
        /// </summary>
        public const string IGSLAT = "IGSLAT";

        /// <summary>
        /// IGCCUU.
        /// </summary>
        public const string IGCCUU = "IGCCUU";

        /// <summary>
        /// IGCCUA.
        /// </summary>
        public const string IGCCUA = "IGCCUA";

        /// <summary>
        /// IGUNPU.
        /// </summary>
        public const string IGUNPU = "IGUNPU";

        /// <summary>
        /// IGUNPA.
        /// </summary>
        public const string IGUNPA = "IGUNPA";

        /// <summary>
        /// IGUOM.
        /// </summary>
        public const string IGUOM = "IGUOM";

        /// <summary>
        /// IGUSER.
        /// </summary>
        public const string IGUSER = "IGUSER";

        /// <summary>
        /// IGPID.
        /// </summary>
        public const string IGPID = "IGPID";

        /// <summary>
        /// IGUPMJ.
        /// </summary>
        public const string IGUPMJ = "IGUPMJ";

        /// <summary>
        /// IGTDAY.
        /// </summary>
        public const string IGTDAY = "IGTDAY";

        /// <summary>
        /// IGJOBN.
        /// </summary>
        public const string IGJOBN = "IGJOBN";

        /// <summary>
        /// IGMCU.
        /// </summary>
        public const string IGMCU = "IGMCU";

        /// <summary>
        /// IGWMCU.
        /// </summary>
        public const string IGWMCU = "IGWMCU";

        /// <summary>
        /// IGMMCU.
        /// </summary>
        public const string IGMMCU = "IGMMCU";

        /// <summary>
        /// IGFORQ.
        /// </summary>
        public const string IGFORQ = "IGFORQ";

        /// <summary>
        /// IGENGV.
        /// </summary>
        public const string IGENGV = "IGENGV";

        /// <summary>
        /// IGPLNV.
        /// </summary>
        public const string IGPLNV = "IGPLNV";

        /// <summary>
        /// IGVACT.
        /// </summary>
        public const string IGVACT = "IGVACT";

        /// <summary>
        /// IGOTHV.
        /// </summary>
        public const string IGOTHV = "IGOTHV";

        /// <summary>
        /// IGNETV.
        /// </summary>
        public const string IGNETV = "IGNETV";

        /// <summary>
        /// IGSCRP.
        /// </summary>
        public const string IGSCRP = "IGSCRP";

        /// <summary>
        /// IGSCTC.
        /// </summary>
        public const string IGSCTC = "IGSCTC";

        /// <summary>
        /// IGSTFC.
        /// </summary>
        public const string IGSTFC = "IGSTFC";

        /// <summary>
        /// IGRATS.
        /// </summary>
        public const string IGRATS = "IGRATS";

        /// <summary>
        /// IGRTSD.
        /// </summary>
        public const string IGRTSD = "IGRTSD";
    }

    /// <inheritdoc />
    public override string TableName => "F3102S";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IGDOCO", "IGDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("IGDCTO", "IGDCTO", JdeDataType.String, 4),
        new JdeField("IGOPSQ", "IGOPSQ", JdeDataType.Numeric),
        new JdeField("IGITM", "IGITM", JdeDataType.Numeric, null, true, true),
        new JdeField("IGLITM", "IGLITM", JdeDataType.String, 50),
        new JdeField("IGAITM", "IGAITM", JdeDataType.String, 50),
        new JdeField("IGCOST", "IGCOST", JdeDataType.String, 6, true, true),
        new JdeField("IGPART", "IGPART", JdeDataType.String, 2, true, true),
        new JdeField("IGOPUN", "IGOPUN", JdeDataType.Numeric),
        new JdeField("IGOPAT", "IGOPAT", JdeDataType.Numeric),
        new JdeField("IGCLUN", "IGCLUN", JdeDataType.Numeric),
        new JdeField("IGCLAT", "IGCLAT", JdeDataType.Numeric),
        new JdeField("IGCCCU", "IGCCCU", JdeDataType.Numeric),
        new JdeField("IGCCCA", "IGCCCA", JdeDataType.Numeric),
        new JdeField("IGPLUN", "IGPLUN", JdeDataType.Numeric),
        new JdeField("IGPLAT", "IGPLAT", JdeDataType.Numeric),
        new JdeField("IGCPUN", "IGCPUN", JdeDataType.Numeric),
        new JdeField("IGCPAT", "IGCPAT", JdeDataType.Numeric),
        new JdeField("IGSLUN", "IGSLUN", JdeDataType.Numeric),
        new JdeField("IGSLAT", "IGSLAT", JdeDataType.Numeric),
        new JdeField("IGCCUU", "IGCCUU", JdeDataType.Numeric),
        new JdeField("IGCCUA", "IGCCUA", JdeDataType.Numeric),
        new JdeField("IGUNPU", "IGUNPU", JdeDataType.Numeric),
        new JdeField("IGUNPA", "IGUNPA", JdeDataType.Numeric),
        new JdeField("IGUOM", "IGUOM", JdeDataType.String, 4),
        new JdeField("IGUSER", "IGUSER", JdeDataType.String, 20),
        new JdeField("IGPID", "IGPID", JdeDataType.String, 20),
        new JdeField("IGUPMJ", "IGUPMJ", JdeDataType.Numeric),
        new JdeField("IGTDAY", "IGTDAY", JdeDataType.Numeric),
        new JdeField("IGJOBN", "IGJOBN", JdeDataType.String, 20),
        new JdeField("IGMCU", "IGMCU", JdeDataType.String, 24, true, true),
        new JdeField("IGWMCU", "IGWMCU", JdeDataType.String, 24),
        new JdeField("IGMMCU", "IGMMCU", JdeDataType.String, 24),
        new JdeField("IGFORQ", "IGFORQ", JdeDataType.String, 2),
        new JdeField("IGENGV", "IGENGV", JdeDataType.Numeric),
        new JdeField("IGPLNV", "IGPLNV", JdeDataType.Numeric),
        new JdeField("IGVACT", "IGVACT", JdeDataType.Numeric),
        new JdeField("IGOTHV", "IGOTHV", JdeDataType.Numeric),
        new JdeField("IGNETV", "IGNETV", JdeDataType.Numeric),
        new JdeField("IGSCRP", "IGSCRP", JdeDataType.Numeric),
        new JdeField("IGSCTC", "IGSCTC", JdeDataType.String, 8),
        new JdeField("IGSTFC", "IGSTFC", JdeDataType.Numeric),
        new JdeField("IGRATS", "IGRATS", JdeDataType.String, 8),
        new JdeField("IGRTSD", "IGRTSD", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F3102S_0", "Primary Key on IGDOCO, IGITM, IGCOST, IGPART, IGMCU", new[] { "IGDOCO", "IGITM", "IGCOST", "IGPART", "IGMCU" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F3102S_1", "Index on IGDOCO, IGPART, IGITM, IGCOST", new[] { "IGDOCO", "IGPART", "IGITM", "IGCOST" }),
        new JdeIndex("F3102S_2", "Index on IGDOCO, IGITM, IGCOST", new[] { "IGDOCO", "IGITM", "IGCOST" })
    };
}
