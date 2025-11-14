using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74P507 - .
/// </summary>
public class F74P507 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RVKCO.
        /// </summary>
        public const string RVKCO = "RVKCO";

        /// <summary>
        /// RVDCT.
        /// </summary>
        public const string RVDCT = "RVDCT";

        /// <summary>
        /// RVDOC.
        /// </summary>
        public const string RVDOC = "RVDOC";

        /// <summary>
        /// RVP74CASF.
        /// </summary>
        public const string RVP74CASF = "RVP74CASF";

        /// <summary>
        /// RVP74SBF.
        /// </summary>
        public const string RVP74SBF = "RVP74SBF";

        /// <summary>
        /// RVP74RCMF.
        /// </summary>
        public const string RVP74RCMF = "RVP74RCMF";

        /// <summary>
        /// RVP74GVEF.
        /// </summary>
        public const string RVP74GVEF = "RVP74GVEF";

        /// <summary>
        /// RVP74AVAF.
        /// </summary>
        public const string RVP74AVAF = "RVP74AVAF";

        /// <summary>
        /// RVP74IIRF.
        /// </summary>
        public const string RVP74IIRF = "RVP74IIRF";

        /// <summary>
        /// RVP74LAA.
        /// </summary>
        public const string RVP74LAA = "RVP74LAA";

        /// <summary>
        /// RVP74LAW.
        /// </summary>
        public const string RVP74LAW = "RVP74LAW";

        /// <summary>
        /// RVP74OLA.
        /// </summary>
        public const string RVP74OLA = "RVP74OLA";

        /// <summary>
        /// RVP74AN8.
        /// </summary>
        public const string RVP74AN8 = "RVP74AN8";

        /// <summary>
        /// RVP74ANT8.
        /// </summary>
        public const string RVP74ANT8 = "RVP74ANT8";

        /// <summary>
        /// RVP74AN.
        /// </summary>
        public const string RVP74AN = "RVP74AN";

        /// <summary>
        /// RVP74INTF.
        /// </summary>
        public const string RVP74INTF = "RVP74INTF";

        /// <summary>
        /// RVP74ADNT.
        /// </summary>
        public const string RVP74ADNT = "RVP74ADNT";

        /// <summary>
        /// RVP74MNT.
        /// </summary>
        public const string RVP74MNT = "RVP74MNT";

        /// <summary>
        /// RVP74WHNT.
        /// </summary>
        public const string RVP74WHNT = "RVP74WHNT";

        /// <summary>
        /// RVP74SIIF.
        /// </summary>
        public const string RVP74SIIF = "RVP74SIIF";

        /// <summary>
        /// RVP74TCPM.
        /// </summary>
        public const string RVP74TCPM = "RVP74TCPM";

        /// <summary>
        /// RVP74UCPM.
        /// </summary>
        public const string RVP74UCPM = "RVP74UCPM";

        /// <summary>
        /// RVP74PD.
        /// </summary>
        public const string RVP74PD = "RVP74PD";

        /// <summary>
        /// RVUSER.
        /// </summary>
        public const string RVUSER = "RVUSER";

        /// <summary>
        /// RVPID.
        /// </summary>
        public const string RVPID = "RVPID";

        /// <summary>
        /// RVJOBN.
        /// </summary>
        public const string RVJOBN = "RVJOBN";

        /// <summary>
        /// RVUPMJ.
        /// </summary>
        public const string RVUPMJ = "RVUPMJ";

        /// <summary>
        /// RVUPMT.
        /// </summary>
        public const string RVUPMT = "RVUPMT";

        /// <summary>
        /// RVDATF01.
        /// </summary>
        public const string RVDATF01 = "RVDATF01";

        /// <summary>
        /// RVDEPFUT2.
        /// </summary>
        public const string RVDEPFUT2 = "RVDEPFUT2";

        /// <summary>
        /// RVACTFU1.
        /// </summary>
        public const string RVACTFU1 = "RVACTFU1";

        /// <summary>
        /// RVFLAG.
        /// </summary>
        public const string RVFLAG = "RVFLAG";

        /// <summary>
        /// RVP74DIST.
        /// </summary>
        public const string RVP74DIST = "RVP74DIST";

        /// <summary>
        /// RVP74TELS.
        /// </summary>
        public const string RVP74TELS = "RVP74TELS";

        /// <summary>
        /// RVP74ITRE.
        /// </summary>
        public const string RVP74ITRE = "RVP74ITRE";

        /// <summary>
        /// RVP74IEUA.
        /// </summary>
        public const string RVP74IEUA = "RVP74IEUA";

        /// <summary>
        /// RVP74IEUD.
        /// </summary>
        public const string RVP74IEUD = "RVP74IEUD";

        /// <summary>
        /// RVP74MTTS.
        /// </summary>
        public const string RVP74MTTS = "RVP74MTTS";

        /// <summary>
        /// RVP74MTSH.
        /// </summary>
        public const string RVP74MTSH = "RVP74MTSH";

        /// <summary>
        /// RVP74ID42.
        /// </summary>
        public const string RVP74ID42 = "RVP74ID42";

        /// <summary>
        /// RVP74ID63.
        /// </summary>
        public const string RVP74ID63 = "RVP74ID63";

        /// <summary>
        /// RVP74TXPV.
        /// </summary>
        public const string RVP74TXPV = "RVP74TXPV";

        /// <summary>
        /// RVP74GSDR.
        /// </summary>
        public const string RVP74GSDR = "RVP74GSDR";

        /// <summary>
        /// RVP74SDRB.
        /// </summary>
        public const string RVP74SDRB = "RVP74SDRB";
    }

    /// <inheritdoc />
    public override string TableName => "F74P507";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RVKCO", "RVKCO", JdeDataType.String, 10, true, true),
        new JdeField("RVDCT", "RVDCT", JdeDataType.String, 4, true, true),
        new JdeField("RVDOC", "RVDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("RVP74CASF", "RVP74CASF", JdeDataType.String, 2),
        new JdeField("RVP74SBF", "RVP74SBF", JdeDataType.String, 2),
        new JdeField("RVP74RCMF", "RVP74RCMF", JdeDataType.String, 2),
        new JdeField("RVP74GVEF", "RVP74GVEF", JdeDataType.String, 2),
        new JdeField("RVP74AVAF", "RVP74AVAF", JdeDataType.String, 2),
        new JdeField("RVP74IIRF", "RVP74IIRF", JdeDataType.String, 2),
        new JdeField("RVP74LAA", "RVP74LAA", JdeDataType.String, 80),
        new JdeField("RVP74LAW", "RVP74LAW", JdeDataType.String, 80),
        new JdeField("RVP74OLA", "RVP74OLA", JdeDataType.String, 80),
        new JdeField("RVP74AN8", "RVP74AN8", JdeDataType.Numeric),
        new JdeField("RVP74ANT8", "RVP74ANT8", JdeDataType.Numeric),
        new JdeField("RVP74AN", "RVP74AN", JdeDataType.String, 20),
        new JdeField("RVP74INTF", "RVP74INTF", JdeDataType.String, 2),
        new JdeField("RVP74ADNT", "RVP74ADNT", JdeDataType.Numeric),
        new JdeField("RVP74MNT", "RVP74MNT", JdeDataType.Numeric),
        new JdeField("RVP74WHNT", "RVP74WHNT", JdeDataType.Numeric),
        new JdeField("RVP74SIIF", "RVP74SIIF", JdeDataType.String, 2),
        new JdeField("RVP74TCPM", "RVP74TCPM", JdeDataType.String, 2),
        new JdeField("RVP74UCPM", "RVP74UCPM", JdeDataType.String, 2),
        new JdeField("RVP74PD", "RVP74PD", JdeDataType.String, 200),
        new JdeField("RVUSER", "RVUSER", JdeDataType.String, 20),
        new JdeField("RVPID", "RVPID", JdeDataType.String, 20),
        new JdeField("RVJOBN", "RVJOBN", JdeDataType.String, 20),
        new JdeField("RVUPMJ", "RVUPMJ", JdeDataType.Numeric),
        new JdeField("RVUPMT", "RVUPMT", JdeDataType.Numeric),
        new JdeField("RVDATF01", "RVDATF01", JdeDataType.Numeric),
        new JdeField("RVDEPFUT2", "RVDEPFUT2", JdeDataType.String, 60),
        new JdeField("RVACTFU1", "RVACTFU1", JdeDataType.String, 2),
        new JdeField("RVFLAG", "RVFLAG", JdeDataType.String, 2),
        new JdeField("RVP74DIST", "RVP74DIST", JdeDataType.String, 2),
        new JdeField("RVP74TELS", "RVP74TELS", JdeDataType.String, 2),
        new JdeField("RVP74ITRE", "RVP74ITRE", JdeDataType.String, 2),
        new JdeField("RVP74IEUA", "RVP74IEUA", JdeDataType.String, 2),
        new JdeField("RVP74IEUD", "RVP74IEUD", JdeDataType.String, 2),
        new JdeField("RVP74MTTS", "RVP74MTTS", JdeDataType.String, 2),
        new JdeField("RVP74MTSH", "RVP74MTSH", JdeDataType.String, 2),
        new JdeField("RVP74ID42", "RVP74ID42", JdeDataType.String, 2),
        new JdeField("RVP74ID63", "RVP74ID63", JdeDataType.String, 2),
        new JdeField("RVP74TXPV", "RVP74TXPV", JdeDataType.String, 2),
        new JdeField("RVP74GSDR", "RVP74GSDR", JdeDataType.String, 2),
        new JdeField("RVP74SDRB", "RVP74SDRB", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74P507_0", "Primary Key on RVDOC, RVKCO, RVDCT", new[] { "RVDOC", "RVKCO", "RVDCT" }, isUnique: true, isPrimaryKey: true)
    };
}
