using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F3910 - .
/// </summary>
public class F3910 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SCCRCD.
        /// </summary>
        public const string SCCRCD = "SCCRCD";

        /// <summary>
        /// SCCO.
        /// </summary>
        public const string SCCO = "SCCO";

        /// <summary>
        /// SCSVAT.
        /// </summary>
        public const string SCSVAT = "SCSVAT";

        /// <summary>
        /// SCITPL.
        /// </summary>
        public const string SCITPL = "SCITPL";

        /// <summary>
        /// SCITM.
        /// </summary>
        public const string SCITM = "SCITM";

        /// <summary>
        /// SCDGJ.
        /// </summary>
        public const string SCDGJ = "SCDGJ";

        /// <summary>
        /// SCSVVM.
        /// </summary>
        public const string SCSVVM = "SCSVVM";

        /// <summary>
        /// SCMCU.
        /// </summary>
        public const string SCMCU = "SCMCU";

        /// <summary>
        /// SCANI.
        /// </summary>
        public const string SCANI = "SCANI";

        /// <summary>
        /// SCAA.
        /// </summary>
        public const string SCAA = "SCAA";

        /// <summary>
        /// SCAID.
        /// </summary>
        public const string SCAID = "SCAID";

        /// <summary>
        /// SCLT.
        /// </summary>
        public const string SCLT = "SCLT";

        /// <summary>
        /// SCDCT.
        /// </summary>
        public const string SCDCT = "SCDCT";

        /// <summary>
        /// SCDOC.
        /// </summary>
        public const string SCDOC = "SCDOC";

        /// <summary>
        /// SCKCO.
        /// </summary>
        public const string SCKCO = "SCKCO";

        /// <summary>
        /// SCJELN.
        /// </summary>
        public const string SCJELN = "SCJELN";

        /// <summary>
        /// SCICU.
        /// </summary>
        public const string SCICU = "SCICU";

        /// <summary>
        /// SCICUT.
        /// </summary>
        public const string SCICUT = "SCICUT";

        /// <summary>
        /// SCSVDT.
        /// </summary>
        public const string SCSVDT = "SCSVDT";

        /// <summary>
        /// SCSVFU.
        /// </summary>
        public const string SCSVFU = "SCSVFU";

        /// <summary>
        /// SCSVF1.
        /// </summary>
        public const string SCSVF1 = "SCSVF1";

        /// <summary>
        /// SCSVF2.
        /// </summary>
        public const string SCSVF2 = "SCSVF2";

        /// <summary>
        /// SCUSER.
        /// </summary>
        public const string SCUSER = "SCUSER";

        /// <summary>
        /// SCPID.
        /// </summary>
        public const string SCPID = "SCPID";

        /// <summary>
        /// SCJOBN.
        /// </summary>
        public const string SCJOBN = "SCJOBN";

        /// <summary>
        /// SCUPMJ.
        /// </summary>
        public const string SCUPMJ = "SCUPMJ";

        /// <summary>
        /// SCTDAY.
        /// </summary>
        public const string SCTDAY = "SCTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F3910";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SCCRCD", "SCCRCD", JdeDataType.String, 6, true, true),
        new JdeField("SCCO", "SCCO", JdeDataType.String, 10, true, true),
        new JdeField("SCSVAT", "SCSVAT", JdeDataType.String, 2, true, true),
        new JdeField("SCITPL", "SCITPL", JdeDataType.String, 20, true, true),
        new JdeField("SCITM", "SCITM", JdeDataType.Numeric, null, true, true),
        new JdeField("SCDGJ", "SCDGJ", JdeDataType.Numeric, null, true, true),
        new JdeField("SCSVVM", "SCSVVM", JdeDataType.String, 4, true, true),
        new JdeField("SCMCU", "SCMCU", JdeDataType.String, 24),
        new JdeField("SCANI", "SCANI", JdeDataType.String, 58),
        new JdeField("SCAA", "SCAA", JdeDataType.Numeric),
        new JdeField("SCAID", "SCAID", JdeDataType.String, 16),
        new JdeField("SCLT", "SCLT", JdeDataType.String, 4),
        new JdeField("SCDCT", "SCDCT", JdeDataType.String, 4),
        new JdeField("SCDOC", "SCDOC", JdeDataType.Numeric),
        new JdeField("SCKCO", "SCKCO", JdeDataType.String, 10),
        new JdeField("SCJELN", "SCJELN", JdeDataType.Numeric),
        new JdeField("SCICU", "SCICU", JdeDataType.Numeric),
        new JdeField("SCICUT", "SCICUT", JdeDataType.String, 4),
        new JdeField("SCSVDT", "SCSVDT", JdeDataType.Numeric),
        new JdeField("SCSVFU", "SCSVFU", JdeDataType.String, 4),
        new JdeField("SCSVF1", "SCSVF1", JdeDataType.String, 2),
        new JdeField("SCSVF2", "SCSVF2", JdeDataType.String, 2),
        new JdeField("SCUSER", "SCUSER", JdeDataType.String, 20),
        new JdeField("SCPID", "SCPID", JdeDataType.String, 20),
        new JdeField("SCJOBN", "SCJOBN", JdeDataType.String, 20),
        new JdeField("SCUPMJ", "SCUPMJ", JdeDataType.Numeric),
        new JdeField("SCTDAY", "SCTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F3910_0", "Primary Key on SCCRCD, SCCO, SCSVAT, SCITPL, SCITM, SCDGJ, SCSVVM", new[] { "SCCRCD", "SCCO", "SCSVAT", "SCITPL", "SCITM", "SCDGJ", "SCSVVM" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F3910_2", "Index on SCCO, SCMCU, SCSVAT, SCITPL, SCITM, SCDGJ", new[] { "SCCO", "SCMCU", "SCSVAT", "SCITPL", "SCITM", "SCDGJ" }),
        new JdeIndex("F3910_3", "Index on SCDCT, SCDOC, SCKCO, SCDGJ, SCJELN, SCLT", new[] { "SCDCT", "SCDOC", "SCKCO", "SCDGJ", "SCJELN", "SCLT" })
    };
}
