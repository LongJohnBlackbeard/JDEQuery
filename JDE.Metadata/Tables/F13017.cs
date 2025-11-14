using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F13017 - .
/// </summary>
public class F13017 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PLNUMB.
        /// </summary>
        public const string PLNUMB = "PLNUMB";

        /// <summary>
        /// PLUKID.
        /// </summary>
        public const string PLUKID = "PLUKID";

        /// <summary>
        /// PLKIT.
        /// </summary>
        public const string PLKIT = "PLKIT";

        /// <summary>
        /// PLKITL.
        /// </summary>
        public const string PLKITL = "PLKITL";

        /// <summary>
        /// PLKITA.
        /// </summary>
        public const string PLKITA = "PLKITA";

        /// <summary>
        /// PLITM.
        /// </summary>
        public const string PLITM = "PLITM";

        /// <summary>
        /// PLLITM.
        /// </summary>
        public const string PLLITM = "PLLITM";

        /// <summary>
        /// PLAITM.
        /// </summary>
        public const string PLAITM = "PLAITM";

        /// <summary>
        /// PLCPNB.
        /// </summary>
        public const string PLCPNB = "PLCPNB";

        /// <summary>
        /// PLLOTN.
        /// </summary>
        public const string PLLOTN = "PLLOTN";

        /// <summary>
        /// PLLOCN.
        /// </summary>
        public const string PLLOCN = "PLLOCN";

        /// <summary>
        /// PLVEND.
        /// </summary>
        public const string PLVEND = "PLVEND";

        /// <summary>
        /// PLCMCU.
        /// </summary>
        public const string PLCMCU = "PLCMCU";

        /// <summary>
        /// PLTBM.
        /// </summary>
        public const string PLTBM = "PLTBM";

        /// <summary>
        /// PLQNTY.
        /// </summary>
        public const string PLQNTY = "PLQNTY";

        /// <summary>
        /// PLUM.
        /// </summary>
        public const string PLUM = "PLUM";

        /// <summary>
        /// PLEFFF.
        /// </summary>
        public const string PLEFFF = "PLEFFF";

        /// <summary>
        /// PLEFFT.
        /// </summary>
        public const string PLEFFT = "PLEFFT";

        /// <summary>
        /// PLITC.
        /// </summary>
        public const string PLITC = "PLITC";

        /// <summary>
        /// PLCOST.
        /// </summary>
        public const string PLCOST = "PLCOST";

        /// <summary>
        /// PLDRAW.
        /// </summary>
        public const string PLDRAW = "PLDRAW";

        /// <summary>
        /// PLOPSQ.
        /// </summary>
        public const string PLOPSQ = "PLOPSQ";

        /// <summary>
        /// PLBSEQ.
        /// </summary>
        public const string PLBSEQ = "PLBSEQ";

        /// <summary>
        /// PLLOVD.
        /// </summary>
        public const string PLLOVD = "PLLOVD";

        /// <summary>
        /// PLECO.
        /// </summary>
        public const string PLECO = "PLECO";

        /// <summary>
        /// PLECTY.
        /// </summary>
        public const string PLECTY = "PLECTY";

        /// <summary>
        /// PLECOD.
        /// </summary>
        public const string PLECOD = "PLECOD";

        /// <summary>
        /// PLDSC1.
        /// </summary>
        public const string PLDSC1 = "PLDSC1";

        /// <summary>
        /// PLDSC2.
        /// </summary>
        public const string PLDSC2 = "PLDSC2";

        /// <summary>
        /// PLCITM.
        /// </summary>
        public const string PLCITM = "PLCITM";

        /// <summary>
        /// PLDS01.
        /// </summary>
        public const string PLDS01 = "PLDS01";

        /// <summary>
        /// PLLNTY.
        /// </summary>
        public const string PLLNTY = "PLLNTY";

        /// <summary>
        /// PLUNCS.
        /// </summary>
        public const string PLUNCS = "PLUNCS";

        /// <summary>
        /// PLBREV.
        /// </summary>
        public const string PLBREV = "PLBREV";

        /// <summary>
        /// PLCMRV.
        /// </summary>
        public const string PLCMRV = "PLCMRV";

        /// <summary>
        /// PLRVNO.
        /// </summary>
        public const string PLRVNO = "PLRVNO";

        /// <summary>
        /// PLURCD.
        /// </summary>
        public const string PLURCD = "PLURCD";

        /// <summary>
        /// PLURDT.
        /// </summary>
        public const string PLURDT = "PLURDT";

        /// <summary>
        /// PLURAT.
        /// </summary>
        public const string PLURAT = "PLURAT";

        /// <summary>
        /// PLURRF.
        /// </summary>
        public const string PLURRF = "PLURRF";

        /// <summary>
        /// PLURAB.
        /// </summary>
        public const string PLURAB = "PLURAB";

        /// <summary>
        /// PLUSER.
        /// </summary>
        public const string PLUSER = "PLUSER";

        /// <summary>
        /// PLPID.
        /// </summary>
        public const string PLPID = "PLPID";

        /// <summary>
        /// PLJOBN.
        /// </summary>
        public const string PLJOBN = "PLJOBN";

        /// <summary>
        /// PLUPMJ.
        /// </summary>
        public const string PLUPMJ = "PLUPMJ";

        /// <summary>
        /// PLUPMT.
        /// </summary>
        public const string PLUPMT = "PLUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F13017";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PLNUMB", "PLNUMB", JdeDataType.Numeric, null, true, true),
        new JdeField("PLUKID", "PLUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("PLKIT", "PLKIT", JdeDataType.Numeric),
        new JdeField("PLKITL", "PLKITL", JdeDataType.String, 50),
        new JdeField("PLKITA", "PLKITA", JdeDataType.String, 50),
        new JdeField("PLITM", "PLITM", JdeDataType.Numeric),
        new JdeField("PLLITM", "PLLITM", JdeDataType.String, 50),
        new JdeField("PLAITM", "PLAITM", JdeDataType.String, 50),
        new JdeField("PLCPNB", "PLCPNB", JdeDataType.Numeric),
        new JdeField("PLLOTN", "PLLOTN", JdeDataType.String, 60),
        new JdeField("PLLOCN", "PLLOCN", JdeDataType.String, 40),
        new JdeField("PLVEND", "PLVEND", JdeDataType.Numeric),
        new JdeField("PLCMCU", "PLCMCU", JdeDataType.String, 24),
        new JdeField("PLTBM", "PLTBM", JdeDataType.String, 6),
        new JdeField("PLQNTY", "PLQNTY", JdeDataType.Numeric),
        new JdeField("PLUM", "PLUM", JdeDataType.String, 4),
        new JdeField("PLEFFF", "PLEFFF", JdeDataType.Numeric),
        new JdeField("PLEFFT", "PLEFFT", JdeDataType.Numeric),
        new JdeField("PLITC", "PLITC", JdeDataType.String, 2),
        new JdeField("PLCOST", "PLCOST", JdeDataType.String, 6),
        new JdeField("PLDRAW", "PLDRAW", JdeDataType.String, 40),
        new JdeField("PLOPSQ", "PLOPSQ", JdeDataType.Numeric),
        new JdeField("PLBSEQ", "PLBSEQ", JdeDataType.Numeric),
        new JdeField("PLLOVD", "PLLOVD", JdeDataType.Numeric),
        new JdeField("PLECO", "PLECO", JdeDataType.String, 24),
        new JdeField("PLECTY", "PLECTY", JdeDataType.String, 4),
        new JdeField("PLECOD", "PLECOD", JdeDataType.Numeric),
        new JdeField("PLDSC1", "PLDSC1", JdeDataType.String, 60),
        new JdeField("PLDSC2", "PLDSC2", JdeDataType.String, 60),
        new JdeField("PLCITM", "PLCITM", JdeDataType.String, 50),
        new JdeField("PLDS01", "PLDS01", JdeDataType.String, 160),
        new JdeField("PLLNTY", "PLLNTY", JdeDataType.String, 4),
        new JdeField("PLUNCS", "PLUNCS", JdeDataType.Numeric),
        new JdeField("PLBREV", "PLBREV", JdeDataType.String, 6),
        new JdeField("PLCMRV", "PLCMRV", JdeDataType.String, 6),
        new JdeField("PLRVNO", "PLRVNO", JdeDataType.String, 4),
        new JdeField("PLURCD", "PLURCD", JdeDataType.String, 4),
        new JdeField("PLURDT", "PLURDT", JdeDataType.Numeric),
        new JdeField("PLURAT", "PLURAT", JdeDataType.Numeric),
        new JdeField("PLURRF", "PLURRF", JdeDataType.String, 30),
        new JdeField("PLURAB", "PLURAB", JdeDataType.Numeric),
        new JdeField("PLUSER", "PLUSER", JdeDataType.String, 20),
        new JdeField("PLPID", "PLPID", JdeDataType.String, 20),
        new JdeField("PLJOBN", "PLJOBN", JdeDataType.String, 20),
        new JdeField("PLUPMJ", "PLUPMJ", JdeDataType.Numeric),
        new JdeField("PLUPMT", "PLUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F13017_0", "Primary Key on PLNUMB, PLUKID", new[] { "PLNUMB", "PLUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F13017_3", "Index on PLNUMB, PLCPNB", new[] { "PLNUMB", "PLCPNB" }),
        new JdeIndex("F13017_4", "Index on PLKIT, PLNUMB, PLUKID", new[] { "PLKIT", "PLNUMB", "PLUKID" }),
        new JdeIndex("F13017_6", "Index on PLCITM, PLNUMB, PLUKID", new[] { "PLCITM", "PLNUMB", "PLUKID" })
    };
}
