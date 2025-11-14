using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74Y021 - .
/// </summary>
public class F74Y021 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IDY74IDEC.
        /// </summary>
        public const string IDY74IDEC = "IDY74IDEC";

        /// <summary>
        /// IDKCOO.
        /// </summary>
        public const string IDKCOO = "IDKCOO";

        /// <summary>
        /// IDDCTO.
        /// </summary>
        public const string IDDCTO = "IDDCTO";

        /// <summary>
        /// IDDOCO.
        /// </summary>
        public const string IDDOCO = "IDDOCO";

        /// <summary>
        /// IDY74SEC.
        /// </summary>
        public const string IDY74SEC = "IDY74SEC";

        /// <summary>
        /// IDY74MOS.
        /// </summary>
        public const string IDY74MOS = "IDY74MOS";

        /// <summary>
        /// IDY74MOC.
        /// </summary>
        public const string IDY74MOC = "IDY74MOC";

        /// <summary>
        /// IDY74PCTR.
        /// </summary>
        public const string IDY74PCTR = "IDY74PCTR";

        /// <summary>
        /// IDY74OPTY.
        /// </summary>
        public const string IDY74OPTY = "IDY74OPTY";

        /// <summary>
        /// IDY74SECN.
        /// </summary>
        public const string IDY74SECN = "IDY74SECN";

        /// <summary>
        /// IDY74SSEQ.
        /// </summary>
        public const string IDY74SSEQ = "IDY74SSEQ";

        /// <summary>
        /// IDY74IAA.
        /// </summary>
        public const string IDY74IAA = "IDY74IAA";

        /// <summary>
        /// IDCTR.
        /// </summary>
        public const string IDCTR = "IDCTR";

        /// <summary>
        /// IDTAX.
        /// </summary>
        public const string IDTAX = "IDTAX";

        /// <summary>
        /// IDAN8.
        /// </summary>
        public const string IDAN8 = "IDAN8";

        /// <summary>
        /// IDDGJ.
        /// </summary>
        public const string IDDGJ = "IDDGJ";

        /// <summary>
        /// IDY74IFA.
        /// </summary>
        public const string IDY74IFA = "IDY74IFA";

        /// <summary>
        /// IDCRCD.
        /// </summary>
        public const string IDCRCD = "IDCRCD";

        /// <summary>
        /// IDVINV.
        /// </summary>
        public const string IDVINV = "IDVINV";

        /// <summary>
        /// IDY74NIDE.
        /// </summary>
        public const string IDY74NIDE = "IDY74NIDE";

        /// <summary>
        /// IDUSER.
        /// </summary>
        public const string IDUSER = "IDUSER";

        /// <summary>
        /// IDPID.
        /// </summary>
        public const string IDPID = "IDPID";

        /// <summary>
        /// IDJOBN.
        /// </summary>
        public const string IDJOBN = "IDJOBN";

        /// <summary>
        /// IDUPMJ.
        /// </summary>
        public const string IDUPMJ = "IDUPMJ";

        /// <summary>
        /// IDUPMT.
        /// </summary>
        public const string IDUPMT = "IDUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F74Y021";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IDY74IDEC", "IDY74IDEC", JdeDataType.Numeric, null, true, true),
        new JdeField("IDKCOO", "IDKCOO", JdeDataType.String, 10, true, true),
        new JdeField("IDDCTO", "IDDCTO", JdeDataType.String, 4, true, true),
        new JdeField("IDDOCO", "IDDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("IDY74SEC", "IDY74SEC", JdeDataType.String, 20, true, true),
        new JdeField("IDY74MOS", "IDY74MOS", JdeDataType.String, 2, true, true),
        new JdeField("IDY74MOC", "IDY74MOC", JdeDataType.String, 2, true, true),
        new JdeField("IDY74PCTR", "IDY74PCTR", JdeDataType.String, 6, true, true),
        new JdeField("IDY74OPTY", "IDY74OPTY", JdeDataType.String, 2),
        new JdeField("IDY74SECN", "IDY74SECN", JdeDataType.Numeric),
        new JdeField("IDY74SSEQ", "IDY74SSEQ", JdeDataType.Numeric),
        new JdeField("IDY74IAA", "IDY74IAA", JdeDataType.Numeric),
        new JdeField("IDCTR", "IDCTR", JdeDataType.String, 6),
        new JdeField("IDTAX", "IDTAX", JdeDataType.String, 40),
        new JdeField("IDAN8", "IDAN8", JdeDataType.Numeric),
        new JdeField("IDDGJ", "IDDGJ", JdeDataType.Numeric),
        new JdeField("IDY74IFA", "IDY74IFA", JdeDataType.Numeric),
        new JdeField("IDCRCD", "IDCRCD", JdeDataType.String, 6),
        new JdeField("IDVINV", "IDVINV", JdeDataType.String, 50),
        new JdeField("IDY74NIDE", "IDY74NIDE", JdeDataType.Numeric),
        new JdeField("IDUSER", "IDUSER", JdeDataType.String, 20),
        new JdeField("IDPID", "IDPID", JdeDataType.String, 20),
        new JdeField("IDJOBN", "IDJOBN", JdeDataType.String, 20),
        new JdeField("IDUPMJ", "IDUPMJ", JdeDataType.Numeric),
        new JdeField("IDUPMT", "IDUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74Y021_0", "Primary Key on IDY74IDEC, IDKCOO, IDDCTO, IDDOCO, IDY74SEC, IDY74MOS, IDY74MOC, IDY74PCTR", new[] { "IDY74IDEC", "IDKCOO", "IDDCTO", "IDDOCO", "IDY74SEC", "IDY74MOS", "IDY74MOC", "IDY74PCTR" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F74Y021_2", "Index on IDKCOO, IDDCTO, IDDOCO, SYS_NC00026$, IDY74SEC, IDY74MOS, IDY74MOC, IDY74PCTR", new[] { "IDKCOO", "IDDCTO", "IDDOCO", "SYS_NC00026$", "IDY74SEC", "IDY74MOS", "IDY74MOC", "IDY74PCTR" })
    };
}
