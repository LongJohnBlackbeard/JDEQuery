using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F15151 - .
/// </summary>
public class F15151 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CDCAPID.
        /// </summary>
        public const string CDCAPID = "CDCAPID";

        /// <summary>
        /// CDMCU.
        /// </summary>
        public const string CDMCU = "CDMCU";

        /// <summary>
        /// CDSEQ.
        /// </summary>
        public const string CDSEQ = "CDSEQ";

        /// <summary>
        /// CDCAPBASA.
        /// </summary>
        public const string CDCAPBASA = "CDCAPBASA";

        /// <summary>
        /// CDCAPBASY.
        /// </summary>
        public const string CDCAPBASY = "CDCAPBASY";

        /// <summary>
        /// CDCAPFLOR.
        /// </summary>
        public const string CDCAPFLOR = "CDCAPFLOR";

        /// <summary>
        /// CDCAPCEIL.
        /// </summary>
        public const string CDCAPCEIL = "CDCAPCEIL";

        /// <summary>
        /// CDAMTYP.
        /// </summary>
        public const string CDAMTYP = "CDAMTYP";

        /// <summary>
        /// CDCAPAREA.
        /// </summary>
        public const string CDCAPAREA = "CDCAPAREA";

        /// <summary>
        /// CDCAPFIXED.
        /// </summary>
        public const string CDCAPFIXED = "CDCAPFIXED";

        /// <summary>
        /// CDCAPFREQ.
        /// </summary>
        public const string CDCAPFREQ = "CDCAPFREQ";

        /// <summary>
        /// CDCAPPCBAS.
        /// </summary>
        public const string CDCAPPCBAS = "CDCAPPCBAS";

        /// <summary>
        /// CDCRCD.
        /// </summary>
        public const string CDCRCD = "CDCRCD";

        /// <summary>
        /// CDURCD.
        /// </summary>
        public const string CDURCD = "CDURCD";

        /// <summary>
        /// CDURDT.
        /// </summary>
        public const string CDURDT = "CDURDT";

        /// <summary>
        /// CDURAT.
        /// </summary>
        public const string CDURAT = "CDURAT";

        /// <summary>
        /// CDURAB.
        /// </summary>
        public const string CDURAB = "CDURAB";

        /// <summary>
        /// CDURRF.
        /// </summary>
        public const string CDURRF = "CDURRF";

        /// <summary>
        /// CDUSER.
        /// </summary>
        public const string CDUSER = "CDUSER";

        /// <summary>
        /// CDPID.
        /// </summary>
        public const string CDPID = "CDPID";

        /// <summary>
        /// CDMKEY.
        /// </summary>
        public const string CDMKEY = "CDMKEY";

        /// <summary>
        /// CDUPMJ.
        /// </summary>
        public const string CDUPMJ = "CDUPMJ";

        /// <summary>
        /// CDUPMT.
        /// </summary>
        public const string CDUPMT = "CDUPMT";

        /// <summary>
        /// CDTORG.
        /// </summary>
        public const string CDTORG = "CDTORG";

        /// <summary>
        /// CDENTJ.
        /// </summary>
        public const string CDENTJ = "CDENTJ";

        /// <summary>
        /// CDCAPEFF.
        /// </summary>
        public const string CDCAPEFF = "CDCAPEFF";

        /// <summary>
        /// CDCAPEND.
        /// </summary>
        public const string CDCAPEND = "CDCAPEND";

        /// <summary>
        /// CDCAPPCT.
        /// </summary>
        public const string CDCAPPCT = "CDCAPPCT";
    }

    /// <inheritdoc />
    public override string TableName => "F15151";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CDCAPID", "CDCAPID", JdeDataType.String, 20, true, true),
        new JdeField("CDMCU", "CDMCU", JdeDataType.String, 24, true, true),
        new JdeField("CDSEQ", "CDSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("CDCAPBASA", "CDCAPBASA", JdeDataType.Numeric),
        new JdeField("CDCAPBASY", "CDCAPBASY", JdeDataType.Numeric),
        new JdeField("CDCAPFLOR", "CDCAPFLOR", JdeDataType.Numeric),
        new JdeField("CDCAPCEIL", "CDCAPCEIL", JdeDataType.Numeric),
        new JdeField("CDAMTYP", "CDAMTYP", JdeDataType.String, 2),
        new JdeField("CDCAPAREA", "CDCAPAREA", JdeDataType.Numeric),
        new JdeField("CDCAPFIXED", "CDCAPFIXED", JdeDataType.Numeric),
        new JdeField("CDCAPFREQ", "CDCAPFREQ", JdeDataType.Numeric),
        new JdeField("CDCAPPCBAS", "CDCAPPCBAS", JdeDataType.Numeric),
        new JdeField("CDCRCD", "CDCRCD", JdeDataType.String, 6),
        new JdeField("CDURCD", "CDURCD", JdeDataType.String, 4),
        new JdeField("CDURDT", "CDURDT", JdeDataType.Numeric),
        new JdeField("CDURAT", "CDURAT", JdeDataType.Numeric),
        new JdeField("CDURAB", "CDURAB", JdeDataType.Numeric),
        new JdeField("CDURRF", "CDURRF", JdeDataType.String, 30),
        new JdeField("CDUSER", "CDUSER", JdeDataType.String, 20),
        new JdeField("CDPID", "CDPID", JdeDataType.String, 20),
        new JdeField("CDMKEY", "CDMKEY", JdeDataType.String, 30),
        new JdeField("CDUPMJ", "CDUPMJ", JdeDataType.Numeric),
        new JdeField("CDUPMT", "CDUPMT", JdeDataType.Numeric),
        new JdeField("CDTORG", "CDTORG", JdeDataType.String, 20),
        new JdeField("CDENTJ", "CDENTJ", JdeDataType.Numeric),
        new JdeField("CDCAPEFF", "CDCAPEFF", JdeDataType.Numeric),
        new JdeField("CDCAPEND", "CDCAPEND", JdeDataType.Numeric),
        new JdeField("CDCAPPCT", "CDCAPPCT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F15151_0", "Primary Key on CDCAPID, CDMCU, CDSEQ", new[] { "CDCAPID", "CDMCU", "CDSEQ" }, isUnique: true, isPrimaryKey: true)
    };
}
