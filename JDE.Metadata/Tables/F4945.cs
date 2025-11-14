using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4945 - .
/// </summary>
public class F4945 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// SCSHPN.
        /// </summary>
        public const string SCSHPN = "SCSHPN";

        /// <summary>
        /// SCRSSN.
        /// </summary>
        public const string SCRSSN = "SCRSSN";

        /// <summary>
        /// SCVMCU.
        /// </summary>
        public const string SCVMCU = "SCVMCU";

        /// <summary>
        /// SCLDNM.
        /// </summary>
        public const string SCLDNM = "SCLDNM";

        /// <summary>
        /// SCDLNO.
        /// </summary>
        public const string SCDLNO = "SCDLNO";

        /// <summary>
        /// SCOSEQ.
        /// </summary>
        public const string SCOSEQ = "SCOSEQ";

        /// <summary>
        /// SCRTNM.
        /// </summary>
        public const string SCRTNM = "SCRTNM";

        /// <summary>
        /// SCSDSQ.
        /// </summary>
        public const string SCSDSQ = "SCSDSQ";

        /// <summary>
        /// SCSCSN.
        /// </summary>
        public const string SCSCSN = "SCSCSN";

        /// <summary>
        /// SCNMFC.
        /// </summary>
        public const string SCNMFC = "SCNMFC";

        /// <summary>
        /// SCDSGP.
        /// </summary>
        public const string SCDSGP = "SCDSGP";

        /// <summary>
        /// SCFRT1.
        /// </summary>
        public const string SCFRT1 = "SCFRT1";

        /// <summary>
        /// SCFRT2.
        /// </summary>
        public const string SCFRT2 = "SCFRT2";

        /// <summary>
        /// SCCGC1.
        /// </summary>
        public const string SCCGC1 = "SCCGC1";

        /// <summary>
        /// SCAG.
        /// </summary>
        public const string SCAG = "SCAG";

        /// <summary>
        /// SCBLPB.
        /// </summary>
        public const string SCBLPB = "SCBLPB";

        /// <summary>
        /// SCCRDC.
        /// </summary>
        public const string SCCRDC = "SCCRDC";

        /// <summary>
        /// SCFAA.
        /// </summary>
        public const string SCFAA = "SCFAA";

        /// <summary>
        /// SCNAMF.
        /// </summary>
        public const string SCNAMF = "SCNAMF";

        /// <summary>
        /// SCRTDQ.
        /// </summary>
        public const string SCRTDQ = "SCRTDQ";

        /// <summary>
        /// SCNAMT.
        /// </summary>
        public const string SCNAMT = "SCNAMT";

        /// <summary>
        /// SCUOM.
        /// </summary>
        public const string SCUOM = "SCUOM";

        /// <summary>
        /// SCRTGB.
        /// </summary>
        public const string SCRTGB = "SCRTGB";

        /// <summary>
        /// SCCRCD.
        /// </summary>
        public const string SCCRCD = "SCCRCD";

        /// <summary>
        /// SCDOCO.
        /// </summary>
        public const string SCDOCO = "SCDOCO";

        /// <summary>
        /// SCDCTO.
        /// </summary>
        public const string SCDCTO = "SCDCTO";

        /// <summary>
        /// SCKCOO.
        /// </summary>
        public const string SCKCOO = "SCKCOO";

        /// <summary>
        /// SCLNID.
        /// </summary>
        public const string SCLNID = "SCLNID";

        /// <summary>
        /// SCOVFG.
        /// </summary>
        public const string SCOVFG = "SCOVFG";

        /// <summary>
        /// SCUKID.
        /// </summary>
        public const string SCUKID = "SCUKID";

        /// <summary>
        /// SCUK01.
        /// </summary>
        public const string SCUK01 = "SCUK01";

        /// <summary>
        /// SCURCD.
        /// </summary>
        public const string SCURCD = "SCURCD";

        /// <summary>
        /// SCURDT.
        /// </summary>
        public const string SCURDT = "SCURDT";

        /// <summary>
        /// SCURAT.
        /// </summary>
        public const string SCURAT = "SCURAT";

        /// <summary>
        /// SCURAB.
        /// </summary>
        public const string SCURAB = "SCURAB";

        /// <summary>
        /// SCURRF.
        /// </summary>
        public const string SCURRF = "SCURRF";

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

        /// <summary>
        /// SCRTN.
        /// </summary>
        public const string SCRTN = "SCRTN";

        /// <summary>
        /// SCLNMB.
        /// </summary>
        public const string SCLNMB = "SCLNMB";

        /// <summary>
        /// SCPRTE.
        /// </summary>
        public const string SCPRTE = "SCPRTE";

        /// <summary>
        /// SCEFTJ.
        /// </summary>
        public const string SCEFTJ = "SCEFTJ";
    }

    /// <inheritdoc />
    public override string TableName => "F4945";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("SCSHPN", "SCSHPN", JdeDataType.Numeric),
        new JdeField("SCRSSN", "SCRSSN", JdeDataType.Numeric),
        new JdeField("SCVMCU", "SCVMCU", JdeDataType.String, 24),
        new JdeField("SCLDNM", "SCLDNM", JdeDataType.Numeric),
        new JdeField("SCDLNO", "SCDLNO", JdeDataType.Numeric),
        new JdeField("SCOSEQ", "SCOSEQ", JdeDataType.Numeric),
        new JdeField("SCRTNM", "SCRTNM", JdeDataType.String, 20),
        new JdeField("SCSDSQ", "SCSDSQ", JdeDataType.Numeric),
        new JdeField("SCSCSN", "SCSCSN", JdeDataType.Numeric),
        new JdeField("SCNMFC", "SCNMFC", JdeDataType.String, 8),
        new JdeField("SCDSGP", "SCDSGP", JdeDataType.String, 6),
        new JdeField("SCFRT1", "SCFRT1", JdeDataType.String, 12),
        new JdeField("SCFRT2", "SCFRT2", JdeDataType.String, 12),
        new JdeField("SCCGC1", "SCCGC1", JdeDataType.String, 6),
        new JdeField("SCAG", "SCAG", JdeDataType.Numeric),
        new JdeField("SCBLPB", "SCBLPB", JdeDataType.String, 2),
        new JdeField("SCCRDC", "SCCRDC", JdeDataType.String, 6),
        new JdeField("SCFAA", "SCFAA", JdeDataType.Numeric),
        new JdeField("SCNAMF", "SCNAMF", JdeDataType.Numeric),
        new JdeField("SCRTDQ", "SCRTDQ", JdeDataType.Numeric),
        new JdeField("SCNAMT", "SCNAMT", JdeDataType.Numeric),
        new JdeField("SCUOM", "SCUOM", JdeDataType.String, 4),
        new JdeField("SCRTGB", "SCRTGB", JdeDataType.String, 2),
        new JdeField("SCCRCD", "SCCRCD", JdeDataType.String, 6),
        new JdeField("SCDOCO", "SCDOCO", JdeDataType.Numeric),
        new JdeField("SCDCTO", "SCDCTO", JdeDataType.String, 4),
        new JdeField("SCKCOO", "SCKCOO", JdeDataType.String, 10),
        new JdeField("SCLNID", "SCLNID", JdeDataType.Numeric),
        new JdeField("SCOVFG", "SCOVFG", JdeDataType.String, 2),
        new JdeField("SCUKID", "SCUKID", JdeDataType.Numeric),
        new JdeField("SCUK01", "SCUK01", JdeDataType.Numeric, null, true, true),
        new JdeField("SCURCD", "SCURCD", JdeDataType.String, 4),
        new JdeField("SCURDT", "SCURDT", JdeDataType.Numeric),
        new JdeField("SCURAT", "SCURAT", JdeDataType.Numeric),
        new JdeField("SCURAB", "SCURAB", JdeDataType.Numeric),
        new JdeField("SCURRF", "SCURRF", JdeDataType.String, 30),
        new JdeField("SCUSER", "SCUSER", JdeDataType.String, 20),
        new JdeField("SCPID", "SCPID", JdeDataType.String, 20),
        new JdeField("SCJOBN", "SCJOBN", JdeDataType.String, 20),
        new JdeField("SCUPMJ", "SCUPMJ", JdeDataType.Numeric),
        new JdeField("SCTDAY", "SCTDAY", JdeDataType.Numeric),
        new JdeField("SCRTN", "SCRTN", JdeDataType.Numeric),
        new JdeField("SCLNMB", "SCLNMB", JdeDataType.Numeric),
        new JdeField("SCPRTE", "SCPRTE", JdeDataType.String, 2),
        new JdeField("SCEFTJ", "SCEFTJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4945_0", "Primary Key on SCUK01", new[] { "SCUK01" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F4945_2", "Index on SCSHPN, SCRSSN, SCSDSQ, SCSCSN", new[] { "SCSHPN", "SCRSSN", "SCSDSQ", "SCSCSN" }),
        new JdeIndex("F4945_3", "Index on SCVMCU, SCLDNM, SCSDSQ, SCSCSN", new[] { "SCVMCU", "SCLDNM", "SCSDSQ", "SCSCSN" }),
        new JdeIndex("F4945_5", "Index on SCDLNO, SCSDSQ, SCSCSN", new[] { "SCDLNO", "SCSDSQ", "SCSCSN" }),
        new JdeIndex("F4945_6", "Index on SCBLPB, SCSHPN, SCRSSN, SCCGC1, SCSDSQ, SCSCSN", new[] { "SCBLPB", "SCSHPN", "SCRSSN", "SCCGC1", "SCSDSQ", "SCSCSN" }),
        new JdeIndex("F4945_7", "Index on SCBLPB, SCVMCU, SCLDNM, SCCGC1, SCSDSQ, SCSCSN", new[] { "SCBLPB", "SCVMCU", "SCLDNM", "SCCGC1", "SCSDSQ", "SCSCSN" }),
        new JdeIndex("F4945_8", "Index on SCBLPB, SCDLNO, SCCGC1, SCSDSQ, SCSCSN", new[] { "SCBLPB", "SCDLNO", "SCCGC1", "SCSDSQ", "SCSCSN" }),
        new JdeIndex("F4945_9", "Index on SCBLPB, SCDOCO, SCDCTO, SCKCOO", new[] { "SCBLPB", "SCDOCO", "SCDCTO", "SCKCOO" })
    };
}
