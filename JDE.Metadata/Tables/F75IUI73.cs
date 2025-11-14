using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75IUI73 - .
/// </summary>
public class F75IUI73 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WFSHPN.
        /// </summary>
        public const string WFSHPN = "WFSHPN";

        /// <summary>
        /// WFRSSN.
        /// </summary>
        public const string WFRSSN = "WFRSSN";

        /// <summary>
        /// WFJOBS.
        /// </summary>
        public const string WFJOBS = "WFJOBS";

        /// <summary>
        /// WFI75CGSTR.
        /// </summary>
        public const string WFI75CGSTR = "WFI75CGSTR";

        /// <summary>
        /// WFI75SGSTR.
        /// </summary>
        public const string WFI75SGSTR = "WFI75SGSTR";

        /// <summary>
        /// WFI75IGSTR.
        /// </summary>
        public const string WFI75IGSTR = "WFI75IGSTR";

        /// <summary>
        /// WFI75CESSR.
        /// </summary>
        public const string WFI75CESSR = "WFI75CESSR";

        /// <summary>
        /// WFI75CGSTA.
        /// </summary>
        public const string WFI75CGSTA = "WFI75CGSTA";

        /// <summary>
        /// WFI75SGSTA.
        /// </summary>
        public const string WFI75SGSTA = "WFI75SGSTA";

        /// <summary>
        /// WFI75IGSTA.
        /// </summary>
        public const string WFI75IGSTA = "WFI75IGSTA";

        /// <summary>
        /// WFI75CESSA.
        /// </summary>
        public const string WFI75CESSA = "WFI75CESSA";

        /// <summary>
        /// WFI75SERAC.
        /// </summary>
        public const string WFI75SERAC = "WFI75SERAC";

        /// <summary>
        /// WFI75FRC.
        /// </summary>
        public const string WFI75FRC = "WFI75FRC";

        /// <summary>
        /// WFUSER.
        /// </summary>
        public const string WFUSER = "WFUSER";

        /// <summary>
        /// WFPID.
        /// </summary>
        public const string WFPID = "WFPID";

        /// <summary>
        /// WFJOBN.
        /// </summary>
        public const string WFJOBN = "WFJOBN";

        /// <summary>
        /// WFUPMJ.
        /// </summary>
        public const string WFUPMJ = "WFUPMJ";

        /// <summary>
        /// WFUPMT.
        /// </summary>
        public const string WFUPMT = "WFUPMT";

        /// <summary>
        /// WFDOC.
        /// </summary>
        public const string WFDOC = "WFDOC";

        /// <summary>
        /// WFDCTV.
        /// </summary>
        public const string WFDCTV = "WFDCTV";

        /// <summary>
        /// WFKCO.
        /// </summary>
        public const string WFKCO = "WFKCO";

        /// <summary>
        /// WFDOCO.
        /// </summary>
        public const string WFDOCO = "WFDOCO";

        /// <summary>
        /// WFDCTO.
        /// </summary>
        public const string WFDCTO = "WFDCTO";

        /// <summary>
        /// WFKCOO.
        /// </summary>
        public const string WFKCOO = "WFKCOO";

        /// <summary>
        /// WFLNID.
        /// </summary>
        public const string WFLNID = "WFLNID";

        /// <summary>
        /// WFATXA.
        /// </summary>
        public const string WFATXA = "WFATXA";

        /// <summary>
        /// WFI75PROVL.
        /// </summary>
        public const string WFI75PROVL = "WFI75PROVL";

        /// <summary>
        /// WFI75RECVL.
        /// </summary>
        public const string WFI75RECVL = "WFI75RECVL";

        /// <summary>
        /// WFI75PSP.
        /// </summary>
        public const string WFI75PSP = "WFI75PSP";

        /// <summary>
        /// WFI75PSR.
        /// </summary>
        public const string WFI75PSR = "WFI75PSR";

        /// <summary>
        /// WFI75ITCAF.
        /// </summary>
        public const string WFI75ITCAF = "WFI75ITCAF";

        /// <summary>
        /// WFSFX.
        /// </summary>
        public const string WFSFX = "WFSFX";
    }

    /// <inheritdoc />
    public override string TableName => "F75IUI73";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WFSHPN", "WFSHPN", JdeDataType.Numeric, null, true, true),
        new JdeField("WFRSSN", "WFRSSN", JdeDataType.Numeric, null, true, true),
        new JdeField("WFJOBS", "WFJOBS", JdeDataType.Numeric, null, true, true),
        new JdeField("WFI75CGSTR", "WFI75CGSTR", JdeDataType.Numeric),
        new JdeField("WFI75SGSTR", "WFI75SGSTR", JdeDataType.Numeric),
        new JdeField("WFI75IGSTR", "WFI75IGSTR", JdeDataType.Numeric),
        new JdeField("WFI75CESSR", "WFI75CESSR", JdeDataType.Numeric),
        new JdeField("WFI75CGSTA", "WFI75CGSTA", JdeDataType.Numeric),
        new JdeField("WFI75SGSTA", "WFI75SGSTA", JdeDataType.Numeric),
        new JdeField("WFI75IGSTA", "WFI75IGSTA", JdeDataType.Numeric),
        new JdeField("WFI75CESSA", "WFI75CESSA", JdeDataType.Numeric),
        new JdeField("WFI75SERAC", "WFI75SERAC", JdeDataType.String, 40),
        new JdeField("WFI75FRC", "WFI75FRC", JdeDataType.String, 2),
        new JdeField("WFUSER", "WFUSER", JdeDataType.String, 20, true, true),
        new JdeField("WFPID", "WFPID", JdeDataType.String, 20),
        new JdeField("WFJOBN", "WFJOBN", JdeDataType.String, 20),
        new JdeField("WFUPMJ", "WFUPMJ", JdeDataType.Numeric),
        new JdeField("WFUPMT", "WFUPMT", JdeDataType.Numeric),
        new JdeField("WFDOC", "WFDOC", JdeDataType.Numeric),
        new JdeField("WFDCTV", "WFDCTV", JdeDataType.String, 4),
        new JdeField("WFKCO", "WFKCO", JdeDataType.String, 10),
        new JdeField("WFDOCO", "WFDOCO", JdeDataType.Numeric),
        new JdeField("WFDCTO", "WFDCTO", JdeDataType.String, 4),
        new JdeField("WFKCOO", "WFKCOO", JdeDataType.String, 10),
        new JdeField("WFLNID", "WFLNID", JdeDataType.Numeric),
        new JdeField("WFATXA", "WFATXA", JdeDataType.Numeric),
        new JdeField("WFI75PROVL", "WFI75PROVL", JdeDataType.Numeric),
        new JdeField("WFI75RECVL", "WFI75RECVL", JdeDataType.Numeric),
        new JdeField("WFI75PSP", "WFI75PSP", JdeDataType.Numeric),
        new JdeField("WFI75PSR", "WFI75PSR", JdeDataType.Numeric),
        new JdeField("WFI75ITCAF", "WFI75ITCAF", JdeDataType.String, 2),
        new JdeField("WFSFX", "WFSFX", JdeDataType.String, 6)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75IUI73_0", "Primary Key on WFSHPN, WFRSSN, WFJOBS, WFUSER", new[] { "WFSHPN", "WFRSSN", "WFJOBS", "WFUSER" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F75IUI73_2", "Index on WFJOBS, WFUSER", new[] { "WFJOBS", "WFUSER" }),
        new JdeIndex("F75IUI73_3", "Index on WFDOC, WFDCTV, WFKCO, WFSFX", new[] { "WFDOC", "WFDCTV", "WFKCO", "WFSFX" })
    };
}
