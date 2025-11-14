using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74R9011 - .
/// </summary>
public class F74R9011 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CRR74DDCT.
        /// </summary>
        public const string CRR74DDCT = "CRR74DDCT";

        /// <summary>
        /// CRR74DDOC.
        /// </summary>
        public const string CRR74DDOC = "CRR74DDOC";

        /// <summary>
        /// CRR74DKCO.
        /// </summary>
        public const string CRR74DKCO = "CRR74DKCO";

        /// <summary>
        /// CRR74DDGJ.
        /// </summary>
        public const string CRR74DDGJ = "CRR74DDGJ";

        /// <summary>
        /// CRR74DJLN.
        /// </summary>
        public const string CRR74DJLN = "CRR74DJLN";

        /// <summary>
        /// CRR74DLT.
        /// </summary>
        public const string CRR74DLT = "CRR74DLT";

        /// <summary>
        /// CRR74DEXT.
        /// </summary>
        public const string CRR74DEXT = "CRR74DEXT";

        /// <summary>
        /// CRSEQ.
        /// </summary>
        public const string CRSEQ = "CRSEQ";

        /// <summary>
        /// CRR74CDCT.
        /// </summary>
        public const string CRR74CDCT = "CRR74CDCT";

        /// <summary>
        /// CRR74CDOC.
        /// </summary>
        public const string CRR74CDOC = "CRR74CDOC";

        /// <summary>
        /// CRR74CKCO.
        /// </summary>
        public const string CRR74CKCO = "CRR74CKCO";

        /// <summary>
        /// CRR74CDGJ.
        /// </summary>
        public const string CRR74CDGJ = "CRR74CDGJ";

        /// <summary>
        /// CRR74CJLN.
        /// </summary>
        public const string CRR74CJLN = "CRR74CJLN";

        /// <summary>
        /// CRR74CLT.
        /// </summary>
        public const string CRR74CLT = "CRR74CLT";

        /// <summary>
        /// CRR74CEXT.
        /// </summary>
        public const string CRR74CEXT = "CRR74CEXT";

        /// <summary>
        /// CRICUT.
        /// </summary>
        public const string CRICUT = "CRICUT";

        /// <summary>
        /// CRICU.
        /// </summary>
        public const string CRICU = "CRICU";

        /// <summary>
        /// CRAA.
        /// </summary>
        public const string CRAA = "CRAA";

        /// <summary>
        /// CRR74FLDC.
        /// </summary>
        public const string CRR74FLDC = "CRR74FLDC";

        /// <summary>
        /// CRR74RMID.
        /// </summary>
        public const string CRR74RMID = "CRR74RMID";

        /// <summary>
        /// CRR74CPOP.
        /// </summary>
        public const string CRR74CPOP = "CRR74CPOP";

        /// <summary>
        /// CRR74CMA1.
        /// </summary>
        public const string CRR74CMA1 = "CRR74CMA1";

        /// <summary>
        /// CRR74CMA5.
        /// </summary>
        public const string CRR74CMA5 = "CRR74CMA5";

        /// <summary>
        /// CRR74RUID.
        /// </summary>
        public const string CRR74RUID = "CRR74RUID";

        /// <summary>
        /// CRR74CCA1.
        /// </summary>
        public const string CRR74CCA1 = "CRR74CCA1";

        /// <summary>
        /// CRR74CCA2.
        /// </summary>
        public const string CRR74CCA2 = "CRR74CCA2";

        /// <summary>
        /// CRR74CCA3.
        /// </summary>
        public const string CRR74CCA3 = "CRR74CCA3";

        /// <summary>
        /// CRR74CCA4.
        /// </summary>
        public const string CRR74CCA4 = "CRR74CCA4";

        /// <summary>
        /// CRR74CCA5.
        /// </summary>
        public const string CRR74CCA5 = "CRR74CCA5";

        /// <summary>
        /// CRR74CRCO.
        /// </summary>
        public const string CRR74CRCO = "CRR74CRCO";

        /// <summary>
        /// CRCO.
        /// </summary>
        public const string CRCO = "CRCO";

        /// <summary>
        /// CRCRCD.
        /// </summary>
        public const string CRCRCD = "CRCRCD";

        /// <summary>
        /// CRUSER.
        /// </summary>
        public const string CRUSER = "CRUSER";

        /// <summary>
        /// CRPID.
        /// </summary>
        public const string CRPID = "CRPID";

        /// <summary>
        /// CRJOBN.
        /// </summary>
        public const string CRJOBN = "CRJOBN";

        /// <summary>
        /// CRUPMJ.
        /// </summary>
        public const string CRUPMJ = "CRUPMJ";

        /// <summary>
        /// CRUPMT.
        /// </summary>
        public const string CRUPMT = "CRUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F74R9011";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CRR74DDCT", "CRR74DDCT", JdeDataType.String, 4, true, true),
        new JdeField("CRR74DDOC", "CRR74DDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("CRR74DKCO", "CRR74DKCO", JdeDataType.String, 10, true, true),
        new JdeField("CRR74DDGJ", "CRR74DDGJ", JdeDataType.Numeric, null, true, true),
        new JdeField("CRR74DJLN", "CRR74DJLN", JdeDataType.Numeric, null, true, true),
        new JdeField("CRR74DLT", "CRR74DLT", JdeDataType.String, 4, true, true),
        new JdeField("CRR74DEXT", "CRR74DEXT", JdeDataType.String, 4, true, true),
        new JdeField("CRSEQ", "CRSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("CRR74CDCT", "CRR74CDCT", JdeDataType.String, 4),
        new JdeField("CRR74CDOC", "CRR74CDOC", JdeDataType.Numeric),
        new JdeField("CRR74CKCO", "CRR74CKCO", JdeDataType.String, 10),
        new JdeField("CRR74CDGJ", "CRR74CDGJ", JdeDataType.Numeric),
        new JdeField("CRR74CJLN", "CRR74CJLN", JdeDataType.Numeric),
        new JdeField("CRR74CLT", "CRR74CLT", JdeDataType.String, 4),
        new JdeField("CRR74CEXT", "CRR74CEXT", JdeDataType.String, 4),
        new JdeField("CRICUT", "CRICUT", JdeDataType.String, 4),
        new JdeField("CRICU", "CRICU", JdeDataType.Numeric),
        new JdeField("CRAA", "CRAA", JdeDataType.Numeric),
        new JdeField("CRR74FLDC", "CRR74FLDC", JdeDataType.String, 2),
        new JdeField("CRR74RMID", "CRR74RMID", JdeDataType.Numeric),
        new JdeField("CRR74CPOP", "CRR74CPOP", JdeDataType.String, 4),
        new JdeField("CRR74CMA1", "CRR74CMA1", JdeDataType.String, 6),
        new JdeField("CRR74CMA5", "CRR74CMA5", JdeDataType.String, 20),
        new JdeField("CRR74RUID", "CRR74RUID", JdeDataType.Numeric),
        new JdeField("CRR74CCA1", "CRR74CCA1", JdeDataType.String, 6),
        new JdeField("CRR74CCA2", "CRR74CCA2", JdeDataType.String, 6),
        new JdeField("CRR74CCA3", "CRR74CCA3", JdeDataType.String, 6),
        new JdeField("CRR74CCA4", "CRR74CCA4", JdeDataType.String, 20),
        new JdeField("CRR74CCA5", "CRR74CCA5", JdeDataType.String, 20),
        new JdeField("CRR74CRCO", "CRR74CRCO", JdeDataType.String, 4),
        new JdeField("CRCO", "CRCO", JdeDataType.String, 10),
        new JdeField("CRCRCD", "CRCRCD", JdeDataType.String, 6),
        new JdeField("CRUSER", "CRUSER", JdeDataType.String, 20),
        new JdeField("CRPID", "CRPID", JdeDataType.String, 20),
        new JdeField("CRJOBN", "CRJOBN", JdeDataType.String, 20),
        new JdeField("CRUPMJ", "CRUPMJ", JdeDataType.Numeric),
        new JdeField("CRUPMT", "CRUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74R9011_0", "Primary Key on CRR74DDCT, CRR74DDOC, CRR74DKCO, CRR74DDGJ, CRR74DJLN, CRR74DLT, CRR74DEXT, CRSEQ", new[] { "CRR74DDCT", "CRR74DDOC", "CRR74DKCO", "CRR74DDGJ", "CRR74DJLN", "CRR74DLT", "CRR74DEXT", "CRSEQ" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F74R9011_2", "Index on CRR74CDCT, CRR74CDOC, CRR74CKCO, CRR74CDGJ, CRR74CJLN, CRR74CLT, CRR74CEXT", new[] { "CRR74CDCT", "CRR74CDOC", "CRR74CKCO", "CRR74CDGJ", "CRR74CJLN", "CRR74CLT", "CRR74CEXT" }),
        new JdeIndex("F74R9011_3", "Index on CRICUT, CRICU", new[] { "CRICUT", "CRICU" })
    };
}
