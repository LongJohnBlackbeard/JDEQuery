using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F3216 - .
/// </summary>
public class F3216 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PCCFGID.
        /// </summary>
        public const string PCCFGID = "PCCFGID";

        /// <summary>
        /// PCCFGCID.
        /// </summary>
        public const string PCCFGCID = "PCCFGCID";

        /// <summary>
        /// PCSEQN.
        /// </summary>
        public const string PCSEQN = "PCSEQN";

        /// <summary>
        /// PCDSC1.
        /// </summary>
        public const string PCDSC1 = "PCDSC1";

        /// <summary>
        /// PCLNTY.
        /// </summary>
        public const string PCLNTY = "PCLNTY";

        /// <summary>
        /// PCPRU.
        /// </summary>
        public const string PCPRU = "PCPRU";

        /// <summary>
        /// PCSOCF.
        /// </summary>
        public const string PCSOCF = "PCSOCF";

        /// <summary>
        /// PCFOVQ.
        /// </summary>
        public const string PCFOVQ = "PCFOVQ";

        /// <summary>
        /// PCATMU.
        /// </summary>
        public const string PCATMU = "PCATMU";

        /// <summary>
        /// PCECST.
        /// </summary>
        public const string PCECST = "PCECST";

        /// <summary>
        /// PCFEC.
        /// </summary>
        public const string PCFEC = "PCFEC";

        /// <summary>
        /// PCAEXP.
        /// </summary>
        public const string PCAEXP = "PCAEXP";

        /// <summary>
        /// PCFEA.
        /// </summary>
        public const string PCFEA = "PCFEA";

        /// <summary>
        /// PCATOT.
        /// </summary>
        public const string PCATOT = "PCATOT";

        /// <summary>
        /// PCATO#.
        /// </summary>
        public const string PCATO_ = "PCATO#";

        /// <summary>
        /// PCATOS.
        /// </summary>
        public const string PCATOS = "PCATOS";

        /// <summary>
        /// PCLNID.
        /// </summary>
        public const string PCLNID = "PCLNID";

        /// <summary>
        /// PCAKID.
        /// </summary>
        public const string PCAKID = "PCAKID";

        /// <summary>
        /// PCURCD.
        /// </summary>
        public const string PCURCD = "PCURCD";

        /// <summary>
        /// PCURDT.
        /// </summary>
        public const string PCURDT = "PCURDT";

        /// <summary>
        /// PCURAT.
        /// </summary>
        public const string PCURAT = "PCURAT";

        /// <summary>
        /// PCURAB.
        /// </summary>
        public const string PCURAB = "PCURAB";

        /// <summary>
        /// PCURRF.
        /// </summary>
        public const string PCURRF = "PCURRF";

        /// <summary>
        /// PCUSER.
        /// </summary>
        public const string PCUSER = "PCUSER";

        /// <summary>
        /// PCPID.
        /// </summary>
        public const string PCPID = "PCPID";

        /// <summary>
        /// PCJOBN.
        /// </summary>
        public const string PCJOBN = "PCJOBN";

        /// <summary>
        /// PCUPMJ.
        /// </summary>
        public const string PCUPMJ = "PCUPMJ";

        /// <summary>
        /// PCTDAY.
        /// </summary>
        public const string PCTDAY = "PCTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F3216";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PCCFGID", "PCCFGID", JdeDataType.Numeric, null, true, true),
        new JdeField("PCCFGCID", "PCCFGCID", JdeDataType.Numeric, null, true, true),
        new JdeField("PCSEQN", "PCSEQN", JdeDataType.Numeric, null, true, true),
        new JdeField("PCDSC1", "PCDSC1", JdeDataType.String, 60),
        new JdeField("PCLNTY", "PCLNTY", JdeDataType.String, 4, true, true),
        new JdeField("PCPRU", "PCPRU", JdeDataType.String, 2, true, true),
        new JdeField("PCSOCF", "PCSOCF", JdeDataType.String, 2),
        new JdeField("PCFOVQ", "PCFOVQ", JdeDataType.String, 2),
        new JdeField("PCATMU", "PCATMU", JdeDataType.Numeric),
        new JdeField("PCECST", "PCECST", JdeDataType.Numeric),
        new JdeField("PCFEC", "PCFEC", JdeDataType.Numeric),
        new JdeField("PCAEXP", "PCAEXP", JdeDataType.Numeric),
        new JdeField("PCFEA", "PCFEA", JdeDataType.Numeric),
        new JdeField("PCATOT", "PCATOT", JdeDataType.String, 2),
        new JdeField("PCATO#", "PCATO#", JdeDataType.Numeric),
        new JdeField("PCATOS", "PCATOS", JdeDataType.Numeric),
        new JdeField("PCLNID", "PCLNID", JdeDataType.Numeric),
        new JdeField("PCAKID", "PCAKID", JdeDataType.Numeric),
        new JdeField("PCURCD", "PCURCD", JdeDataType.String, 4),
        new JdeField("PCURDT", "PCURDT", JdeDataType.Numeric),
        new JdeField("PCURAT", "PCURAT", JdeDataType.Numeric),
        new JdeField("PCURAB", "PCURAB", JdeDataType.Numeric),
        new JdeField("PCURRF", "PCURRF", JdeDataType.String, 30),
        new JdeField("PCUSER", "PCUSER", JdeDataType.String, 20),
        new JdeField("PCPID", "PCPID", JdeDataType.String, 20),
        new JdeField("PCJOBN", "PCJOBN", JdeDataType.String, 20),
        new JdeField("PCUPMJ", "PCUPMJ", JdeDataType.Numeric),
        new JdeField("PCTDAY", "PCTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F3216_0", "Primary Key on PCCFGID, PCCFGCID, PCSEQN, PCLNTY, PCPRU", new[] { "PCCFGID", "PCCFGCID", "PCSEQN", "PCLNTY", "PCPRU" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F3216_2", "Index on PCCFGID, PCSOCF, PCCFGCID, PCLNTY, PCPRU, PCSEQN", new[] { "PCCFGID", "PCSOCF", "PCCFGCID", "PCLNTY", "PCPRU", "PCSEQN" })
    };
}
