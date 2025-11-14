using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F04572 - .
/// </summary>
public class F04572 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// KKHDC.
        /// </summary>
        public const string KKHDC = "KKHDC";

        /// <summary>
        /// KKCKC.
        /// </summary>
        public const string KKCKC = "KKCKC";

        /// <summary>
        /// KKPSEL.
        /// </summary>
        public const string KKPSEL = "KKPSEL";

        /// <summary>
        /// KKPGMP.
        /// </summary>
        public const string KKPGMP = "KKPGMP";

        /// <summary>
        /// KKCHKQ.
        /// </summary>
        public const string KKCHKQ = "KKCHKQ";

        /// <summary>
        /// KKGLBA.
        /// </summary>
        public const string KKGLBA = "KKGLBA";

        /// <summary>
        /// KKCRCD.
        /// </summary>
        public const string KKCRCD = "KKCRCD";

        /// <summary>
        /// KKPST.
        /// </summary>
        public const string KKPST = "KKPST";

        /// <summary>
        /// KKDOCM.
        /// </summary>
        public const string KKDOCM = "KKDOCM";

        /// <summary>
        /// KKDCTM.
        /// </summary>
        public const string KKDCTM = "KKDCTM";

        /// <summary>
        /// KKPSTT.
        /// </summary>
        public const string KKPSTT = "KKPSTT";

        /// <summary>
        /// KKPYE.
        /// </summary>
        public const string KKPYE = "KKPYE";

        /// <summary>
        /// KKALPP.
        /// </summary>
        public const string KKALPP = "KKALPP";

        /// <summary>
        /// KKAN8.
        /// </summary>
        public const string KKAN8 = "KKAN8";

        /// <summary>
        /// KKALPH.
        /// </summary>
        public const string KKALPH = "KKALPH";

        /// <summary>
        /// KKCRC.
        /// </summary>
        public const string KKCRC = "KKCRC";

        /// <summary>
        /// KKATT.
        /// </summary>
        public const string KKATT = "KKATT";

        /// <summary>
        /// KKSTUB.
        /// </summary>
        public const string KKSTUB = "KKSTUB";

        /// <summary>
        /// KKDETL.
        /// </summary>
        public const string KKDETL = "KKDETL";

        /// <summary>
        /// KKCO.
        /// </summary>
        public const string KKCO = "KKCO";

        /// <summary>
        /// KKTNST.
        /// </summary>
        public const string KKTNST = "KKTNST";

        /// <summary>
        /// KKCBNK.
        /// </summary>
        public const string KKCBNK = "KKCBNK";

        /// <summary>
        /// KKCHKD.
        /// </summary>
        public const string KKCHKD = "KKCHKD";

        /// <summary>
        /// KKDL01.
        /// </summary>
        public const string KKDL01 = "KKDL01";

        /// <summary>
        /// KKADSA.
        /// </summary>
        public const string KKADSA = "KKADSA";

        /// <summary>
        /// KKPAAP.
        /// </summary>
        public const string KKPAAP = "KKPAAP";

        /// <summary>
        /// KKDGJ.
        /// </summary>
        public const string KKDGJ = "KKDGJ";

        /// <summary>
        /// KKPYTY.
        /// </summary>
        public const string KKPYTY = "KKPYTY";

        /// <summary>
        /// KKVLDT.
        /// </summary>
        public const string KKVLDT = "KKVLDT";

        /// <summary>
        /// KKBPDJ.
        /// </summary>
        public const string KKBPDJ = "KKBPDJ";

        /// <summary>
        /// KKBXDJ.
        /// </summary>
        public const string KKBXDJ = "KKBXDJ";

        /// <summary>
        /// KKAC01.
        /// </summary>
        public const string KKAC01 = "KKAC01";

        /// <summary>
        /// KKAC02.
        /// </summary>
        public const string KKAC02 = "KKAC02";

        /// <summary>
        /// KKAC03.
        /// </summary>
        public const string KKAC03 = "KKAC03";

        /// <summary>
        /// KKAC04.
        /// </summary>
        public const string KKAC04 = "KKAC04";

        /// <summary>
        /// KKAC05.
        /// </summary>
        public const string KKAC05 = "KKAC05";

        /// <summary>
        /// KKRMK.
        /// </summary>
        public const string KKRMK = "KKRMK";

        /// <summary>
        /// KKPO.
        /// </summary>
        public const string KKPO = "KKPO";

        /// <summary>
        /// KKPDCT.
        /// </summary>
        public const string KKPDCT = "KKPDCT";

        /// <summary>
        /// KKPKCO.
        /// </summary>
        public const string KKPKCO = "KKPKCO";

        /// <summary>
        /// KKMCU.
        /// </summary>
        public const string KKMCU = "KKMCU";

        /// <summary>
        /// KKPID.
        /// </summary>
        public const string KKPID = "KKPID";

        /// <summary>
        /// KKUSER.
        /// </summary>
        public const string KKUSER = "KKUSER";

        /// <summary>
        /// KKUPMJ.
        /// </summary>
        public const string KKUPMJ = "KKUPMJ";

        /// <summary>
        /// KKUPMT.
        /// </summary>
        public const string KKUPMT = "KKUPMT";

        /// <summary>
        /// KKCRR.
        /// </summary>
        public const string KKCRR = "KKCRR";

        /// <summary>
        /// KKPVN.
        /// </summary>
        public const string KKPVN = "KKPVN";

        /// <summary>
        /// KKEFTJ.
        /// </summary>
        public const string KKEFTJ = "KKEFTJ";

        /// <summary>
        /// KKFILE.
        /// </summary>
        public const string KKFILE = "KKFILE";

        /// <summary>
        /// KKMID.
        /// </summary>
        public const string KKMID = "KKMID";

        /// <summary>
        /// KKPTYF.
        /// </summary>
        public const string KKPTYF = "KKPTYF";

        /// <summary>
        /// KKPYIN.
        /// </summary>
        public const string KKPYIN = "KKPYIN";

        /// <summary>
        /// KKEDTY.
        /// </summary>
        public const string KKEDTY = "KKEDTY";

        /// <summary>
        /// KKEDSQ.
        /// </summary>
        public const string KKEDSQ = "KKEDSQ";

        /// <summary>
        /// KKEKCO.
        /// </summary>
        public const string KKEKCO = "KKEKCO";

        /// <summary>
        /// KKEDOC.
        /// </summary>
        public const string KKEDOC = "KKEDOC";

        /// <summary>
        /// KKEDCT.
        /// </summary>
        public const string KKEDCT = "KKEDCT";

        /// <summary>
        /// KKJOBN.
        /// </summary>
        public const string KKJOBN = "KKJOBN";

        /// <summary>
        /// KKGFL3.
        /// </summary>
        public const string KKGFL3 = "KKGFL3";

        /// <summary>
        /// KKGFL4.
        /// </summary>
        public const string KKGFL4 = "KKGFL4";

        /// <summary>
        /// KKCRRM.
        /// </summary>
        public const string KKCRRM = "KKCRRM";
    }

    /// <inheritdoc />
    public override string TableName => "F04572";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("KKHDC", "KKHDC", JdeDataType.Numeric, null, true, true),
        new JdeField("KKCKC", "KKCKC", JdeDataType.Numeric, null, true, true),
        new JdeField("KKPSEL", "KKPSEL", JdeDataType.Numeric),
        new JdeField("KKPGMP", "KKPGMP", JdeDataType.String, 20),
        new JdeField("KKCHKQ", "KKCHKQ", JdeDataType.String, 20),
        new JdeField("KKGLBA", "KKGLBA", JdeDataType.String, 16),
        new JdeField("KKCRCD", "KKCRCD", JdeDataType.String, 6),
        new JdeField("KKPST", "KKPST", JdeDataType.String, 2),
        new JdeField("KKDOCM", "KKDOCM", JdeDataType.Numeric),
        new JdeField("KKDCTM", "KKDCTM", JdeDataType.String, 4),
        new JdeField("KKPSTT", "KKPSTT", JdeDataType.String, 2),
        new JdeField("KKPYE", "KKPYE", JdeDataType.Numeric),
        new JdeField("KKALPP", "KKALPP", JdeDataType.String, 80),
        new JdeField("KKAN8", "KKAN8", JdeDataType.Numeric),
        new JdeField("KKALPH", "KKALPH", JdeDataType.String, 80),
        new JdeField("KKCRC", "KKCRC", JdeDataType.String, 6),
        new JdeField("KKATT", "KKATT", JdeDataType.String, 2),
        new JdeField("KKSTUB", "KKSTUB", JdeDataType.Numeric),
        new JdeField("KKDETL", "KKDETL", JdeDataType.Numeric),
        new JdeField("KKCO", "KKCO", JdeDataType.String, 10),
        new JdeField("KKTNST", "KKTNST", JdeDataType.String, 40),
        new JdeField("KKCBNK", "KKCBNK", JdeDataType.String, 40),
        new JdeField("KKCHKD", "KKCHKD", JdeDataType.String, 4),
        new JdeField("KKDL01", "KKDL01", JdeDataType.String, 60),
        new JdeField("KKADSA", "KKADSA", JdeDataType.Numeric),
        new JdeField("KKPAAP", "KKPAAP", JdeDataType.Numeric),
        new JdeField("KKDGJ", "KKDGJ", JdeDataType.Numeric),
        new JdeField("KKPYTY", "KKPYTY", JdeDataType.String, 2),
        new JdeField("KKVLDT", "KKVLDT", JdeDataType.Numeric),
        new JdeField("KKBPDJ", "KKBPDJ", JdeDataType.Numeric),
        new JdeField("KKBXDJ", "KKBXDJ", JdeDataType.Numeric),
        new JdeField("KKAC01", "KKAC01", JdeDataType.String, 6),
        new JdeField("KKAC02", "KKAC02", JdeDataType.String, 6),
        new JdeField("KKAC03", "KKAC03", JdeDataType.String, 6),
        new JdeField("KKAC04", "KKAC04", JdeDataType.String, 6),
        new JdeField("KKAC05", "KKAC05", JdeDataType.String, 6),
        new JdeField("KKRMK", "KKRMK", JdeDataType.String, 60),
        new JdeField("KKPO", "KKPO", JdeDataType.String, 16),
        new JdeField("KKPDCT", "KKPDCT", JdeDataType.String, 4),
        new JdeField("KKPKCO", "KKPKCO", JdeDataType.String, 10),
        new JdeField("KKMCU", "KKMCU", JdeDataType.String, 24),
        new JdeField("KKPID", "KKPID", JdeDataType.String, 20),
        new JdeField("KKUSER", "KKUSER", JdeDataType.String, 20),
        new JdeField("KKUPMJ", "KKUPMJ", JdeDataType.Numeric),
        new JdeField("KKUPMT", "KKUPMT", JdeDataType.Numeric),
        new JdeField("KKCRR", "KKCRR", JdeDataType.Numeric),
        new JdeField("KKPVN", "KKPVN", JdeDataType.String, 20),
        new JdeField("KKEFTJ", "KKEFTJ", JdeDataType.Numeric),
        new JdeField("KKFILE", "KKFILE", JdeDataType.String, 20),
        new JdeField("KKMID", "KKMID", JdeDataType.String, 20),
        new JdeField("KKPTYF", "KKPTYF", JdeDataType.String, 2),
        new JdeField("KKPYIN", "KKPYIN", JdeDataType.String, 2),
        new JdeField("KKEDTY", "KKEDTY", JdeDataType.String, 2),
        new JdeField("KKEDSQ", "KKEDSQ", JdeDataType.Numeric),
        new JdeField("KKEKCO", "KKEKCO", JdeDataType.String, 10),
        new JdeField("KKEDOC", "KKEDOC", JdeDataType.Numeric),
        new JdeField("KKEDCT", "KKEDCT", JdeDataType.String, 4),
        new JdeField("KKJOBN", "KKJOBN", JdeDataType.String, 20),
        new JdeField("KKGFL3", "KKGFL3", JdeDataType.String, 2),
        new JdeField("KKGFL4", "KKGFL4", JdeDataType.String, 2),
        new JdeField("KKCRRM", "KKCRRM", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F04572_0", "Primary Key on KKHDC, KKCKC", new[] { "KKHDC", "KKCKC" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F04572_2", "Index on KKPSEL, KKPST, KKGLBA, KKDOCM", new[] { "KKPSEL", "KKPST", "KKGLBA", "KKDOCM" }),
        new JdeIndex("F04572_3", "Index on KKHDC, KKPST", new[] { "KKHDC", "KKPST" }),
        new JdeIndex("F04572_4", "Index on KKHDC, SYS_NC00062$", new[] { "KKHDC", "SYS_NC00062$" })
    };
}
