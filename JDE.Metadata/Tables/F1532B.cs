using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1532B - .
/// </summary>
public class F1532B : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// NTDCT.
        /// </summary>
        public const string NTDCT = "NTDCT";

        /// <summary>
        /// NTDOC.
        /// </summary>
        public const string NTDOC = "NTDOC";

        /// <summary>
        /// NTDGJ.
        /// </summary>
        public const string NTDGJ = "NTDGJ";

        /// <summary>
        /// NTJELN.
        /// </summary>
        public const string NTJELN = "NTJELN";

        /// <summary>
        /// NTICU.
        /// </summary>
        public const string NTICU = "NTICU";

        /// <summary>
        /// NTEPCL.
        /// </summary>
        public const string NTEPCL = "NTEPCL";

        /// <summary>
        /// NTMCU.
        /// </summary>
        public const string NTMCU = "NTMCU";

        /// <summary>
        /// NTOBJ.
        /// </summary>
        public const string NTOBJ = "NTOBJ";

        /// <summary>
        /// NTSUB.
        /// </summary>
        public const string NTSUB = "NTSUB";

        /// <summary>
        /// NTAID.
        /// </summary>
        public const string NTAID = "NTAID";

        /// <summary>
        /// NTCTRY.
        /// </summary>
        public const string NTCTRY = "NTCTRY";

        /// <summary>
        /// NTAA.
        /// </summary>
        public const string NTAA = "NTAA";

        /// <summary>
        /// NTLT.
        /// </summary>
        public const string NTLT = "NTLT";

        /// <summary>
        /// NTSBL.
        /// </summary>
        public const string NTSBL = "NTSBL";

        /// <summary>
        /// NTSBLT.
        /// </summary>
        public const string NTSBLT = "NTSBLT";

        /// <summary>
        /// NTCO.
        /// </summary>
        public const string NTCO = "NTCO";

        /// <summary>
        /// NTPPUP.
        /// </summary>
        public const string NTPPUP = "NTPPUP";

        /// <summary>
        /// NTURCD.
        /// </summary>
        public const string NTURCD = "NTURCD";

        /// <summary>
        /// NTURDT.
        /// </summary>
        public const string NTURDT = "NTURDT";

        /// <summary>
        /// NTURAT.
        /// </summary>
        public const string NTURAT = "NTURAT";

        /// <summary>
        /// NTURAB.
        /// </summary>
        public const string NTURAB = "NTURAB";

        /// <summary>
        /// NTURRF.
        /// </summary>
        public const string NTURRF = "NTURRF";

        /// <summary>
        /// NTUSER.
        /// </summary>
        public const string NTUSER = "NTUSER";

        /// <summary>
        /// NTPID.
        /// </summary>
        public const string NTPID = "NTPID";

        /// <summary>
        /// NTUPMJ.
        /// </summary>
        public const string NTUPMJ = "NTUPMJ";

        /// <summary>
        /// NTUPMT.
        /// </summary>
        public const string NTUPMT = "NTUPMT";

        /// <summary>
        /// NTJOBN.
        /// </summary>
        public const string NTJOBN = "NTJOBN";

        /// <summary>
        /// NTKCO.
        /// </summary>
        public const string NTKCO = "NTKCO";

        /// <summary>
        /// NTCRCD.
        /// </summary>
        public const string NTCRCD = "NTCRCD";

        /// <summary>
        /// NTDOCO.
        /// </summary>
        public const string NTDOCO = "NTDOCO";

        /// <summary>
        /// NTLSVR.
        /// </summary>
        public const string NTLSVR = "NTLSVR";

        /// <summary>
        /// NTUNIT.
        /// </summary>
        public const string NTUNIT = "NTUNIT";

        /// <summary>
        /// NTEPMCU.
        /// </summary>
        public const string NTEPMCU = "NTEPMCU";

        /// <summary>
        /// NTBCI.
        /// </summary>
        public const string NTBCI = "NTBCI";
    }

    /// <inheritdoc />
    public override string TableName => "F1532B";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("NTDCT", "NTDCT", JdeDataType.String, 4, true, true),
        new JdeField("NTDOC", "NTDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("NTDGJ", "NTDGJ", JdeDataType.Numeric, null, true, true),
        new JdeField("NTJELN", "NTJELN", JdeDataType.Numeric, null, true, true),
        new JdeField("NTICU", "NTICU", JdeDataType.Numeric, null, true, true),
        new JdeField("NTEPCL", "NTEPCL", JdeDataType.String, 8, true, true),
        new JdeField("NTMCU", "NTMCU", JdeDataType.String, 24),
        new JdeField("NTOBJ", "NTOBJ", JdeDataType.String, 12),
        new JdeField("NTSUB", "NTSUB", JdeDataType.String, 16),
        new JdeField("NTAID", "NTAID", JdeDataType.String, 16, true, true),
        new JdeField("NTCTRY", "NTCTRY", JdeDataType.Numeric),
        new JdeField("NTAA", "NTAA", JdeDataType.Numeric),
        new JdeField("NTLT", "NTLT", JdeDataType.String, 4, true, true),
        new JdeField("NTSBL", "NTSBL", JdeDataType.String, 16, true, true),
        new JdeField("NTSBLT", "NTSBLT", JdeDataType.String, 2),
        new JdeField("NTCO", "NTCO", JdeDataType.String, 10, true, true),
        new JdeField("NTPPUP", "NTPPUP", JdeDataType.String, 2),
        new JdeField("NTURCD", "NTURCD", JdeDataType.String, 4),
        new JdeField("NTURDT", "NTURDT", JdeDataType.Numeric),
        new JdeField("NTURAT", "NTURAT", JdeDataType.Numeric),
        new JdeField("NTURAB", "NTURAB", JdeDataType.Numeric),
        new JdeField("NTURRF", "NTURRF", JdeDataType.String, 30),
        new JdeField("NTUSER", "NTUSER", JdeDataType.String, 20),
        new JdeField("NTPID", "NTPID", JdeDataType.String, 20),
        new JdeField("NTUPMJ", "NTUPMJ", JdeDataType.Numeric),
        new JdeField("NTUPMT", "NTUPMT", JdeDataType.Numeric),
        new JdeField("NTJOBN", "NTJOBN", JdeDataType.String, 20),
        new JdeField("NTKCO", "NTKCO", JdeDataType.String, 10),
        new JdeField("NTCRCD", "NTCRCD", JdeDataType.String, 6),
        new JdeField("NTDOCO", "NTDOCO", JdeDataType.Numeric),
        new JdeField("NTLSVR", "NTLSVR", JdeDataType.Numeric),
        new JdeField("NTUNIT", "NTUNIT", JdeDataType.String, 16),
        new JdeField("NTEPMCU", "NTEPMCU", JdeDataType.String, 24),
        new JdeField("NTBCI", "NTBCI", JdeDataType.Numeric, null, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1532B_0", "Primary Key on NTICU, NTEPCL, NTDGJ, NTAID, NTLT, NTDOC, NTCO, NTDCT, NTJELN, NTSBL, NTBCI", new[] { "NTICU", "NTEPCL", "NTDGJ", "NTAID", "NTLT", "NTDOC", "NTCO", "NTDCT", "NTJELN", "NTSBL", "NTBCI" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F1532B_2", "Index on NTEPCL, NTDGJ, NTAID, NTLT, NTDOC, NTCO, NTDCT, NTJELN, NTSBL, NTSBLT", new[] { "NTEPCL", "NTDGJ", "NTAID", "NTLT", "NTDOC", "NTCO", "NTDCT", "NTJELN", "NTSBL", "NTSBLT" }),
        new JdeIndex("F1532B_3", "Index on NTICU, NTEPCL, NTMCU, NTOBJ, NTSUB, NTDGJ", new[] { "NTICU", "NTEPCL", "NTMCU", "NTOBJ", "NTSUB", "NTDGJ" }),
        new JdeIndex("F1532B_4", "Index on NTICU, NTEPCL, NTAID", new[] { "NTICU", "NTEPCL", "NTAID" }),
        new JdeIndex("F1532B_5", "Index on NTICU, NTEPCL, NTDOCO, NTLSVR, NTBCI", new[] { "NTICU", "NTEPCL", "NTDOCO", "NTLSVR", "NTBCI" })
    };
}
