using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4133 - .
/// </summary>
public class F4133 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// UDUNUM.
        /// </summary>
        public const string UDUNUM = "UDUNUM";

        /// <summary>
        /// UDLINN.
        /// </summary>
        public const string UDLINN = "UDLINN";

        /// <summary>
        /// UDUSP.
        /// </summary>
        public const string UDUSP = "UDUSP";

        /// <summary>
        /// UDCONMCU.
        /// </summary>
        public const string UDCONMCU = "UDCONMCU";

        /// <summary>
        /// UDMCU.
        /// </summary>
        public const string UDMCU = "UDMCU";

        /// <summary>
        /// UDVR01.
        /// </summary>
        public const string UDVR01 = "UDVR01";

        /// <summary>
        /// UDITM.
        /// </summary>
        public const string UDITM = "UDITM";

        /// <summary>
        /// UDQTYCC.
        /// </summary>
        public const string UDQTYCC = "UDQTYCC";

        /// <summary>
        /// UDQTYOHC.
        /// </summary>
        public const string UDQTYOHC = "UDQTYOHC";

        /// <summary>
        /// UDUOM.
        /// </summary>
        public const string UDUOM = "UDUOM";

        /// <summary>
        /// UDQTYCC2.
        /// </summary>
        public const string UDQTYCC2 = "UDQTYCC2";

        /// <summary>
        /// UDQTYOHC2.
        /// </summary>
        public const string UDQTYOHC2 = "UDQTYOHC2";

        /// <summary>
        /// UDUOM2.
        /// </summary>
        public const string UDUOM2 = "UDUOM2";

        /// <summary>
        /// UDCONDATE.
        /// </summary>
        public const string UDCONDATE = "UDCONDATE";

        /// <summary>
        /// UDLOTN.
        /// </summary>
        public const string UDLOTN = "UDLOTN";

        /// <summary>
        /// UDOCCARDNO.
        /// </summary>
        public const string UDOCCARDNO = "UDOCCARDNO";

        /// <summary>
        /// UDRCD.
        /// </summary>
        public const string UDRCD = "UDRCD";

        /// <summary>
        /// UDTRKIT.
        /// </summary>
        public const string UDTRKIT = "UDTRKIT";

        /// <summary>
        /// UDCRMCU.
        /// </summary>
        public const string UDCRMCU = "UDCRMCU";

        /// <summary>
        /// UDBRPC.
        /// </summary>
        public const string UDBRPC = "UDBRPC";

        /// <summary>
        /// UDUNCS.
        /// </summary>
        public const string UDUNCS = "UDUNCS";

        /// <summary>
        /// UDPAID.
        /// </summary>
        public const string UDPAID = "UDPAID";

        /// <summary>
        /// UDAUNCS.
        /// </summary>
        public const string UDAUNCS = "UDAUNCS";

        /// <summary>
        /// UDAPAID.
        /// </summary>
        public const string UDAPAID = "UDAPAID";

        /// <summary>
        /// UDCBDOCO.
        /// </summary>
        public const string UDCBDOCO = "UDCBDOCO";

        /// <summary>
        /// UDCBDCTO.
        /// </summary>
        public const string UDCBDCTO = "UDCBDCTO";

        /// <summary>
        /// UDCBKCOO.
        /// </summary>
        public const string UDCBKCOO = "UDCBKCOO";

        /// <summary>
        /// UDCSDOCO.
        /// </summary>
        public const string UDCSDOCO = "UDCSDOCO";

        /// <summary>
        /// UDCSDCTO.
        /// </summary>
        public const string UDCSDCTO = "UDCSDCTO";

        /// <summary>
        /// UDCSKCOO.
        /// </summary>
        public const string UDCSKCOO = "UDCSKCOO";

        /// <summary>
        /// UDCRDOCO.
        /// </summary>
        public const string UDCRDOCO = "UDCRDOCO";

        /// <summary>
        /// UDCRDCTO.
        /// </summary>
        public const string UDCRDCTO = "UDCRDCTO";

        /// <summary>
        /// UDCRKCOO.
        /// </summary>
        public const string UDCRKCOO = "UDCRKCOO";

        /// <summary>
        /// UDCIDOC.
        /// </summary>
        public const string UDCIDOC = "UDCIDOC";

        /// <summary>
        /// UDCIDCT.
        /// </summary>
        public const string UDCIDCT = "UDCIDCT";

        /// <summary>
        /// UDCIKCO.
        /// </summary>
        public const string UDCIKCO = "UDCIKCO";

        /// <summary>
        /// UDURCD.
        /// </summary>
        public const string UDURCD = "UDURCD";

        /// <summary>
        /// UDURDT.
        /// </summary>
        public const string UDURDT = "UDURDT";

        /// <summary>
        /// UDURAT.
        /// </summary>
        public const string UDURAT = "UDURAT";

        /// <summary>
        /// UDURAB.
        /// </summary>
        public const string UDURAB = "UDURAB";

        /// <summary>
        /// UDURRF.
        /// </summary>
        public const string UDURRF = "UDURRF";

        /// <summary>
        /// UDURNUM01.
        /// </summary>
        public const string UDURNUM01 = "UDURNUM01";

        /// <summary>
        /// UDURNUM02.
        /// </summary>
        public const string UDURNUM02 = "UDURNUM02";

        /// <summary>
        /// UDUR06.
        /// </summary>
        public const string UDUR06 = "UDUR06";

        /// <summary>
        /// UDUR07.
        /// </summary>
        public const string UDUR07 = "UDUR07";

        /// <summary>
        /// UDUSER.
        /// </summary>
        public const string UDUSER = "UDUSER";

        /// <summary>
        /// UDPID.
        /// </summary>
        public const string UDPID = "UDPID";

        /// <summary>
        /// UDJOBN.
        /// </summary>
        public const string UDJOBN = "UDJOBN";

        /// <summary>
        /// UDUTIME.
        /// </summary>
        public const string UDUTIME = "UDUTIME";
    }

    /// <inheritdoc />
    public override string TableName => "F4133";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("UDUNUM", "UDUNUM", JdeDataType.Numeric, null, true, true),
        new JdeField("UDLINN", "UDLINN", JdeDataType.Numeric, null, true, true),
        new JdeField("UDUSP", "UDUSP", JdeDataType.String, 2),
        new JdeField("UDCONMCU", "UDCONMCU", JdeDataType.String, 24),
        new JdeField("UDMCU", "UDMCU", JdeDataType.String, 24),
        new JdeField("UDVR01", "UDVR01", JdeDataType.String, 50),
        new JdeField("UDITM", "UDITM", JdeDataType.Numeric),
        new JdeField("UDQTYCC", "UDQTYCC", JdeDataType.Numeric),
        new JdeField("UDQTYOHC", "UDQTYOHC", JdeDataType.Numeric),
        new JdeField("UDUOM", "UDUOM", JdeDataType.String, 4),
        new JdeField("UDQTYCC2", "UDQTYCC2", JdeDataType.Numeric),
        new JdeField("UDQTYOHC2", "UDQTYOHC2", JdeDataType.Numeric),
        new JdeField("UDUOM2", "UDUOM2", JdeDataType.String, 4),
        new JdeField("UDCONDATE", "UDCONDATE", JdeDataType.Numeric),
        new JdeField("UDLOTN", "UDLOTN", JdeDataType.String, 60),
        new JdeField("UDOCCARDNO", "UDOCCARDNO", JdeDataType.Numeric),
        new JdeField("UDRCD", "UDRCD", JdeDataType.String, 6),
        new JdeField("UDTRKIT", "UDTRKIT", JdeDataType.String, 2),
        new JdeField("UDCRMCU", "UDCRMCU", JdeDataType.String, 24),
        new JdeField("UDBRPC", "UDBRPC", JdeDataType.String, 2),
        new JdeField("UDUNCS", "UDUNCS", JdeDataType.Numeric),
        new JdeField("UDPAID", "UDPAID", JdeDataType.Numeric),
        new JdeField("UDAUNCS", "UDAUNCS", JdeDataType.Numeric),
        new JdeField("UDAPAID", "UDAPAID", JdeDataType.Numeric),
        new JdeField("UDCBDOCO", "UDCBDOCO", JdeDataType.Numeric),
        new JdeField("UDCBDCTO", "UDCBDCTO", JdeDataType.String, 4),
        new JdeField("UDCBKCOO", "UDCBKCOO", JdeDataType.String, 10),
        new JdeField("UDCSDOCO", "UDCSDOCO", JdeDataType.Numeric),
        new JdeField("UDCSDCTO", "UDCSDCTO", JdeDataType.String, 4),
        new JdeField("UDCSKCOO", "UDCSKCOO", JdeDataType.String, 10),
        new JdeField("UDCRDOCO", "UDCRDOCO", JdeDataType.Numeric),
        new JdeField("UDCRDCTO", "UDCRDCTO", JdeDataType.String, 4),
        new JdeField("UDCRKCOO", "UDCRKCOO", JdeDataType.String, 10),
        new JdeField("UDCIDOC", "UDCIDOC", JdeDataType.Numeric),
        new JdeField("UDCIDCT", "UDCIDCT", JdeDataType.String, 4),
        new JdeField("UDCIKCO", "UDCIKCO", JdeDataType.String, 10),
        new JdeField("UDURCD", "UDURCD", JdeDataType.String, 4),
        new JdeField("UDURDT", "UDURDT", JdeDataType.Numeric),
        new JdeField("UDURAT", "UDURAT", JdeDataType.Numeric),
        new JdeField("UDURAB", "UDURAB", JdeDataType.Numeric),
        new JdeField("UDURRF", "UDURRF", JdeDataType.String, 30),
        new JdeField("UDURNUM01", "UDURNUM01", JdeDataType.Numeric),
        new JdeField("UDURNUM02", "UDURNUM02", JdeDataType.Numeric),
        new JdeField("UDUR06", "UDUR06", JdeDataType.String, 20),
        new JdeField("UDUR07", "UDUR07", JdeDataType.String, 20),
        new JdeField("UDUSER", "UDUSER", JdeDataType.String, 20),
        new JdeField("UDPID", "UDPID", JdeDataType.String, 20),
        new JdeField("UDJOBN", "UDJOBN", JdeDataType.String, 20),
        new JdeField("UDUTIME", "UDUTIME", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4133_0", "Primary Key on UDUNUM, UDLINN", new[] { "UDUNUM", "UDLINN" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F4133_2", "Index on UDUNUM, UDMCU", new[] { "UDUNUM", "UDMCU" }),
        new JdeIndex("F4133_3", "Index on UDUNUM, SYS_NC00050$", new[] { "UDUNUM", "SYS_NC00050$" }),
        new JdeIndex("F4133_4", "Index on UDUSP, UDCONMCU, UDITM", new[] { "UDUSP", "UDCONMCU", "UDITM" })
    };
}
