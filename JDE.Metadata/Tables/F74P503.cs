using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74P503 - .
/// </summary>
public class F74P503 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RPDOC.
        /// </summary>
        public const string RPDOC = "RPDOC";

        /// <summary>
        /// RPDCT.
        /// </summary>
        public const string RPDCT = "RPDCT";

        /// <summary>
        /// RPKCO.
        /// </summary>
        public const string RPKCO = "RPKCO";

        /// <summary>
        /// RPP74CASF.
        /// </summary>
        public const string RPP74CASF = "RPP74CASF";

        /// <summary>
        /// RPP74SBF.
        /// </summary>
        public const string RPP74SBF = "RPP74SBF";

        /// <summary>
        /// RPP74RCMF.
        /// </summary>
        public const string RPP74RCMF = "RPP74RCMF";

        /// <summary>
        /// RPP74GVEF.
        /// </summary>
        public const string RPP74GVEF = "RPP74GVEF";

        /// <summary>
        /// RPP74AVAF.
        /// </summary>
        public const string RPP74AVAF = "RPP74AVAF";

        /// <summary>
        /// RPP74IIRF.
        /// </summary>
        public const string RPP74IIRF = "RPP74IIRF";

        /// <summary>
        /// RPP74LAA.
        /// </summary>
        public const string RPP74LAA = "RPP74LAA";

        /// <summary>
        /// RPP74LAW.
        /// </summary>
        public const string RPP74LAW = "RPP74LAW";

        /// <summary>
        /// RPP74OLA.
        /// </summary>
        public const string RPP74OLA = "RPP74OLA";

        /// <summary>
        /// RPP74AN8.
        /// </summary>
        public const string RPP74AN8 = "RPP74AN8";

        /// <summary>
        /// RPP74ANT8.
        /// </summary>
        public const string RPP74ANT8 = "RPP74ANT8";

        /// <summary>
        /// RPP74AN.
        /// </summary>
        public const string RPP74AN = "RPP74AN";

        /// <summary>
        /// RPP74INTF.
        /// </summary>
        public const string RPP74INTF = "RPP74INTF";

        /// <summary>
        /// RPP74ADNT.
        /// </summary>
        public const string RPP74ADNT = "RPP74ADNT";

        /// <summary>
        /// RPP74MNT.
        /// </summary>
        public const string RPP74MNT = "RPP74MNT";

        /// <summary>
        /// RPP74WHNT.
        /// </summary>
        public const string RPP74WHNT = "RPP74WHNT";

        /// <summary>
        /// RPP74SIIF.
        /// </summary>
        public const string RPP74SIIF = "RPP74SIIF";

        /// <summary>
        /// RPP74TCPM.
        /// </summary>
        public const string RPP74TCPM = "RPP74TCPM";

        /// <summary>
        /// RPP74UCPM.
        /// </summary>
        public const string RPP74UCPM = "RPP74UCPM";

        /// <summary>
        /// RPP74PD.
        /// </summary>
        public const string RPP74PD = "RPP74PD";

        /// <summary>
        /// RPUSER.
        /// </summary>
        public const string RPUSER = "RPUSER";

        /// <summary>
        /// RPPID.
        /// </summary>
        public const string RPPID = "RPPID";

        /// <summary>
        /// RPJOBN.
        /// </summary>
        public const string RPJOBN = "RPJOBN";

        /// <summary>
        /// RPUPMJ.
        /// </summary>
        public const string RPUPMJ = "RPUPMJ";

        /// <summary>
        /// RPUPMT.
        /// </summary>
        public const string RPUPMT = "RPUPMT";

        /// <summary>
        /// RPDATF01.
        /// </summary>
        public const string RPDATF01 = "RPDATF01";

        /// <summary>
        /// RPDEPFUT2.
        /// </summary>
        public const string RPDEPFUT2 = "RPDEPFUT2";

        /// <summary>
        /// RPACTFU1.
        /// </summary>
        public const string RPACTFU1 = "RPACTFU1";

        /// <summary>
        /// RPFLAG.
        /// </summary>
        public const string RPFLAG = "RPFLAG";

        /// <summary>
        /// RPP74DIST.
        /// </summary>
        public const string RPP74DIST = "RPP74DIST";

        /// <summary>
        /// RPP74TELS.
        /// </summary>
        public const string RPP74TELS = "RPP74TELS";

        /// <summary>
        /// RPP74ITRE.
        /// </summary>
        public const string RPP74ITRE = "RPP74ITRE";

        /// <summary>
        /// RPP74IEUA.
        /// </summary>
        public const string RPP74IEUA = "RPP74IEUA";

        /// <summary>
        /// RPP74IEUD.
        /// </summary>
        public const string RPP74IEUD = "RPP74IEUD";

        /// <summary>
        /// RPP74MTTS.
        /// </summary>
        public const string RPP74MTTS = "RPP74MTTS";

        /// <summary>
        /// RPP74MTSH.
        /// </summary>
        public const string RPP74MTSH = "RPP74MTSH";

        /// <summary>
        /// RPP74ID42.
        /// </summary>
        public const string RPP74ID42 = "RPP74ID42";

        /// <summary>
        /// RPP74ID63.
        /// </summary>
        public const string RPP74ID63 = "RPP74ID63";

        /// <summary>
        /// RPP74TXPV.
        /// </summary>
        public const string RPP74TXPV = "RPP74TXPV";

        /// <summary>
        /// RPP74GSDR.
        /// </summary>
        public const string RPP74GSDR = "RPP74GSDR";

        /// <summary>
        /// RPP74SDRB.
        /// </summary>
        public const string RPP74SDRB = "RPP74SDRB";
    }

    /// <inheritdoc />
    public override string TableName => "F74P503";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RPDOC", "RPDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("RPDCT", "RPDCT", JdeDataType.String, 4, true, true),
        new JdeField("RPKCO", "RPKCO", JdeDataType.String, 10, true, true),
        new JdeField("RPP74CASF", "RPP74CASF", JdeDataType.String, 2),
        new JdeField("RPP74SBF", "RPP74SBF", JdeDataType.String, 2),
        new JdeField("RPP74RCMF", "RPP74RCMF", JdeDataType.String, 2),
        new JdeField("RPP74GVEF", "RPP74GVEF", JdeDataType.String, 2),
        new JdeField("RPP74AVAF", "RPP74AVAF", JdeDataType.String, 2),
        new JdeField("RPP74IIRF", "RPP74IIRF", JdeDataType.String, 2),
        new JdeField("RPP74LAA", "RPP74LAA", JdeDataType.String, 80),
        new JdeField("RPP74LAW", "RPP74LAW", JdeDataType.String, 80),
        new JdeField("RPP74OLA", "RPP74OLA", JdeDataType.String, 80),
        new JdeField("RPP74AN8", "RPP74AN8", JdeDataType.Numeric),
        new JdeField("RPP74ANT8", "RPP74ANT8", JdeDataType.Numeric),
        new JdeField("RPP74AN", "RPP74AN", JdeDataType.String, 20),
        new JdeField("RPP74INTF", "RPP74INTF", JdeDataType.String, 2),
        new JdeField("RPP74ADNT", "RPP74ADNT", JdeDataType.Numeric),
        new JdeField("RPP74MNT", "RPP74MNT", JdeDataType.Numeric),
        new JdeField("RPP74WHNT", "RPP74WHNT", JdeDataType.Numeric),
        new JdeField("RPP74SIIF", "RPP74SIIF", JdeDataType.String, 2),
        new JdeField("RPP74TCPM", "RPP74TCPM", JdeDataType.String, 2),
        new JdeField("RPP74UCPM", "RPP74UCPM", JdeDataType.String, 2),
        new JdeField("RPP74PD", "RPP74PD", JdeDataType.String, 200),
        new JdeField("RPUSER", "RPUSER", JdeDataType.String, 20),
        new JdeField("RPPID", "RPPID", JdeDataType.String, 20),
        new JdeField("RPJOBN", "RPJOBN", JdeDataType.String, 20),
        new JdeField("RPUPMJ", "RPUPMJ", JdeDataType.Numeric),
        new JdeField("RPUPMT", "RPUPMT", JdeDataType.Numeric),
        new JdeField("RPDATF01", "RPDATF01", JdeDataType.Numeric),
        new JdeField("RPDEPFUT2", "RPDEPFUT2", JdeDataType.String, 60),
        new JdeField("RPACTFU1", "RPACTFU1", JdeDataType.String, 2),
        new JdeField("RPFLAG", "RPFLAG", JdeDataType.String, 2),
        new JdeField("RPP74DIST", "RPP74DIST", JdeDataType.String, 2),
        new JdeField("RPP74TELS", "RPP74TELS", JdeDataType.String, 2),
        new JdeField("RPP74ITRE", "RPP74ITRE", JdeDataType.String, 2),
        new JdeField("RPP74IEUA", "RPP74IEUA", JdeDataType.String, 2),
        new JdeField("RPP74IEUD", "RPP74IEUD", JdeDataType.String, 2),
        new JdeField("RPP74MTTS", "RPP74MTTS", JdeDataType.String, 2),
        new JdeField("RPP74MTSH", "RPP74MTSH", JdeDataType.String, 2),
        new JdeField("RPP74ID42", "RPP74ID42", JdeDataType.String, 2),
        new JdeField("RPP74ID63", "RPP74ID63", JdeDataType.String, 2),
        new JdeField("RPP74TXPV", "RPP74TXPV", JdeDataType.String, 2),
        new JdeField("RPP74GSDR", "RPP74GSDR", JdeDataType.String, 2),
        new JdeField("RPP74SDRB", "RPP74SDRB", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74P503_0", "Primary Key on RPDOC, RPDCT, RPKCO", new[] { "RPDOC", "RPDCT", "RPKCO" }, isUnique: true, isPrimaryKey: true)
    };
}
